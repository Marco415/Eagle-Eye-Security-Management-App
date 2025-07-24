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

namespace TemplateForm
{
    public partial class Insert_Incident_Type : Form
    {
        public Insert_Incident_Type()
        {
            InitializeComponent();
        }

        string conStr;
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adap;
        DataSet ds;

        private void btnClose2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            // Confirm popup
            DialogResult result = MessageBox.Show("Do you want to proceed with inserting the new incident?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Ensure the necessary fields are not empty
                if (string.IsNullOrWhiteSpace(txtTypeCode.Text) || string.IsNullOrWhiteSpace(txtTypeName.Text) || string.IsNullOrWhiteSpace(rtbTypeDescription.Text))
                {
                    MessageBox.Show("Please fill in all required fields.");
                    return;
                }

                using (SqlConnection conn = new SqlConnection(conStr))
                {
                    // Define your SQL Insert query
                    string sql = "INSERT INTO dbo.INCIDENT_TYPE (CODE, INCIDENT_TYPE_NAME, I_DESCRIPTION) VALUES (@TypeCode, @TypeName, @TypeDescription)";

                    // Use using block for SqlCommand to ensure it gets disposed properly
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        // Add parameters
                        cmd.Parameters.AddWithValue("@TypeCode", txtTypeCode.Text);
                        cmd.Parameters.AddWithValue("@TypeName", txtTypeName.Text);
                        cmd.Parameters.AddWithValue("@TypeDescription", rtbTypeDescription.Text);

                        try
                        {
                            conn.Open();
                            // Execute the command
                            int rowsAffected = cmd.ExecuteNonQuery();

                            // Notify the user
                            if (rowsAffected > 0)
                            {
                                
                                
                                txtTypeCode.Clear();
                                txtTypeName.Clear();
                                rtbTypeDescription.Clear();
                                
                                this.Close();
                                
                            }
                            else
                            {
                                MessageBox.Show("No rows were inserted.");
                            }
                        }
                        catch (Exception ex)
                        {
                            // Handle exceptions with detailed error messages
                            MessageBox.Show("An error occurred: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                this.Close();
            }
        }

        private void Insert_Incident_Type_Load(object sender, EventArgs e)
        {
            string serverName = Environment.GetEnvironmentVariable("EYE_SECURITY_DB") ?? @"localhost\SQLEXPRESS";

            conStr = "Server =" + serverName + ";Database =EYSECURITY;Integrated Security=True;";
            // Now you can use the connection string with a SqlConnection
            // Connect with click of Button

            // Establish connection
            conn = new SqlConnection(conStr);
            conn.Open();
            conn.Close();



           
        }
    }
}
