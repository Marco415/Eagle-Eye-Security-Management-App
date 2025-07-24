using MainForm;
using SecurityPersonnelForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TemplateForm;

namespace Equipment
{ 
    public partial class frmEquipment : Form
    {
        public bool EquipType = false;

        public frmEquipment()
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

        private void frmTemplate_Load(object sender, EventArgs e)
        {
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
            txtSearch.Text = "Search for data in the displayed table";
            txtSearch.ForeColor = Color.DarkGray;
            #endregion            
        }

        private void frmEquipment_Shown(object sender, EventArgs e)
        {
            btnUpdateEquip.Enabled = false;

            ConnectDB(); // Connect to the database

            // Show all the data in the database
            string sql = "SELECT e.EQUIPMENT_ID, e.EQUIPMENT_NAME, et.TYPES_NAME AS Type_Name, sp.PERSONNEL_ID, sp.FIRST_NAME AS Personnel_Name, sp.LAST_NAME AS Personnel_LastName " +
             "FROM EQUIPMENT e " +
             "LEFT JOIN EQUIPMENT_TYPE et ON e.TYPES_ID = et.TYPES_ID " +
             "LEFT JOIN SECURITYPERSONNEL sp ON e.PERSONNEL_ID = sp.PERSONNEL_ID";


            showDataWithQuery(sql, new List<Tuple<string, string>>()); // Execute query with no parameters
            PopulateComboBoxes();

            dtgResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; // Auto size columns

            btnShowEquip.Enabled = false;
            btnEquipment.Enabled = false;
            label1.Text = "Equipment";

            txtTypeIDD.Enabled = false;
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

        private void showDataWithQuery(string sql, List<Tuple<string, string>> parameters)
        {
            using (conn = new SqlConnection(conStr))
            {
                try
                {
                    conn.Open();
                    adap = new SqlDataAdapter();
                    ds = new DataSet();

                    cmd = new SqlCommand(sql, conn);
                    adap.SelectCommand = cmd;

                    // Clear existing parameters and add new ones
                    cmd.Parameters.Clear();
                    foreach (var tuple in parameters)
                    {
                        cmd.Parameters.AddWithValue(tuple.Item1, tuple.Item2);
                    }

                    adap.Fill(ds, "SourceTable");

                    // Check if data is returned
                    if (ds.Tables["SourceTable"].Rows.Count == 0)
                    {
                        MessageBox.Show("Please click anywhere and then hit refresh.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    // Extract the DataTable and set it as the DataSource
                    DataTable dt = ds.Tables["SourceTable"];
                    dtgResults.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error executing query: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (dtgResults.ColumnHeadersVisible && txtSearch.ForeColor == Color.Black)
            {
                string searchText = txtSearch.Text.Trim() + "%";

                // Handle empty search text
                if (string.IsNullOrEmpty(txtSearch.Text.Trim()))
                {
                    // Refresh based on the current view when search text is empty
                    RefreshDataGrid();
                    return;
                }

                string sql;
                var parameters = new List<Tuple<string, string>> { new Tuple<string, string>("@searchText", searchText) };

                if (EquipType)
                {
                    // SQL query for Equipment Types search
                    sql = "SELECT TYPES_ID AS Type_Id, TYPES_NAME AS Type_Name, E_DESCRIPTION AS Description " +
                          "FROM EQUIPMENT_TYPE " +
                          "WHERE TYPES_NAME LIKE @searchText OR E_DESCRIPTION LIKE @searchText";
                }
                else
                {
                    // SQL query for Equipment search
                    sql = "SELECT e.EQUIPMENT_ID, e.EQUIPMENT_NAME, et.TYPES_NAME AS Type_Name, sp.PERSONNEL_ID, sp.FIRST_NAME AS Personnel_Name, sp.LAST_NAME AS Personnel_LastName " +
                          "FROM EQUIPMENT e " +
                          "LEFT JOIN EQUIPMENT_TYPE et ON e.TYPES_ID = et.TYPES_ID " +
                          "LEFT JOIN SECURITYPERSONNEL sp ON e.PERSONNEL_ID = sp.PERSONNEL_ID " +
                          "WHERE e.EQUIPMENT_NAME LIKE @searchText OR " +
                                "et.TYPES_NAME LIKE @searchText OR " +
                                "sp.FIRST_NAME LIKE @searchText OR " +
                                "sp.LAST_NAME LIKE @searchText";
                }

                // Execute the query with the search parameter
                showDataWithQuery(sql, parameters);
            }
        }

        private void ConnectDB()
        {
            string serverName = Environment.GetEnvironmentVariable("EYE_SECURITY_DB") ?? @"localhost\SQLEXPRESS";
            conStr = "Server=" + serverName + ";Database=EYSECURITY;Integrated Security=True;";

        }
        public void PopulateComboBoxes()
        {
            // Populate equipment types
            string sqlTypes = "SELECT TYPES_ID, TYPES_NAME FROM EQUIPMENT_TYPE";
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                conn.Open(); // Ensure connection is opened before executing commands
                using (SqlCommand cmd = new SqlCommand(sqlTypes, conn))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    cmbEquipTD.Items.Clear(); // Clear existing items
                    while (reader.Read())
                    {
                        // Use a ComboBoxItem class to store the value and text
                        var item = new ComboBoxItem
                        {
                            Value = reader["TYPES_ID"],
                            Text = reader["TYPES_NAME"].ToString()
                        };
                        cmbEquipTD.Items.Add(item);
                    }
                }
            }

            // Populate personnel first names
            string sqlFirstNames = "SELECT DISTINCT FIRST_NAME FROM SECURITYPERSONNEL";
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sqlFirstNames, conn))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    cmbFirstNameD.Items.Clear(); // Clear existing items
                    while (reader.Read())
                    {
                        cmbFirstNameD.Items.Add(reader["FIRST_NAME"].ToString());
                    }
                }
            }

            // Populate personnel last names
            string sqlLastNames = "SELECT DISTINCT LAST_NAME FROM SECURITYPERSONNEL";
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sqlLastNames, conn))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    cmbLastNameD.Items.Clear(); // Clear existing items
                    while (reader.Read())
                    {
                        cmbLastNameD.Items.Add(reader["LAST_NAME"].ToString());
                    }
                }
            }
        }

        // Define a class for ComboBox items with value and text
        public class ComboBoxItem
        {
            public object Value { get; set; }
            public string Text { get; set; }

            public override string ToString()
            {
                return Text; // Ensures that the displayed text in the ComboBox is the "Text" property
            }
        }

        private void btnShowEquip_Click(object sender, EventArgs e)
        {
            
        }
        private void ApplyFilter()
        {
            if (isPopulating) return; // Prevent re-entry during population

            isPopulating = true;

            if (!EquipType)
            {
                // Apply filter for the equipment tab
                ApplyEquipmentFilter();
            }
            else
            {
                // Apply filter for the types tab
                ApplyTypesFilter();
            }

            isPopulating = false;
        }
        private void ApplyEquipmentFilter()
        {
            string filterExpression = "";

            // Check if the correct tab is selected
            if (tabCntrlEquip.SelectedTab == tabFilterEquip)
            {
                if (!string.IsNullOrEmpty(txtEquipNameFilter.Text))
                {
                    filterExpression += $"EQUIPMENT_NAME LIKE '%{txtEquipNameFilter.Text}%'";
                }

                if (!string.IsNullOrEmpty(txtTypeNameFilter.Text))
                {
                    if (!string.IsNullOrEmpty(filterExpression))
                        filterExpression += " AND ";
                    filterExpression += $"TYPE_NAME LIKE '%{txtTypeNameFilter.Text}%'";
                }

                if (!string.IsNullOrEmpty(txtFirstNameFilter.Text))
                {
                    if (!string.IsNullOrEmpty(filterExpression))
                        filterExpression += " AND ";
                    filterExpression += $"PERSONNEL_NAME LIKE '%{txtFirstNameFilter.Text}%'";
                }

                if (!string.IsNullOrEmpty(txtLastNameFilter.Text))
                {
                    if (!string.IsNullOrEmpty(filterExpression))
                        filterExpression += " AND ";
                    filterExpression += $"PERSONNEL_LASTNAME LIKE '%{txtLastNameFilter.Text}%'";
                }

                // Apply the filter to the DataTable for equipment
                (dtgResults.DataSource as DataTable).DefaultView.RowFilter = filterExpression;
            }
        }
        private void ApplyTypesFilter()
        {
            string filterExpression = "";

            // Check if the correct tab is selected
            if (tabCntrlTypes.SelectedTab == tabFilterTypes)
            {

                if (!string.IsNullOrEmpty(txtTypeNameF.Text))
                {
                    if (!string.IsNullOrEmpty(filterExpression))
                        filterExpression += " AND ";
                    filterExpression += $"TYPE_NAME LIKE '%{txtTypeNameF.Text}%'";
                }

                if (!string.IsNullOrEmpty(txtDescriptionF.Text))
                {
                    if (!string.IsNullOrEmpty(filterExpression))
                        filterExpression += " AND ";
                    filterExpression += $"DESCRIPTION LIKE '%{txtDescriptionF.Text}%'";
                }

                // Apply the filter to the DataTable for types
                (dtgResults.DataSource as DataTable).DefaultView.RowFilter = filterExpression;
            }
        }
        private void txtEquipID_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }
        private void txtEquipName_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }
        private void txtTypeName_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }
        private void txtPersonnelID_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }
        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }
        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter();
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
        private void btnInsertEquip_Click(object sender, EventArgs e)
        {
            if (EquipType == true)
            {
                // Show InsertTypes form
                using (InsertType insertTypeForm = new InsertType())
                {
                    insertTypeForm.StartPosition = FormStartPosition.CenterScreen;

                    // Subscribe to the TypeInserted event

                    if (insertTypeForm.ShowDialog() == DialogResult.OK)
                    {
                        // Optionally handle other tasks if needed
                        btnShowTypes_Click(sender, e);
                    }
                }
            }
            else
            {
                // Show frmInsertEquipment form
                using (frmInsertEquipment insertForm = new frmInsertEquipment())
                {
                    insertForm.StartPosition = FormStartPosition.CenterScreen;

                    // Populate combo boxes in the insert form
                    insertForm.PopulateEquipTypes(); // Call the correct method
                    insertForm.PopulateNames();       // Call the correct method

                    if (insertForm.ShowDialog() == DialogResult.OK)
                    {
                        btnShowEquip_Click_1(sender, e);
                    }
                }
            }
        }

        private void btnDeleteEquip_Click(object sender, EventArgs e)
        {
            if (EquipType == true)
            {
                // Handle deletion for equipment types
                if (dtgResults.SelectedRows.Count > 0)
                {
                    // Get the ID of the selected type (assuming TYPES_ID is the first column)
                    int selectedTypeID = Convert.ToInt32(dtgResults.SelectedRows[0].Cells["Type_Id"].Value);

                    // Confirm deletion with the user
                    DialogResult result = MessageBox.Show($"Are you sure you want to delete Equipment Type with ID {selectedTypeID}?",
                                                          "Confirm Deletion",
                                                          MessageBoxButtons.YesNo,
                                                          MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            // Attempt to delete the selected type from the database
                            string sql = "DELETE FROM EQUIPMENT_TYPE WHERE TYPES_ID = @TypeID";
                            using (conn = new SqlConnection(conStr))
                            {
                                using (SqlCommand cmd = new SqlCommand(sql, conn))
                                {
                                    cmd.Parameters.AddWithValue("@TypeID", selectedTypeID);
                                    conn.Open();
                                    cmd.ExecuteNonQuery();
                                }
                            }

                            // Refresh the DataGridView for types
                            btnShowTypes_Click(sender, e);

                            lblDescriptionD.ForeColor = Color.Black;
                            lblTypeIDD.ForeColor = Color.Black;
                            lblTypeNamesD.ForeColor = Color.Black;

                            // Temporarily disable TextChanged events to prevent triggering
                            txtTypeIDD.TextChanged -= txtTypeIDD_TextChanged;
                            txtTypeNamesD.TextChanged -= txtTypeNamesD_TextChanged;
                            txtDescriptionD.TextChanged -= txtDescriptionD_TextChanged;

                            // Clear textboxes after update
                            txtTypeIDD.Clear();
                            txtTypeNamesD.Clear();
                            txtDescriptionD.Clear();

                            // Reattach events
                            txtTypeIDD.TextChanged += txtTypeIDD_TextChanged;
                            txtTypeNamesD.TextChanged += txtTypeNamesD_TextChanged;
                            txtDescriptionD.TextChanged += txtDescriptionD_TextChanged;
                        }
                        catch (SqlException ex)
                        {
                            // Check if the error is due to foreign key constraint violation
                            MessageBox.Show("This Equipment Type cannot be deleted because it is currently used by existing equipment.",
                                            "Deletion Error",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select a row to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                // Handle deletion for equipment
                if (dtgResults.SelectedRows.Count > 0)
                {
                    // Get the ID of the selected equipment (assuming EQUIPMENT_ID is the first column)
                    int selectedEquipmentID = Convert.ToInt32(dtgResults.SelectedRows[0].Cells["EQUIPMENT_ID"].Value);

                    // Confirm deletion with the user
                    DialogResult result = MessageBox.Show($"Are you sure you want to delete Equipment with ID {selectedEquipmentID}?",
                                                          "Confirm Deletion",
                                                          MessageBoxButtons.YesNo,
                                                          MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            // Attempt to delete the selected equipment from the database
                            string sql = "DELETE FROM EQUIPMENT WHERE EQUIPMENT_ID = @EquipmentID";
                            using (conn = new SqlConnection(conStr))
                            {
                                using (SqlCommand cmd = new SqlCommand(sql, conn))
                                {
                                    cmd.Parameters.AddWithValue("@EquipmentID", selectedEquipmentID);
                                    conn.Open();
                                    cmd.ExecuteNonQuery();
                                }
                            }

                            // Clear and refresh the DataGridView for equipment
                            dtgResults.DataSource = null; // Clear the existing data source
                            btnShowEquip_Click_1(sender, e); // Refresh the data in the DataGridView

                            // Reset all label colors to black
                            lblEquipName.ForeColor = Color.Black;
                            lblTypeName.ForeColor = Color.Black;
                            lblFirstName.ForeColor = Color.Black;
                            lblLastName.ForeColor = Color.Black;

                            // Temporarily detach event handlers to prevent unintended triggering
                            txtEquipNameD.TextChanged -= txtEquipNameD_TextChanged;
                            cmbEquipTD.SelectedIndexChanged -= cmbEquipTD_SelectedIndexChanged;
                            cmbFirstNameD.SelectedIndexChanged -= cmbFirstNameD_SelectedIndexChanged;
                            cmbLastNameD.SelectedIndexChanged -= cmbLastNameD_SelectedIndexChanged;

                            // Reset the state of textboxes and combo boxes
                            txtEquipNameD.Clear();
                            cmbEquipTD.ResetText();
                            cmbEquipTD.SelectedIndex = -1;

                            cmbFirstNameD.ResetText();
                            cmbFirstNameD.SelectedIndex = -1;

                            cmbLastNameD.ResetText();
                            cmbLastNameD.SelectedIndex = -1;

                            // Reattach the event handlers
                            txtEquipNameD.TextChanged += txtEquipNameD_TextChanged;
                            cmbEquipTD.SelectedIndexChanged += cmbEquipTD_SelectedIndexChanged;
                            cmbFirstNameD.SelectedIndexChanged += cmbFirstNameD_SelectedIndexChanged;
                            cmbLastNameD.SelectedIndexChanged += cmbLastNameD_SelectedIndexChanged;
                        }
                        catch (SqlException ex)
                        {
                            // Handle other deletion errors if necessary
                            MessageBox.Show("An error occurred while deleting the equipment.", "Deletion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select a row to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private int GetTypeID(string typeName)
        {
            int typeId = 0;
            string sql = "SELECT TYPES_ID FROM EQUIPMENT_TYPE WHERE TYPES_NAME = @TypeName";

            using (SqlConnection conn = new SqlConnection(conStr))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@TypeName", typeName);
                    conn.Open();

                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        typeId = Convert.ToInt32(result);
                    }
                }
            }

            return typeId;
        }
        private int GetPersonnelID(string firstName, string lastName)
        {
            int personId = 0;
            string sql = "SELECT PERSONNEL_ID FROM SECURITYPERSONNEL WHERE FIRST_NAME = @FirstName AND LAST_NAME = @LastName";

            using (SqlConnection conn = new SqlConnection(conStr))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@FirstName", firstName);
                    cmd.Parameters.AddWithValue("@LastName", lastName);
                    conn.Open();

                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        personId = Convert.ToInt32(result);
                    }
                }
            }

            return personId;
        }
        private bool isPopulating = false;
        private void txtEquipNameD_TextChanged(object sender, EventArgs e)
        {
            if (!isPopulating)
            {
                lblEquipName.ForeColor = Color.Red;
                btnUpdateEquip.Enabled = true;
            }
        }
        private void txtEquipIDD_TextChanged(object sender, EventArgs e)
        {
            if (!isPopulating)
            {
                
                btnUpdateEquip.Enabled = true;
            }
        }
        private void txtTypeNameD_TextChanged(object sender, EventArgs e)
        {
            if (!isPopulating)
            {
                lblTypeName.ForeColor = Color.Red;
                btnUpdateEquip.Enabled = true;
            }
        }
        private void txtPersonnelIDD_TextChanged(object sender, EventArgs e)
        {
            if (!isPopulating)
            {
               
                btnUpdateEquip.Enabled = true;
            }
        }

        private void txtFirstNameD_TextChanged(object sender, EventArgs e)
        {
            if (!isPopulating)
            {
                lblFirstName.ForeColor = Color.Red;
                btnUpdateEquip.Enabled = true;
            }
        }

        private void txtLastNameD_TextChanged(object sender, EventArgs e)
        {
            if (!isPopulating)
            {
                lblLastName.ForeColor = Color.Red;
                btnUpdateEquip.Enabled = true;
            }
        }
        private void btnUpdateEquip_Click(object sender, EventArgs e)
        {
            if (EquipType == true)
            {
                // Update logic for equipment types
                if (dtgResults.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dtgResults.SelectedRows[0];

                    string originalTypeName = selectedRow.Cells["Type_Name"].Value.ToString();
                    string newTypeName = txtTypeNamesD.Text;

                    string originalDescription = selectedRow.Cells["Description"].Value.ToString();
                    string newDescription = txtDescriptionD.Text;

                    string changes = "";
                    if (originalTypeName != newTypeName)
                        changes += $"Type Name: {originalTypeName} -> {newTypeName}\n";
                    if (originalDescription != newDescription)
                        changes += $"Description: {originalDescription} -> {newDescription}\n";

                    if (MessageBox.Show($"Are you sure you want to update this type?\n\nChanges:\n{changes}", "Confirm Update", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        string sql = "UPDATE EQUIPMENT_TYPE SET TYPES_NAME = @NewTypeName, E_DESCRIPTION = @NewDescription WHERE TYPES_ID = @TypeID";

                        using (SqlConnection conn = new SqlConnection(conStr))
                        {
                            using (SqlCommand cmd = new SqlCommand(sql, conn))
                            {
                                cmd.Parameters.AddWithValue("@NewTypeName", newTypeName);
                                cmd.Parameters.AddWithValue("@NewDescription", newDescription);
                                cmd.Parameters.AddWithValue("@TypeID", Convert.ToInt32(selectedRow.Cells["Type_Id"].Value));

                                conn.Open();
                                cmd.ExecuteNonQuery();
                            }
                        }

                        btnShowTypes_Click(sender, e);

                        // Reset all label colors to black
                        lblDescriptionD.ForeColor = Color.Black;
                        lblTypeIDD.ForeColor = Color.Black;
                        lblTypeNamesD.ForeColor = Color.Black;

                        // Temporarily disable TextChanged events to prevent triggering
                        txtTypeIDD.TextChanged -= txtTypeIDD_TextChanged;
                        txtTypeNamesD.TextChanged -= txtTypeNamesD_TextChanged;
                        txtDescriptionD.TextChanged -= txtDescriptionD_TextChanged;

                        // Clear textboxes after update
                        txtTypeIDD.Clear();
                        txtTypeNamesD.Clear();
                        txtDescriptionD.Clear();

                        // Reattach events
                        txtTypeIDD.TextChanged += txtTypeIDD_TextChanged;
                        txtTypeNamesD.TextChanged += txtTypeNamesD_TextChanged;
                        txtDescriptionD.TextChanged += txtDescriptionD_TextChanged;
                    }
                }
                else
                {
                    MessageBox.Show("Please select a row to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                // Update logic for equipment
                if (dtgResults.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dtgResults.SelectedRows[0];

                    string originalEquipName = selectedRow.Cells["EQUIPMENT_NAME"].Value.ToString();
                    string newEquipName = txtEquipNameD.Text;

                    string originalTypeName = selectedRow.Cells["Type_Name"].Value.ToString();
                    string newTypeName = cmbEquipTD.Text; // Use combo box value

                    string originalPersonnelID = selectedRow.Cells["PERSONNEL_ID"].Value.ToString();
                    int newPersonnelID = GetPersonnelID(cmbFirstNameD.Text, cmbLastNameD.Text); // Use combo box values

                    string originalFirstName = selectedRow.Cells["Personnel_Name"].Value.ToString();
                    string newFirstName = cmbFirstNameD.Text; // Use combo box value

                    string originalLastName = selectedRow.Cells["Personnel_LastName"].Value.ToString();
                    string newLastName = cmbLastNameD.Text; // Use combo box value

                    string changes = "";
                    if (originalEquipName != newEquipName)
                        changes += $"Equipment Name: {originalEquipName} -> {newEquipName}\n";
                    if (originalTypeName != newTypeName)
                        changes += $"Type Name: {originalTypeName} -> {newTypeName}\n";
                    if (int.TryParse(originalPersonnelID, out int originalID) && originalID != newPersonnelID)
                        changes += $"Personnel ID: {originalID} -> {newPersonnelID}\n";
                    if (originalFirstName != newFirstName)
                        changes += $"First Name: {originalFirstName} -> {newFirstName}\n";
                    if (originalLastName != newLastName)
                        changes += $"Last Name: {originalLastName} -> {newLastName}\n";

                    if (MessageBox.Show($"Are you sure you want to update this record?\n\nChanges:\n{changes}", "Confirm Update", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        string sql = "UPDATE EQUIPMENT SET EQUIPMENT_NAME = @NewEquipName, TYPES_ID = @NewTypeID, PERSONNEL_ID = @NewPersonnelID WHERE EQUIPMENT_ID = @EquipID";

                        using (SqlConnection conn = new SqlConnection(conStr))
                        {
                            using (SqlCommand cmd = new SqlCommand(sql, conn))
                            {
                                cmd.Parameters.AddWithValue("@NewEquipName", newEquipName);
                                cmd.Parameters.AddWithValue("@NewTypeID", GetTypeID(newTypeName));
                                cmd.Parameters.AddWithValue("@NewPersonnelID", newPersonnelID);
                                cmd.Parameters.AddWithValue("@EquipID", Convert.ToInt32(selectedRow.Cells["EQUIPMENT_ID"].Value));

                                conn.Open();
                                cmd.ExecuteNonQuery();
                            }
                        }

                        // Refresh the DataGridView to show updated data
                        btnShowEquip_Click_1(sender, e);

                        // Reset all label colors to black
                        lblEquipName.ForeColor = Color.Black;
                        lblTypeName.ForeColor = Color.Black;
                        lblFirstName.ForeColor = Color.Black;
                        lblLastName.ForeColor = Color.Black;

                        // Temporarily detach event handlers to prevent unintended triggering
                        txtEquipNameD.TextChanged -= txtEquipNameD_TextChanged;
                        cmbEquipTD.SelectedIndexChanged -= cmbEquipTD_SelectedIndexChanged;
                        cmbFirstNameD.SelectedIndexChanged -= cmbFirstNameD_SelectedIndexChanged;
                        cmbLastNameD.SelectedIndexChanged -= cmbLastNameD_SelectedIndexChanged;

                        // Reset the state of textboxes and combo boxes
                        txtEquipNameD.Clear();
                        cmbEquipTD.ResetText(); // Clears the text shown in the ComboBox
                        cmbEquipTD.SelectedIndex = -1; // Ensures no item is selected

                        cmbFirstNameD.ResetText();
                        cmbFirstNameD.SelectedIndex = -1;

                        cmbLastNameD.ResetText();
                        cmbLastNameD.SelectedIndex = -1;

                        // Optionally refresh the controls to update the UI immediately
                        cmbEquipTD.Refresh();
                        cmbFirstNameD.Refresh();
                        cmbLastNameD.Refresh();

                        // Reattach the event handlers
                        txtEquipNameD.TextChanged += txtEquipNameD_TextChanged;
                        cmbEquipTD.SelectedIndexChanged += cmbEquipTD_SelectedIndexChanged;
                        cmbFirstNameD.SelectedIndexChanged += cmbFirstNameD_SelectedIndexChanged;
                        cmbLastNameD.SelectedIndexChanged += cmbLastNameD_SelectedIndexChanged;
                    }
                }
                else
                {
                    MessageBox.Show("Please select a row to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void dtgResults_SelectionChanged(object sender, EventArgs e)
        {
            if (isPopulating) return; // Prevent re-entry during population

            isPopulating = true;

            // Check if there is a selected row
            if (dtgResults.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dtgResults.SelectedRows[0];

                if (EquipType == true)
                {
                    lblDescriptionD.ForeColor = Color.Black;
                    lblTypeIDD.ForeColor = Color.Black;
                    lblTypeNamesD.ForeColor = Color.Black;

                    // Populate the Display tab in tabCntrlTypes
                    txtTypeIDD.Text = selectedRow.Cells["Type_Id"].Value.ToString();
                    txtTypeNamesD.Text = selectedRow.Cells["Type_Name"].Value.ToString();
                    txtDescriptionD.Text = selectedRow.Cells["Description"].Value.ToString();

                    tabCntrlTypes.SelectedTab = tabDisplayTypes;
                }
                else
                {
                    lblEquipName.ForeColor = Color.Black;
                    lblTypeName.ForeColor = Color.Black;
                    lblFirstName.ForeColor = Color.Black;
                    lblLastName.ForeColor = Color.Black;

                    // Populate the Display tab in tabCntrlEquip
                    txtEquipNameD.Text = selectedRow.Cells["EQUIPMENT_NAME"].Value.ToString();

                    string typeName = selectedRow.Cells["Type_Name"].Value.ToString();
                    string personnelName = selectedRow.Cells["Personnel_Name"].Value.ToString();
                    string lastName = selectedRow.Cells["Personnel_LastName"].Value.ToString();

                    // Find and set the selected index in the cmbEquipTD ComboBox based on Type Name
                    cmbEquipTD.SelectedIndex = cmbEquipTD.Items.Cast<dynamic>()
                        .ToList().FindIndex(item => item.Text == typeName);

                    // Set the selected item in the cmbFirstNameD ComboBox based on Personnel Name
                    cmbFirstNameD.SelectedIndex = cmbFirstNameD.Items.Cast<string>()
                        .ToList().FindIndex(item => item == personnelName);

                    // Set the selected item in the cmbLastNameD ComboBox based on Personnel Last Name
                    cmbLastNameD.SelectedIndex = cmbLastNameD.Items.Cast<string>()
                        .ToList().FindIndex(item => item == lastName);

                    tabCntrlEquip.SelectedTab = tabDisplayEquip;
                }
            }

            isPopulating = false;
        }






        private void btnShowEquip_Click_1(object sender, EventArgs e)
        {
            EquipType = false;

            tabCntrlEquip.BringToFront();

            btnInsertEquip.Text = "Insert Equipment";
            btnUpdateEquip.Text = "Update Equipment";
            btnDeleteEquip.Text = "Delete Equipment";

            // Corrected SQL query
            string sql = "SELECT e.EQUIPMENT_ID, e.EQUIPMENT_NAME, et.TYPES_NAME AS Type_Name, sp.PERSONNEL_ID, sp.FIRST_NAME AS Personnel_Name, sp.LAST_NAME AS Personnel_LastName " +
                         "FROM EQUIPMENT e " +
                         "LEFT JOIN EQUIPMENT_TYPE et ON e.TYPES_ID = et.TYPES_ID " +
                         "LEFT JOIN SECURITYPERSONNEL sp ON e.PERSONNEL_ID = sp.PERSONNEL_ID";

            btnShowEquip.Enabled = false;
            btnUpdateEquip.Enabled = false;
            btnShowTypes.Enabled = true;
            label1.Text = "Equipment";
            showDataWithQuery(sql, new List<Tuple<string, string>>()); // Execute query with no parameters

            dtgResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; // Auto size columns
        }



        private void btnShowTypes_Click(object sender, EventArgs e)
        {
            btnInsertEquip.Text = "Insert Types";
            btnUpdateEquip.Text = "Update Types";
            btnDeleteEquip.Text = "Delete Types";

            tabCntrlTypes.BringToFront();
            label1.Text = "Equipment Types";
            EquipType = true;
            btnUpdateEquip.Enabled = false;
            btnShowTypes.Enabled = false;
            btnShowEquip.Enabled = true;

            // Corrected SQL query
            string sql = "SELECT TYPES_ID AS Type_Id, TYPES_NAME AS Type_Name, E_DESCRIPTION AS Description FROM EQUIPMENT_TYPE";

            showDataWithQuery(sql, new List<Tuple<string, string>>()); // Execute query with no parameters

            dtgResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; // Auto size columns
        }

        private void lblTypeIDD_Click(object sender, EventArgs e)
        {
            
        }

        private void lblTypeNameD_Click(object sender, EventArgs e)
        {

        }

        private void txtTypeIDD_TextChanged(object sender, EventArgs e)
        {
            if (!isPopulating)
            {
                lblTypeIDD.ForeColor = Color.Red;
                btnUpdateEquip.Enabled = true;
            }
        }

        private void txtTypeNamesD_TextChanged(object sender, EventArgs e)
        {
            if (!isPopulating)
            {
                lblTypeNamesD.ForeColor = Color.Red;
                btnUpdateEquip.Enabled = true;
            }
        }

        private void txtDescriptionD_TextChanged(object sender, EventArgs e)
        {
            if (!isPopulating)
            {
                lblDescriptionD.ForeColor = Color.Red;
                btnUpdateEquip.Enabled = true;
            }
        }

        private void cmbEquipTD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isPopulating)
            {
                lblTypeName.ForeColor = Color.Red;
                btnUpdateEquip.Enabled = true;
            }
        }

        private void cmbFirstNameD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isPopulating)
            {
                lblFirstName.ForeColor = Color.Red;
                btnUpdateEquip.Enabled = true;
            }
        }

        private void cmbLastNameD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isPopulating)
            {
                lblLastName.ForeColor = Color.Red;
                btnUpdateEquip.Enabled = true;
            }
        }

        private void txtTypeIDF_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void txtTypeNameF_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void txtDescriptionF_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void frmEquipment_Activated(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(conStr))
            {
                PopulateComboBoxes();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // Check EquipType to determine which data to refresh
            if (EquipType)
            {
                // Refresh Equipment Types Data
                string sql = "SELECT TYPES_ID AS Type_Id, TYPES_NAME AS Type_Name, E_DESCRIPTION AS Description FROM EQUIPMENT_TYPE";
                showDataWithQuery(sql, new List<Tuple<string, string>>());

                // Clear type-related textboxes
                ClearTypeTextboxes();
            }
            else
            {
                // Refresh Equipment Data
                string sql = "SELECT e.EQUIPMENT_ID, e.EQUIPMENT_NAME, et.TYPES_NAME AS Type_Name, sp.PERSONNEL_ID, sp.FIRST_NAME AS Personnel_Name, sp.LAST_NAME AS Personnel_LastName " +
                             "FROM EQUIPMENT e " +
                             "LEFT JOIN EQUIPMENT_TYPE et ON e.TYPES_ID = et.TYPES_ID " +
                             "LEFT JOIN SECURITYPERSONNEL sp ON e.PERSONNEL_ID = sp.PERSONNEL_ID";
                showDataWithQuery(sql, new List<Tuple<string, string>>());

                // Clear equipment-related textboxes
                ClearEquipmentTextboxes();
            }

            // Reset the search box to ensure the data display matches the current view
            txtSearch.Clear();
        }


        // Method to refresh DataGridView with Equipment Types
        // Method to clear textboxes associated with Equipment Types
        private void ClearTypeTextboxes()
        {
            // Reset all label colors to black
            lblDescriptionD.ForeColor = Color.Black;
            lblTypeIDD.ForeColor = Color.Black;
            lblTypeNamesD.ForeColor = Color.Black;

            // Temporarily disable TextChanged events to prevent triggering
            txtTypeIDD.TextChanged -= txtTypeIDD_TextChanged;
            txtTypeNamesD.TextChanged -= txtTypeNamesD_TextChanged;
            txtDescriptionD.TextChanged -= txtDescriptionD_TextChanged;

            // Clear textboxes after update
            txtTypeIDD.Clear();
            txtTypeNamesD.Clear();
            txtDescriptionD.Clear();

            // Reattach events
            txtTypeIDD.TextChanged += txtTypeIDD_TextChanged;
            txtTypeNamesD.TextChanged += txtTypeNamesD_TextChanged;
            txtDescriptionD.TextChanged += txtDescriptionD_TextChanged;
        }

        // Method to clear textboxes associated with Equipment
        private void ClearEquipmentTextboxes()
        {
            // Reset all label colors to black
            lblEquipName.ForeColor = Color.Black;
            lblTypeName.ForeColor = Color.Black;
            lblFirstName.ForeColor = Color.Black;
            lblLastName.ForeColor = Color.Black;

            // Temporarily disable event handlers
            txtEquipNameD.TextChanged -= txtEquipNameD_TextChanged;
            cmbEquipTD.SelectedIndexChanged -= cmbEquipTD_SelectedIndexChanged;
            cmbFirstNameD.SelectedIndexChanged -= cmbFirstNameD_SelectedIndexChanged;
            cmbLastNameD.SelectedIndexChanged -= cmbLastNameD_SelectedIndexChanged;

            // Clear textboxes and comboboxes after update
            txtEquipNameD.Clear();
            cmbEquipTD.SelectedIndex = -1;
            cmbFirstNameD.SelectedIndex = -1;
            cmbLastNameD.SelectedIndex = -1;

            // Reattach event handlers
            txtEquipNameD.TextChanged += txtEquipNameD_TextChanged;
            cmbEquipTD.SelectedIndexChanged += cmbEquipTD_SelectedIndexChanged;
            cmbFirstNameD.SelectedIndexChanged += cmbFirstNameD_SelectedIndexChanged;
            cmbLastNameD.SelectedIndexChanged += cmbLastNameD_SelectedIndexChanged;
        }

        // Method to refresh the DataGridView based on the current state
        private void RefreshDataGrid()
        {
            if (EquipType)
            {
                // Refresh for equipment types
                string sql = "SELECT TYPES_ID AS Type_Id, TYPES_NAME AS Type_Name, E_DESCRIPTION AS Description FROM EQUIPMENT_TYPE";
                showDataWithQuery(sql, new List<Tuple<string, string>>());
            }
            else
            {
                // Refresh for equipment
                string sql = "SELECT e.EQUIPMENT_ID, e.EQUIPMENT_NAME, et.TYPES_NAME AS Type_Name, sp.PERSONNEL_ID, sp.FIRST_NAME AS Personnel_Name, sp.LAST_NAME AS Personnel_LastName " +
                             "FROM EQUIPMENT e " +
                             "LEFT JOIN EQUIPMENT_TYPE et ON e.TYPES_ID = et.TYPES_ID " +
                             "LEFT JOIN SECURITYPERSONNEL sp ON e.PERSONNEL_ID = sp.PERSONNEL_ID";
                showDataWithQuery(sql, new List<Tuple<string, string>>());
            }
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

        private void picHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Email support at: tiredofbugs@gmail.com", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtEquipNameFilter_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void txtTypeNameFilter_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void txtFirstNameFilter_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void txtLastNameFilter_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }
    }
}
