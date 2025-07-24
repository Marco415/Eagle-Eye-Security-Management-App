using Equipment;
using MainForm;
using SecurityPersonnelForm;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemplateForm
{
    public partial class frmShifts : Form
    {
        public frmShifts()
        {
            InitializeComponent();
            dgvShiftData.SelectionChanged += dgvShiftData_SelectionChanged;
        }

        // Menu and Text Fields sliding movements
        private const int EXPAND_RATE = 4;
        private const int TEXT_FIELD_PANEL_MAX_WIDTH = 375;
        private const int MENU_PANEL_MAX_WIDTH = 190;

        string connectionString;

        private DateTime originalStartDateTime;
        private decimal originalDuration;
        private int originalSectorId;

        bool displayShifts = true;

        private void frmTemplate_Load(object sender, EventArgs e)
        {
            #region "Visual Elements"
            //buttons
            btnShift.Enabled = false;
            btnDisplayShifts.Enabled = false;
            btnUpdateShift.Enabled = false;

            #region "Visual Elements"
            //data grid
            dgvShiftData.Width = 1100;
            dgvShiftData.Left = 400;

            //menu
            tipMenu.SetToolTip(picMenu, "Move between different pages");
            pnlSidePanel.Width = 0;

            //text field
            tipTextFields.SetToolTip(picTextFieldMoveRight, "Display values of a selected record");
            pnlTextFieldPanel.Width = TEXT_FIELD_PANEL_MAX_WIDTH;
            picTextFieldMoveLeft.Visible = true;
            picTextFieldMoveRight.Visible = false;

            //other
            lblDate.Text = DateTime.Now.ToLongDateString();
            lblTime.Text = DateTime.Now.ToShortTimeString();
            tipHome.SetToolTip(picHome, "Home");
            tipHelp.SetToolTip(picHelp, "Help");
            tipSearch.SetToolTip(txtSearch, "Search for data in the displayed table");
            txtSearch.ForeColor = Color.DarkGray;
            txtSearch.Text = "Search for data in the displayed table";           
            #endregion
        }

        private void frmShifts_Shown(object sender, EventArgs e)
        {
            connectDatabase();
            displayDatabase();
            populateSectorComboboxes();

            resetFilters();

            if (dgvShiftData.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvShiftData.SelectedRows[0];
                originalStartDateTime = Convert.ToDateTime(selectedRow.Cells["START_DATETIME"].Value);
                originalDuration = Convert.ToDecimal(selectedRow.Cells["DURATION"].Value);
                originalSectorId = Convert.ToInt32(selectedRow.Cells["SECTOR_ID"].Value);

                // Initialize controls with the original values
                dtpStartTimeDate.Value = originalStartDateTime;
                nudShiftDuration.Value = originalDuration;
                cmbSectors.SelectedValue = originalSectorId;

                dtpStartTimeDate.ValueChanged += dtpStartTimeDate_ValueChanged;
                nudShiftDuration.ValueChanged += nudShiftDuration_ValueChanged;
                cmbSectors.SelectedIndexChanged += cmbSectors_SelectedIndexChanged;
            }
        }

        private void populateSectorComboboxes()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "SELECT SECTOR_ID, SECTOR_NAME FROM SECTOR";
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                cmbSectors.DataSource = dt;
                cmbSectors.DisplayMember = "SECTOR_NAME";
                cmbSectors.ValueMember = "SECTOR_ID";
                cmbFilterSectors.DataSource = dt;
                cmbFilterSectors.DisplayMember = "SECTOR_NAME";
                cmbFilterSectors.ValueMember = "SECTOR_ID";
                connection.Close();
            }
        }

        // Menu on the left side of screen
        #region "Visual Elements"
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            tmrMenu.Enabled = true;
        }

        private void tmrMenu_Tick(object sender, EventArgs e)
        { 
            //expand menu
            if (pnlSidePanel.Width < MENU_PANEL_MAX_WIDTH)
            {
                while (pnlSidePanel.Width < MENU_PANEL_MAX_WIDTH)
                {
                    pnlSidePanel.Width += EXPAND_RATE;
                    dgvShiftData.Width -= EXPAND_RATE;
                    dgvShiftData.Left += EXPAND_RATE;
                    if (pnlSidePanel.Width % 5 == 0)
                        System.Threading.Thread.Sleep(1);
                }
                tipMenu.SetToolTip(picMenu, "Hide menu");
                tmrMenu.Enabled = false;
            }
            //collapse menu
            else if (pnlSidePanel.Width >= MENU_PANEL_MAX_WIDTH)
            {
                while (pnlSidePanel.Width > 1)
                {
                    pnlSidePanel.Width -= EXPAND_RATE;
                    dgvShiftData.Width += EXPAND_RATE;
                    dgvShiftData.Left -= EXPAND_RATE;
                    if (pnlSidePanel.Width % 5 == 0)
                        System.Threading.Thread.Sleep(1);
                }
                tipMenu.SetToolTip(picMenu, "Show Menu");
                tmrMenu.Enabled = false;
            }
        }
        #endregion

        private void picTextFieldMove_Click(object sender, EventArgs e)
        {
            tmrTextFields.Enabled = true;
        }

        private void picTextFieldMoveLeft_Click(object sender, EventArgs e)
        {
            tmrTextFields.Enabled = true;
        }

        private void tmrTextFields_Tick(object sender, EventArgs e)
        {
            //expand text fields
            if (pnlTextFieldPanel.Width < TEXT_FIELD_PANEL_MAX_WIDTH)
            {
                while (pnlTextFieldPanel.Width < TEXT_FIELD_PANEL_MAX_WIDTH)
                {
                    pnlTextFieldPanel.Width += EXPAND_RATE;
                    dgvShiftData.Width -= EXPAND_RATE;
                    dgvShiftData.Left += EXPAND_RATE;
                }
                picTextFieldMoveLeft.Visible = true;
                picTextFieldMoveRight.Visible = false;
                tipTextFields.SetToolTip(picTextFieldMoveLeft, "Hide Filter Fields");
                tmrTextFields.Enabled = false;
            }
            //collapse text fields
            else if (pnlTextFieldPanel.Width >= TEXT_FIELD_PANEL_MAX_WIDTH)
            {
                while (pnlTextFieldPanel.Width > 35)
                {
                    pnlTextFieldPanel.Width -= EXPAND_RATE;
                    dgvShiftData.Width += EXPAND_RATE;
                    dgvShiftData.Left -= EXPAND_RATE;
                }
                picTextFieldMoveLeft.Visible = false;
                picTextFieldMoveRight.Visible = true;
                tipTextFields.SetToolTip(picTextFieldMoveRight, "Show Filter Fields");
                tmrTextFields.Enabled = false;
            }
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            txtSearch.ForeColor = Color.Black;
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            txtSearch.Text = "Search for data in the displayed table";
            txtSearch.ForeColor = Color.DarkGray;
            displayDatabase();
        }
        #endregion
      
        // Insert
        private void btnCreateShift_Click(object sender, EventArgs e)
        {
            createInsertForm();
            dgvShiftData.Refresh();
        }

        private void createInsertForm()
        {
            using (Form createShift = new Form())
            {
                createShift.StartPosition = FormStartPosition.CenterScreen;
                createShift.Width = 500;
                createShift.Height = 500;
                createShift.Font = new Font("Arial", 10);
                string iconPath = Path.Combine(Application.StartupPath, "Eagle_Eye_Icon.ico");
                createShift.Icon = new Icon(iconPath);

                // Heading
                Panel pnlHeading = new Panel()
                {
                    Dock = DockStyle.Top,
                    Height = 70,
                    BackColor = Color.FromArgb(233, 222, 211),
                };
                createShift.Controls.Add(pnlHeading);
                pnlHeading.SendToBack();

                pnlHeading.Controls.Add(new Label()
                {
                    Name = "lblHeading",
                    Text = "Create New Shift",
                    Left = 125,
                    Top = 20,
                    Font = new Font("Arial", 20),
                    Width = 250,
                    Height = 50
                });

                string path = "Eagle_Eye_Logo.png";
                pnlHeading.Controls.Add(new PictureBox()
                {
                    Name = "picInsertLogo",
                    Top = 4,
                    Left = 415,
                    Height = 65,
                    Width = 65,
                    Image = Image.FromFile(Path.GetFullPath(path)),
                    SizeMode = PictureBoxSizeMode.StretchImage
                });

                // Lables
                createShift.Controls.Add(new Label()
                {
                    Name = "lblField1",
                    Text = "Start Time\nand Date",
                    Top = 100, //+50 for next label
                    Left = 50,
                    Height = 38
                });
                createShift.Controls.Add(new Label()
                {
                    Name = "lblField2",
                    Text = "Duration\nof Shift",
                    Top = 150, //+50 for next label
                    Left = 50,
                    Height = 38
                });
                createShift.Controls.Add(new Label()
                {
                    Name = "lblField4",
                    Text = "Sector",
                    Top = 200, //+50 for next label
                    Left = 50
                });

                // Inputs
                DateTimePicker dtpShiftStart = new DateTimePicker()
                {
                    Top = 100, //+50 for next text box
                    Left = 150,
                    Width = 202,
                    Format = DateTimePickerFormat.Custom,
                    CustomFormat = "yyyy-MM-dd HH:mm",
                    MinDate = DateTime.Now,
                    MaxDate = Convert.ToDateTime("2030-12-31")
                };
                createShift.Controls.Add(dtpShiftStart);

                NumericUpDown nudShiftTime = new NumericUpDown()
                {
                    Top = 150, //+50 for next text box
                    Left = 150,
                    Width = 202,
                    Increment = 0.50M,
                    DecimalPlaces = 2,
                    Minimum = 2,
                    Maximum = 24
                };
                createShift.Controls.Add(nudShiftTime);

                ComboBox cmbShiftSector = new ComboBox()
                {
                    Top = 200, //+50 for next text box
                    Left = 150,
                    Width = 202
                };
                createShift.Controls.Add(cmbShiftSector);
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT SECTOR_ID, SECTOR_NAME FROM SECTOR";
                    SqlCommand command = new SqlCommand(sql, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    cmbShiftSector.DataSource = dt;
                    cmbShiftSector.DisplayMember = "SECTOR_NAME";
                    cmbShiftSector.ValueMember = "SECTOR_ID";
                    connection.Close();
                }

                // Insert Buttons
                Button btnCreate = new Button()
                {
                    Text = "Create New Shift",
                    Top = 300,
                    Left = 160,
                    Width = 150,
                    Height = 59
                };
                createShift.Controls.Add(btnCreate);
                btnCreate.Click += new EventHandler(Button_Click);

                Button btnCancel = new Button()
                {
                    Text = "Cancel",
                    Top = 375,
                    Left = 160,
                    Width = 150,
                    Height = 59
                };
                createShift.Controls.Add(btnCancel);
                btnCancel.Click += new EventHandler(CancelButton_Click);

                //show form
                createShift.ShowDialog();

                //button event
                void Button_Click(object sender, EventArgs e)
                {
                    //button code

                    //confirmation
                    DialogResult result;
                    result = MessageBox.Show("Is all the information for this new shift correct", "Create New Shift", 
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    //close form
                    if (result == DialogResult.Yes)
                    {
                        DateTime shiftStart = dtpShiftStart.Value;
                        decimal shiftTime = nudShiftTime.Value;
                        int sectorID = Convert.ToInt32(cmbShiftSector.SelectedValue);
                        insertInDatabase(shiftStart, shiftTime, sectorID);
                        createShift.Close();
                    }
                }

                //cancel button event
                void CancelButton_Click(object sender, EventArgs e)
                {
                    createShift.Close();
                }
            }
        }

        // Update
        private void btnUpdateShift_Click(object sender, EventArgs e)
        {
            updateShift();
            dgvShiftData.Refresh();
            btnUpdateShift.Enabled = false;
        }

        private void updateShift()
        {
            if (dgvShiftData.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvShiftData.SelectedRows[0];
                int shiftId = Convert.ToInt32(selectedRow.Cells["SHIFT_ID"].Value);

                DateTime newStartDateTime = dtpStartTimeDate.Value;
                decimal newDuration = nudShiftDuration.Value;
                int newSectorId = Convert.ToInt32(cmbSectors.SelectedValue);

                string message = $"You are about to update the following fields for SHIFT_ID {shiftId}:\n\n" +
                         $"START_DATETIME: {selectedRow.Cells["START_DATETIME"].Value} -> {newStartDateTime}\n" +
                         $"DURATION: {selectedRow.Cells["DURATION"].Value} -> {newDuration}\n" +
                         $"SECTOR_ID: {selectedRow.Cells["SECTOR_ID"].Value} -> {newSectorId}\n\n" +
                         "Are you sure you want to proceed?";

                DialogResult result = MessageBox.Show(message, "Confirm Update", MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string query = "UPDATE SHIFTS SET START_DATETIME = @StartDateTime, DURATION = @Duration, " +
                        "SECTOR_ID = @SectorId WHERE SHIFT_ID = @ShiftId";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@StartDateTime", newStartDateTime);
                        command.Parameters.AddWithValue("@Duration", newDuration);
                        command.Parameters.AddWithValue("@SectorId", newSectorId);
                        command.Parameters.AddWithValue("@ShiftId", shiftId);

                        try
                        {
                            connection.Open();
                            int rowsAffected = command.ExecuteNonQuery();
                            MessageBox.Show($"Rows updated: {rowsAffected}", "Update Successful", 
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            connection.Close();
                            displayDatabase();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message, "Update Failed", 
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Update canceled.", "Update Canceled", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to update.", "No Row Selected", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Delete
        private void deleteShift()
        {
            if (dgvShiftData.SelectedRows.Count > 0)
            {
                if (displayShifts)
                {
                    DataGridViewRow selectedRow = dgvShiftData.SelectedRows[0];
                    int shiftID = Convert.ToInt32(selectedRow.Cells["SHIFT_ID"].Value);
                    DateTime startDateTime = Convert.ToDateTime(selectedRow.Cells["START_DATETIME"].Value);
                    decimal duration = Convert.ToDecimal(selectedRow.Cells["DURATION"].Value);
                    int sectorID = Convert.ToInt32(selectedRow.Cells["SECTOR_ID"].Value);

                    string message = $"You are about to delete the following record:\n\n" +
                                     $"SHIFT_ID: {shiftID}\n" +
                                     $"START_DATETIME: {startDateTime}\n" +
                                     $"DURATION: {duration}\n" +
                                     $"SECTOR_ID: {sectorID}\n\n" +
                                     "Are you sure you want to delete this record?";

                    DialogResult result = MessageBox.Show(message, "Confirm Delete", 
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        string query = "DELETE FROM SHIFTs WHERE SHIFT_ID = @ShiftID";
                        try
                        {
                            using (SqlConnection connection = new SqlConnection(connectionString))
                            {
                                SqlCommand command = new SqlCommand(query, connection);
                                command.Parameters.AddWithValue("@ShiftID", shiftID);


                                connection.Open();
                                int rowsAffected = command.ExecuteNonQuery();
                                MessageBox.Show($"Rows deleted: {rowsAffected}", "Delete Successful", 
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                                connection.Close();
                                displayDatabase();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error Deleting", 
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void btnDeleteShift_Click(object sender, EventArgs e)
        {
            deleteShift();
        }

        private void dtpStartTimeDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtpStartTimeDate.Value != originalStartDateTime)
            {
                lblStartTimeDate.ForeColor = Color.Red;
                btnUpdateShift.Enabled = true;
            }
            else
            {
                lblStartTimeDate.ForeColor = SystemColors.ControlText;
                btnUpdateShift.Enabled = false;
            }
        }

        private void nudShiftDuration_ValueChanged(object sender, EventArgs e)
        {
            if(nudShiftDuration.Value != originalDuration)
            {
                lblShiftDuration.ForeColor = Color.Red;
                btnUpdateShift.Enabled = true;
            }
            else
            {
                lblShiftDuration.ForeColor = SystemColors.ControlText;
                btnUpdateShift.Enabled = false;
            }
        }

        private void cmbSectors_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSectors.SelectedValue is DataRowView drv)
            {
                int newSectorId = Convert.ToInt32(drv["SECTOR_ID"]); // Replace "SECTOR_ID" with the actual field name if different
                if (newSectorId != originalSectorId)
                {
                    lblSector.ForeColor = Color.Red; // Change to the color you prefer
                    btnUpdateShift.Enabled= true;
                }
                else
                {
                    lblSector.ForeColor = SystemColors.ControlText; // Reset to default color
                    btnUpdateShift.Enabled = false;
                }
            }
            else if (cmbSectors.SelectedValue is int sectorId)
            {
                if (sectorId != originalSectorId)
                {
                    lblSector.ForeColor = Color.Red; // Change to the color you prefer
                    btnUpdateShift.Enabled= true;
                }
                else
                {
                    lblSector.ForeColor = SystemColors.ControlText; // Reset to default color
                    btnUpdateShift.Enabled = false;
                }
            }
        }

        private void btnShiftDetails_Click(object sender, EventArgs e)
        {
            if (dgvShiftData.SelectedRows.Count == 1)
            {
                displayShifts = false;
                btnShiftDetails.Enabled = false;
                btnDisplayShifts.Enabled = true;

                DataGridViewRow selectedRow = dgvShiftData.SelectedRows[0];
                int shiftID = Convert.ToInt32(selectedRow.Cells["SHIFT_ID"].Value);

                string query = "SELECT sd.SHIFT_ID, sd.PERSONNEL_ID, CONCAT(sp.FIRST_NAME, ' ', sp.LAST_NAME) AS 'PERSONNEL_NAME'" +
                    " FROM SHIFT_DETAIL sd, SECURITYPERSONNEL sp" +
                    " WHERE SHIFT_ID = @ShiftID AND sd.PERSONNEL_ID=sp.PERSONNEL_ID";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    DataSet ds = new DataSet();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ShiftID", shiftID);
                        adapter.SelectCommand = command;
                        adapter.Fill(ds, "SourceTable");
                        dgvShiftData.DataSource = ds;
                        dgvShiftData.DataMember = "SourceTable";
                    }
                }
                
            }
            else
            {
                MessageBox.Show("Please select a row in the datagrid to delete", "Delete Security Personnel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                SelectOnlyFirstRecordOf(dgvShiftData);
            }
            
        }

        private void SelectOnlyFirstRecordOf(DataGridView dtg)
        {
            if (dtg.Rows.Count > 0)
            {
                dtg.ClearSelection();
                dtg.Rows[0].Selected = true;
            }
        }

        private void btnDisplayShifts_Click(object sender, EventArgs e)
        {
            displayDatabase();
            displayShifts = true;
            SelectOnlyFirstRecordOf(dgvShiftData);
            
            btnShiftDetails.Enabled = true;
            btnDisplayShifts.Enabled = false;
        }

        private void connectDatabase()
        {
            try
            {
                // The ?? will give serverName a default value of @"localhost\SQLEXPRESS"
                string serverName = Environment.GetEnvironmentVariable("EYE_SECURITY_DB") ?? @"localhost\SQLEXPRESS";
                connectionString = "Server =" + serverName + ";Database =EYSECURITY;Integrated Security=True;";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to database: " + ex);
            }
        }

        private void displayDatabase()
        {
            try
            {
                string sql = "SELECT sh.SHIFT_ID, sh.START_DATETIME, sh.DURATION, sh.SECTOR_ID, se.SECTOR_NAME " +
                    "FROM SHIFTS sh, SECTOR se WHERE sh.SECTOR_ID=se.SECTOR_ID";
                using (SqlConnection connection = new SqlConnection(connectionString))
                { 
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    DataSet ds = new DataSet();

                    using (SqlCommand cmd = new SqlCommand(sql, connection))
                    {
                        adapter.SelectCommand = cmd;
                        adapter.Fill(ds, "SourceTable");
                        dgvShiftData.DataSource = ds;
                        dgvShiftData.DataMember = "SourceTable";
                        dgvShiftData.Refresh();
                        connection.Close();
                    }                        
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error displaying database: " + ex);
            }
        }

        private void insertInDatabase(DateTime startDateTime, decimal duration, int sectorID)
        {
            string insertQuery = "INSERT INTO SHIFTS (START_DATETIME, DURATION, SECTOR_ID) " +
                "VALUES (@StartDateTime, @Duration, @SectorId)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(insertQuery, connection);
                command.Parameters.AddWithValue("@StartDateTime", startDateTime);
                command.Parameters.AddWithValue("@Duration", duration);
                command.Parameters.AddWithValue("@SectorId", sectorID);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    displayDatabase();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error inserting data into database: " + ex);
                }
            }            
        }

        private void dgvShiftData_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvShiftData.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvShiftData.SelectedRows[0];
                if (displayShifts)
                { // Populate display inputs
                    originalStartDateTime = Convert.ToDateTime(selectedRow.Cells["START_DATETIME"].Value);
                    originalDuration = Convert.ToDecimal(selectedRow.Cells["DURATION"].Value);
                    originalSectorId = Convert.ToInt32(selectedRow.Cells["SECTOR_ID"].Value);

                    // Check if record can be deleted
                    if (originalStartDateTime.CompareTo(DateTime.Now) <= 0)
                    {
                        dtpStartTimeDate.Enabled = false;
                        nudShiftDuration.Enabled = false;
                        cmbSectors.Enabled = false;

                        btnDeleteShift.Enabled = false;

                        dtpStartTimeDate.MinDate = DateTime.Now.AddYears(-30);
                    }
                    else
                    {
                        dtpStartTimeDate.Enabled = true;
                        nudShiftDuration.Enabled = true;
                        cmbSectors.Enabled = true;

                        btnDeleteShift.Enabled = true;

                        dtpStartTimeDate.MinDate = DateTime.Now;
                    }
                    txtShiftID.Text = selectedRow.Cells["SHIFT_ID"].Value.ToString();
                    dtpStartTimeDate.Value = Convert.ToDateTime(selectedRow.Cells["START_DATETIME"].Value);
                    nudShiftDuration.Value = Convert.ToDecimal(selectedRow.Cells["DURATION"].Value);
                    cmbSectors.SelectedValue = Convert.ToInt32(selectedRow.Cells["SECTOR_ID"].Value);
                }                              
            }
        }

        // Home Button
        protected void NavigateToForm(Form targetForm)
        {
            targetForm.Show();
            this.Close();
        }
        private void picHome_Click(object sender, EventArgs e)
        {
            frmMain form = new frmMain(false);
            NavigateToForm(form);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
                string filterText = txtSearch.Text.Trim();
                string query;

                if (string.IsNullOrEmpty(filterText))
                {
                    // If the filter text is empty, select all records
                    query = "SELECT sh.SHIFT_ID, sh.START_DATETIME, sh.DURATION, sh.SECTOR_ID, se.SECTOR_NAME " +
                            "FROM SHIFTS sh, SECTOR se WHERE sh.SECTOR_ID=se.SECTOR_ID";
                }
                else
                {
                    // Construct the query to search in all columns
                    query = $@"SELECT SHIFTS.*, SECTOR.SECTOR_NAME FROM SHIFTS INNER JOIN SECTOR " +
                            "ON SHIFTS.SECTOR_ID = SECTOR.SECTOR_ID WHERE CONVERT(VARCHAR, SHIFTS.SHIFT_ID) " +
                            "LIKE @filterText OR CONVERT(VARCHAR, SHIFTS.START_DATETIME, 120) LIKE @filterText OR " +
                            "CONVERT(VARCHAR, SHIFTS.DURATION) LIKE @filterText OR CONVERT(VARCHAR, SHIFTS.SECTOR_ID) " +
                            "LIKE @filterText OR SECTOR.SECTOR_NAME LIKE @filterText";
                }

                // Execute the query and bind the result to the DataGridView
                string serverName = Environment.GetEnvironmentVariable("EYE_SECURITY_DB") ?? @"localhost\SQLEXPRESS";
                connectionString = "Server =" + serverName + ";Database =EYSECURITY;Integrated Security=True;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@filterText", $"%{filterText}%");

                    try
                    {
                        connection.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable filteredTable = new DataTable();
                        adapter.Fill(filteredTable);

                        // Bind the filtered table to the DataGridView
                        dgvShiftData.DataSource = filteredTable;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetFilters();
        }

        private void resetFilters()
        {
            txtFilterShiftID.Text = null;
            dtpFilterStart.Value = DateTime.Today;
            dtpFilterStart.MinDate = Convert.ToDateTime("2020-01-01 00:00:00");
            dtpFilterStart.MaxDate = Convert.ToDateTime("2030-12-31 23:59:59");
            dtpFilterEnd.MinDate = Convert.ToDateTime("2020-01-01 00:00:00");
            dtpFilterEnd.MaxDate = Convert.ToDateTime("2030-12-31 23:59:59");
            dtpFilterEnd.Value = DateTime.Today;           
            dtpFilterEnd.Enabled = false;
            nudFilterShiftDuration.Value = 2;
            cmbFilterSectors.SelectedIndex = -1;

            displayDatabase();
        }

        private void txtFilterShiftID_TextChanged(object sender, EventArgs e)
        {
            string filterText = txtFilterShiftID.Text.Trim();
            string query = @"SELECT SHIFTS.*, SECTOR.SECTOR_NAME FROM SHIFTS INNER JOIN " +
                            "SECTOR ON SHIFTS.SECTOR_ID = SECTOR.SECTOR_ID WHERE " +
                            "CONVERT(VARCHAR, SHIFTS.SHIFT_ID) LIKE @filterText";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@filterText", $"%{filterText}%");

                    try
                    {
                        connection.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable filteredTable = new DataTable();
                        adapter.Fill(filteredTable);

                        // Bind the filtered table to the DataGridView
                        dgvShiftData.DataSource = filteredTable;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }            
        }

        private void btnFilterDates_Click(object sender, EventArgs e)
        {
            DateTime startDate = dtpFilterStart.Value;
            DateTime endDate = dtpFilterEnd.Value;

            string query = @"SELECT SHIFTS.*, SECTOR.SECTOR_NAME FROM SHIFTS INNER JOIN SECTOR " +
                            "ON SHIFTS.SECTOR_ID = SECTOR.SECTOR_ID WHERE SHIFTS.START_DATETIME " +
                            "BETWEEN @startDate AND @endDate";

            // Execute the query and bind the result to the DataGridView
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                // Add parameters to avoid SQL injection and ensure correct date format
                command.Parameters.AddWithValue("@startDate", startDate);
                command.Parameters.AddWithValue("@endDate", endDate);

                try
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable filteredTable = new DataTable();
                    adapter.Fill(filteredTable);

                    // Bind the filtered table to the DataGridView
                    dgvShiftData.DataSource = filteredTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void nudFilterShiftDuration_ValueChanged(object sender, EventArgs e)
        {
            decimal duration = Convert.ToDecimal(nudFilterShiftDuration.Value);
            string query = @"SELECT SHIFTS.*, SECTOR.SECTOR_NAME FROM SHIFTS INNER JOIN " +
                            "SECTOR ON SHIFTS.SECTOR_ID = SECTOR.SECTOR_ID WHERE " +
                            "CONVERT(VARCHAR, SHIFTS.DURATION) LIKE @filterText";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@filterText", $"%{duration}%");

                    try
                    {
                        connection.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable filteredTable = new DataTable();
                        adapter.Fill(filteredTable);

                        // Bind the filtered table to the DataGridView
                        dgvShiftData.DataSource = filteredTable;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnFilterSectors_Click(object sender, EventArgs e)
        {
            if (cmbFilterSectors.SelectedValue != null)
            {
                // Check if the SelectedValue is of type DataRowView
                if (cmbFilterSectors.SelectedValue is DataRowView drv)
                {
                    // Extract the actual value from the DataRowView
                    int selectedSectorID = Convert.ToInt32(drv["SECTOR_ID"]);
                    FilterDataBySectorID(selectedSectorID);
                }
                else
                {
                    // If it's not a DataRowView, assume it's already an integer
                    int selectedSectorID = Convert.ToInt32(cmbFilterSectors.SelectedValue);
                    FilterDataBySectorID(selectedSectorID);
                }
            }
            else
            {
                MessageBox.Show("Please select a valid sector.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FilterDataBySectorID(int sectorID)
        {
            string query = @"SELECT SHIFTS.*, SECTOR.SECTOR_NAME FROM SHIFTS INNER JOIN " +
                            "SECTOR ON SHIFTS.SECTOR_ID = SECTOR.SECTOR_ID WHERE SHIFTS.SECTOR_ID = @selectedSectorID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@selectedSectorID", sectorID);

                try
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable filteredTable = new DataTable();
                    adapter.Fill(filteredTable);

                    dgvShiftData.DataSource = filteredTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dtpFilterStart_ValueChanged(object sender, EventArgs e)
        {
            dtpFilterEnd.Enabled = true;
            dtpFilterEnd.MinDate = dtpFilterStart.Value.AddHours(23.99);
            dtpFilterEnd.Value = dtpFilterEnd.MinDate;
        }

        private void btnSecurityPersonnel_Click(object sender, EventArgs e)
        {
            frmSecurityPersonnel form = new frmSecurityPersonnel();
            NavigateToForm(form);
        }

        private void btnShift_Click(object sender, EventArgs e)
        {
            frmShifts form = new frmShifts();
            NavigateToForm(form);
        }

        private void btnEquipment_Click(object sender, EventArgs e)
        {
            frmEquipment form = new frmEquipment();
            NavigateToForm(form);
        }

        private void btnSectors_Click(object sender, EventArgs e)
        {
            frmSectors form = new frmSectors();
            NavigateToForm(form);
        }

        private void btnIncidents_Click(object sender, EventArgs e)
        {
            frmIncidents form = new frmIncidents();
            NavigateToForm(form);
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            frmReports form = new frmReports();
            NavigateToForm(form);
        }

        private void tmrTimeUpdate_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToShortTimeString();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            resetFilters();
            txtShiftID.Clear();
            btnDisplayShifts_Click(sender, e);
        }

        private void picHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Email support at: tiredofbugs@gmail.com", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
