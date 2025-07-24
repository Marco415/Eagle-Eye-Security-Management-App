using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TemplateForm
{
    public partial class InsertIncidents : Form
    {
        public InsertIncidents()
        {
            InitializeComponent();
        }

        string conStr;
        SqlConnection conn;
        SqlCommand cmd;

        private void LoadComboBoxData()
        {
            LoadIncidentTypeNames();
            LoadLastNames();
            LoadSectorNames();
            LoadShiftDates();
        }

        private void LoadIncidentTypeNames()
        {
            string query = "SELECT INCIDENT_TYPE_ID, INCIDENT_TYPE_NAME FROM dbo.INCIDENT_TYPE";
            LoadComboBoxData(query, cbxTypeName, "INCIDENT_TYPE_ID", "INCIDENT_TYPE_NAME");
        }

        private void LoadLastNames()
        {
            string query = "SELECT PERSONNEL_ID, LAST_NAME FROM dbo.SECURITYPERSONNEL";
            LoadComboBoxData(query, cbxLastN, "PERSONNEL_ID", "LAST_NAME");
        }

        private void LoadSectorNames()
        {
            string query = "SELECT SECTOR_ID, SECTOR_NAME FROM dbo.SECTOR";
            LoadComboBoxData(query, cbxSector, "SECTOR_ID", "SECTOR_NAME");
        }

        private void LoadShiftDates()
        {
            string query = "SELECT SHIFT_ID, START_DATETIME FROM dbo.SHIFTS";
            LoadComboBoxData(query, cbxShift, "SHIFT_ID", "START_DATETIME");
        }

        private void LoadComboBoxData(string query, System.Windows.Forms.ComboBox comboBox, string idColumn , string columnName)
        {
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                SqlCommand cmd = new SqlCommand(query, conn);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        comboBox.Items.Add(reader[idColumn].ToString() + " " + reader[columnName].ToString() );
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }


        private void btnInsert_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(rtbSummary.Text))
            {
                MessageBox.Show("Please enter a summary for the incident.");
                return; // Stop execution if summary is missing
            }

            if (cbxTypeName.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an incident type.");
                return;
            }

            if (cbxLastN.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a security personnel.");
                return;
            }

            if (cbxSector.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a sector.");
                return;
            }

            if (cbxShift.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a shift.");
                return;
            }


            string typeAndID, nameAndID, sectorAndID, shiftAndID;

            nameAndID = cbxLastN.Text;
            typeAndID = cbxTypeName.Text;
            sectorAndID = cbxSector.Text;
            shiftAndID = cbxShift.Text;
            string PersonnelID = nameAndID.Substring(0, nameAndID.IndexOf(' '));
            string TypeID = typeAndID.Substring(0, typeAndID.IndexOf(' '));
            string SectorID = sectorAndID.Substring(0, sectorAndID.IndexOf(' '));
            string ShiftID = shiftAndID.Substring(0, shiftAndID.IndexOf(' '));
        
            // Confirmation popup
            DialogResult result = MessageBox.Show("Do you want to proceed with inserting the new incident?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(conStr))
                {                                       
                    
                    // Define your SQL Insert query, assuming you want to insert values into specific columns
                    string sql = "INSERT INTO dbo.INCIDENT (SUMMARY_OF_EVENTS, PERSONNEL_ID, SHIFT_ID, INCIDENT_TYPE_ID, SECTOR_ID) VALUES (@Summary, @Personnel, @Shift, @Incident, @Sector)";

                    cmd = new SqlCommand(sql, conn);

                    // Add parameters to prevent SQL injection
                    //cmd.Parameters.AddWithValue("@Summary",);
                    cmd.Parameters.AddWithValue("@Summary", rtbSummary.Text);
                    cmd.Parameters.AddWithValue("@Personnel", PersonnelID);
                    cmd.Parameters.AddWithValue("@Shift", ShiftID);
                    cmd.Parameters.AddWithValue("@Incident", TypeID);
                    cmd.Parameters.AddWithValue("@Sector", SectorID);

                    //try
                    {
                        conn.Open();
                        // Execute the command
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Notify the user
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("New incident inserted successfully!");
                            rtbSummary.Clear();
                            cbxLastN.SelectedIndex = -1;
                            cbxShift.SelectedIndex = -1;
                            cbxTypeName.SelectedIndex = -1;
                            cbxSector.SelectedIndex = -1;

                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("No rows were inserted.");
                        }
                    }
                    //catch (Exception ex)
                    {
                        // Handle any exceptions
                        //MessageBox.Show("An error occurred: " + ex.Message);
                    }
                                      
                }              
            }          
        }

        private void btnClose2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InsertIncidents_Load(object sender, EventArgs e)
        {
            #region "SQLConnection"
            string serverName = Environment.GetEnvironmentVariable("EYE_SECURITY_DB") ?? @"localhost\SQLEXPRESS";

            conStr = "Server =" + serverName + ";Database =EYSECURITY;Integrated Security=True;";
            // Now you can use the connection string with a SqlConnection
            // Connect with click of Button

            // Establish connection
            conn = new SqlConnection(conStr);
            conn.Open();
            conn.Close();
            


            LoadComboBoxData();



            #endregion
        }

        private void InsertIncidents_Shown(object sender, EventArgs e)
        {
            
        }
    }
}
