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

namespace MainForm
{
    public partial class frmAssignPersonnelToShift : Form
    {
        public frmAssignPersonnelToShift()
        {
            InitializeComponent();
        }
        public frmAssignPersonnelToShift(string personnelID)
        {
            InitializeComponent();
            cmbPersonnelID.SelectedItem = personnelID;
        }

        // Database & DatagridView
        string conStr;

        // Shift combobox

        private void assignPersonnelToShift()
        {
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                conn.Open();
                string shiftID = cmbShiftID.Text;
                string personnelID = cmbPersonnelID.Text;
                string sql = $"INSERT INTO Shift_Detail (Shift_ID, Personnel_ID) VALUES({shiftID},{personnelID})";
                SqlCommand cmd = new SqlCommand(sql, conn);
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show($"Successfully assigned {txtFirstName.Text} {txtLastName.Text} with ID: {personnelID} to" +
                    $"\nShift ID: {shiftID} starting at: {txtStartTime.Text}", "Assign Personnel to Shift", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Unsuccessful in assignment", "Unexpected Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            // Check whether shift is selected
            if (cmbShiftID.SelectedIndex > -1)
            {
                DialogResult result = MessageBox.Show($"Are you sure?", "Assign Personnel to Shift", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        assignPersonnelToShift();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message, "Error assigning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Please select a Shift", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbShiftID.Focus();
            }
        }

        // Database things
        private void ConnectDB()
        {
            // The ?? will give serverName a default value of @"localhost\SQLEXPRESS"
            string serverName = Environment.GetEnvironmentVariable("EYE_SECURITY_DB") ?? @"localhost\SQLEXPRESS";
            conStr = "Server =" + serverName + ";Database =EYSECURITY;Integrated Security=True;";
        }

        private void populatePersonnelCombobox()
        {
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                conn.Open();

                // Populate personnel combobox
                string sql = "SELECT Personnel_ID FROM SecurityPersonnel";
                SqlCommand cmd = new SqlCommand(sql, conn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cmbPersonnelID.Items.Add(reader["PERSONNEL_ID"].ToString());
                    }
                }
            }
        }

        private void populateShiftComboBoxAccordingToPersonnelID(string personnelID)
        {
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                conn.Open();

                // Clear existing items in shift combobox
                cmbShiftID.Items.Clear();

                // Get available shifts for the selected personnel
                string sql = @"SELECT s.SHIFT_ID 
                               FROM SHIFTS s
                               WHERE s.SHIFT_ID NOT IN (
                                   SELECT sd.SHIFT_ID 
                                   FROM SHIFT_DETAIL sd 
                                   WHERE sd.PERSONNEL_ID = @personnelID)";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@personnelID", personnelID);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cmbShiftID.Items.Add(reader["SHIFT_ID"].ToString());
                    }
                }

                if (cmbShiftID.Items.Count == 0)
                {
                    lblAlreadyAssigned.Visible = true;
                    cmbShiftID.Enabled = false;
                    btnAssign.Enabled = false;
                }
                else
                {
                    lblAlreadyAssigned.Visible = false;
                    cmbShiftID.Enabled = true;
                    btnAssign.Enabled = true;
                }
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbShiftID_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // Populate shift fields
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                conn.Open();
                string sql = $"SELECT Start_DateTime, Duration FROM Shifts WHERE Shift_ID = {cmbShiftID.Text}";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();


                reader.Read();

                txtStartTime.Text = reader["START_DATETIME"].ToString();
                txtDuration.Text = reader["DURATION"].ToString();
                reader.Close();
                conn.Close();
            }
        }

        private void cmbPersonnelID_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string personnelID = cmbPersonnelID.Text;
            // Populate personnel fields
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                conn.Open();
                string sql = $"SELECT First_Name, Last_Name FROM SecurityPersonnel WHERE Personnel_ID = {personnelID}";
                SqlCommand cmd = new SqlCommand(sql, conn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {

                    reader.Read();

                    txtFirstName.Text = reader["FIRST_NAME"].ToString();
                    txtLastName.Text = reader["LAST_NAME"].ToString();
                }
            }
            // Populate Shift Combobox
            populateShiftComboBoxAccordingToPersonnelID(personnelID);
        }

        private void frmAssignPersonnelToShift_Load(object sender, EventArgs e)
        {
            ConnectDB();
            populatePersonnelCombobox();
            if (cmbPersonnelID.Items.Count > 0)
                cmbPersonnelID.SelectedIndex = 0;
        }
    }
}

