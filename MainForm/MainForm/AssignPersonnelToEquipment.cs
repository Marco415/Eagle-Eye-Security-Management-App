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
    public partial class frmAssignPersonnelToEquipment : Form
    {
        public frmAssignPersonnelToEquipment()
        {
            InitializeComponent();
        }
        public frmAssignPersonnelToEquipment(string personnelID)
        {
            InitializeComponent();
            cmbPersonnelID.SelectedItem = personnelID;
        }

        // Database & DatagridView
        string conStr;

        private void assignPersonnelToEquipment()
        {
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                conn.Open();
                int equipmentID = int.Parse(cmbEquipmentID.SelectedItem.ToString()); 
                int personnelID = int.Parse(cmbPersonnelID.SelectedItem.ToString());
                string sql = $"UPDATE Equipment SET Personnel_ID = {personnelID} WHERE Equipment_ID = {equipmentID}";

                SqlCommand cmd = new SqlCommand(sql, conn);
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show($"Successfully assigned {txtFirstName.Text} {txtLastName.Text} with ID: {personnelID} to" +
                    $"\nEquipment ID: {equipmentID} with name: {txtEquipmentName.Text}", "Assign Personnel to Equipment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Unsuccessful in assignment", "Unexpected Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            // Check whether equipment is selected
            if (cmbEquipmentID.SelectedIndex > -1)
            {
                DialogResult result = MessageBox.Show($"Are you sure?", "Assign Personnel to Equipment", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        assignPersonnelToEquipment();
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
                MessageBox.Show("Please select a Equipment", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbEquipmentID.Focus();
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

        private void populateEquipmentComboBoxAccordingToPersonnelID(string personnelID)
        {
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                conn.Open();

                // Clear existing items in equipment combobox
                cmbEquipmentID.Items.Clear();

                // Get available equipments for the selected personnel
                string sql = @"SELECT e.EQUIPMENT_ID
                       FROM Equipment e
                       WHERE e.Personnel_ID <> @personnelID";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@personnelID", personnelID);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cmbEquipmentID.Items.Add(reader["EQUIPMENT_ID"].ToString());
                    }
                }

                if (cmbEquipmentID.Items.Count == 0)
                {
                    lblAlreadyAssigned.Visible = true;
                    cmbEquipmentID.Enabled = false;
                    btnAssign.Enabled = false;
                }
                else
                {
                    lblAlreadyAssigned.Visible = false;
                    cmbEquipmentID.Enabled = true;
                    btnAssign.Enabled = true;
                }
            }
        }

        private void frmAssignPersonnelToEquipment_Load(object sender, EventArgs e)
        {
            ConnectDB();
            populatePersonnelCombobox();
            if (cmbPersonnelID.Items.Count > 0)
                cmbPersonnelID.SelectedIndex = 0;
        }

        private void cmbEquipmentID_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Populate equipment fields
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                conn.Open();
                string sql = $"SELECT e.Equipment_Name, et.Types_Name " +
                    $"FROM Equipment e, Equipment_Type et " +
                    $"WHERE e.Equipment_ID = {cmbEquipmentID.Text} " +
                    $"AND e.Types_ID = et.Types_ID";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                reader.Read();

                txtEquipmentName.Text = reader["Equipment_Name"].ToString();
                txtEquipmentType.Text = reader["Types_Name"].ToString();
                reader.Close();
                conn.Close();
            }
        }

        private void cmbPersonnelID_SelectedIndexChanged(object sender, EventArgs e)
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
            // Populate equipment Combobox
            populateEquipmentComboBoxAccordingToPersonnelID(personnelID);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
