using Equipment;
using MainForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TemplateForm;

namespace SecurityPersonnelForm
{
    public partial class frmSecurityPersonnel : Form
    {
        public frmSecurityPersonnel()
        {
            InitializeComponent();
        }

        // Database & DatagridView
        string conStr;
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adap;
        DataSet ds;

        // Menu and Text Fields sliding movements
        private const int EXPAND_RATE = 4;
        private const int TEXT_FIELD_PANEL_MAX_WIDTH = 375;
        private const int MENU_PANEL_MAX_WIDTH = 190;

        private void ApplyTheme()
        {
            this.BackColor = Color.White; // Set a consistent background color
        }

        private decimal GetMaxSalary()
        {
            decimal max = 0m;
            string sql = "SELECT MAX(Salary) FROM SecurityPersonnel";

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

        // Form load
        private void frmTemplate_Load(object sender, EventArgs e)
        {
            ApplyTheme();
            //buttons
            btnSecurityPersonnel.Enabled = false;
            btnUpdate.Enabled = false;

            #region "Visual Elements"
            //data grid
            dtgResults.Width = 1100;
            dtgResults.Left = 400;

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

        // Form Show
        private void frmSecurityPersonnel_Shown(object sender, EventArgs e)
        {
            // Connect DB
            ConnectDB();
            showDataWithQuery("Select * FROM SecurityPersonnel");

            //Set filterMaxSalary to Max value in table 
            decimal max = GetMaxSalary();
            nudMaxSalary.Value = max;
            nudMaxSalary.Maximum = max;
        }
        // Form Activated
        private void frmSecurityPersonnel_Activated(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(conStr))
            {
                showDataWithQuery("Select * FROM SecurityPersonnel");
                decimal max = GetMaxSalary();
                nudMaxSalary.Maximum = max;
                nudMaxSalary.Value = max;                
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
                    dtgResults.Width -= EXPAND_RATE;
                    dtgResults.Left += EXPAND_RATE;
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
                    dtgResults.Width += EXPAND_RATE;
                    dtgResults.Left -= EXPAND_RATE;
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
                    dtgResults.Width -= EXPAND_RATE;
                    dtgResults.Left += EXPAND_RATE;
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
                    dtgResults.Width += EXPAND_RATE;
                    dtgResults.Left -= EXPAND_RATE;
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
        
        // Database things
        private void ConnectDB()
        {
            // The ?? will give serverName a default value of @"localhost\SQLEXPRESS"
            string serverName = Environment.GetEnvironmentVariable("EYE_SECURITY_DB") ?? @"localhost\SQLEXPRESS";
            conStr = "Server =" + serverName + ";Database =EYSECURITY;Integrated Security=True;";
        }
        private void showDataWithQuery(string sql)
        {
            try
            {
                using (conn = new SqlConnection(conStr))
                {
                    conn.Open();
                    adap = new SqlDataAdapter();
                    ds = new DataSet();

                    cmd = new SqlCommand(sql, conn);
                    adap.SelectCommand = cmd;
                    adap.Fill(ds, "SourceTable");

                    dtgResults.DataSource = ds;
                    dtgResults.DataMember = "SourceTable";
                }
            }
            catch
            {
                MessageBox.Show("Error loading datagrid data","Database Connection Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void showDataWithQuery(string sql, List<Tuple<string, string>> paramaters)
        {
            try
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

                    dtgResults.DataSource = ds;
                    dtgResults.DataMember = "SourceTable";
                }
            }                
            catch
            {
                MessageBox.Show("Error loading datagrid data","Database Connection Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}
        private void showDataWithQuery(string sql, List<Tuple<string, decimal>> paramaters)
        {
            try
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

                    dtgResults.DataSource = ds;
                    dtgResults.DataMember = "SourceTable";
                }
            }
            catch
            {
                MessageBox.Show("Error loading datagrid data", "Database Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }                  
        }

        // Insert
        private void btnAddNew_Click(object sender, EventArgs e)
        {        
            frmInsertSecurityPersonnel frmInsertSecurityPersonnel = new frmInsertSecurityPersonnel();
            frmInsertSecurityPersonnel.ShowDialog();
        }

        // Update
        private void validateUpdateFields()
        {
            TextBox[] txts = { txtDisplayFirstName, txtDisplayLastName, txtDisplayIDNumber, txtDisplayPhoneNumber, txtDisplayEmail };
            ValidateSecurityPersonnel validator = new ValidateSecurityPersonnel();

            // Check for empty txts
            for (int i = 0; i < txts.Length; i++)
            {
                if (validator.IsTxtEmpty(txts[i]))
                {
                    string label = txts[i].Name.Substring("txtDisplay".Length);
                    txts[i].Focus();
                    throw new Exception("Please fill in " + label);
                }
            }

            // Check ID Number
            string errorMessage = validator.IsValidIDNumber(txtDisplayIDNumber.Text);
            if (errorMessage != "")
            {
                txtDisplayIDNumber.Focus();
                throw new Exception(errorMessage);
            }

            // Check phone Number
            errorMessage = validator.IsValidPhoneNumber(txtDisplayPhoneNumber.Text);
            if (errorMessage != "")
            {
                txtDisplayPhoneNumber.Focus();
                throw new Exception(errorMessage);
            }

            // Check Email Address
            if (!validator.IsValidEmail(txtDisplayEmail.Text))
            {
                txtDisplayEmail.Focus();
                throw new Exception("Please enter a valid email address");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string firstName, lastName, idNum, phoneNumber, email;
            int explvl;
            decimal salary;

            if (dtgResults.SelectedRows.Count == 1)
            {
                try
                {
                    validateUpdateFields();

                    DataGridViewRow row = dtgResults.SelectedRows[0];
                    int id = (int)row.Cells["PERSONNEL_ID"].Value;

                    DialogResult result;

                    using (conn = new SqlConnection(conStr))
                    {
                        conn.Open();
                        string sql = "SELECT * FROM SecurityPersonnel WHERE PERSONNEL_ID = @id";
                        cmd = new SqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@id", id);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            reader.Read();

                            //confirmation after validations
                            firstName = txtDisplayFirstName.Text;
                            lastName = txtDisplayLastName.Text;
                            idNum = txtDisplayIDNumber.Text;
                            phoneNumber = txtDisplayPhoneNumber.Text;
                            email = txtDisplayEmail.Text;
                            explvl = (int)nudDisplayExpLvl.Value;
                            salary = nudDisplaySalary.Value;

                            result = MessageBox.Show($"Are you sure you want to update the details of Personnel with ID: {id}" +
                                "\nFirst_Name: " + reader["FIRST_NAME"].ToString() + " -> " + firstName +
                                "\nLast_Name: " + reader["LAST_NAME"].ToString() + " -> " + lastName +
                                "\nID_Number: " + reader["ID_NUMBER"].ToString() + " -> " + idNum +
                                "\nPhone_Number: " + reader["PHONE_NUMBER"].ToString() + " -> " + phoneNumber +
                                "\nEmail_Address: " + reader["EMAIL_ADDRESS"].ToString() + " -> " + email +
                                "\nExperience_Level: " + reader["EXPERIENCE_LEVEL"].ToString() + " -> " + explvl.ToString() +
                                "\nSalary: " + reader["SALARY"].ToString() + " -> " + salary.ToString()
                                    , "Confirm Update Security Personnel", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        }
                    }

                    // Update after checks
                    if (result == DialogResult.Yes)
                    {
                        using (conn = new SqlConnection(conStr))
                        {
                            string sql = "UPDATE SecurityPersonnel SET First_Name = @firstName, Last_Name = @lastName, ID_Number = @idNum, " +
                                "Phone_Number = @phoneNum, Email_Address = @email, Experience_Level = @xp, Salary = @salary " +
                                "WHERE Personnel_ID = @id";
                            conn.Open();
                            cmd = new SqlCommand(sql, conn);
                            cmd.Parameters.AddWithValue("@id", id);
                            cmd.Parameters.AddWithValue("@firstName", firstName);
                            cmd.Parameters.AddWithValue("@lastName", lastName);
                            cmd.Parameters.AddWithValue("@idNum", idNum);
                            cmd.Parameters.AddWithValue("@phoneNum", phoneNumber);
                            cmd.Parameters.AddWithValue("@email", email);
                            cmd.Parameters.AddWithValue("@xp", explvl);
                            cmd.Parameters.AddWithValue("@salary", salary);

                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected == 1)
                            {
                                MessageBox.Show($"Successfully updated Personnel with ID: {id}", "Update Security Personnel", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Select updated record
                                if (dtgResults.Rows.Count > 0)
                                {
                                    dtgResults.ClearSelection();
                                    int i = 0;
                                    bool found = false;
                                    while (!found && i < dtgResults.RowCount)
                                    {
                                        if ((int)dtgResults.Rows[i].Cells["PERSONNEL_ID"].Value == id)
                                        {
                                            dtgResults.Rows[i].Selected = true;
                                            found = true;
                                        }
                                        i++;
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show($"Unsuccessfully updated Personnel with ID: {id}", "Update Security Personnel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                        // Housekeeping                      
                        setDisplayLabelsToBlack();
                        clearDisplayInputs();
                        btnUpdate.Enabled = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Invalid value entered", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Delete
        private void DeleteSecurityPersonnelWithID(int id, string name, string lastName)
        {
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                string sql = "DELETE FROM SecurityPersonnel WHERE Personnel_ID = @id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                try
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@id", id.ToString());
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show(name + " " + lastName + " deleted successfully!", "Successfully Deleted Security Personnel");
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete " + name + " " + lastName + ".", "Failed to Delete Security Personnel");
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
            if (dtgResults.SelectedRows.Count == 1)
            {
                DataGridViewRow row = dtgResults.SelectedRows[0];
                // Row not null && did not select the empty row
                if (row != null && row.Cells[indexForColumnHeader("PERSONNEL_ID")].Value != null)
                {
                    
                    string message = "Are you sure you want to delete Security Personnel with";
                    int id = (int)row.Cells[indexForColumnHeader("PERSONNEL_ID")].Value;
                    string name = (string)row.Cells[indexForColumnHeader("FIRST_NAME")].Value;
                    string lastName = (string)row.Cells[indexForColumnHeader("LAST_NAME")].Value;
                    // Build message
                    message += "\nID: " + id.ToString();
                    message += "\nFirst Name: " + name;
                    message += "\nLast Name: " + lastName;

                    DialogResult result = MessageBox.Show(message, "Confirm Delete Security Personnel", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        // ADD NEW PERSONNEL
                        DeleteSecurityPersonnelWithID(id, name, lastName);

                        clearDisplayInputs();
                    }
                }
                else
                {
                    MessageBox.Show("Please select a row in the datagrid to delete", "Delete Security Personnel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    SelectOnlyFirstRecordOf(dtgResults);
                }
            }
            else
            {
                MessageBox.Show("Please select only ONE row in the datagrid to delete");
                SelectOnlyFirstRecordOf(dtgResults);
            }
        }

        // Find Columns in datagrid
        private int indexForColumnHeader(string header)
        {
            foreach (DataGridViewColumn column in dtgResults.Columns)
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

        // Populate Display txts for update
        private void dtgResults_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgResults.SelectedRows.Count == 1)
            {
                DataGridViewRow row = dtgResults.SelectedRows[0];
                if (row != null &&  row.Cells["PERSONNEL_ID"].Value != null)
                {
                    txtDisplayPersonnelID.Text = row.Cells[0].Value?.ToString();
                    txtDisplayFirstName.Text = row.Cells[1].Value?.ToString();
                    txtDisplayLastName.Text = row.Cells[2].Value?.ToString();
                    txtDisplayIDNumber.Text = row.Cells[3].Value?.ToString();
                    txtDisplayPhoneNumber.Text = row.Cells[4].Value?.ToString();
                    txtDisplayEmail.Text = row.Cells[5].Value?.ToString();

                    var expLvl = row.Cells[6].Value;
                    if (expLvl != DBNull.Value && expLvl != null)
                        nudDisplayExpLvl.Value = Convert.ToInt32(expLvl);
                    else
                        nudDisplayExpLvl.Value = 1;

                    var salary = row.Cells[7].Value;
                    if (salary != DBNull.Value && salary != null)
                        nudDisplaySalary.Value = Convert.ToDecimal(salary);
                    else
                        nudDisplaySalary.Value = 0;
                }
                else
                {
                    clearDisplayInputs();                   
                }
            }
            else
            {
                clearDisplayInputs();
            }
            // Housekeeping
            setDisplayLabelsToBlack();
            btnUpdate.Enabled = false;
        }

        //Reset display inputs
        private void clearDisplayInputs()
        {
            txtDisplayPersonnelID.Clear();
            txtDisplayFirstName.Clear();
            txtDisplayLastName.Clear();
            txtDisplayIDNumber.Clear();
            txtDisplayPhoneNumber.Clear();
            txtDisplayEmail.Clear();
            nudDisplayExpLvl.Value = 1;
            nudDisplaySalary.Value = 0;
        }

        private void setDisplayLabelsToBlack()
        {
            lblDisplayFirstName.ForeColor = Color.Black;
            lblDisplayLastName.ForeColor = Color.Black;
            lblDisplayIDNumber.ForeColor = Color.Black;
            lblDisplayPhoneNumber.ForeColor = Color.Black;
            lblDisplayEmailAddress.ForeColor = Color.Black;
            lblDisplayExpLvl.ForeColor = Color.Black;
            lblDisplaySalary.ForeColor = Color.Black;
        }

        // Filter selectively
        private void filterText_TextChange(object sender)
        {
            TextBox txt = (TextBox)sender;
            string columnName = txt.Name.Substring("txt".Length);

            string sql = $"Select * FROM SecurityPersonnel WHERE {columnName} LIKE @filterTxt";
            var tuples = new List<Tuple<string, string>>
            {
                new Tuple<string, string> ("@filterTxt", "%" + txt.Text + "%")
            };
            showDataWithQuery(sql, tuples);
        }
        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            filterText_TextChange(sender);
        }
        private void nudMinExpLvl_ValueChanged(object sender, EventArgs e)
        {
            var parameters = new List<Tuple<string, string>>
            {
                new Tuple<string, string> ("@minValue", nudMinExpLvl.Value.ToString()),
                new Tuple<string, string> ("@maxValue", nudMaxExpLvl.Value.ToString())
            };
            showDataWithQuery("Select * FROM SecurityPersonnel WHERE Experience_Level BETWEEN @minValue AND @maxValue", parameters);
        }
        private void nudMaxSalary_ValueChanged(object sender, EventArgs e)
        {
            var parameters = new List<Tuple<string, decimal>>
            {
                new Tuple<string, decimal> ("@minValue", nudMinSalary.Value),
                new Tuple<string, decimal> ("@maxValue", nudMaxSalary.Value)
            };
            showDataWithQuery("SELECT * FROM SecurityPersonnel WHERE Salary BETWEEN @minValue AND @maxValue", parameters);
        }

        // Searches all fields currently displayed in dtgResults
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {           
            if (dtgResults.ColumnHeadersVisible && txtSearch.ForeColor == Color.Black)
            {
                // Build sql query: @txt1 OR @txt2 OR...
                // Add first header
                string columnHeaders = $"{dtgResults.Columns[0].HeaderText} LIKE @searchText0";
                var tuples = new List<Tuple<string, string>>
                {
                    new Tuple<string, string>("@searchText0", txtSearch.Text + "%")
                };
                // Add the rest of the headers
                for (int i = 1; i < dtgResults.Columns.Count; i++)
                {
                    string paramName = $"@searchText{i}";
                    columnHeaders += $" OR {dtgResults.Columns[i].HeaderText} LIKE {paramName}";
                    tuples.Add(new Tuple<string, string>(paramName, txtSearch.Text + "%"));
                }

                // Update table and finish sql query
                string sql = $"SELECT * FROM SecurityPersonnel WHERE {columnHeaders}";
                showDataWithQuery(sql, tuples);
            }
        }

        // Update label Colour if txt Value Changed
        private void SetLabelRed(Label label)
        {
            label.ForeColor = Color.Red;
            btnUpdate.Enabled = true;

        }
        private void txtDisplayFirstName_TextChanged(object sender, EventArgs e)
        {
            SetLabelRed(lblDisplayFirstName);
        }
        private void txtDisplayLastName_TextChanged(object sender, EventArgs e)
        {
            SetLabelRed(lblDisplayLastName);
        }
        private void txtDisplayIDNumber_TextChanged(object sender, EventArgs e)
        {
            SetLabelRed(lblDisplayIDNumber);
        }
        private void txtDisplayPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            SetLabelRed(lblDisplayPhoneNumber);
        }
        private void txtDisplayEmail_TextChanged(object sender, EventArgs e)
        {
            SetLabelRed(lblDisplayEmailAddress);
        }
        private void nudDisplayExpLvl_ValueChanged(object sender, EventArgs e)
        {
            SetLabelRed(lblDisplayExpLvl);
        }
        private void nudDisplaySalary_ValueChanged(object sender, EventArgs e)
        {
            SetLabelRed(lblDisplaySalary);
        }

        // Assign Personnel to a shift
        private void btnAssignShifts_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDisplayPersonnelID.Text))
            {
                frmAssignPersonnelToShift frmAssignToShift = new frmAssignPersonnelToShift();
                frmAssignToShift.ShowDialog();
            }
            else
            {
                frmAssignPersonnelToShift frmAssignToShift = new frmAssignPersonnelToShift(txtDisplayPersonnelID.Text);
                frmAssignToShift.ShowDialog();
            }
        }

        // Assign Personnel equipment
        private void btnAssignEquipment_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDisplayPersonnelID.Text))
            {
                frmAssignPersonnelToEquipment frmAssignEquipment = new frmAssignPersonnelToEquipment();
                frmAssignEquipment.ShowDialog();
            }
            else
            {
                frmAssignPersonnelToEquipment frmAssignEquipment = new frmAssignPersonnelToEquipment(txtDisplayPersonnelID.Text);
                frmAssignEquipment.ShowDialog();
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

        // Navigation
        private void btnSecurityPersonnel_Click_1(object sender, EventArgs e)
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

        private void clearFilters()
        {
            txtFirst_Name.Clear();
            txtLast_Name.Clear();
            txtID_Number.Clear();
            txtPhone_Number.Clear();
            txtEmail_Address.Clear();
            decimal max = GetMaxSalary();
            nudMinExpLvl.Value = nudMinExpLvl.Minimum;
            nudMaxExpLvl.Value = nudMaxExpLvl.Maximum;
            nudMaxSalary.Maximum = max;
            nudMaxSalary.Value = max;
            nudMinSalary.Value = nudMinSalary.Minimum;

            txtSearch.ForeColor = Color.DarkGray;
            txtSearch.Text = "Search for data in the displayed table";           
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            clearDisplayInputs();
            setDisplayLabelsToBlack();
            btnUpdate.Enabled = false;
            clearFilters();
            dtgResults.ClearSelection();
            
            showDataWithQuery("SELECT * FROM SecurityPersonnel");           
        }

        private void picHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Email support at: tiredofbugs@gmail.com","Help",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
