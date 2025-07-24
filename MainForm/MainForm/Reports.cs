using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Collections.Specialized.BitVector32;
using System.Security.Cryptography;
using Equipment;
using SecurityPersonnelForm;
using TemplateForm;

namespace MainForm
{
    public partial class frmReports : Form
    {
        //public variables
        private string reportName;
        private string sql;
        private string orderField;
        private DateTime startDate;
        private DateTime endDate;
        //private SqlConnection cnn;
        string conStr;

        // Database & DatagridView
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adap;
        DataSet ds;
        public frmReports()
        {
            InitializeComponent();
        }

        //connect to database method
        private void ConnectDB()
        {
            // The ?? will give serverName a default value of @"localhost\SQLEXPRESS"
            string serverName = Environment.GetEnvironmentVariable("EYE_SECURITY_DB") ?? @"localhost\SQLEXPRESS";
            conStr = "Server =" + serverName + ";Database =EYSECURITY;Integrated Security=True;";
        }

        private void frmReports_Load(object sender, EventArgs e)
        {
            #region "Visual Elements"
            lblDate.Text = DateTime.Now.ToLongDateString();
            lblTime.Text = DateTime.Now.ToShortTimeString();
            tipHome.SetToolTip(picHome, "Home");
            tipHelp.SetToolTip(picHelp, "Help");
            ApplyTheme();
            #endregion
            //call connect to database method
            ConnectDB();   

            //check default radio buttons
            rdoSecurityPersonnel.Checked = true;
            rdoAscending.Checked = true;
            rdoR1PersonnelId.Checked = true;

            //sort by field
            tabSortFields.Appearance = TabAppearance.FlatButtons;
            tabSortFields.ItemSize = new Size(0, 1);
            tabSortFields.SizeMode = TabSizeMode.Fixed;
            foreach (TabPage tab in tabSortFields.TabPages)
            {
                tab.Text = "";
            }
            tabSortFields.SelectedTab = tpSecurityPersonnel;

            //header and sql
            reportName = "Security personnel performance per time period";
            sql = "SELECT sp.PERSONNEL_ID, CONCAT(sp.FIRST_NAME, ' ', sp.LAST_NAME) AS 'PERSONNEL_NAME', " +
                "SUM(s.DURATION) AS 'HOURS_WORKED', COUNT(i.INCIDENT_ID) AS 'INCIDENTS_HANDLED' " +
                "FROM SECURITYPERSONNEL sp, SHIFTS s, SHIFT_DETAIL sd, INCIDENT i " +
                "WHERE sp.PERSONNEL_ID=sd.PERSONNEL_ID AND s.SHIFT_ID=sd.SHIFT_ID AND " +
                "sp.PERSONNEL_ID=i.PERSONNEL_ID AND s.START_DATETIME BETWEEN " + startDate.ToShortDateString() +
                " AND " + endDate.ToShortDateString();
            startDate = dtpStartDate.Value;
            endDate = dtpEndDate.Value;

        }

        private void ApplyTheme()
        {
            this.BackColor = Color.White; // Set a consistent background color
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.BackColor = Color.LightGray; // Example styling
                    btn.Font = new Font("Arial", 10, FontStyle.Bold);
                }
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

        //select report to generate
        private void rdoSecurityPersonnel_CheckedChanged(object sender, EventArgs e)
        {
            
            if (rdoSecurityPersonnel.Checked)
            {
                tabSortFields.SelectedTab = tpSecurityPersonnel;

            }
            
            if (rdoShift.Checked)
            {
                tabSortFields.SelectedTab = tpShits;

            }
            
            if (rdoEquipment.Checked)
            {
                tabSortFields.SelectedTab = tpEquipment;

            }
            
            if (rdoSectors.Checked)
            {
                tabSortFields.SelectedTab = tpSectors;
                
            }
            
            if (rdoIncidents.Checked)
            {
                tabSortFields.SelectedTab = tpIncidents;
            }
        }

        //field to order by
        private void rdoR1PersonnelId_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoR1PersonnelId.Checked)
                orderField = " ORDER BY sp.PERSONNEL_ID ";
            else if (rdoR1PersonnelName.Checked)
                orderField = " ORDER BY PERSONNEL_NAME ";
            else if (rdoR1HoursWorked.Checked)
                orderField = " ORDER BY SUM(s.DURATION) ";
            else if (rdoR1IncidentsHandled.Checked)
                orderField = " ORDER BY COUNT(i.INCIDENT_ID) ";
            else if (rdoR2ShiftId.Checked)
                orderField = " ORDER BY s.SHIFT_ID ";
            else if (rdoR2DateTime.Checked)
                orderField = " ORDER BY s.START_DATETIME ";
            else if (rdoR2NumberOfPersonnel.Checked)
                orderField = " ORDER BY COUNT(sd.PERSONNEL_ID) ";
            else if (rdoR3EquipmentId.Checked)
                orderField = " ORDER BY e.EQUIPMENT_ID ";
            else if (rdoR3EquipmentName.Checked)
                orderField = " ORDER BY e.EQUIPMENT_NAME ";
            else if (rdoR3PersonnelId.Checked)
                orderField = " ORDER BY sd.PERSONNEL_ID ";
            else if (rdoR3PersonnelName.Checked)
                orderField = " ORDER BY CONCAT(sp.FIRST_NAME, ' ', sp.LAST_NAME) ";
            else if (rdoR4SectorId.Checked)
                orderField = " ORDER BY INCIDENT_COUNT ";
            else if (rdoR4SectorName.Checked)
                orderField = " ORDER BY s.SECTOR_NAME ";
            else if (rdoR5SectorId.Checked)
                orderField = " ORDER BY s.SECTOR_ID ";
            else if (rdoR5SectorName.Checked)
                orderField = " ORDER BY s.SECTOR_NAME ";
            else if (rdoR5NumberOfIncidents.Checked)
                orderField = " ORDER BY COUNT(i.INCIDENT_ID) ";
        }

        //report time period
        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtpStartDate.Value > dtpEndDate.Value)
                dtpStartDate.Value = dtpEndDate.Value;
            startDate = dtpStartDate.Value;
        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtpEndDate.Value < dtpStartDate.Value)
                dtpEndDate.Value = dtpStartDate.Value;
            endDate = dtpEndDate.Value;
        }

        //generate report
        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            //R1 - Security personnel performance per time period
            if (rdoSecurityPersonnel.Checked == true)
            {
                
                reportName = "Security personnel performance per time period";
                sql = "SELECT sp.PERSONNEL_ID, " +
                    "CONCAT(sp.FIRST_NAME, ' ', sp.LAST_NAME) AS PERSONNEL_NAME, " +
                    "SUM(s.DURATION) AS HOURS_WORKED, " +
                    "COUNT(i.INCIDENT_ID) AS INCIDENTS_HANDLED " +
                    "FROM SECURITYPERSONNEL sp " +
                    "JOIN SHIFT_DETAIL sd ON sp.PERSONNEL_ID = sd.PERSONNEL_ID " +
                    "JOIN SHIFTS s ON s.SHIFT_ID = sd.SHIFT_ID " +
                    "LEFT JOIN INCIDENT i ON sp.PERSONNEL_ID = i.PERSONNEL_ID " +
                    "WHERE s.START_DATETIME BETWEEN '" + startDate.ToShortDateString() +
                    "' AND '" + endDate.ToShortDateString() + "' " +
                    "GROUP BY sp.PERSONNEL_ID, sp.FIRST_NAME, sp.LAST_NAME";

            }
            //R2 - Personnel worked per shift per time period
            else if (rdoShift.Checked == true)
            {
                
                reportName = "Personnel worked per shift per time period";
                sql = "SELECT s.SHIFT_ID, s.START_DATETIME, " +
                    "COUNT(sd.PERSONNEL_ID) AS 'NUMBER_OF_SECURITY_PERSONNEL_WORKED' " +
                    "FROM SHIFTS s, SHIFT_DETAIL sd " +
                    "WHERE s.SHIFT_ID=sd.SHIFT_ID " +
                    "GROUP BY s.SHIFT_ID, s.START_DATETIME ";

            }
            //R3 - Equipment used by security personnel per time period
            else if (rdoEquipment.Checked == true)
            {
                
                reportName = "Equipment used by security personnel per time period";
                sql = "SELECT e.EQUIPMENT_ID, e.EQUIPMENT_NAME, sp.PERSONNEL_ID, " +
                    "CONCAT(sp.FIRST_NAME, ' ', sp.LAST_NAME) AS 'PERSONNEL_NAME' " +
                    "FROM SECURITYPERSONNEL sp, EQUIPMENT e " +
                    "WHERE sp.PERSONNEL_ID=e.PERSONNEL_ID";

            }
            //R4 - Top 10 most dangerous sectors per time period
            else if (rdoSectors.Checked == true)
            {
                
                reportName = "Top 10 most dangerous sectors per time period";
                sql = @"SELECT TOP 10 
                        s.SECTOR_ID, 
                        s.SECTOR_NAME, 
                    (SELECT COUNT(*) FROM INCIDENT i WHERE i.SECTOR_ID = s.SECTOR_ID) AS INCIDENT_COUNT
                    FROM 
                        SECTOR s 
                    WHERE 
                        s.SECTOR_ID IN (
                    SELECT 
                        i.SECTOR_ID 
                    FROM 
                        INCIDENT i
                    GROUP BY 
                        i.SECTOR_ID 
                    HAVING 
                        COUNT(i.INCIDENT_ID) > 0 )
                    GROUP BY 
                        s.SECTOR_ID, s.SECTOR_NAME ";

            }
            //R5 - Incidents per sector per time period
            else if (rdoIncidents.Checked == true)
            {
                
                reportName = "Incidents per sector per time period";
                sql = "SELECT s.SECTOR_ID, s.SECTOR_NAME , COUNT(i.INCIDENT_ID) AS 'NUMBER_OF_INCIDENTS' " +
                    "FROM SECTOR s, INCIDENT i " +
                    "WHERE s.SECTOR_ID=i.SECTOR_ID " +
                    "GROUP BY s.SECTOR_ID, SECTOR_NAME";
            }

            string reportTimePeriod = "For the time period " + startDate.ToLongDateString() + 
                " to " + endDate.ToLongDateString();
            string requestDate = "Requested on " + DateTime.Now.ToLongDateString();
            txtHeading.Text = reportName + "\r\n" + reportTimePeriod + "\r\n" + requestDate + 
                "\r\n\r\n***START OF REPORT***";
            txtReportEnd.Text = "***END OF REPORT***";
            txtHeading.Height = 85;

            //construct sql statement
            string orderDirection = "";
            if (rdoAscending.Checked)
                orderDirection = " ASC";
            else if (rdoDescending.Checked)
                orderDirection = " DESC";

            sql += orderField + orderDirection;
            

            //show data
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

                    dgvReport.DataSource = ds;
                    dgvReport.DataMember = "SourceTable";

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            txtNumberRecords.Text = "Number of records in report: " + dgvReport.Rows.Count.ToString();
        }

        public void Reset_Radio_Buttons()
        {
            rdoR1PersonnelId.Checked = false;
            rdoR1PersonnelName.Checked = false;
            rdoR1HoursWorked.Checked = false;
            rdoR1IncidentsHandled.Checked = false;

            rdoR2DateTime.Checked = false;
            rdoR2NumberOfPersonnel.Checked = false;
            rdoR2ShiftId.Checked = false;

            rdoR3EquipmentId.Checked = false;
            rdoR3EquipmentName.Checked = false;
            rdoR3PersonnelId.Checked = false;
            rdoR3PersonnelName.Checked = false;

            rdoR4SectorId.Checked = false;
            rdoR4SectorName.Checked = false;


            rdoR5SectorId.Checked = false;
            rdoR5NumberOfIncidents.Checked = false;
            rdoR5SectorName.Checked = false;

            rdoAscending.Checked = false;
            rdoDescending.Checked = false;
        }

        private void rdoShift_Click(object sender, EventArgs e)
        {
            Reset_Radio_Buttons();

        }

        private void rdoSecurityPersonnel_Click(object sender, EventArgs e)
        {
            Reset_Radio_Buttons();
        }

        private void rdoEquipment_Click(object sender, EventArgs e)
        {

        }

        private void rdoSectors_Click(object sender, EventArgs e)
        {
            Reset_Radio_Buttons();
        }

        private void rdoIncidents_Click(object sender, EventArgs e)
        {
            Reset_Radio_Buttons();
        }

        private void btnSecurityPersonnel_Click(object sender, EventArgs e)
        {
            frmSecurityPersonnel form = new frmSecurityPersonnel();
            NavigateToForm(form);
        }

        private void btnShifts_Click(object sender, EventArgs e)
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

        private void picHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Email support at: tiredofbugs@gmail.com", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tmrTimeUpdate_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToShortTimeString();
        }
    }
}
