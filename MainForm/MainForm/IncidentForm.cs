using Equipment;
using MainForm;
using SecurityPersonnelForm;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace TemplateForm
{
    public partial class frmIncidents : Form
    {
        public Boolean IncidentType = false;

        public frmIncidents()
        {
            InitializeComponent();
        }

        string conStr;
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adap;
        DataSet ds;

        // Menu and Text Fields sliding movements
        private const int EXPAND_RATE = 4;
        private const int TEXT_FIELD_PANEL_MAX_WIDTH = 375;
        private const int MENU_PANEL_MAX_WIDTH = 190;
    
        #region "FILTER TYPE INCIDENTS

        private void FilterIncidentTypeDataGrid()
        {
            // Get the filter values from the text boxes
            string codeFilter = txtCodeF.Text.Trim();
            string nameFilter = txtNameF.Text.Trim();
            string descriptionFilter = txtDescriptionF.Text.Trim();

            // Create the filter string
            string filterString = "";

            if (!string.IsNullOrEmpty(codeFilter))
            {
                filterString += string.Format("CODE LIKE '%{0}%'", codeFilter);
            }

            if (!string.IsNullOrEmpty(nameFilter))
            {
                if (!string.IsNullOrEmpty(filterString))
                {
                    filterString += " AND ";
                }
                filterString += string.Format("INCIDENT_TYPE_NAME LIKE '%{0}%'", nameFilter);
            }

            if (!string.IsNullOrEmpty(descriptionFilter))
            {
                if (!string.IsNullOrEmpty(filterString))
                {
                    filterString += " AND ";
                }
                filterString += string.Format("I_DESCRIPTION LIKE '%{0}%'", descriptionFilter);
            }

            // Apply the filter to the DataGridView
            (dgvData1.DataSource as DataTable).DefaultView.RowFilter = filterString;
        }

        #endregion

        private bool IsRowEmpty(DataGridViewRow row)
        {
            foreach (DataGridViewCell cell in row.Cells)
            {
                if (cell.Value != null && !string.IsNullOrWhiteSpace(cell.Value.ToString()))
                {
                    return false; // If at least one cell has a value, the row is not empty
                }
            }
            return true; // All cells are empty or null
        }

        private void fixColumnNames()
        {
            dgvData1.Columns["FIRST_NAME"].HeaderText = "SECURITY_PERSONELL_FIRST_NAME";
            
            dgvData1.Columns["START_DATETIME"].HeaderText = "START_DATE & TIME";
        }

        private void refreshDataGrid()
        {
            showDataWithQuery("SELECT i.INCIDENT_ID, i.SUMMARY_OF_EVENTS, it.INCIDENT_TYPE_NAME, sp.FIRST_NAME, " +
                "sp.LAST_NAME, s.SECTOR_NAME, sh.START_DATETIME  " +
                "FROM dbo.INCIDENT i, dbo.INCIDENT_TYPE it, dbo.SECURITYPERSONNEL sp, dbo.SECTOR s, dbo.SHIFTS sh " +
                "WHERE sp.PERSONNEL_ID = i.PERSONNEL_ID AND it.INCIDENT_TYPE_ID = i.INCIDENT_TYPE_ID " +
                "AND s.SECTOR_ID = i.SECTOR_ID AND sh.SHIFT_ID = i.SHIFT_ID");
            fixColumnNames();
        }

        private void RefreshDataGridForType()
        {
            // Retrieve updated data from the database and bind to the DataGridView
            string sql = "SELECT * FROM dbo.INCIDENT_TYPE";
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    try
                    {
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        ds = new DataSet();
                        da.Fill(ds, "INCIDENT_TYPE");
                        dgvData1.DataSource = ds.Tables["INCIDENT_TYPE"];
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while refreshing data: " + ex.Message);
                    }
                }
            }
        }

        private void showDataWithQuery(string sql)
        {

            using (conn = new SqlConnection(conStr))
            {
                conn.Open();
                adap = new SqlDataAdapter();
                ds = new DataSet();

                cmd = new SqlCommand(sql, conn);
                adap.SelectCommand = cmd;
                adap.Fill(ds, "SourceTable");

                // Set the DataGridView's DataSource to the DataTable
                dgvData1.DataSource = ds.Tables["SourceTable"]; // IMPORTANT: Set the DataSource here
            }

        }

        #region "FORM LOAD"
        private void frmTemplate_Load(object sender, EventArgs e)
        {
            IncidentType = false;

            #region "Visual Elements"
            //data grid
            dgvData1.Width = 1100;
            dgvData1.Left = 400;

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
            txtSearch.Text = "Search for data in the displayed table";
            txtSearch.ForeColor = Color.DarkGray;
            txtCodeF.Enabled = false;
            txtNameF.Enabled = false;
            txtDescriptionF.Enabled = false;
            #endregion
           
        }

        private void frmIncidents_Shown(object sender, EventArgs e)
        {
            #region "SQLConnection"
            string serverName = Environment.GetEnvironmentVariable("EYE_SECURITY_DB") ?? @"localhost\SQLEXPRESS";

            conStr = "Server =" + serverName + ";Database =EYSECURITY;Integrated Security=True;";
            // Now you can use the connection string with a SqlConnection
            // Connect with click of Button


            // Establish connection           
            string sql = "Select * FROM dbo.INCIDENT";

            using (SqlConnection conn = new SqlConnection(conStr))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                try
                {
                    conn.Open();

                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }

            #endregion

            //user access
            StreamReader userFile = new StreamReader("CurrentUser.txt");
            string line = userFile.ReadLine();
            userFile.Close();
            if (line == "Personnel")
            {
                btnSecurityPersonnel.Enabled = false;
                btnShift.Enabled = false;
                btnSectors.Enabled = false;
                btnEquipment.Enabled = false;
                btnReports.Enabled = false;
                btnDisplayType.Enabled = false;
            }

            refreshDataGrid();
            LoadComboBoxData();

            // Check if there are any rows in the DataGridView
            if (dgvData1.Rows.Count > 0 && !dgvData1.Rows[0].IsNewRow)
            {
                // Get the first row (row index 0)
                DataGridViewRow row = dgvData1.Rows[0];

                // Check if the row is empty using the IsRowEmpty method
                if (IsRowEmpty(row))
                {
                    MessageBox.Show("The first row is empty.");
                    txtIncident_ID.Clear();  // Clear the TextBox for Incident ID
                    rtbSummary.Clear();      // Clear the RichTextBox for Summary
                }
                else
                {
                    // Assuming the ID is in the column "INCIDENT_ID" and the summary in "SUMMARY_OF_EVENTS"
                    var selectedID = Convert.ToInt32(row.Cells["INCIDENT_ID"].Value);  // Retrieve the Incident ID
                    var summaryEvents = row.Cells["SUMMARY_OF_EVENTS"].Value;
                    // Retrieve the Summary

                    // Display the selected Incident ID and Summary in their respective controls
                    txtIncident_ID.Text = selectedID.ToString();
                    rtbSummary.Text = summaryEvents?.ToString();
                }
            }
            else
            {
                MessageBox.Show("No rows available in the DataGridView.");
            }
            lblSummary.ForeColor = Color.Black;
            txtTypeDescription.ForeColor = Color.Black;
            txtTypeID.ForeColor = Color.Black;
            txtTypeName.ForeColor = Color.Black;
            btnUpdate.Enabled = false;
            btnDisplayIncidents.Enabled = false;
        }

        #endregion

        #region "Visual Elements"
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            tmrMenu.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //expand menu
            if (pnlSidePanel.Width < MENU_PANEL_MAX_WIDTH)
            {
                while (pnlSidePanel.Width < MENU_PANEL_MAX_WIDTH)
                {
                    pnlSidePanel.Width += EXPAND_RATE;
                    dgvData1.Width -= EXPAND_RATE;
                    dgvData1.Left += EXPAND_RATE;
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
                    dgvData1.Width += EXPAND_RATE;
                    dgvData1.Left -= EXPAND_RATE;
                    if (pnlSidePanel.Width % 5 == 0)
                        System.Threading.Thread.Sleep(1);
                }
                tipMenu.SetToolTip(picMenu, "Show Menu");
                tmrMenu.Enabled = false;
            }
        }

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
                    dgvData1.Width -= EXPAND_RATE;
                    dgvData1.Left += EXPAND_RATE;
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
                    dgvData1.Width += EXPAND_RATE;
                    dgvData1.Left -= EXPAND_RATE;
                }
                picTextFieldMoveLeft.Visible = false;
                picTextFieldMoveRight.Visible = true;
                tipTextFields.SetToolTip(picTextFieldMoveRight, "Show Filter Fields");
                tmrTextFields.Enabled = false;
            }
        }


        #endregion

        #region "INSERT DATA"

        private void btnInsert_Click(object sender, EventArgs e)
        {
            
            if (IncidentType == true)
            {
                Insert_Incident_Type insertIncidentsType = new Insert_Incident_Type();
                insertIncidentsType.ShowDialog();
            }

            else
            {
                InsertIncidents insertIncidents = new InsertIncidents();
                insertIncidents.ShowDialog();
            }
        }

        #endregion

        #region "UPDATE DATA"

        private void ExpandTextFields()
        {
            if (pnlTextFieldPanel.Width >= 375) return;

            while (pnlTextFieldPanel.Width < 375)
            {
                pnlTextFieldPanel.Width++;
                dgvData1.Width--;
                dgvData1.Left++;
            }

            picTextFieldMoveLeft.Visible = true;
            picTextFieldMoveRight.Visible = false;
            tipTextFields.SetToolTip(picTextFieldMoveLeft, "Hide values of a selected record");
            tmrTextFields.Enabled = false;
        }
     
        private void ClearFields()
        {
            // Incident Fields
            cbxTypeName.SelectedIndex = -1;
            cbxLastN.SelectedIndex = -1;
            cbxSector.SelectedIndex = -1;
            cbxShift.SelectedIndex = -1;
            txtIncident_ID.Clear();
            rtbSummary.TextChanged -= richTextBox1_TextChanged;
            rtbSummary.Clear();
            rtbSummary.TextChanged += richTextBox1_TextChanged;
            // Incident Type Fields
            txtTypeID.Clear();
            txtIncidentTypeCode.Clear();
            txtTypeName.Clear();
            txtTypeDescription.Clear();
        }

        private void ValidateAndUpdate()
        {
            if (!IncidentType)
            {
                UpdateIncident();
            }
            else
            {
                if (ValidateIncidentTypeFields())
                {
                    UpdateIncidentType();
                }
            }
        }

        private bool ValidateIncidentTypeFields()
        {
            if (string.IsNullOrWhiteSpace(txtIncidentTypeCode.Text))
            {
                MessageBox.Show("Please enter a code for the incident type.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTypeName.Text))
            {
                MessageBox.Show("Please enter a name for the incident type.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTypeDescription.Text))
            {
                MessageBox.Show("Please enter a description for the incident type.");
                return false;
            }

            return true;
        }

        private void UpdateIncident()
        {
            string sql = @"UPDATE dbo.INCIDENT
                            SET SUMMARY_OF_EVENTS = @Summary,
                                PERSONNEL_ID = @Personnel,
                                SHIFT_ID = @Shift,
                                INCIDENT_TYPE_ID = @IncidentTypeID,
                                SECTOR_ID = @Sector
                            WHERE INCIDENT_ID = @IncidentID";

            string typeAndID, nameAndID, sectorAndID, shiftAndID;

            nameAndID = cbxLastN.Text;
            typeAndID = cbxTypeName.Text;
            sectorAndID = cbxSector.Text;
            shiftAndID = cbxShift.Text;
            string PersonnelID = nameAndID.Substring(0, nameAndID.IndexOf(' '));
            string TypeID = typeAndID.Substring(0, typeAndID.IndexOf(' '));
            string SectorID = sectorAndID.Substring(0, sectorAndID.IndexOf(' '));
            string ShiftID = shiftAndID.Substring(0, shiftAndID.IndexOf(' '));

            ExecuteUpdate(sql, new SqlParameter[]
            {
                new SqlParameter("@Summary", rtbSummary.Text),
                new SqlParameter("@IncidentID", txtIncident_ID.Text),
                new SqlParameter("@Personnel", PersonnelID),
                new SqlParameter("@Shift", ShiftID),
                new SqlParameter("@IncidentTypeID", TypeID),
                new SqlParameter("@Sector", SectorID)
        });

            refreshDataGrid();
            ClearAfterUpdate();
        }

        private void UpdateIncidentType()
        {
            string sql = "UPDATE dbo.INCIDENT_TYPE SET CODE = @Code, INCIDENT_TYPE_NAME = @Name, I_DESCRIPTION = @Description WHERE INCIDENT_TYPE_ID = @TypeID";

            ExecuteUpdate(sql, new SqlParameter[]
            {
        new SqlParameter("@TypeID", Convert.ToInt32(txtTypeID.Text)),
        new SqlParameter("@Code", txtIncidentTypeCode.Text),
        new SqlParameter("@Name", txtTypeName.Text),
        new SqlParameter("@Description", txtTypeDescription.Text)
            });

            RefreshDataGridForType();
            ClearAfterUpdate();
        }

        private void ExecuteUpdate(string sql, SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddRange(parameters);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        MessageBox.Show(rowsAffected > 0 ? "Update successful!" : "No rows updated.");
                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void ClearAfterUpdate()
        {
            btnUpdate.Enabled = false;
            // Disable editable fields
            rtbSummary.Enabled = false;
            cbxTypeName.Enabled = false;
            cbxLastN.Enabled = false;
            cbxSector.Enabled = false;
            cbxShift.Enabled = false;
            ClearFields();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ExpandTextFields();

            if (dgvData1.Rows.Count == 0 || dgvData1.Rows[0].IsNewRow)
            {
                MessageBox.Show("No rows available in the DataGridView.");
                return;
            }

           
            ValidateAndUpdate();
            btnUpdate.Enabled = false;
            setUpdateLabelsToBlack();

        }
        #endregion

        private void SelectOnlyFirstRecordOf(DataGridView dtg)
        {
            if (dtg.Rows.Count > 0)
            {
                dtg.ClearSelection();
                dtg.Rows[0].Selected = true;
            }
        }
        #region "DELETE DATA"
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (dgvData1.SelectedRows.Count != 1)
            {
                MessageBox.Show("Please select a row to delete.");
                SelectOnlyFirstRecordOf(dgvData1);
                return; // Exit the method if no row is selected
            }

            // Get the selected ID based on IncidentType
            int selectedId = GetSelectedId();

            // Confirmation popup
            DialogResult result = MessageBox.Show(
                IncidentType ? "Do you want to proceed with deleting the selected incident type?" : "Do you want to proceed with deleting the selected incident?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                // Define the SQL DELETE query
                string sql = IncidentType
                    ? "DELETE FROM dbo.INCIDENT_TYPE WHERE INCIDENT_TYPE_ID = @IncidentTypeID"
                    : "DELETE FROM dbo.INCIDENT WHERE INCIDENT_ID = @IncidentID";

                using (SqlConnection conn = new SqlConnection(conStr))
                {
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    // Add the ID parameter
                    cmd.Parameters.AddWithValue(IncidentType ? "@IncidentTypeID" : "@IncidentID", selectedId);

                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show(IncidentType ? "Incident type deleted successfully!" : "Incident deleted successfully!");
                            RefreshData(); // Call a single method to refresh the DataGridView
                        }
                        else
                        {
                            MessageBox.Show("No rows were deleted.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Deletion canceled.");
            }

            ClearAfterUpdate();
        }

        // Helper methods
        private int GetSelectedId()
        {
            return Convert.ToInt32(dgvData1.SelectedRows[0].Cells[IncidentType ? "INCIDENT_TYPE_ID" : "INCIDENT_ID"].Value);
        }

        private void RefreshData()
        {
            if (IncidentType)
            {
                RefreshDataGridForType();
            }
            else
            {
                refreshDataGrid();
            }
        }

        #endregion

        #region "DISPLAY INCIDENTS TYPE"
        private void btnDisplayType_Click(object sender, EventArgs e)
        {
            btnInsert.Text = "Insert Incidents Type";
            btnUpdate.Text = "Update Incidents Type";
            btnDelete.Text = "Delete Incidents Type";
            lblHeading.Text = "Incident Type";

            txtNameF.Enabled = true;
            txtDescriptionF.Enabled = true;
            txtCodeF.Enabled = true;



            tabDisplayRecords.Visible = false;

            tabCtrlFields.SelectedIndex = 2;

            IncidentType = true;
            btnDisplayIncidents.Enabled = true;
            
            
            btnUpdate.Enabled = false;
                   
            showDataWithQuery("Select * FROM dbo.INCIDENT_TYPE");
            dgvData1.Columns["I_DESCRIPTION"].HeaderText = "INCIDENT_TYPE_DESCRIPTION";

            if (dgvData1.Rows.Count > 0 && !dgvData1.Rows[0].IsNewRow)
            {
                // Get the first row (row index 0)
                DataGridViewRow row = dgvData1.Rows[0];

                // Check if the row is empty using the IsRowEmpty method
                if (IsRowEmpty(row))
                {
                    MessageBox.Show("The first row is empty.");
                    txtIncident_ID.Clear();  // Clear the TextBox for Incident ID
                    rtbSummary.Clear();      // Clear the RichTextBox for Summary
                }
                else
                {
                    var selectedTypeID = Convert.ToInt32(row.Cells["INCIDENT_TYPE_ID"].Value);  // Retrieve the Incident ID
                    var Code = row.Cells["CODE"].Value;
                    var TypeName = row.Cells["INCIDENT_TYPE_NAME"].Value;
                    var Description = row.Cells["I_DESCRIPTION"].Value;
                    // Retrieve the Summary

                    // Display the selected Incident ID and Summary in their respective controls
                    txtTypeID.Text = selectedTypeID.ToString();
                    txtIncidentTypeCode.Text = Code?.ToString();
                    txtTypeName.Text = TypeName?.ToString();
                    txtTypeDescription.Text = Description?.ToString();
                }
            }

            btnUpdate.Enabled = false;
            lblIncidentTypeCode.ForeColor = Color.Black;
            lblTypeName.ForeColor = Color.Black;
            lblTypeDescription.ForeColor = Color.Black;

            btnDisplayType.Enabled = false;
        }

        #endregion

        private void txtIncidentTypeCode_TextChanged(object sender, EventArgs e)
        {
            lblIncidentTypeCode.ForeColor = Color.Red;
            btnUpdate.Enabled = true;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            lblSummary.ForeColor = Color.Red;
            btnUpdate.Enabled= true;
        }

        private void btnDisplayIncidents_Click(object sender, EventArgs e)
        {
            
            IncidentType = false;

            tabDisplayType.Visible = false;
            tabFilterRecords.Visible = false;   

            tabDisplayRecords.Visible = true;

            lblHeading.Text = "Incidents";
            btnInsert.Text = "Insert Incidents";
            btnUpdate.Text = "Update Incidents";
            btnDelete.Text = "Delete Incidents";

            txtNameF.Enabled = false;   
            txtDescriptionF.Enabled = false;
            txtCodeF.Enabled = false;

            refreshDataGrid();
            btnDisplayIncidents.Enabled = false;
                       
            btnUpdate.Enabled = false;

            btnDisplayType.Enabled = true;
            SelectOnlyFirstRecordOf(dgvData1);
        }

        private void txtTypeName_TextChanged(object sender, EventArgs e)
        {
            lblTypeName.ForeColor = Color.Red;
            btnUpdate.Enabled = true;
        }

        private void txtTypeDescription_TextChanged(object sender, EventArgs e)
        {
            lblTypeDescription.ForeColor = Color.Red;
            btnUpdate.Enabled = true;
        }

        private void dgvData1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the row index is valid (prevents index out of bounds errors)
            if (e.RowIndex >= 0)
            {
                // Get the currently selected row
                DataGridViewRow row = dgvData1.Rows[e.RowIndex];

                if (IsRowEmpty(row))
                {
                    MessageBox.Show("The selected row is empty.");
                    txtIncident_ID.Clear();
                    rtbSummary.Clear();
                    // disable update fields
                    rtbSummary.Enabled = false;
                    cbxTypeName.Enabled = false;
                    cbxLastN.Enabled = false;
                    cbxSector.Enabled = false;
                    cbxShift.Enabled = false;
        
                    cbxShift.SelectedIndex = -1;
                    cbxTypeName.SelectedIndex = -1;
                    cbxLastN.SelectedIndex = -1;
                    cbxSector.SelectedIndex = -1;
                    // Clear other textboxes related to Incident Type if needed
                }
                else
                {
                    // Enable update fields
                    rtbSummary.Enabled = true;
                    cbxTypeName.Enabled = true;
                    cbxLastN.Enabled = true;
                    cbxSector.Enabled = true;
                    cbxShift.Enabled = true;
                    // Temporarily disable TextChanged event handlers
                    txtIncidentTypeCode.TextChanged -= txtIncidentTypeCode_TextChanged;
                    txtTypeName.TextChanged -= txtTypeName_TextChanged;
                    txtTypeDescription.TextChanged -= txtTypeDescription_TextChanged;

                    if (!IncidentType)
                    {
                        // Assuming the ID is in the column "INCIDENT_ID" and the summary in "SUMMARY_OF_EVENTS"
                        string typeID, personnelID, sectorID, shiftID;
                        typeID = personnelID = sectorID = shiftID = "";
                        var selectedID = Convert.ToInt32(row.Cells["INCIDENT_ID"].Value);
                        using (SqlConnection conn = new SqlConnection(conStr))
                        {
                            string sql = $"SELECT * FROM dbo.INCIDENT WHERE Incident_ID = {selectedID}";
                            SqlCommand cmd = new SqlCommand(sql, conn);

                            try
                            {
                                conn.Open();
                                SqlDataReader reader = cmd.ExecuteReader();

                                reader.Read();
                                
                                typeID = reader["INCIDENT_TYPE_ID"].ToString();
                                personnelID = reader["PERSONNEL_ID"].ToString();
                                sectorID = reader["SECTOR_ID"].ToString();
                                shiftID = reader["SHIFT_ID"].ToString();

                                reader.Dispose();
                                reader.Close();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("An error occurred: " + ex.Message);
                            }
                        }
                        var summaryEvents = row.Cells["SUMMARY_OF_EVENTS"].Value;
                        var incidentTypeName = row.Cells["INCIDENT_TYPE_NAME"].Value;
                        var lastName = row.Cells["LAST_NAME"].Value;
                        var sectorName = row.Cells["SECTOR_NAME"].Value;
                        var shiftStartAndTime = row.Cells["START_DATETIME"].Value;

                        // Display the selected ID, or use it as needed
                        txtIncident_ID.Text = selectedID.ToString();
                        rtbSummary.Text = summaryEvents.ToString();
                        cbxTypeName.Text = typeID + " " + incidentTypeName.ToString();
                        cbxLastN.Text = personnelID + " " + lastName.ToString();
                        cbxSector.Text = sectorID + " " + sectorName.ToString();
                        cbxShift.Text = shiftID + " " + shiftStartAndTime.ToString();
                    }
                    else
                    {
                        // Assuming the ID is in the column "INCIDENT_TYPE_ID" and other values are in their respective columns
                        var selectedTypeID = Convert.ToInt32(row.Cells["INCIDENT_TYPE_ID"].Value);
                        var code = row.Cells["CODE"].Value;
                        var name = row.Cells["INCIDENT_TYPE_NAME"].Value;
                        var description = row.Cells["I_DESCRIPTION"].Value;

                        // Display the selected ID, or use it as needed
                        txtTypeID.Text = selectedTypeID.ToString();
                        txtIncidentTypeCode.Text = code.ToString();
                        txtTypeName.Text = name.ToString();
                        txtTypeDescription.Text = description.ToString();
                    }

                    // Re-enable TextChanged event handlers
                    txtIncidentTypeCode.TextChanged += txtIncidentTypeCode_TextChanged;
                    txtTypeName.TextChanged += txtTypeName_TextChanged;
                    txtTypeDescription.TextChanged += txtTypeDescription_TextChanged;

                    setUpdateLabelsToBlack();
                    txtTypeID.ForeColor = Color.Black;
                    txtTypeDescription.ForeColor = Color.Black;
                    txtTypeName.ForeColor = Color.Black;
                    txtIncidentTypeCode.ForeColor = Color.Black;
                    btnUpdate.Enabled = false;
                }
            }
        }

        private void dgvData1_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void dgvData1_VisibleChanged(object sender, EventArgs e)
        {

        }

        public void setUpdateLabelsToBlack()
        {
            lblIncidentTypeName.ForeColor = Color.Black;
            lblPersonnelLastName.ForeColor = Color.Black;
            lblSectorName.ForeColor = Color.Black;
            lblShiftDateAndTime.ForeColor = Color.Black;
            lblSummary.ForeColor = Color.Black;
            lblTypeDescription.ForeColor = Color.Black;
            lblTypeName.ForeColor = Color.Black;
            lblIncidentTypeCode.ForeColor = Color.Black;
        }

        private void dgvData1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the currently selected row
                DataGridViewRow row = dgvData1.Rows[e.RowIndex];

                if (IsRowEmpty(row))
                {
                    MessageBox.Show("The selected row is empty.");
                    txtIncident_ID.Clear();
                    rtbSummary.Clear();
                }
                else
                {
                    // Assuming the ID is in the first column (index 0)
                    var selectedID = Convert.ToInt32(row.Cells["INCIDENT_ID"].Value);
                    var summaryEvents = row.Cells["SUMMARY_OF_EVENTS"].Value;

                    // Display the selected ID, or use it as needed
                    txtIncident_ID.Text = selectedID.ToString();
                    rtbSummary.Text = summaryEvents.ToString();
                }

                setUpdateLabelsToBlack();

                btnUpdate.Enabled = false;
            }
        }

        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();

            // Check if there is data to filter
            if (dgvData1.DataSource != null && (dgvData1.DataSource as DataTable).Rows.Count > 0)
            {
                string filterString = IncidentType
            ? string.Format("CONVERT(INCIDENT_TYPE_ID, System.String) LIKE '%{0}%' OR CODE LIKE '%{0}%' OR INCIDENT_TYPE_NAME LIKE '%{0}%' OR I_DESCRIPTION LIKE '%{0}%'", searchText)
            : string.Format("CONVERT(INCIDENT_ID, System.String) LIKE '%{0}%' OR SUMMARY_OF_EVENTS LIKE '%{0}%' OR FIRST_NAME LIKE '%{0}%' OR LAST_NAME LIKE '%{0}%' OR SECTOR_NAME LIKE '%{0}%' OR CONVERT(START_DATETIME, System.String) LIKE '%{0}%'", searchText);

                (dgvData1.DataSource as DataTable).DefaultView.RowFilter = filterString;
            }
        }

        #region "LoadComboBoxData"
        private void LoadIncidentTypeNames()
        {
            string query = "SELECT INCIDENT_TYPE_ID, INCIDENT_TYPE_NAME FROM dbo.INCIDENT_TYPE";
            LoadComboBoxData(query, cbxTypeName, "INCIDENT_TYPE_ID", "INCIDENT_TYPE_NAME");
        }

        private void LoadLastNames()
        {
            string query = "SELECT PERSONNEL_ID, LAST_NAME FROM dbo.SECURITYPERSONNEL";
            LoadComboBoxData(query, cbxLastN, "PERSONNEL_ID", "LAST_NAME");
        }

        private void LoadSectorNames()
        {
            string query = "SELECT SECTOR_ID, SECTOR_NAME FROM dbo.SECTOR";
            LoadComboBoxData(query, cbxSector, "SECTOR_ID", "SECTOR_NAME");
        }

        private void LoadShiftDates()
        {
            string query = "SELECT SHIFT_ID, START_DATETIME FROM dbo.SHIFTS";
            LoadComboBoxData(query, cbxShift, "SHIFT_ID", "START_DATETIME");
        }

        private void LoadComboBoxData()
        {
            cbxTypeName.Items.Clear();
            cbxLastN.Items.Clear();
            cbxSector.Items.Clear();
            cbxShift.Items.Clear();
            LoadIncidentTypeNames();
            LoadLastNames();
            LoadSectorNames();
            LoadShiftDates();
        }

        private void LoadComboBoxData(string query, System.Windows.Forms.ComboBox comboBox, string idColumn, string columnName)
        {
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                SqlCommand cmd = new SqlCommand(query, conn);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        comboBox.Items.Add(reader[idColumn].ToString() + " " + reader[columnName].ToString());
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        #endregion

        private void frmIncidents_Activated(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(conStr))
            {
                lblSummary.ForeColor= Color.Black;
                txtTypeID.ForeColor= Color.Black;
                txtTypeName.ForeColor= Color.Black;
                txtIncidentTypeCode.ForeColor= Color.Black; 
                txtTypeDescription.ForeColor= Color.Black;
           
                if (!IncidentType)
                {
                    refreshDataGrid();
                    LoadComboBoxData();
                }
                else
                {
                    RefreshDataGridForType();
                }
            }
        }

        private void txtCodeF_TextChanged(object sender, EventArgs e)
        {
            FilterIncidentTypeDataGrid();
        }

        private void txtNameF_TextChanged(object sender, EventArgs e)
        {
            FilterIncidentTypeDataGrid();
        }

        private void txtDescriptionF_TextChanged(object sender, EventArgs e)
        {
            FilterIncidentTypeDataGrid();
        }

        private void tmrTimeUpdate_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToShortTimeString();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            btnDisplayIncidents_Click(sender, e);
        }

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

        private void picHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Email support at: tiredofbugs@gmail.com", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void setLabelRed(Label lbl)
        {
            lbl.ForeColor = Color.Red;
            btnUpdate.Enabled = true;
        }

        private void cbxTypeName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            setLabelRed(lblIncidentTypeName);
        }

        private void cbxLastN_SelectionChangeCommitted(object sender, EventArgs e)
        {
            setLabelRed(lblPersonnelLastName);
        }

        private void cbxSector_SelectionChangeCommitted(object sender, EventArgs e)
        {
            setLabelRed(lblSectorName);
        }

        private void cbxShift_SelectionChangeCommitted(object sender, EventArgs e)
        {
            setLabelRed(lblShiftDateAndTime);
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
        }
    }
}
