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
    public partial class frmInsertEquipment : Form
    {
        private string conStr;

        public frmInsertEquipment()
        {
            InitializeComponent();
            ConnectDB();  // Initialize the connection string
        }

        public void PopulateNames()
        {
            // Populate names (e.g., first names and last names) from SECURITYPERSONNEL
            string sql = "SELECT DISTINCT FIRST_NAME FROM SECURITYPERSONNEL";
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        cmbName.Items.Clear();
                        while (reader.Read())
                        {
                            cmbName.Items.Add(reader["FIRST_NAME"].ToString());
                        }
                    }
                }
            }

            sql = "SELECT DISTINCT LAST_NAME FROM SECURITYPERSONNEL";
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        cmbLastName.Items.Clear();
                        while (reader.Read())
                        {
                            cmbLastName.Items.Add(reader["LAST_NAME"].ToString());
                        }
                    }
                }
            }
        }
        public void PopulateEquipTypes()
        {
            string sql = "SELECT TYPES_NAME FROM EQUIPMENT_TYPE";
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        cmbEquipType.Items.Clear();
                        while (reader.Read())
                        {
                            cmbEquipType.Items.Add(reader["TYPES_NAME"].ToString());
                        }
                    }
                }
            }
        }
        private void ConnectDB()
        {
            // Use the same method as in frmEquipment to set the connection string
            string serverName = Environment.GetEnvironmentVariable("EYE_SECURITY_DB") ?? @"localhost\SQLEXPRESS";
            conStr = $"Server={serverName};Database=EYSECURITY;Integrated Security=True;";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInsertRecord_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (cmbEquipType.SelectedItem == null ||
                cmbName.SelectedItem == null ||
                cmbLastName.SelectedItem == null)
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            // Get IDs
            int typeID = GetTypeID(cmbEquipType.SelectedItem.ToString());
            if (typeID == -1)
            {
                MessageBox.Show("Invalid equipment type. Please enter a valid type.");
                return;
            }

            int personnelID = GetPersonnelID(cmbName.SelectedItem.ToString(), cmbLastName.SelectedItem.ToString());
            if (personnelID == -1)
            {
                MessageBox.Show("Invalid personnel. Please select a valid personnel.");
                return;
            }

            // Insert data into the database
            string sql = "INSERT INTO EQUIPMENT (EQUIPMENT_NAME, TYPES_ID, PERSONNEL_ID) " +
                         "VALUES (@EquipmentName, @TypesID, @PersonnelID)";

            using (SqlConnection conn = new SqlConnection(conStr))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@EquipmentName", txtInsertEquipName.Text);
                    cmd.Parameters.AddWithValue("@TypesID", typeID);
                    cmd.Parameters.AddWithValue("@PersonnelID", personnelID);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }

            // Close the form with OK result
            this.DialogResult = DialogResult.OK;
            this.Close();
        }


        private int GetTypeID(string typeName)
        {
            string sql = "SELECT TYPES_ID FROM EQUIPMENT_TYPE WHERE TYPES_NAME = @TypeName";
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@TypeName", typeName);
                    conn.Open();
                    object result = cmd.ExecuteScalar();
                    if (result == null)
                    {
                        MessageBox.Show($"The equipment type '{typeName}' does not exist.");
                        throw new InvalidOperationException("Invalid equipment type.");
                    }
                    return Convert.ToInt32(result);
                }
            }
        }


        private int GetPersonnelID(string firstName, string lastName)
        {
            string sql = "SELECT PERSONNEL_ID FROM SECURITYPERSONNEL WHERE FIRST_NAME = @FirstName AND LAST_NAME = @LastName";
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@FirstName", firstName);
                    cmd.Parameters.AddWithValue("@LastName", lastName);
                    conn.Open();
                    object result = cmd.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : -1;
                }
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmInsertEquipment_Load(object sender, EventArgs e)
        {
            // Populate equipment types
            PopulateEquipTypes();

            // Populate names and last names
            PopulateNames();

            cmbEquipType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbName.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLastName.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        

        
    }
}
