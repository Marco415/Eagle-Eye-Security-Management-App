using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MainForm
{
    public partial class InsertType : Form
    {
        private string conStr;
      

        public InsertType()
        {
            InitializeComponent();
            ConnectDB();  // Initialize the connection string
        }

        private void ConnectDB()
        {
            // Use the same method as in frmEquipment to set the connection string
            string serverName = Environment.GetEnvironmentVariable("EYE_SECURITY_DB") ?? @"localhost\SQLEXPRESS";
            conStr = $"Server={serverName};Database=EYSECURITY;Integrated Security=True;";
        }

        private void btnInsertType_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (string.IsNullOrWhiteSpace(txtInsertTypesName.Text) ||
                string.IsNullOrWhiteSpace(txtInsertDescription.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            // Insert data into the database
            string sql = "INSERT INTO EQUIPMENT_TYPE (TYPES_NAME, E_DESCRIPTION) " +
                         "VALUES (@TypeName, @Description)";

            using (SqlConnection conn = new SqlConnection(conStr))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@TypeName", txtInsertTypesName.Text);
                    cmd.Parameters.AddWithValue("@Description", txtInsertDescription.Text);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }



            // Close the form with OK result
            
            this.DialogResult = DialogResult.OK; // Close the form and indicate success
            this.Close();
        }

        private void btnCancelType_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
