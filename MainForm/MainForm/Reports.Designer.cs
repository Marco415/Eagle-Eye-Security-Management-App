namespace MainForm
{
    partial class frmReports
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReports));
            this.pnlTopMenu = new System.Windows.Forms.Panel();
            this.lblReports = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.picHelp = new System.Windows.Forms.PictureBox();
            this.picHome = new System.Windows.Forms.PictureBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pnlSideMenu = new System.Windows.Forms.Panel();
            this.btnIncidents = new System.Windows.Forms.Button();
            this.btnSectors = new System.Windows.Forms.Button();
            this.btnEquipment = new System.Windows.Forms.Button();
            this.btnShifts = new System.Windows.Forms.Button();
            this.btnSecurityPersonnel = new System.Windows.Forms.Button();
            this.pnlReports = new System.Windows.Forms.Panel();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.lblGenerateReport = new System.Windows.Forms.Label();
            this.grpReports = new System.Windows.Forms.GroupBox();
            this.rdoIncidents = new System.Windows.Forms.RadioButton();
            this.rdoSectors = new System.Windows.Forms.RadioButton();
            this.rdoEquipment = new System.Windows.Forms.RadioButton();
            this.rdoShift = new System.Windows.Forms.RadioButton();
            this.rdoSecurityPersonnel = new System.Windows.Forms.RadioButton();
            this.tipMenu = new System.Windows.Forms.ToolTip(this.components);
            this.tipHome = new System.Windows.Forms.ToolTip(this.components);
            this.tipHelp = new System.Windows.Forms.ToolTip(this.components);
            this.grpReportDetails = new System.Windows.Forms.GroupBox();
            this.grpSort = new System.Windows.Forms.GroupBox();
            this.lblSortField = new System.Windows.Forms.Label();
            this.tabSortFields = new System.Windows.Forms.TabControl();
            this.tpSecurityPersonnel = new System.Windows.Forms.TabPage();
            this.rdoR1IncidentsHandled = new System.Windows.Forms.RadioButton();
            this.rdoR1HoursWorked = new System.Windows.Forms.RadioButton();
            this.rdoR1PersonnelName = new System.Windows.Forms.RadioButton();
            this.rdoR1PersonnelId = new System.Windows.Forms.RadioButton();
            this.tpShits = new System.Windows.Forms.TabPage();
            this.rdoR2NumberOfPersonnel = new System.Windows.Forms.RadioButton();
            this.rdoR2DateTime = new System.Windows.Forms.RadioButton();
            this.rdoR2ShiftId = new System.Windows.Forms.RadioButton();
            this.tpEquipment = new System.Windows.Forms.TabPage();
            this.rdoR3EquipmentName = new System.Windows.Forms.RadioButton();
            this.rdoR3EquipmentId = new System.Windows.Forms.RadioButton();
            this.rdoR3PersonnelName = new System.Windows.Forms.RadioButton();
            this.rdoR3PersonnelId = new System.Windows.Forms.RadioButton();
            this.tpSectors = new System.Windows.Forms.TabPage();
            this.rdoR4SectorName = new System.Windows.Forms.RadioButton();
            this.rdoR4SectorId = new System.Windows.Forms.RadioButton();
            this.tpIncidents = new System.Windows.Forms.TabPage();
            this.rdoR5NumberOfIncidents = new System.Windows.Forms.RadioButton();
            this.rdoR5SectorName = new System.Windows.Forms.RadioButton();
            this.rdoR5SectorId = new System.Windows.Forms.RadioButton();
            this.grpSortOrder = new System.Windows.Forms.GroupBox();
            this.rdoDescending = new System.Windows.Forms.RadioButton();
            this.rdoAscending = new System.Windows.Forms.RadioButton();
            this.grpTimePeriod = new System.Windows.Forms.GroupBox();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.pnlReport = new System.Windows.Forms.Panel();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.txtNumberRecords = new System.Windows.Forms.TextBox();
            this.txtReportEnd = new System.Windows.Forms.TextBox();
            this.txtHeading = new System.Windows.Forms.TextBox();
            this.tmrTimeUpdate = new System.Windows.Forms.Timer(this.components);
            this.pnlTopMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHelp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlSideMenu.SuspendLayout();
            this.pnlReports.SuspendLayout();
            this.grpReports.SuspendLayout();
            this.grpReportDetails.SuspendLayout();
            this.grpSort.SuspendLayout();
            this.tabSortFields.SuspendLayout();
            this.tpSecurityPersonnel.SuspendLayout();
            this.tpShits.SuspendLayout();
            this.tpEquipment.SuspendLayout();
            this.tpSectors.SuspendLayout();
            this.tpIncidents.SuspendLayout();
            this.grpSortOrder.SuspendLayout();
            this.grpTimePeriod.SuspendLayout();
            this.pnlReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTopMenu
            // 
            this.pnlTopMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(222)))), ((int)(((byte)(211)))));
            this.pnlTopMenu.Controls.Add(this.lblReports);
            this.pnlTopMenu.Controls.Add(this.lblTime);
            this.pnlTopMenu.Controls.Add(this.lblDate);
            this.pnlTopMenu.Controls.Add(this.picHelp);
            this.pnlTopMenu.Controls.Add(this.picHome);
            this.pnlTopMenu.Controls.Add(this.picLogo);
            this.pnlTopMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlTopMenu.Name = "pnlTopMenu";
            this.pnlTopMenu.Size = new System.Drawing.Size(1370, 108);
            this.pnlTopMenu.TabIndex = 0;
            // 
            // lblReports
            // 
            this.lblReports.AutoSize = true;
            this.lblReports.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReports.Location = new System.Drawing.Point(492, 25);
            this.lblReports.Name = "lblReports";
            this.lblReports.Size = new System.Drawing.Size(147, 40);
            this.lblReports.TabIndex = 6;
            this.lblReports.Text = "Reports";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(25, 49);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(45, 16);
            this.lblTime.TabIndex = 5;
            this.lblTime.Text = "label2";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(25, 28);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(45, 16);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "label1";
            // 
            // picHelp
            // 
            this.picHelp.Image = global::MainForm.Properties.Resources.Help;
            this.picHelp.Location = new System.Drawing.Point(1190, 3);
            this.picHelp.Name = "picHelp";
            this.picHelp.Size = new System.Drawing.Size(97, 101);
            this.picHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHelp.TabIndex = 2;
            this.picHelp.TabStop = false;
            this.picHelp.Click += new System.EventHandler(this.picHelp_Click);
            // 
            // picHome
            // 
            this.picHome.Image = global::MainForm.Properties.Resources.Home;
            this.picHome.Location = new System.Drawing.Point(1293, 3);
            this.picHome.Name = "picHome";
            this.picHome.Size = new System.Drawing.Size(108, 101);
            this.picHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHome.TabIndex = 1;
            this.picHome.TabStop = false;
            this.picHome.Click += new System.EventHandler(this.picHome_Click);
            // 
            // picLogo
            // 
            this.picLogo.Image = global::MainForm.Properties.Resources.Eagle_Eye_Logo;
            this.picLogo.Location = new System.Drawing.Point(1407, 0);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(108, 104);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // pnlSideMenu
            // 
            this.pnlSideMenu.BackColor = System.Drawing.Color.Silver;
            this.pnlSideMenu.Controls.Add(this.btnIncidents);
            this.pnlSideMenu.Controls.Add(this.btnSectors);
            this.pnlSideMenu.Controls.Add(this.btnEquipment);
            this.pnlSideMenu.Controls.Add(this.btnShifts);
            this.pnlSideMenu.Controls.Add(this.btnSecurityPersonnel);
            this.pnlSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideMenu.Location = new System.Drawing.Point(0, 108);
            this.pnlSideMenu.Name = "pnlSideMenu";
            this.pnlSideMenu.Size = new System.Drawing.Size(190, 641);
            this.pnlSideMenu.TabIndex = 1;
            // 
            // btnIncidents
            // 
            this.btnIncidents.Location = new System.Drawing.Point(20, 424);
            this.btnIncidents.Name = "btnIncidents";
            this.btnIncidents.Size = new System.Drawing.Size(150, 59);
            this.btnIncidents.TabIndex = 4;
            this.btnIncidents.Text = "Incidents";
            this.btnIncidents.UseVisualStyleBackColor = true;
            this.btnIncidents.Click += new System.EventHandler(this.btnIncidents_Click);
            // 
            // btnSectors
            // 
            this.btnSectors.Location = new System.Drawing.Point(20, 324);
            this.btnSectors.Name = "btnSectors";
            this.btnSectors.Size = new System.Drawing.Size(150, 59);
            this.btnSectors.TabIndex = 3;
            this.btnSectors.Text = "Sectors";
            this.btnSectors.UseVisualStyleBackColor = true;
            this.btnSectors.Click += new System.EventHandler(this.btnSectors_Click);
            // 
            // btnEquipment
            // 
            this.btnEquipment.Location = new System.Drawing.Point(20, 224);
            this.btnEquipment.Name = "btnEquipment";
            this.btnEquipment.Size = new System.Drawing.Size(150, 59);
            this.btnEquipment.TabIndex = 2;
            this.btnEquipment.Text = "Equipment";
            this.btnEquipment.UseVisualStyleBackColor = true;
            this.btnEquipment.Click += new System.EventHandler(this.btnEquipment_Click);
            // 
            // btnShifts
            // 
            this.btnShifts.Location = new System.Drawing.Point(20, 124);
            this.btnShifts.Name = "btnShifts";
            this.btnShifts.Size = new System.Drawing.Size(150, 59);
            this.btnShifts.TabIndex = 1;
            this.btnShifts.Text = "Shifts";
            this.btnShifts.UseVisualStyleBackColor = true;
            this.btnShifts.Click += new System.EventHandler(this.btnShifts_Click);
            // 
            // btnSecurityPersonnel
            // 
            this.btnSecurityPersonnel.Location = new System.Drawing.Point(20, 24);
            this.btnSecurityPersonnel.Name = "btnSecurityPersonnel";
            this.btnSecurityPersonnel.Size = new System.Drawing.Size(150, 59);
            this.btnSecurityPersonnel.TabIndex = 0;
            this.btnSecurityPersonnel.Text = "Security Personnel";
            this.btnSecurityPersonnel.UseVisualStyleBackColor = true;
            this.btnSecurityPersonnel.Click += new System.EventHandler(this.btnSecurityPersonnel_Click);
            // 
            // pnlReports
            // 
            this.pnlReports.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlReports.Controls.Add(this.btnGenerateReport);
            this.pnlReports.Controls.Add(this.lblGenerateReport);
            this.pnlReports.Controls.Add(this.grpReports);
            this.pnlReports.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlReports.Location = new System.Drawing.Point(190, 108);
            this.pnlReports.Name = "pnlReports";
            this.pnlReports.Size = new System.Drawing.Size(300, 641);
            this.pnlReports.TabIndex = 2;
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Location = new System.Drawing.Point(16, 598);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(266, 60);
            this.btnGenerateReport.TabIndex = 2;
            this.btnGenerateReport.Text = "Generate Report";
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // lblGenerateReport
            // 
            this.lblGenerateReport.AutoSize = true;
            this.lblGenerateReport.Location = new System.Drawing.Point(14, 555);
            this.lblGenerateReport.Name = "lblGenerateReport";
            this.lblGenerateReport.Size = new System.Drawing.Size(182, 32);
            this.lblGenerateReport.TabIndex = 1;
            this.lblGenerateReport.Text = "Select report details before \r\ngenerating a report\r\n";
            // 
            // grpReports
            // 
            this.grpReports.Controls.Add(this.rdoIncidents);
            this.grpReports.Controls.Add(this.rdoSectors);
            this.grpReports.Controls.Add(this.rdoEquipment);
            this.grpReports.Controls.Add(this.rdoShift);
            this.grpReports.Controls.Add(this.rdoSecurityPersonnel);
            this.grpReports.Location = new System.Drawing.Point(16, 18);
            this.grpReports.Name = "grpReports";
            this.grpReports.Size = new System.Drawing.Size(266, 421);
            this.grpReports.TabIndex = 0;
            this.grpReports.TabStop = false;
            this.grpReports.Text = "Select a report";
            // 
            // rdoIncidents
            // 
            this.rdoIncidents.AutoSize = true;
            this.rdoIncidents.Location = new System.Drawing.Point(22, 362);
            this.rdoIncidents.Name = "rdoIncidents";
            this.rdoIncidents.Size = new System.Drawing.Size(178, 36);
            this.rdoIncidents.TabIndex = 3;
            this.rdoIncidents.Text = "Incidents per sector per \r\ntime period";
            this.rdoIncidents.UseVisualStyleBackColor = true;
            this.rdoIncidents.CheckedChanged += new System.EventHandler(this.rdoSecurityPersonnel_CheckedChanged);
            this.rdoIncidents.Click += new System.EventHandler(this.rdoIncidents_Click);
            // 
            // rdoSectors
            // 
            this.rdoSectors.AutoSize = true;
            this.rdoSectors.Location = new System.Drawing.Point(22, 281);
            this.rdoSectors.Name = "rdoSectors";
            this.rdoSectors.Size = new System.Drawing.Size(178, 36);
            this.rdoSectors.TabIndex = 1;
            this.rdoSectors.Text = "Top 10 most dangerous \r\nsectors per time period";
            this.rdoSectors.UseVisualStyleBackColor = true;
            this.rdoSectors.CheckedChanged += new System.EventHandler(this.rdoSecurityPersonnel_CheckedChanged);
            this.rdoSectors.Click += new System.EventHandler(this.rdoSectors_Click);
            // 
            // rdoEquipment
            // 
            this.rdoEquipment.AutoSize = true;
            this.rdoEquipment.Location = new System.Drawing.Point(22, 200);
            this.rdoEquipment.Name = "rdoEquipment";
            this.rdoEquipment.Size = new System.Drawing.Size(203, 36);
            this.rdoEquipment.TabIndex = 2;
            this.rdoEquipment.Text = "Equipment used by security \r\npersonnel per time period";
            this.rdoEquipment.UseVisualStyleBackColor = true;
            this.rdoEquipment.CheckedChanged += new System.EventHandler(this.rdoSecurityPersonnel_CheckedChanged);
            this.rdoEquipment.Click += new System.EventHandler(this.rdoEquipment_Click);
            // 
            // rdoShift
            // 
            this.rdoShift.AutoSize = true;
            this.rdoShift.Location = new System.Drawing.Point(22, 119);
            this.rdoShift.Name = "rdoShift";
            this.rdoShift.Size = new System.Drawing.Size(197, 36);
            this.rdoShift.TabIndex = 1;
            this.rdoShift.Text = "Personnel worked per shift \r\nper time period";
            this.rdoShift.UseVisualStyleBackColor = true;
            this.rdoShift.CheckedChanged += new System.EventHandler(this.rdoSecurityPersonnel_CheckedChanged);
            this.rdoShift.Click += new System.EventHandler(this.rdoShift_Click);
            // 
            // rdoSecurityPersonnel
            // 
            this.rdoSecurityPersonnel.AutoSize = true;
            this.rdoSecurityPersonnel.Checked = true;
            this.rdoSecurityPersonnel.Location = new System.Drawing.Point(22, 38);
            this.rdoSecurityPersonnel.Name = "rdoSecurityPersonnel";
            this.rdoSecurityPersonnel.Size = new System.Drawing.Size(204, 36);
            this.rdoSecurityPersonnel.TabIndex = 0;
            this.rdoSecurityPersonnel.TabStop = true;
            this.rdoSecurityPersonnel.Text = "Security personnel \r\nperformance per time period";
            this.rdoSecurityPersonnel.UseVisualStyleBackColor = true;
            this.rdoSecurityPersonnel.CheckedChanged += new System.EventHandler(this.rdoSecurityPersonnel_CheckedChanged);
            this.rdoSecurityPersonnel.Click += new System.EventHandler(this.rdoSecurityPersonnel_Click);
            // 
            // grpReportDetails
            // 
            this.grpReportDetails.Controls.Add(this.grpSort);
            this.grpReportDetails.Controls.Add(this.grpTimePeriod);
            this.grpReportDetails.Location = new System.Drawing.Point(496, 114);
            this.grpReportDetails.Name = "grpReportDetails";
            this.grpReportDetails.Size = new System.Drawing.Size(1019, 206);
            this.grpReportDetails.TabIndex = 3;
            this.grpReportDetails.TabStop = false;
            this.grpReportDetails.Text = "Select details for report";
            // 
            // grpSort
            // 
            this.grpSort.Controls.Add(this.lblSortField);
            this.grpSort.Controls.Add(this.tabSortFields);
            this.grpSort.Controls.Add(this.grpSortOrder);
            this.grpSort.Location = new System.Drawing.Point(362, 22);
            this.grpSort.Name = "grpSort";
            this.grpSort.Size = new System.Drawing.Size(651, 179);
            this.grpSort.TabIndex = 1;
            this.grpSort.TabStop = false;
            this.grpSort.Text = "Sort report";
            // 
            // lblSortField
            // 
            this.lblSortField.AutoSize = true;
            this.lblSortField.Location = new System.Drawing.Point(236, 23);
            this.lblSortField.Name = "lblSortField";
            this.lblSortField.Size = new System.Drawing.Size(143, 16);
            this.lblSortField.TabIndex = 3;
            this.lblSortField.Text = "Select field to sort by:";
            // 
            // tabSortFields
            // 
            this.tabSortFields.Controls.Add(this.tpSecurityPersonnel);
            this.tabSortFields.Controls.Add(this.tpShits);
            this.tabSortFields.Controls.Add(this.tpEquipment);
            this.tabSortFields.Controls.Add(this.tpSectors);
            this.tabSortFields.Controls.Add(this.tpIncidents);
            this.tabSortFields.Location = new System.Drawing.Point(240, 41);
            this.tabSortFields.Name = "tabSortFields";
            this.tabSortFields.SelectedIndex = 0;
            this.tabSortFields.Size = new System.Drawing.Size(405, 132);
            this.tabSortFields.TabIndex = 2;
            // 
            // tpSecurityPersonnel
            // 
            this.tpSecurityPersonnel.Controls.Add(this.rdoR1IncidentsHandled);
            this.tpSecurityPersonnel.Controls.Add(this.rdoR1HoursWorked);
            this.tpSecurityPersonnel.Controls.Add(this.rdoR1PersonnelName);
            this.tpSecurityPersonnel.Controls.Add(this.rdoR1PersonnelId);
            this.tpSecurityPersonnel.Location = new System.Drawing.Point(4, 25);
            this.tpSecurityPersonnel.Name = "tpSecurityPersonnel";
            this.tpSecurityPersonnel.Padding = new System.Windows.Forms.Padding(3);
            this.tpSecurityPersonnel.Size = new System.Drawing.Size(397, 103);
            this.tpSecurityPersonnel.TabIndex = 0;
            this.tpSecurityPersonnel.Text = "1";
            this.tpSecurityPersonnel.UseVisualStyleBackColor = true;
            // 
            // rdoR1IncidentsHandled
            // 
            this.rdoR1IncidentsHandled.AutoSize = true;
            this.rdoR1IncidentsHandled.Location = new System.Drawing.Point(6, 72);
            this.rdoR1IncidentsHandled.Name = "rdoR1IncidentsHandled";
            this.rdoR1IncidentsHandled.Size = new System.Drawing.Size(137, 20);
            this.rdoR1IncidentsHandled.TabIndex = 3;
            this.rdoR1IncidentsHandled.TabStop = true;
            this.rdoR1IncidentsHandled.Text = "Incidents Handled";
            this.rdoR1IncidentsHandled.UseVisualStyleBackColor = true;
            this.rdoR1IncidentsHandled.CheckedChanged += new System.EventHandler(this.rdoR1PersonnelId_CheckedChanged);
            // 
            // rdoR1HoursWorked
            // 
            this.rdoR1HoursWorked.AutoSize = true;
            this.rdoR1HoursWorked.Location = new System.Drawing.Point(6, 50);
            this.rdoR1HoursWorked.Name = "rdoR1HoursWorked";
            this.rdoR1HoursWorked.Size = new System.Drawing.Size(115, 20);
            this.rdoR1HoursWorked.TabIndex = 2;
            this.rdoR1HoursWorked.TabStop = true;
            this.rdoR1HoursWorked.Text = "Hours Worked";
            this.rdoR1HoursWorked.UseVisualStyleBackColor = true;
            this.rdoR1HoursWorked.CheckedChanged += new System.EventHandler(this.rdoR1PersonnelId_CheckedChanged);
            // 
            // rdoR1PersonnelName
            // 
            this.rdoR1PersonnelName.AutoSize = true;
            this.rdoR1PersonnelName.Location = new System.Drawing.Point(6, 28);
            this.rdoR1PersonnelName.Name = "rdoR1PersonnelName";
            this.rdoR1PersonnelName.Size = new System.Drawing.Size(184, 20);
            this.rdoR1PersonnelName.TabIndex = 1;
            this.rdoR1PersonnelName.TabStop = true;
            this.rdoR1PersonnelName.Text = "Security Personnel Name";
            this.rdoR1PersonnelName.UseVisualStyleBackColor = true;
            this.rdoR1PersonnelName.CheckedChanged += new System.EventHandler(this.rdoR1PersonnelId_CheckedChanged);
            // 
            // rdoR1PersonnelId
            // 
            this.rdoR1PersonnelId.AutoSize = true;
            this.rdoR1PersonnelId.Location = new System.Drawing.Point(6, 6);
            this.rdoR1PersonnelId.Name = "rdoR1PersonnelId";
            this.rdoR1PersonnelId.Size = new System.Drawing.Size(161, 20);
            this.rdoR1PersonnelId.TabIndex = 0;
            this.rdoR1PersonnelId.TabStop = true;
            this.rdoR1PersonnelId.Text = "Security Personnel ID";
            this.rdoR1PersonnelId.UseVisualStyleBackColor = true;
            this.rdoR1PersonnelId.CheckedChanged += new System.EventHandler(this.rdoR1PersonnelId_CheckedChanged);
            // 
            // tpShits
            // 
            this.tpShits.Controls.Add(this.rdoR2NumberOfPersonnel);
            this.tpShits.Controls.Add(this.rdoR2DateTime);
            this.tpShits.Controls.Add(this.rdoR2ShiftId);
            this.tpShits.Location = new System.Drawing.Point(4, 25);
            this.tpShits.Name = "tpShits";
            this.tpShits.Padding = new System.Windows.Forms.Padding(3);
            this.tpShits.Size = new System.Drawing.Size(397, 103);
            this.tpShits.TabIndex = 1;
            this.tpShits.Text = "2";
            this.tpShits.UseVisualStyleBackColor = true;
            // 
            // rdoR2NumberOfPersonnel
            // 
            this.rdoR2NumberOfPersonnel.AutoSize = true;
            this.rdoR2NumberOfPersonnel.Location = new System.Drawing.Point(6, 50);
            this.rdoR2NumberOfPersonnel.Name = "rdoR2NumberOfPersonnel";
            this.rdoR2NumberOfPersonnel.Size = new System.Drawing.Size(266, 20);
            this.rdoR2NumberOfPersonnel.TabIndex = 2;
            this.rdoR2NumberOfPersonnel.TabStop = true;
            this.rdoR2NumberOfPersonnel.Text = "Number of Security Personnel Worked\r\n";
            this.rdoR2NumberOfPersonnel.UseVisualStyleBackColor = true;
            this.rdoR2NumberOfPersonnel.CheckedChanged += new System.EventHandler(this.rdoR1PersonnelId_CheckedChanged);
            // 
            // rdoR2DateTime
            // 
            this.rdoR2DateTime.AutoSize = true;
            this.rdoR2DateTime.Location = new System.Drawing.Point(6, 28);
            this.rdoR2DateTime.Name = "rdoR2DateTime";
            this.rdoR2DateTime.Size = new System.Drawing.Size(183, 20);
            this.rdoR2DateTime.TabIndex = 1;
            this.rdoR2DateTime.TabStop = true;
            this.rdoR2DateTime.Text = "Shift Start Date and Time";
            this.rdoR2DateTime.UseVisualStyleBackColor = true;
            this.rdoR2DateTime.CheckedChanged += new System.EventHandler(this.rdoR1PersonnelId_CheckedChanged);
            // 
            // rdoR2ShiftId
            // 
            this.rdoR2ShiftId.AutoSize = true;
            this.rdoR2ShiftId.Location = new System.Drawing.Point(6, 6);
            this.rdoR2ShiftId.Name = "rdoR2ShiftId";
            this.rdoR2ShiftId.Size = new System.Drawing.Size(70, 20);
            this.rdoR2ShiftId.TabIndex = 0;
            this.rdoR2ShiftId.TabStop = true;
            this.rdoR2ShiftId.Text = "Shift ID";
            this.rdoR2ShiftId.UseVisualStyleBackColor = true;
            this.rdoR2ShiftId.CheckedChanged += new System.EventHandler(this.rdoR1PersonnelId_CheckedChanged);
            // 
            // tpEquipment
            // 
            this.tpEquipment.Controls.Add(this.rdoR3EquipmentName);
            this.tpEquipment.Controls.Add(this.rdoR3EquipmentId);
            this.tpEquipment.Controls.Add(this.rdoR3PersonnelName);
            this.tpEquipment.Controls.Add(this.rdoR3PersonnelId);
            this.tpEquipment.Location = new System.Drawing.Point(4, 25);
            this.tpEquipment.Name = "tpEquipment";
            this.tpEquipment.Size = new System.Drawing.Size(397, 103);
            this.tpEquipment.TabIndex = 2;
            this.tpEquipment.Text = "3";
            this.tpEquipment.UseVisualStyleBackColor = true;
            // 
            // rdoR3EquipmentName
            // 
            this.rdoR3EquipmentName.AutoSize = true;
            this.rdoR3EquipmentName.Location = new System.Drawing.Point(6, 28);
            this.rdoR3EquipmentName.Name = "rdoR3EquipmentName";
            this.rdoR3EquipmentName.Size = new System.Drawing.Size(132, 20);
            this.rdoR3EquipmentName.TabIndex = 1;
            this.rdoR3EquipmentName.TabStop = true;
            this.rdoR3EquipmentName.Text = "Equipment Name";
            this.rdoR3EquipmentName.UseVisualStyleBackColor = true;
            this.rdoR3EquipmentName.CheckedChanged += new System.EventHandler(this.rdoR1PersonnelId_CheckedChanged);
            // 
            // rdoR3EquipmentId
            // 
            this.rdoR3EquipmentId.AutoSize = true;
            this.rdoR3EquipmentId.Location = new System.Drawing.Point(6, 6);
            this.rdoR3EquipmentId.Name = "rdoR3EquipmentId";
            this.rdoR3EquipmentId.Size = new System.Drawing.Size(109, 20);
            this.rdoR3EquipmentId.TabIndex = 0;
            this.rdoR3EquipmentId.TabStop = true;
            this.rdoR3EquipmentId.Text = "Equipment ID";
            this.rdoR3EquipmentId.UseVisualStyleBackColor = true;
            this.rdoR3EquipmentId.CheckedChanged += new System.EventHandler(this.rdoR1PersonnelId_CheckedChanged);
            // 
            // rdoR3PersonnelName
            // 
            this.rdoR3PersonnelName.AutoSize = true;
            this.rdoR3PersonnelName.Location = new System.Drawing.Point(6, 72);
            this.rdoR3PersonnelName.Name = "rdoR3PersonnelName";
            this.rdoR3PersonnelName.Size = new System.Drawing.Size(184, 20);
            this.rdoR3PersonnelName.TabIndex = 3;
            this.rdoR3PersonnelName.TabStop = true;
            this.rdoR3PersonnelName.Text = "Security Personnel Name";
            this.rdoR3PersonnelName.UseVisualStyleBackColor = true;
            this.rdoR3PersonnelName.CheckedChanged += new System.EventHandler(this.rdoR1PersonnelId_CheckedChanged);
            // 
            // rdoR3PersonnelId
            // 
            this.rdoR3PersonnelId.AutoSize = true;
            this.rdoR3PersonnelId.Location = new System.Drawing.Point(6, 50);
            this.rdoR3PersonnelId.Name = "rdoR3PersonnelId";
            this.rdoR3PersonnelId.Size = new System.Drawing.Size(161, 20);
            this.rdoR3PersonnelId.TabIndex = 2;
            this.rdoR3PersonnelId.TabStop = true;
            this.rdoR3PersonnelId.Text = "Security Personnel ID";
            this.rdoR3PersonnelId.UseVisualStyleBackColor = true;
            this.rdoR3PersonnelId.CheckedChanged += new System.EventHandler(this.rdoR1PersonnelId_CheckedChanged);
            // 
            // tpSectors
            // 
            this.tpSectors.Controls.Add(this.rdoR4SectorName);
            this.tpSectors.Controls.Add(this.rdoR4SectorId);
            this.tpSectors.Location = new System.Drawing.Point(4, 25);
            this.tpSectors.Name = "tpSectors";
            this.tpSectors.Size = new System.Drawing.Size(397, 103);
            this.tpSectors.TabIndex = 3;
            this.tpSectors.Text = "4";
            this.tpSectors.UseVisualStyleBackColor = true;
            // 
            // rdoR4SectorName
            // 
            this.rdoR4SectorName.AutoSize = true;
            this.rdoR4SectorName.Location = new System.Drawing.Point(6, 28);
            this.rdoR4SectorName.Name = "rdoR4SectorName";
            this.rdoR4SectorName.Size = new System.Drawing.Size(106, 20);
            this.rdoR4SectorName.TabIndex = 1;
            this.rdoR4SectorName.TabStop = true;
            this.rdoR4SectorName.Text = "Sector Name";
            this.rdoR4SectorName.UseVisualStyleBackColor = true;
            this.rdoR4SectorName.CheckedChanged += new System.EventHandler(this.rdoR1PersonnelId_CheckedChanged);
            // 
            // rdoR4SectorId
            // 
            this.rdoR4SectorId.AutoSize = true;
            this.rdoR4SectorId.Location = new System.Drawing.Point(6, 6);
            this.rdoR4SectorId.Name = "rdoR4SectorId";
            this.rdoR4SectorId.Size = new System.Drawing.Size(83, 20);
            this.rdoR4SectorId.TabIndex = 0;
            this.rdoR4SectorId.TabStop = true;
            this.rdoR4SectorId.Text = "Sector ID";
            this.rdoR4SectorId.UseVisualStyleBackColor = true;
            this.rdoR4SectorId.CheckedChanged += new System.EventHandler(this.rdoR1PersonnelId_CheckedChanged);
            // 
            // tpIncidents
            // 
            this.tpIncidents.Controls.Add(this.rdoR5NumberOfIncidents);
            this.tpIncidents.Controls.Add(this.rdoR5SectorName);
            this.tpIncidents.Controls.Add(this.rdoR5SectorId);
            this.tpIncidents.Location = new System.Drawing.Point(4, 25);
            this.tpIncidents.Name = "tpIncidents";
            this.tpIncidents.Size = new System.Drawing.Size(397, 103);
            this.tpIncidents.TabIndex = 4;
            this.tpIncidents.Text = "5";
            this.tpIncidents.UseVisualStyleBackColor = true;
            // 
            // rdoR5NumberOfIncidents
            // 
            this.rdoR5NumberOfIncidents.AutoSize = true;
            this.rdoR5NumberOfIncidents.Location = new System.Drawing.Point(6, 50);
            this.rdoR5NumberOfIncidents.Name = "rdoR5NumberOfIncidents";
            this.rdoR5NumberOfIncidents.Size = new System.Drawing.Size(150, 20);
            this.rdoR5NumberOfIncidents.TabIndex = 2;
            this.rdoR5NumberOfIncidents.TabStop = true;
            this.rdoR5NumberOfIncidents.Text = "Number of Incidents";
            this.rdoR5NumberOfIncidents.UseVisualStyleBackColor = true;
            this.rdoR5NumberOfIncidents.CheckedChanged += new System.EventHandler(this.rdoR1PersonnelId_CheckedChanged);
            // 
            // rdoR5SectorName
            // 
            this.rdoR5SectorName.AutoSize = true;
            this.rdoR5SectorName.Location = new System.Drawing.Point(6, 28);
            this.rdoR5SectorName.Name = "rdoR5SectorName";
            this.rdoR5SectorName.Size = new System.Drawing.Size(106, 20);
            this.rdoR5SectorName.TabIndex = 1;
            this.rdoR5SectorName.TabStop = true;
            this.rdoR5SectorName.Text = "Sector Name";
            this.rdoR5SectorName.UseVisualStyleBackColor = true;
            this.rdoR5SectorName.CheckedChanged += new System.EventHandler(this.rdoR1PersonnelId_CheckedChanged);
            // 
            // rdoR5SectorId
            // 
            this.rdoR5SectorId.AutoSize = true;
            this.rdoR5SectorId.Location = new System.Drawing.Point(6, 6);
            this.rdoR5SectorId.Name = "rdoR5SectorId";
            this.rdoR5SectorId.Size = new System.Drawing.Size(83, 20);
            this.rdoR5SectorId.TabIndex = 0;
            this.rdoR5SectorId.TabStop = true;
            this.rdoR5SectorId.Text = "Sector ID";
            this.rdoR5SectorId.UseVisualStyleBackColor = true;
            this.rdoR5SectorId.CheckedChanged += new System.EventHandler(this.rdoR1PersonnelId_CheckedChanged);
            // 
            // grpSortOrder
            // 
            this.grpSortOrder.Controls.Add(this.rdoDescending);
            this.grpSortOrder.Controls.Add(this.rdoAscending);
            this.grpSortOrder.Location = new System.Drawing.Point(16, 23);
            this.grpSortOrder.Name = "grpSortOrder";
            this.grpSortOrder.Size = new System.Drawing.Size(200, 150);
            this.grpSortOrder.TabIndex = 0;
            this.grpSortOrder.TabStop = false;
            this.grpSortOrder.Text = "Select order to sort:";
            // 
            // rdoDescending
            // 
            this.rdoDescending.AutoSize = true;
            this.rdoDescending.Location = new System.Drawing.Point(22, 99);
            this.rdoDescending.Name = "rdoDescending";
            this.rdoDescending.Size = new System.Drawing.Size(100, 20);
            this.rdoDescending.TabIndex = 1;
            this.rdoDescending.TabStop = true;
            this.rdoDescending.Text = "Descending";
            this.rdoDescending.UseVisualStyleBackColor = true;
            // 
            // rdoAscending
            // 
            this.rdoAscending.AutoSize = true;
            this.rdoAscending.Location = new System.Drawing.Point(22, 35);
            this.rdoAscending.Name = "rdoAscending";
            this.rdoAscending.Size = new System.Drawing.Size(91, 20);
            this.rdoAscending.TabIndex = 0;
            this.rdoAscending.TabStop = true;
            this.rdoAscending.Text = "Ascending";
            this.rdoAscending.UseVisualStyleBackColor = true;
            // 
            // grpTimePeriod
            // 
            this.grpTimePeriod.Controls.Add(this.lblEndDate);
            this.grpTimePeriod.Controls.Add(this.lblStartDate);
            this.grpTimePeriod.Controls.Add(this.dtpEndDate);
            this.grpTimePeriod.Controls.Add(this.dtpStartDate);
            this.grpTimePeriod.Location = new System.Drawing.Point(6, 22);
            this.grpTimePeriod.Name = "grpTimePeriod";
            this.grpTimePeriod.Size = new System.Drawing.Size(325, 179);
            this.grpTimePeriod.TabIndex = 0;
            this.grpTimePeriod.TabStop = false;
            this.grpTimePeriod.Text = "Select time period for report";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(11, 106);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(68, 16);
            this.lblEndDate.TabIndex = 3;
            this.lblEndDate.Text = "End date:";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(11, 41);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(73, 16);
            this.lblStartDate.TabIndex = 2;
            this.lblStartDate.Text = "Start date:";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(15, 128);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(293, 23);
            this.dtpEndDate.TabIndex = 1;
            this.dtpEndDate.ValueChanged += new System.EventHandler(this.dtpEndDate_ValueChanged);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(15, 63);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(293, 23);
            this.dtpStartDate.TabIndex = 0;
            this.dtpStartDate.Value = new System.DateTime(2019, 12, 30, 0, 0, 0, 0);
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.dtpStartDate_ValueChanged);
            // 
            // pnlReport
            // 
            this.pnlReport.Controls.Add(this.dgvReport);
            this.pnlReport.Controls.Add(this.txtNumberRecords);
            this.pnlReport.Controls.Add(this.txtReportEnd);
            this.pnlReport.Controls.Add(this.txtHeading);
            this.pnlReport.Location = new System.Drawing.Point(496, 326);
            this.pnlReport.Name = "pnlReport";
            this.pnlReport.Size = new System.Drawing.Size(1019, 440);
            this.pnlReport.TabIndex = 4;
            // 
            // dgvReport
            // 
            this.dgvReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReport.Location = new System.Drawing.Point(0, 38);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.RowHeadersWidth = 51;
            this.dgvReport.RowTemplate.Height = 24;
            this.dgvReport.Size = new System.Drawing.Size(1019, 356);
            this.dgvReport.TabIndex = 1;
            // 
            // txtNumberRecords
            // 
            this.txtNumberRecords.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumberRecords.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtNumberRecords.Location = new System.Drawing.Point(0, 394);
            this.txtNumberRecords.Name = "txtNumberRecords";
            this.txtNumberRecords.Size = new System.Drawing.Size(1019, 23);
            this.txtNumberRecords.TabIndex = 3;
            this.txtNumberRecords.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtReportEnd
            // 
            this.txtReportEnd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReportEnd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtReportEnd.Location = new System.Drawing.Point(0, 417);
            this.txtReportEnd.Name = "txtReportEnd";
            this.txtReportEnd.Size = new System.Drawing.Size(1019, 23);
            this.txtReportEnd.TabIndex = 2;
            this.txtReportEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtHeading
            // 
            this.txtHeading.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHeading.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtHeading.Location = new System.Drawing.Point(0, 0);
            this.txtHeading.Multiline = true;
            this.txtHeading.Name = "txtHeading";
            this.txtHeading.Size = new System.Drawing.Size(1019, 38);
            this.txtHeading.TabIndex = 0;
            this.txtHeading.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tmrTimeUpdate
            // 
            this.tmrTimeUpdate.Enabled = true;
            this.tmrTimeUpdate.Interval = 1000;
            this.tmrTimeUpdate.Tick += new System.EventHandler(this.tmrTimeUpdate_Tick);
            // 
            // frmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.pnlReport);
            this.Controls.Add(this.grpReportDetails);
            this.Controls.Add(this.pnlReports);
            this.Controls.Add(this.pnlSideMenu);
            this.Controls.Add(this.pnlTopMenu);
            this.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.frmReports_Load);
            this.pnlTopMenu.ResumeLayout(false);
            this.pnlTopMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHelp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlSideMenu.ResumeLayout(false);
            this.pnlReports.ResumeLayout(false);
            this.pnlReports.PerformLayout();
            this.grpReports.ResumeLayout(false);
            this.grpReports.PerformLayout();
            this.grpReportDetails.ResumeLayout(false);
            this.grpSort.ResumeLayout(false);
            this.grpSort.PerformLayout();
            this.tabSortFields.ResumeLayout(false);
            this.tpSecurityPersonnel.ResumeLayout(false);
            this.tpSecurityPersonnel.PerformLayout();
            this.tpShits.ResumeLayout(false);
            this.tpShits.PerformLayout();
            this.tpEquipment.ResumeLayout(false);
            this.tpEquipment.PerformLayout();
            this.tpSectors.ResumeLayout(false);
            this.tpSectors.PerformLayout();
            this.tpIncidents.ResumeLayout(false);
            this.tpIncidents.PerformLayout();
            this.grpSortOrder.ResumeLayout(false);
            this.grpSortOrder.PerformLayout();
            this.grpTimePeriod.ResumeLayout(false);
            this.grpTimePeriod.PerformLayout();
            this.pnlReport.ResumeLayout(false);
            this.pnlReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopMenu;
        private System.Windows.Forms.Panel pnlSideMenu;
        private System.Windows.Forms.Panel pnlReports;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.PictureBox picHome;
        private System.Windows.Forms.PictureBox picHelp;
        private System.Windows.Forms.ToolTip tipMenu;
        private System.Windows.Forms.ToolTip tipHome;
        private System.Windows.Forms.ToolTip tipHelp;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.GroupBox grpReports;
        private System.Windows.Forms.RadioButton rdoEquipment;
        private System.Windows.Forms.RadioButton rdoShift;
        private System.Windows.Forms.RadioButton rdoSecurityPersonnel;
        private System.Windows.Forms.RadioButton rdoIncidents;
        private System.Windows.Forms.RadioButton rdoSectors;
        private System.Windows.Forms.GroupBox grpReportDetails;
        private System.Windows.Forms.GroupBox grpTimePeriod;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.GroupBox grpSort;
        private System.Windows.Forms.GroupBox grpSortOrder;
        private System.Windows.Forms.RadioButton rdoDescending;
        private System.Windows.Forms.RadioButton rdoAscending;
        private System.Windows.Forms.TabControl tabSortFields;
        private System.Windows.Forms.TabPage tpSecurityPersonnel;
        private System.Windows.Forms.TabPage tpShits;
        private System.Windows.Forms.TabPage tpEquipment;
        private System.Windows.Forms.TabPage tpSectors;
        private System.Windows.Forms.TabPage tpIncidents;
        private System.Windows.Forms.Label lblSortField;
        private System.Windows.Forms.Button btnIncidents;
        private System.Windows.Forms.Button btnSectors;
        private System.Windows.Forms.Button btnEquipment;
        private System.Windows.Forms.Button btnShifts;
        private System.Windows.Forms.Button btnSecurityPersonnel;
        private System.Windows.Forms.Panel pnlReport;
        private System.Windows.Forms.TextBox txtHeading;
        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.RadioButton rdoR1IncidentsHandled;
        private System.Windows.Forms.RadioButton rdoR1HoursWorked;
        private System.Windows.Forms.RadioButton rdoR1PersonnelName;
        private System.Windows.Forms.RadioButton rdoR1PersonnelId;
        private System.Windows.Forms.TextBox txtReportEnd;
        private System.Windows.Forms.RadioButton rdoR2ShiftId;
        private System.Windows.Forms.RadioButton rdoR2NumberOfPersonnel;
        private System.Windows.Forms.RadioButton rdoR2DateTime;
        private System.Windows.Forms.RadioButton rdoR3EquipmentName;
        private System.Windows.Forms.RadioButton rdoR3EquipmentId;
        private System.Windows.Forms.RadioButton rdoR3PersonnelName;
        private System.Windows.Forms.RadioButton rdoR3PersonnelId;
        private System.Windows.Forms.RadioButton rdoR4SectorName;
        private System.Windows.Forms.RadioButton rdoR4SectorId;
        private System.Windows.Forms.RadioButton rdoR5NumberOfIncidents;
        private System.Windows.Forms.RadioButton rdoR5SectorName;
        private System.Windows.Forms.RadioButton rdoR5SectorId;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.Label lblGenerateReport;
        private System.Windows.Forms.TextBox txtNumberRecords;
        private System.Windows.Forms.Label lblReports;
        private System.Windows.Forms.Timer tmrTimeUpdate;
    }
}