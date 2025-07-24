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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemplateForm
{
    public partial class frmSectors : Form
    {
        public frmSectors()
        {
            InitializeComponent();
        }

        string conStr;
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adap;
        DataSet ds;

        private string originalSectorName;
        private decimal originalArea;
        private bool originalIsActive;
        private int originalDangerLevel;

        // Menu and Text Fields sliding movements
        private const int EXPAND_RATE = 4;
        private const int TEXT_FIELD_PANEL_MAX_WIDTH = 375;
        private const int MENU_PANEL_MAX_WIDTH = 190;

        private void frmTemplate_Load(object sender, EventArgs e)
        {
            string serverName = Environment.GetEnvironmentVariable("EYE_SECURITY_DB") ?? @"localhost\SQLEXPRESS";
            conStr = "Server =" + serverName + ";Database =EYSECURITY;Integrated Security=True;";
            // Now you can use the connection string with a SqlConnection          
            #region "Visual Elements"
            //data grid
            dgvData.Width = 1100;
            dgvData.Left = 400;

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
            #endregion
        }
        private void frmSectors_Shown(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView();
            DisableUpdateControls();
        }

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
                    dgvData.Width -= EXPAND_RATE;
                    dgvData.Left += EXPAND_RATE;
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
                    dgvData.Width += EXPAND_RATE;
                    dgvData.Left -= EXPAND_RATE;
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
                    dgvData.Width -= EXPAND_RATE;
                    dgvData.Left += EXPAND_RATE;
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
                    dgvData.Width += EXPAND_RATE;
                    dgvData.Left -= EXPAND_RATE;
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
        }
        #endregion

        private void DisableUpdateControls()
        {
            txtName.Enabled = false;
            txtArea.Enabled = false;
            grpDangerlvl.Enabled = false;
            rdoYes.Enabled = false;
            rdoNo.Enabled = false;
            btnUpdate.Enabled = false;
            // Add any other controls that should be disabled
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            lblName.ForeColor = txtName.Text != originalSectorName ? Color.Red : Color.Black;
        }

        private void txtArea_TextChanged(object sender, EventArgs e)
        {
            lblArea.ForeColor = decimal.TryParse(txtArea.Text, out decimal area) && area != originalArea ? Color.Red : Color.Black;
        }

        private void rdoYes_CheckedChanged(object sender, EventArgs e)
        {
            lblActive.ForeColor = rdoYes.Checked != originalIsActive ? Color.Red : Color.Black;
        }

        private void rdoNo_CheckedChanged(object sender, EventArgs e)
        {
            lblActive.ForeColor = rdoNo.Checked != originalIsActive ? Color.Red : Color.Black;
        }

        public void LoadDataIntoDataGridView()
        {
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                string query = "SELECT * FROM Sector";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvData.DataSource = dt;
            }
            decimal max = GetMaxArea();           
            nudMaxArea.Value = max;
            nudMaxArea.Maximum = max;

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            InsertSectorForm insertForm = new InsertSectorForm();

            if (insertForm.ShowDialog() == DialogResult.OK) // Show the insert form as a modal dialog
            {
                // Reload data into the DataGridView after the insert form closes
                LoadDataIntoDataGridView();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Ensure a row is selected
            if (dgvData.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Retrieve the selected row's index and sector ID
            int selectedRowIndex = dgvData.SelectedRows[0].Index;
            int sectorId = Convert.ToInt32(dgvData.Rows[selectedRowIndex].Cells["Sector_ID"].Value); // Replace "Sector_ID" with your actual column name

            // Get the current values from the textboxes and radio buttons
            string newSectorName = txtName.Text;
            decimal newArea;
            if (!decimal.TryParse(txtArea.Text, out newArea))
            {
                MessageBox.Show("Please enter a valid decimal value for the area.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            bool isActive = rdoYes.Checked;
            int newDangerLevel = GetSelectedDangerLevel();
            if (newDangerLevel == -1) return; // If no danger level is selected, stop the update process

            // Prepare a message for confirmation
            string confirmationMessage = $"Are you sure you want to update?\n\n" +
                $"Sector ID: {sectorId}\n" +
                $"Sector Name: {dgvData.Rows[selectedRowIndex].Cells["Sector_Name"].Value} -> {newSectorName}\n" +
                $"Area: {dgvData.Rows[selectedRowIndex].Cells["Area"].Value} -> {newArea}\n" +
                $"Danger Level: {dgvData.Rows[selectedRowIndex].Cells["Danger_Level"].Value} -> {newDangerLevel}\n" +
                $"Is Active: {dgvData.Rows[selectedRowIndex].Cells["IsActive"].Value} -> {isActive}";

            // Show a confirmation dialog
            DialogResult result = MessageBox.Show(confirmationMessage, "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(conStr))
                {
                    conn.Open();
                    string query = "UPDATE Sector SET Sector_Name = @SectorName, Area = @Area, Danger_Level = @DangerLevel, IsActive = @IsActive WHERE Sector_ID = @SectorID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@SectorID", sectorId);
                        cmd.Parameters.AddWithValue("@SectorName", newSectorName);
                        cmd.Parameters.AddWithValue("@Area", newArea);
                        cmd.Parameters.AddWithValue("@DangerLevel", newDangerLevel);
                        cmd.Parameters.AddWithValue("@IsActive", isActive);

                        cmd.ExecuteNonQuery();
                    }
                }

                // After updating, reset label colors
                lblName.ForeColor = Color.Black;
                lblArea.ForeColor = Color.Black;
                lblActive.ForeColor = Color.Black;
                grpDangerlvl.ForeColor = Color.Black;

                // Reload data into the DataGridView to reflect the changes
                LoadDataIntoDataGridView();

                //Clears record data from controls
                ClearInputControls();

                //Resets lable colors
                ResetLabelColors();

                // After updating, disable the controls again
                DisableUpdateControls();
            }
        }

        private int GetSelectedDangerLevel()
        {
            int selectedDangerLevel = 0;

            switch (true)
            {
                case bool _ when rdoOne.Checked:
                    selectedDangerLevel = 1;
                    break;
                case bool _ when rdoTwo.Checked:
                    selectedDangerLevel = 2;
                    break;
                case bool _ when rdoThree.Checked:
                    selectedDangerLevel = 3;
                    break;
                case bool _ when rdoFour.Checked:
                    selectedDangerLevel = 4;
                    break;
                case bool _ when rdoFive.Checked:
                    selectedDangerLevel = 5;
                    break;
                default:
                    // Show a message and return -1 if no danger level is selected
                    MessageBox.Show("Please select a danger level.", "No Danger Level Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return -1;
            }

            return selectedDangerLevel;
        }

        private int indexForColumnHeader(string header)
        {
            foreach (DataGridViewColumn column in dgvData.Columns)
            {
                if (column.HeaderText == header)
                {
                    return column.Index;
                }
            }

            // Column is not found
            return -1;
        }

        private void SelectOnlyFirstRecordOf(DataGridView dtg)
        {
            if (dtg.Rows.Count > 0)
            {
                dtg.ClearSelection();
                dtg.Rows[0].Selected = true;
            }
        }

        private void DeleteSecurityPersonnelWithID(int id, string name, decimal area)
        {
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                string sql = "DELETE FROM Sector WHERE Sector_ID = @id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                try
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@id", id.ToString());
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show(name + " " + area + " deleted successfully!", "Successfully Deleted Sector");
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete Sector: " + name + " with Area: " + area + ".", "Failed to Delete Sector");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvData.SelectedRows.Count == 1)
            {
                DataGridViewRow row = dgvData.SelectedRows[0];
                // Row not null && did not select the empty row
                if (row != null && row.Cells[indexForColumnHeader("SECTOR_ID")].Value != null)
                {

                    string message = "Are you sure you want to delete Sector with";
                    int id = (int)row.Cells[indexForColumnHeader("SECTOR_ID")].Value;
                    string name = (string)row.Cells[indexForColumnHeader("SECTOR_NAME")].Value;
                    decimal area = (decimal)row.Cells[indexForColumnHeader("AREA")].Value;
                    // Build message
                    message += "\nID: " + id.ToString();
                    message += "\nSector: " + name;
                    message += "\nArea: " + area;

                    DialogResult result = MessageBox.Show(message, "Confirm Delete Sector", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        // ADD NEW PERSONNEL
                        DeleteSecurityPersonnelWithID(id, name, area);
                        ClearInputControls();

                        // After updating, reset label colors
                        lblName.ForeColor = Color.Black;
                        lblArea.ForeColor = Color.Black;
                        lblActive.ForeColor = Color.Black;
                        grpDangerlvl.ForeColor = Color.Black;
                    }
                }
                else
                {
                    MessageBox.Show("Please select a row with data, in the datagrid to delete");
                    SelectOnlyFirstRecordOf(dgvData);
                }
            }
            else
            {
                MessageBox.Show("Please select only ONE row in the datagrid to delete");
                SelectOnlyFirstRecordOf(dgvData);
            }

        }

        // Datagrid Queries
        private void showDataWithQuery(string sql, List<Tuple<string, string>> paramaters)
        {
            using (conn = new SqlConnection(conStr))
            {
                conn.Open();
                adap = new SqlDataAdapter();
                ds = new DataSet();

                cmd = new SqlCommand(sql, conn);
                adap.SelectCommand = cmd;
                foreach (var tuple in paramaters)
                {
                    cmd.Parameters.AddWithValue(tuple.Item1, tuple.Item2);
                }
                adap.Fill(ds, "SourceTable");

                dgvData.DataSource = ds;
                dgvData.DataMember = "SourceTable";
            }
        }

        private void showDataWithQuery(string sql, List<Tuple<string, decimal>> paramaters)
        {
            using (conn = new SqlConnection(conStr))
            {
                conn.Open();
                adap = new SqlDataAdapter();
                ds = new DataSet();

                cmd = new SqlCommand(sql, conn);
                adap.SelectCommand = cmd;
                foreach (var tuple in paramaters)
                {
                    cmd.Parameters.AddWithValue(tuple.Item1, tuple.Item2);
                }
                adap.Fill(ds, "SourceTable");

                dgvData.DataSource = ds;
                dgvData.DataMember = "SourceTable";
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

                dgvData.DataSource = ds;
                dgvData.DataMember = "SourceTable";
            }
        }

        private void txtFilterName_TextChanged(object sender, EventArgs e)
        {
            var parameters = new List<Tuple<string, string>>
            {
                new Tuple<string, string> ("@Name", txtFilterName.Text + "%")
            };
            showDataWithQuery("Select * FROM Sector WHERE Sector_Name LIKE @Name", parameters);
        }

        private void rdoFilterYes_CheckedChanged(object sender, EventArgs e)
        {
            showDataWithQuery("SELECT * FROM Sector WHERE IsActive = 1");
        }

        private void rdoFilterNo_CheckedChanged(object sender, EventArgs e)
        {
            showDataWithQuery("SELECT * FROM Sector WHERE IsActive = 0");
        }

        private void rdoFilterOne_CheckedChanged(object sender, EventArgs e)
        {
            showDataWithQuery("SELECT * FROM Sector WHERE Danger_Level = 1");
        }

        private void rdoFilterTwo_CheckedChanged(object sender, EventArgs e)
        {
            showDataWithQuery("SELECT * FROM Sector WHERE Danger_Level = 2");
        }

        private void rdoFilterThree_CheckedChanged(object sender, EventArgs e)
        {
            showDataWithQuery("SELECT * FROM Sector WHERE Danger_Level = 3");
        }

        private void rdoFilterFour_CheckedChanged(object sender, EventArgs e)
        {
            showDataWithQuery("SELECT * FROM Sector WHERE Danger_Level = 4");
        }

        private void rdoFilterFive_CheckedChanged(object sender, EventArgs e)
        {
            showDataWithQuery("SELECT * FROM Sector WHERE Danger_Level = 5");
        }

        private void rdoReset_CheckedChanged(object sender, EventArgs e)
        {
            showDataWithQuery("SELECT * FROM Sector");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // Reload data into the DataGridView
            LoadDataIntoDataGridView();

            // Clear all input controls
            ClearInputControls();

            // Reset label colors to black
            ResetLabelColors();

            //Disable controls after refresh
            DisableUpdateControls();
        }

        private void ClearInputControls()
        {
            // Clear all textboxes
            txtID.Clear();
            txtName.Clear();
            txtArea.Clear();

            // Uncheck radio buttons
            rdoYes.Checked = false;
            rdoNo.Checked = false;

            // Uncheck all danger level radio buttons
            foreach (RadioButton rb in grpDangerlvl.Controls.OfType<RadioButton>())
            {
                rb.Checked = false;
            }
        }

        private void ResetLabelColors()
        {
            lblName.ForeColor = Color.Black;
            lblArea.ForeColor = Color.Black;
            lblActive.ForeColor = Color.Black;
            grpDangerlvl.ForeColor = Color.Black;
        }

        private void frmSectors_Activated(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(conStr))
            {
                // Set the maximum value for the nudMaxArea control
                nudMaxArea.Maximum = GetMaxArea();

                // Ensure nudMinArea and nudMaxArea are within the valid range
                if (nudMinArea.Value > nudMaxArea.Maximum)
                {
                    nudMinArea.Value = nudMaxArea.Maximum;
                }

                if (nudMaxArea.Value > nudMaxArea.Maximum)
                {
                    nudMaxArea.Value = nudMaxArea.Maximum;
                }

                showDataWithQuery("Select * FROM Sector");
                LoadDataIntoDataGridView();
            }
        }

        private void nudMinArea_ValueChanged(object sender, EventArgs e)
        {
            var parameters = new List<Tuple<string, decimal>>
            {
                new Tuple<string, decimal> ("@minValue", nudMinArea.Value),
                new Tuple<string, decimal> ("@maxValue", nudMaxArea.Value)
            };
            showDataWithQuery("SELECT * FROM Sector WHERE Area BETWEEN @minValue AND @maxValue", parameters);
        }

        private void nudMaxArea_ValueChanged(object sender, EventArgs e)
        {
            var parameters = new List<Tuple<string, decimal>>
            {
                new Tuple<string, decimal> ("@minValue", nudMinArea.Value),
                new Tuple<string, decimal> ("@maxValue", nudMaxArea.Value)
            };
            showDataWithQuery("SELECT * FROM Sector WHERE Area BETWEEN @minValue AND @maxValue", parameters);
        }

        private decimal GetMaxArea()
        {
            decimal max = 0m;
            string sql = "SELECT MAX(Area) FROM Sector";

            using (SqlConnection conn = new SqlConnection(conStr))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        max = (decimal)result;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }

            }
            return max;
        }


        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (dgvData.ColumnHeadersVisible && string.IsNullOrWhiteSpace(txtSearch.Text))
                showDataWithQuery("SELECT * FROM Sector");
            else if (txtSearch.ForeColor == Color.Black)
            {
                // Build sql query: @txt1 OR @txt2 OR...
                // Add first header
                string columnHeaders = $"{dgvData.Columns[0].HeaderText} LIKE @searchText0";
                var tuples = new List<Tuple<string, string>>
                {
                    new Tuple<string, string>("@searchText0", txtSearch.Text + "%")
                };

                // Add the rest of the headers
                for (int i = 1; i < dgvData.Columns.Count; i++)
                {
                    string paramName = $"@searchText{i}";
                    columnHeaders += $" OR {dgvData.Columns[i].HeaderText} LIKE {paramName}";
                    tuples.Add(new Tuple<string, string>(paramName, txtSearch.Text + "%"));
                }

                // Update table and finish sql query
                string sql = $"SELECT * FROM Sector WHERE {columnHeaders}";
                showDataWithQuery(sql, tuples);
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

        private void EnableUpdateControls()
        {
            txtName.Enabled = true;
            txtArea.Enabled = true;
            grpDangerlvl.Enabled = true;
            rdoYes.Enabled = true;
            rdoNo.Enabled = true;
            btnUpdate.Enabled = true;
        }

        private void dgvData_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Get the selected row
            int selectedRowIndex = e.RowIndex;
            DataGridViewRow selectedRow = dgvData.Rows[selectedRowIndex];

            if (dgvData.SelectedRows.Count > 0)
            {
                EnableUpdateControls();
            }

            // Populate the SectorID textbox
            txtID.Text = selectedRow.Cells["Sector_ID"].Value.ToString(); // Update this with the exact column name

            // Store the original values
            string originalSectorName = selectedRow.Cells["Sector_Name"].Value.ToString();
            decimal originalArea = Convert.ToDecimal(selectedRow.Cells["Area"].Value);
            bool originalIsActive = Convert.ToBoolean(selectedRow.Cells["IsActive"].Value);
            int originalDangerLevel = Convert.ToInt32(selectedRow.Cells["Danger_Level"].Value);

            // Populate the controls with the selected row's data
            txtName.Text = originalSectorName;
            txtArea.Text = originalArea.ToString();
            rdoYes.Checked = originalIsActive;
            rdoNo.Checked = !originalIsActive;

            // Select the appropriate danger level radio button
            SelectDangerLevelRadioButton(originalDangerLevel);

            // Reset label colors
            lblName.ForeColor = Color.Black;
            lblArea.ForeColor = Color.Black;
            lblActive.ForeColor = Color.Black;
            grpDangerlvl.ForeColor = Color.Black;
        }
        private void SelectDangerLevelRadioButton(int dangerLevel)
        {
            switch (dangerLevel)
            {
                case 1: rdoOne.Checked = true; break;
                case 2: rdoTwo.Checked = true; break;
                case 3: rdoThree.Checked = true; break;
                case 4: rdoFour.Checked = true; break;
                case 5: rdoFive.Checked = true; break;
            }
        }

        private void grpDangerlvl_Enter(object sender, EventArgs e)
        {
            int selectedDangerLevel = GetSelectedDangerLevel();
            grpDangerlvl.ForeColor = selectedDangerLevel != originalDangerLevel ? Color.Red : Color.Black;
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

        private void tipTextFields_Popup(object sender, PopupEventArgs e)
        {

        }

        private void picHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Email support at: tiredofbugs@gmail.com", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}