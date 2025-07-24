using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm
{
    public partial class frmInsertSecurityPersonnel : Form
    {
        public frmInsertSecurityPersonnel()
        {
            InitializeComponent();
        }

        // Database & DatagridView
        string conStr;

        private void ApplyTheme()
        {
            this.BackColor = Color.White; // Set a consistent background color
        }

        private void InsertSecurityPersonnel_Load(object sender, EventArgs e)
        {
            ApplyTheme();
        }

        // Database things
        private void ConnectDB()
        {
            // The ?? will give serverName a default value of @"localhost\SQLEXPRESS"
            string serverName = Environment.GetEnvironmentVariable("EYE_SECURITY_DB") ?? @"localhost\SQLEXPRESS";
            conStr = "Server =" + serverName + ";Database =EYSECURITY;Integrated Security=True;";
        }       

        private void btnInsert_Click(object sender, EventArgs e)
        {
            TextBox[] txts = { txtInsertFirstName, txtInsertLastName, txtInsertIDNumber, txtInsertPhoneNumber, txtInsertEmail };
        
            ValidateSecurityPersonnel validator = new ValidateSecurityPersonnel();

            try
            {
                // Check for empty txts
                for (int i = 0; i < txts.Length; i++)
                {                    
                    if (validator.IsTxtEmpty(txts[i]))
                    {
                        string label = txts[i].Name.Substring("txtInsert".Length);
                        txts[i].Focus();
                        throw new Exception("Please fill in " + label);
                    }                     
                }

                // Check ID Number
                string errorMessage = validator.IsValidIDNumber(txtInsertIDNumber.Text);
                if  (errorMessage != "")
                {
                    txtInsertIDNumber.Focus();
                    throw new Exception(errorMessage);
                }

                // Check phone Number
                errorMessage = validator.IsValidPhoneNumber(txtInsertPhoneNumber.Text);
                if (errorMessage != "")
                {
                    txtInsertPhoneNumber.Focus();
                    throw new Exception(errorMessage);
                }

                // Check Email Address
                if (!validator.IsValidEmail(txtInsertEmail.Text))
                {
                    txtInsertEmail.Focus();
                    throw new Exception("Please enter a valid email address");
                }
                // Check Salary
                ConnectDB();
                //confirmation after validations
                DialogResult result;
                result = MessageBox.Show("Are you sure?", "Confirm Insert Security Personnel", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                //close form
                if (result == DialogResult.Yes)
                {
                    // ADD NEW PERSONNEL
                    InsertNewPersonnel();
                    this.Close();
                }                                 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Invalid value entered",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }          
        }

        private void InsertNewPersonnel()
        {
            string sql = "INSERT INTO SecurityPersonnel (First_Name, Last_Name, ID_Number, Phone_Number, Email_Address, Experience_Level, Salary) " +
                         "VALUES (@FirstName, @LastName, @IDNumber, @PhoneNumber, @EmailAddress, @ExperienceLevel, @Salary)";

            using (SqlConnection conn = new SqlConnection(conStr))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@FirstName", txtInsertFirstName.Text);
                cmd.Parameters.AddWithValue("@LastName", txtInsertLastName.Text);
                cmd.Parameters.AddWithValue("@IDNumber", txtInsertIDNumber.Text);
                cmd.Parameters.AddWithValue("@PhoneNumber", txtInsertPhoneNumber.Text);
                cmd.Parameters.AddWithValue("@EmailAddress", txtInsertEmail.Text);
                cmd.Parameters.AddWithValue("@ExperienceLevel", nudExpLvl.Value.ToString());
                cmd.Parameters.AddWithValue("@Salary", nudSalary.Value);

                try
                {
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("New Security Personnel added successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Failed to add new Security Personnel.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nudExpLvl_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
