namespace TemplateForm
{
    partial class frmShifts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShifts));
            this.pnlTopPanel = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblHeading = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.picHelp = new System.Windows.Forms.PictureBox();
            this.picHome = new System.Windows.Forms.PictureBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.picMenu = new System.Windows.Forms.PictureBox();
            this.pnlBottomPanel = new System.Windows.Forms.Panel();
            this.btnShiftDetails = new System.Windows.Forms.Button();
            this.btnDisplayShifts = new System.Windows.Forms.Button();
            this.btnDeleteShift = new System.Windows.Forms.Button();
            this.btnUpdateShift = new System.Windows.Forms.Button();
            this.btnCreateShift = new System.Windows.Forms.Button();
            this.dgvShiftData = new System.Windows.Forms.DataGridView();
            this.pnlSidePanel = new System.Windows.Forms.Panel();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnShift = new System.Windows.Forms.Button();
            this.btnIncidents = new System.Windows.Forms.Button();
            this.btnSectors = new System.Windows.Forms.Button();
            this.btnEquipment = new System.Windows.Forms.Button();
            this.btnSecurityPersonnel = new System.Windows.Forms.Button();
            this.tmrMenu = new System.Windows.Forms.Timer(this.components);
            this.pnlTextFieldPanel = new System.Windows.Forms.Panel();
            this.picTextFieldMoveLeft = new System.Windows.Forms.PictureBox();
            this.picTextFieldMoveRight = new System.Windows.Forms.PictureBox();
            this.tbcTextFields = new System.Windows.Forms.TabControl();
            this.tabDisplay = new System.Windows.Forms.TabPage();
            this.nudShiftDuration = new System.Windows.Forms.NumericUpDown();
            this.cmbSectors = new System.Windows.Forms.ComboBox();
            this.dtpStartTimeDate = new System.Windows.Forms.DateTimePicker();
            this.lblSector = new System.Windows.Forms.Label();
            this.lblShiftDuration = new System.Windows.Forms.Label();
            this.lblStartTimeDate = new System.Windows.Forms.Label();
            this.lblShiftID = new System.Windows.Forms.Label();
            this.txtShiftID = new System.Windows.Forms.TextBox();
            this.tabFilter = new System.Windows.Forms.TabPage();
            this.btnFilterSectors = new System.Windows.Forms.Button();
            this.btnFilterDates = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFilterEnd = new System.Windows.Forms.DateTimePicker();
            this.btnReset = new System.Windows.Forms.Button();
            this.nudFilterShiftDuration = new System.Windows.Forms.NumericUpDown();
            this.cmbFilterSectors = new System.Windows.Forms.ComboBox();
            this.dtpFilterStart = new System.Windows.Forms.DateTimePicker();
            this.txtFilterShiftID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tipMenu = new System.Windows.Forms.ToolTip(this.components);
            this.tipTextFields = new System.Windows.Forms.ToolTip(this.components);
            this.tmrTextFields = new System.Windows.Forms.Timer(this.components);
            this.tipHome = new System.Windows.Forms.ToolTip(this.components);
            this.tipHelp = new System.Windows.Forms.ToolTip(this.components);
            this.tipSearch = new System.Windows.Forms.ToolTip(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tmrTimeUpdate = new System.Windows.Forms.Timer(this.components);
            this.pnlTopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHelp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMenu)).BeginInit();
            this.pnlBottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShiftData)).BeginInit();
            this.pnlSidePanel.SuspendLayout();
            this.pnlTextFieldPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTextFieldMoveLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTextFieldMoveRight)).BeginInit();
            this.tbcTextFields.SuspendLayout();
            this.tabDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudShiftDuration)).BeginInit();
            this.tabFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFilterShiftDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTopPanel
            // 
            this.pnlTopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(222)))), ((int)(((byte)(211)))));
            this.pnlTopPanel.Controls.Add(this.btnRefresh);
            this.pnlTopPanel.Controls.Add(this.lblHeading);
            this.pnlTopPanel.Controls.Add(this.txtSearch);
            this.pnlTopPanel.Controls.Add(this.lblTime);
            this.pnlTopPanel.Controls.Add(this.lblDate);
            this.pnlTopPanel.Controls.Add(this.picHelp);
            this.pnlTopPanel.Controls.Add(this.picHome);
            this.pnlTopPanel.Controls.Add(this.picLogo);
            this.pnlTopPanel.Controls.Add(this.picMenu);
            this.pnlTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopPanel.Location = new System.Drawing.Point(0, 0);
            this.pnlTopPanel.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTopPanel.Name = "pnlTopPanel";
            this.pnlTopPanel.Size = new System.Drawing.Size(1370, 108);
            this.pnlTopPanel.TabIndex = 3;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(755, 75);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Arial", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(368, 27);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(126, 45);
            this.lblHeading.TabIndex = 9;
            this.lblHeading.Text = "Shifts";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(755, 41);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(303, 23);
            this.txtSearch.TabIndex = 7;
            this.txtSearch.Click += new System.EventHandler(this.txtSearch_Click);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(158, 49);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(53, 16);
            this.lblTime.TabIndex = 6;
            this.lblTime.Text = "label13";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(158, 28);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(53, 16);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "label13";
            // 
            // picHelp
            // 
            this.picHelp.Image = global::MainForm.Properties.Resources.Help;
            this.picHelp.Location = new System.Drawing.Point(1186, 3);
            this.picHelp.Margin = new System.Windows.Forms.Padding(4);
            this.picHelp.Name = "picHelp";
            this.picHelp.Size = new System.Drawing.Size(97, 101);
            this.picHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHelp.TabIndex = 4;
            this.picHelp.TabStop = false;
            this.picHelp.Click += new System.EventHandler(this.picHelp_Click);
            // 
            // picHome
            // 
            this.picHome.Image = global::MainForm.Properties.Resources.Home;
            this.picHome.Location = new System.Drawing.Point(1291, 4);
            this.picHome.Margin = new System.Windows.Forms.Padding(4);
            this.picHome.Name = "picHome";
            this.picHome.Size = new System.Drawing.Size(108, 101);
            this.picHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHome.TabIndex = 2;
            this.picHome.TabStop = false;
            this.picHome.Click += new System.EventHandler(this.picHome_Click);
            // 
            // picLogo
            // 
            this.picLogo.Image = global::MainForm.Properties.Resources.Eagle_Eye_Logo;
            this.picLogo.Location = new System.Drawing.Point(1406, 0);
            this.picLogo.Margin = new System.Windows.Forms.Padding(4);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(108, 104);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;
            // 
            // picMenu
            // 
            this.picMenu.Image = global::MainForm.Properties.Resources.Menu;
            this.picMenu.Location = new System.Drawing.Point(14, 14);
            this.picMenu.Margin = new System.Windows.Forms.Padding(4);
            this.picMenu.Name = "picMenu";
            this.picMenu.Size = new System.Drawing.Size(112, 71);
            this.picMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMenu.TabIndex = 0;
            this.picMenu.TabStop = false;
            this.picMenu.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pnlBottomPanel
            // 
            this.pnlBottomPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(136)))), ((int)(((byte)(125)))));
            this.pnlBottomPanel.Controls.Add(this.btnShiftDetails);
            this.pnlBottomPanel.Controls.Add(this.btnDisplayShifts);
            this.pnlBottomPanel.Controls.Add(this.btnDeleteShift);
            this.pnlBottomPanel.Controls.Add(this.btnUpdateShift);
            this.pnlBottomPanel.Controls.Add(this.btnCreateShift);
            this.pnlBottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottomPanel.Location = new System.Drawing.Point(0, 627);
            this.pnlBottomPanel.Margin = new System.Windows.Forms.Padding(4);
            this.pnlBottomPanel.Name = "pnlBottomPanel";
            this.pnlBottomPanel.Size = new System.Drawing.Size(1370, 122);
            this.pnlBottomPanel.TabIndex = 1;
            // 
            // btnShiftDetails
            // 
            this.btnShiftDetails.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShiftDetails.Location = new System.Drawing.Point(783, 38);
            this.btnShiftDetails.Margin = new System.Windows.Forms.Padding(4);
            this.btnShiftDetails.Name = "btnShiftDetails";
            this.btnShiftDetails.Size = new System.Drawing.Size(150, 59);
            this.btnShiftDetails.TabIndex = 4;
            this.btnShiftDetails.Text = "Display Shift Details";
            this.btnShiftDetails.UseVisualStyleBackColor = true;
            this.btnShiftDetails.Click += new System.EventHandler(this.btnShiftDetails_Click);
            // 
            // btnDisplayShifts
            // 
            this.btnDisplayShifts.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayShifts.Location = new System.Drawing.Point(993, 38);
            this.btnDisplayShifts.Margin = new System.Windows.Forms.Padding(4);
            this.btnDisplayShifts.Name = "btnDisplayShifts";
            this.btnDisplayShifts.Size = new System.Drawing.Size(150, 59);
            this.btnDisplayShifts.TabIndex = 3;
            this.btnDisplayShifts.Text = "Display Shifts";
            this.btnDisplayShifts.UseVisualStyleBackColor = true;
            this.btnDisplayShifts.Click += new System.EventHandler(this.btnDisplayShifts_Click);
            // 
            // btnDeleteShift
            // 
            this.btnDeleteShift.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteShift.Location = new System.Drawing.Point(409, 38);
            this.btnDeleteShift.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteShift.Name = "btnDeleteShift";
            this.btnDeleteShift.Size = new System.Drawing.Size(150, 59);
            this.btnDeleteShift.TabIndex = 2;
            this.btnDeleteShift.Text = "Delete Shift";
            this.btnDeleteShift.UseVisualStyleBackColor = true;
            this.btnDeleteShift.Click += new System.EventHandler(this.btnDeleteShift_Click);
            // 
            // btnUpdateShift
            // 
            this.btnUpdateShift.Enabled = false;
            this.btnUpdateShift.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateShift.Location = new System.Drawing.Point(222, 38);
            this.btnUpdateShift.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateShift.Name = "btnUpdateShift";
            this.btnUpdateShift.Size = new System.Drawing.Size(150, 59);
            this.btnUpdateShift.TabIndex = 1;
            this.btnUpdateShift.Text = "Update Shift Details";
            this.btnUpdateShift.UseVisualStyleBackColor = true;
            this.btnUpdateShift.Click += new System.EventHandler(this.btnUpdateShift_Click);
            // 
            // btnCreateShift
            // 
            this.btnCreateShift.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateShift.Location = new System.Drawing.Point(35, 38);
            this.btnCreateShift.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateShift.Name = "btnCreateShift";
            this.btnCreateShift.Size = new System.Drawing.Size(150, 59);
            this.btnCreateShift.TabIndex = 0;
            this.btnCreateShift.Text = "Create New Shift";
            this.btnCreateShift.UseVisualStyleBackColor = true;
            this.btnCreateShift.Click += new System.EventHandler(this.btnCreateShift_Click);
            // 
            // dgvShiftData
            // 
            this.dgvShiftData.AllowUserToAddRows = false;
            this.dgvShiftData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvShiftData.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvShiftData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShiftData.Location = new System.Drawing.Point(689, 132);
            this.dgvShiftData.Margin = new System.Windows.Forms.Padding(4);
            this.dgvShiftData.Name = "dgvShiftData";
            this.dgvShiftData.RowHeadersWidth = 51;
            this.dgvShiftData.RowTemplate.Height = 24;
            this.dgvShiftData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShiftData.Size = new System.Drawing.Size(825, 501);
            this.dgvShiftData.TabIndex = 2;
            this.dgvShiftData.SelectionChanged += new System.EventHandler(this.dgvShiftData_SelectionChanged);
            // 
            // pnlSidePanel
            // 
            this.pnlSidePanel.BackColor = System.Drawing.Color.Silver;
            this.pnlSidePanel.Controls.Add(this.btnReports);
            this.pnlSidePanel.Controls.Add(this.btnShift);
            this.pnlSidePanel.Controls.Add(this.btnIncidents);
            this.pnlSidePanel.Controls.Add(this.btnSectors);
            this.pnlSidePanel.Controls.Add(this.btnEquipment);
            this.pnlSidePanel.Controls.Add(this.btnSecurityPersonnel);
            this.pnlSidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidePanel.Location = new System.Drawing.Point(0, 108);
            this.pnlSidePanel.Margin = new System.Windows.Forms.Padding(4);
            this.pnlSidePanel.Name = "pnlSidePanel";
            this.pnlSidePanel.Size = new System.Drawing.Size(185, 519);
            this.pnlSidePanel.TabIndex = 3;
            // 
            // btnReports
            // 
            this.btnReports.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.Location = new System.Drawing.Point(14, 466);
            this.btnReports.Margin = new System.Windows.Forms.Padding(4);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(150, 59);
            this.btnReports.TabIndex = 16;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnShift
            // 
            this.btnShift.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShift.Location = new System.Drawing.Point(14, 109);
            this.btnShift.Margin = new System.Windows.Forms.Padding(4);
            this.btnShift.Name = "btnShift";
            this.btnShift.Size = new System.Drawing.Size(150, 59);
            this.btnShift.TabIndex = 15;
            this.btnShift.Text = "Shifts";
            this.btnShift.UseVisualStyleBackColor = true;
            this.btnShift.Click += new System.EventHandler(this.btnShift_Click);
            // 
            // btnIncidents
            // 
            this.btnIncidents.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncidents.Location = new System.Drawing.Point(14, 378);
            this.btnIncidents.Margin = new System.Windows.Forms.Padding(4);
            this.btnIncidents.Name = "btnIncidents";
            this.btnIncidents.Size = new System.Drawing.Size(150, 59);
            this.btnIncidents.TabIndex = 14;
            this.btnIncidents.Text = "Incidents";
            this.btnIncidents.UseVisualStyleBackColor = true;
            this.btnIncidents.Click += new System.EventHandler(this.btnIncidents_Click);
            // 
            // btnSectors
            // 
            this.btnSectors.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSectors.Location = new System.Drawing.Point(14, 288);
            this.btnSectors.Margin = new System.Windows.Forms.Padding(4);
            this.btnSectors.Name = "btnSectors";
            this.btnSectors.Size = new System.Drawing.Size(150, 59);
            this.btnSectors.TabIndex = 13;
            this.btnSectors.Text = "Sectors";
            this.btnSectors.UseVisualStyleBackColor = true;
            this.btnSectors.Click += new System.EventHandler(this.btnSectors_Click);
            // 
            // btnEquipment
            // 
            this.btnEquipment.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquipment.Location = new System.Drawing.Point(14, 198);
            this.btnEquipment.Margin = new System.Windows.Forms.Padding(4);
            this.btnEquipment.Name = "btnEquipment";
            this.btnEquipment.Size = new System.Drawing.Size(150, 59);
            this.btnEquipment.TabIndex = 12;
            this.btnEquipment.Text = "Equipment";
            this.btnEquipment.UseVisualStyleBackColor = true;
            this.btnEquipment.Click += new System.EventHandler(this.btnEquipment_Click);
            // 
            // btnSecurityPersonnel
            // 
            this.btnSecurityPersonnel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSecurityPersonnel.Location = new System.Drawing.Point(14, 20);
            this.btnSecurityPersonnel.Margin = new System.Windows.Forms.Padding(4);
            this.btnSecurityPersonnel.Name = "btnSecurityPersonnel";
            this.btnSecurityPersonnel.Size = new System.Drawing.Size(150, 59);
            this.btnSecurityPersonnel.TabIndex = 11;
            this.btnSecurityPersonnel.Text = "Security Personnel";
            this.btnSecurityPersonnel.UseVisualStyleBackColor = true;
            this.btnSecurityPersonnel.Click += new System.EventHandler(this.btnSecurityPersonnel_Click);
            // 
            // tmrMenu
            // 
            this.tmrMenu.Interval = 50;
            this.tmrMenu.Tick += new System.EventHandler(this.tmrMenu_Tick);
            // 
            // pnlTextFieldPanel
            // 
            this.pnlTextFieldPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlTextFieldPanel.Controls.Add(this.picTextFieldMoveLeft);
            this.pnlTextFieldPanel.Controls.Add(this.picTextFieldMoveRight);
            this.pnlTextFieldPanel.Controls.Add(this.tbcTextFields);
            this.pnlTextFieldPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTextFieldPanel.Location = new System.Drawing.Point(185, 108);
            this.pnlTextFieldPanel.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTextFieldPanel.Name = "pnlTextFieldPanel";
            this.pnlTextFieldPanel.Size = new System.Drawing.Size(433, 519);
            this.pnlTextFieldPanel.TabIndex = 5;
            // 
            // picTextFieldMoveLeft
            // 
            this.picTextFieldMoveLeft.Dock = System.Windows.Forms.DockStyle.Right;
            this.picTextFieldMoveLeft.Image = ((System.Drawing.Image)(resources.GetObject("picTextFieldMoveLeft.Image")));
            this.picTextFieldMoveLeft.Location = new System.Drawing.Point(361, 0);
            this.picTextFieldMoveLeft.Margin = new System.Windows.Forms.Padding(4);
            this.picTextFieldMoveLeft.Name = "picTextFieldMoveLeft";
            this.picTextFieldMoveLeft.Size = new System.Drawing.Size(36, 519);
            this.picTextFieldMoveLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTextFieldMoveLeft.TabIndex = 1;
            this.picTextFieldMoveLeft.TabStop = false;
            this.picTextFieldMoveLeft.Click += new System.EventHandler(this.picTextFieldMoveLeft_Click);
            // 
            // picTextFieldMoveRight
            // 
            this.picTextFieldMoveRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.picTextFieldMoveRight.Image = ((System.Drawing.Image)(resources.GetObject("picTextFieldMoveRight.Image")));
            this.picTextFieldMoveRight.Location = new System.Drawing.Point(397, 0);
            this.picTextFieldMoveRight.Margin = new System.Windows.Forms.Padding(4);
            this.picTextFieldMoveRight.Name = "picTextFieldMoveRight";
            this.picTextFieldMoveRight.Size = new System.Drawing.Size(36, 519);
            this.picTextFieldMoveRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTextFieldMoveRight.TabIndex = 0;
            this.picTextFieldMoveRight.TabStop = false;
            this.picTextFieldMoveRight.Click += new System.EventHandler(this.picTextFieldMove_Click);
            // 
            // tbcTextFields
            // 
            this.tbcTextFields.Controls.Add(this.tabDisplay);
            this.tbcTextFields.Controls.Add(this.tabFilter);
            this.tbcTextFields.Location = new System.Drawing.Point(0, 0);
            this.tbcTextFields.Name = "tbcTextFields";
            this.tbcTextFields.SelectedIndex = 0;
            this.tbcTextFields.Size = new System.Drawing.Size(360, 548);
            this.tbcTextFields.TabIndex = 2;
            // 
            // tabDisplay
            // 
            this.tabDisplay.Controls.Add(this.nudShiftDuration);
            this.tabDisplay.Controls.Add(this.cmbSectors);
            this.tabDisplay.Controls.Add(this.dtpStartTimeDate);
            this.tabDisplay.Controls.Add(this.lblSector);
            this.tabDisplay.Controls.Add(this.lblShiftDuration);
            this.tabDisplay.Controls.Add(this.lblStartTimeDate);
            this.tabDisplay.Controls.Add(this.lblShiftID);
            this.tabDisplay.Controls.Add(this.txtShiftID);
            this.tabDisplay.Location = new System.Drawing.Point(4, 25);
            this.tabDisplay.Name = "tabDisplay";
            this.tabDisplay.Padding = new System.Windows.Forms.Padding(3);
            this.tabDisplay.Size = new System.Drawing.Size(352, 519);
            this.tabDisplay.TabIndex = 0;
            this.tabDisplay.Text = "Update Shift";
            this.tabDisplay.UseVisualStyleBackColor = true;
            // 
            // nudShiftDuration
            // 
            this.nudShiftDuration.DecimalPlaces = 2;
            this.nudShiftDuration.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudShiftDuration.Location = new System.Drawing.Point(105, 176);
            this.nudShiftDuration.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.nudShiftDuration.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudShiftDuration.Name = "nudShiftDuration";
            this.nudShiftDuration.Size = new System.Drawing.Size(202, 23);
            this.nudShiftDuration.TabIndex = 34;
            this.nudShiftDuration.ThousandsSeparator = true;
            this.nudShiftDuration.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudShiftDuration.ValueChanged += new System.EventHandler(this.nudShiftDuration_ValueChanged);
            // 
            // cmbSectors
            // 
            this.cmbSectors.FormattingEnabled = true;
            this.cmbSectors.Location = new System.Drawing.Point(105, 244);
            this.cmbSectors.Name = "cmbSectors";
            this.cmbSectors.Size = new System.Drawing.Size(202, 24);
            this.cmbSectors.TabIndex = 33;
            this.cmbSectors.SelectedIndexChanged += new System.EventHandler(this.cmbSectors_SelectedIndexChanged);
            // 
            // dtpStartTimeDate
            // 
            this.dtpStartTimeDate.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dtpStartTimeDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartTimeDate.Location = new System.Drawing.Point(105, 108);
            this.dtpStartTimeDate.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.dtpStartTimeDate.Name = "dtpStartTimeDate";
            this.dtpStartTimeDate.Size = new System.Drawing.Size(202, 23);
            this.dtpStartTimeDate.TabIndex = 30;
            this.dtpStartTimeDate.ValueChanged += new System.EventHandler(this.dtpStartTimeDate_ValueChanged);
            // 
            // lblSector
            // 
            this.lblSector.AutoSize = true;
            this.lblSector.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSector.Location = new System.Drawing.Point(7, 244);
            this.lblSector.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSector.Name = "lblSector";
            this.lblSector.Size = new System.Drawing.Size(48, 16);
            this.lblSector.TabIndex = 29;
            this.lblSector.Text = "Sector";
            // 
            // lblShiftDuration
            // 
            this.lblShiftDuration.AutoSize = true;
            this.lblShiftDuration.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShiftDuration.Location = new System.Drawing.Point(7, 176);
            this.lblShiftDuration.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblShiftDuration.Name = "lblShiftDuration";
            this.lblShiftDuration.Size = new System.Drawing.Size(61, 32);
            this.lblShiftDuration.TabIndex = 25;
            this.lblShiftDuration.Text = "Duration\r\nof Shift";
            // 
            // lblStartTimeDate
            // 
            this.lblStartTimeDate.AutoSize = true;
            this.lblStartTimeDate.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartTimeDate.Location = new System.Drawing.Point(7, 108);
            this.lblStartTimeDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStartTimeDate.Name = "lblStartTimeDate";
            this.lblStartTimeDate.Size = new System.Drawing.Size(71, 32);
            this.lblStartTimeDate.TabIndex = 23;
            this.lblStartTimeDate.Text = "Start Time\r\nand Date";
            // 
            // lblShiftID
            // 
            this.lblShiftID.AutoSize = true;
            this.lblShiftID.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShiftID.Location = new System.Drawing.Point(7, 40);
            this.lblShiftID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblShiftID.Name = "lblShiftID";
            this.lblShiftID.Size = new System.Drawing.Size(52, 16);
            this.lblShiftID.TabIndex = 21;
            this.lblShiftID.Text = "Shift ID";
            // 
            // txtShiftID
            // 
            this.txtShiftID.Enabled = false;
            this.txtShiftID.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShiftID.Location = new System.Drawing.Point(104, 37);
            this.txtShiftID.Margin = new System.Windows.Forms.Padding(4);
            this.txtShiftID.Name = "txtShiftID";
            this.txtShiftID.ReadOnly = true;
            this.txtShiftID.Size = new System.Drawing.Size(202, 23);
            this.txtShiftID.TabIndex = 20;
            // 
            // tabFilter
            // 
            this.tabFilter.Controls.Add(this.btnFilterSectors);
            this.tabFilter.Controls.Add(this.btnFilterDates);
            this.tabFilter.Controls.Add(this.label2);
            this.tabFilter.Controls.Add(this.label1);
            this.tabFilter.Controls.Add(this.dtpFilterEnd);
            this.tabFilter.Controls.Add(this.btnReset);
            this.tabFilter.Controls.Add(this.nudFilterShiftDuration);
            this.tabFilter.Controls.Add(this.cmbFilterSectors);
            this.tabFilter.Controls.Add(this.dtpFilterStart);
            this.tabFilter.Controls.Add(this.txtFilterShiftID);
            this.tabFilter.Controls.Add(this.label6);
            this.tabFilter.Controls.Add(this.label8);
            this.tabFilter.Controls.Add(this.label10);
            this.tabFilter.Location = new System.Drawing.Point(4, 25);
            this.tabFilter.Name = "tabFilter";
            this.tabFilter.Padding = new System.Windows.Forms.Padding(3);
            this.tabFilter.Size = new System.Drawing.Size(352, 519);
            this.tabFilter.TabIndex = 1;
            this.tabFilter.Text = "Filter Shift";
            this.tabFilter.UseVisualStyleBackColor = true;
            // 
            // btnFilterSectors
            // 
            this.btnFilterSectors.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilterSectors.Location = new System.Drawing.Point(88, 322);
            this.btnFilterSectors.Margin = new System.Windows.Forms.Padding(4);
            this.btnFilterSectors.Name = "btnFilterSectors";
            this.btnFilterSectors.Size = new System.Drawing.Size(150, 32);
            this.btnFilterSectors.TabIndex = 44;
            this.btnFilterSectors.Text = "Filter Sectors";
            this.btnFilterSectors.UseVisualStyleBackColor = true;
            this.btnFilterSectors.Click += new System.EventHandler(this.btnFilterSectors_Click);
            // 
            // btnFilterDates
            // 
            this.btnFilterDates.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilterDates.Location = new System.Drawing.Point(88, 165);
            this.btnFilterDates.Margin = new System.Windows.Forms.Padding(4);
            this.btnFilterDates.Name = "btnFilterDates";
            this.btnFilterDates.Size = new System.Drawing.Size(150, 32);
            this.btnFilterDates.TabIndex = 43;
            this.btnFilterDates.Text = "Filter Dates";
            this.btnFilterDates.UseVisualStyleBackColor = true;
            this.btnFilterDates.Click += new System.EventHandler(this.btnFilterDates_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 16);
            this.label2.TabIndex = 42;
            this.label2.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 41;
            this.label1.Text = "Between Dates";
            // 
            // dtpFilterEnd
            // 
            this.dtpFilterEnd.CustomFormat = "yyyy-MM-dd";
            this.dtpFilterEnd.Enabled = false;
            this.dtpFilterEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFilterEnd.Location = new System.Drawing.Point(171, 120);
            this.dtpFilterEnd.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.dtpFilterEnd.Name = "dtpFilterEnd";
            this.dtpFilterEnd.Size = new System.Drawing.Size(133, 23);
            this.dtpFilterEnd.TabIndex = 40;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(88, 400);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(150, 59);
            this.btnReset.TabIndex = 16;
            this.btnReset.Text = "Reset Filters";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // nudFilterShiftDuration
            // 
            this.nudFilterShiftDuration.DecimalPlaces = 2;
            this.nudFilterShiftDuration.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudFilterShiftDuration.Location = new System.Drawing.Point(105, 224);
            this.nudFilterShiftDuration.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.nudFilterShiftDuration.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudFilterShiftDuration.Name = "nudFilterShiftDuration";
            this.nudFilterShiftDuration.Size = new System.Drawing.Size(202, 23);
            this.nudFilterShiftDuration.TabIndex = 39;
            this.nudFilterShiftDuration.ThousandsSeparator = true;
            this.nudFilterShiftDuration.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudFilterShiftDuration.ValueChanged += new System.EventHandler(this.nudFilterShiftDuration_ValueChanged);
            // 
            // cmbFilterSectors
            // 
            this.cmbFilterSectors.FormattingEnabled = true;
            this.cmbFilterSectors.Location = new System.Drawing.Point(105, 288);
            this.cmbFilterSectors.Name = "cmbFilterSectors";
            this.cmbFilterSectors.Size = new System.Drawing.Size(184, 24);
            this.cmbFilterSectors.TabIndex = 38;
            // 
            // dtpFilterStart
            // 
            this.dtpFilterStart.CustomFormat = "yyyy-MM-dd";
            this.dtpFilterStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFilterStart.Location = new System.Drawing.Point(11, 120);
            this.dtpFilterStart.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.dtpFilterStart.Name = "dtpFilterStart";
            this.dtpFilterStart.Size = new System.Drawing.Size(133, 23);
            this.dtpFilterStart.TabIndex = 36;
            this.dtpFilterStart.ValueChanged += new System.EventHandler(this.dtpFilterStart_ValueChanged);
            // 
            // txtFilterShiftID
            // 
            this.txtFilterShiftID.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilterShiftID.Location = new System.Drawing.Point(105, 44);
            this.txtFilterShiftID.Margin = new System.Windows.Forms.Padding(4);
            this.txtFilterShiftID.Name = "txtFilterShiftID";
            this.txtFilterShiftID.Size = new System.Drawing.Size(202, 23);
            this.txtFilterShiftID.TabIndex = 35;
            this.txtFilterShiftID.TextChanged += new System.EventHandler(this.txtFilterShiftID_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 288);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 16);
            this.label6.TabIndex = 29;
            this.label6.Text = "Sector";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 224);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 32);
            this.label8.TabIndex = 25;
            this.label8.Text = "Duration\r\nof Shift";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(7, 41);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 16);
            this.label10.TabIndex = 21;
            this.label10.Text = "Shift ID";
            // 
            // tmrTextFields
            // 
            this.tmrTextFields.Interval = 50;
            this.tmrTextFields.Tick += new System.EventHandler(this.tmrTextFields_Tick);
            // 
            // tmrTimeUpdate
            // 
            this.tmrTimeUpdate.Enabled = true;
            this.tmrTimeUpdate.Interval = 1000;
            this.tmrTimeUpdate.Tick += new System.EventHandler(this.tmrTimeUpdate_Tick);
            // 
            // frmShifts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.pnlTextFieldPanel);
            this.Controls.Add(this.pnlSidePanel);
            this.Controls.Add(this.dgvShiftData);
            this.Controls.Add(this.pnlBottomPanel);
            this.Controls.Add(this.pnlTopPanel);
            this.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmShifts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shifts";
            this.Load += new System.EventHandler(this.frmTemplate_Load);
            this.Shown += new System.EventHandler(this.frmShifts_Shown);
            this.pnlTopPanel.ResumeLayout(false);
            this.pnlTopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHelp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMenu)).EndInit();
            this.pnlBottomPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShiftData)).EndInit();
            this.pnlSidePanel.ResumeLayout(false);
            this.pnlTextFieldPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picTextFieldMoveLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTextFieldMoveRight)).EndInit();
            this.tbcTextFields.ResumeLayout(false);
            this.tabDisplay.ResumeLayout(false);
            this.tabDisplay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudShiftDuration)).EndInit();
            this.tabFilter.ResumeLayout(false);
            this.tabFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFilterShiftDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Panel pnlTopPanel;
        private System.Windows.Forms.Panel pnlBottomPanel;
        private System.Windows.Forms.Button btnCreateShift;
        private System.Windows.Forms.Button btnDeleteShift;
        private System.Windows.Forms.Button btnUpdateShift;
        private System.Windows.Forms.DataGridView dgvShiftData;
        private System.Windows.Forms.Panel pnlSidePanel;
        private System.Windows.Forms.PictureBox picMenu;
        private System.Windows.Forms.Timer tmrMenu;
        private System.Windows.Forms.Button btnSecurityPersonnel;
        private System.Windows.Forms.Button btnIncidents;
        private System.Windows.Forms.Button btnSectors;
        private System.Windows.Forms.Button btnEquipment;
        private System.Windows.Forms.Panel pnlTextFieldPanel;
        private System.Windows.Forms.PictureBox picTextFieldMoveRight;
        private System.Windows.Forms.ToolTip tipMenu;
        private System.Windows.Forms.ToolTip tipTextFields;
        private System.Windows.Forms.Timer tmrTextFields;
        private System.Windows.Forms.PictureBox picTextFieldMoveLeft;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.PictureBox picHome;
        private System.Windows.Forms.PictureBox picHelp;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ToolTip tipHome;
        private System.Windows.Forms.ToolTip tipHelp;
        private System.Windows.Forms.ToolTip tipSearch;
        private System.Windows.Forms.TabControl tbcTextFields;
        private System.Windows.Forms.TabPage tabDisplay;
        private System.Windows.Forms.Label lblSector;
        private System.Windows.Forms.Label lblShiftDuration;
        private System.Windows.Forms.Label lblStartTimeDate;
        private System.Windows.Forms.Label lblShiftID;
        private System.Windows.Forms.TextBox txtShiftID;
        private System.Windows.Forms.TabPage tabFilter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpStartTimeDate;
        private System.Windows.Forms.ComboBox cmbSectors;
        private System.Windows.Forms.NumericUpDown nudShiftDuration;
        private System.Windows.Forms.NumericUpDown nudFilterShiftDuration;
        private System.Windows.Forms.ComboBox cmbFilterSectors;
        private System.Windows.Forms.DateTimePicker dtpFilterStart;
        private System.Windows.Forms.TextBox txtFilterShiftID;
        private System.Windows.Forms.Button btnShift;
        private System.Windows.Forms.Button btnDisplayShifts;
        private System.Windows.Forms.Button btnShiftDetails;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnFilterDates;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFilterEnd;
        private System.Windows.Forms.Button btnFilterSectors;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Timer tmrTimeUpdate;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Button btnRefresh;
    }
}

