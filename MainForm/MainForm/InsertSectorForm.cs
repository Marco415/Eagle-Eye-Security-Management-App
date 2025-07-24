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
    public partial class InsertSectorForm : Form
    {
        public InsertSectorForm()
        {
            InitializeComponent();
        }

        string conStr;

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string serverName = Environment.GetEnvironmentVariable("EYE_SECURITY_DB") ?? @"localhost\SQLEXPRESS";
            conStr = "Server =" + serverName + ";Database =EYSECURITY;Integrated Security=True;";

            try
            {
                // Validate Sector Name
                if (string.IsNullOrWhiteSpace(txtName.Text))
                {
                    throw new ArgumentException("Sector Name is required.");
                }

                if (txtName.Text.Length > 30)
                {
                    throw new ArgumentException("Sector Name must be 30 characters or less.");
                }

                // Validate Area
                if (string.IsNullOrWhiteSpace(txtArea.Text))
                {
                    throw new ArgumentException("Area is required.");
                }

                if (!decimal.TryParse(txtArea.Text, out decimal area))
                {
                    throw new ArgumentException("Area must be a valid decimal number.");
                }

                // Validate Danger Level
                int dangerLevel = GetSelectedDangerLevel();
                if (dangerLevel == 0)
                {
                    throw new ArgumentException("Please select a Danger Level.");
                }

                // Validate Active Status
                if (!rdoYes.Checked && !rdoNo.Checked)
                {
                    throw new ArgumentException("Please select whether the sector is active or inactive.");
                }

                bool isActive = rdoYes.Checked;

                // Confirmation message box
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to insert this record?",
                    "Confirm Insertion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Insert data into the database
                    using (SqlConnection conn = new SqlConnection(conStr))
                    {
                        conn.Open();
                        string query = "INSERT INTO Sector (Sector_Name, Area, Danger_Level, IsActive) VALUES (@SectorName, @Area, @DangerLevel, @IsActive)";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@SectorName", txtName.Text);
                            cmd.Parameters.AddWithValue("@Area", area);
                            cmd.Parameters.AddWithValue("@IsActive", isActive);
                            cmd.Parameters.AddWithValue("@DangerLevel", dangerLevel);                          
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Record inserted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int GetSelectedDangerLevel()
        {
            switch (true)
            {
                case bool _ when rdoOne.Checked:
                    {
                        return 1;
                    }
                case bool _ when rdoTwo.Checked:
                    {
                        return 2;
                    }
                case bool _ when rdoThree.Checked:
                    {
                        return 3;
                    }
                case bool _ when rdoFour.Checked:
                    {
                        return 4;
                    }
                case bool _ when rdoFive.Checked:
                    {
                        return 5;
                    }
                default:
                    throw new InvalidOperationException("No danger level selected.");
            }
        }      
    }
}