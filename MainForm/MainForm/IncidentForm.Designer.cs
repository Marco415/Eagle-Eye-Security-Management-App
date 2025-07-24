namespace TemplateForm
{
    partial class frmIncidents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIncidents));
            this.pnlTopPanel = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblHeading = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.picHelp = new System.Windows.Forms.PictureBox();
            this.picHome = new System.Windows.Forms.PictureBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.picMenu = new System.Windows.Forms.PictureBox();
            this.pnlBottomPanel = new System.Windows.Forms.Panel();
            this.btnDisplayType = new System.Windows.Forms.Button();
            this.btnDisplayIncidents = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
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
            this.tabCtrlFields = new System.Windows.Forms.TabControl();
            this.tabDisplayRecords = new System.Windows.Forms.TabPage();
            this.lblPersonnelLastName = new System.Windows.Forms.Label();
            this.cbxLastN = new System.Windows.Forms.ComboBox();
            this.lblShiftDateAndTime = new System.Windows.Forms.Label();
            this.cbxShift = new System.Windows.Forms.ComboBox();
            this.lblSectorName = new System.Windows.Forms.Label();
            this.cbxSector = new System.Windows.Forms.ComboBox();
            this.lblIncidentTypeName = new System.Windows.Forms.Label();
            this.cbxTypeName = new System.Windows.Forms.ComboBox();
            this.rtbSummary = new System.Windows.Forms.RichTextBox();
            this.lblSummary = new System.Windows.Forms.Label();
            this.lblDisplayFirstName = new System.Windows.Forms.Label();
            this.txtIncident_ID = new System.Windows.Forms.TextBox();
            this.tabFilterRecords = new System.Windows.Forms.TabPage();
            this.txtDescriptionF = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCodeF = new System.Windows.Forms.TextBox();
            this.txtNameF = new System.Windows.Forms.TextBox();
            this.tabDisplayType = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTypeID = new System.Windows.Forms.TextBox();
            this.lblTypeDescription = new System.Windows.Forms.Label();
            this.txtTypeDescription = new System.Windows.Forms.TextBox();
            this.lblTypeName = new System.Windows.Forms.Label();
            this.lblIncidentTypeCode = new System.Windows.Forms.Label();
            this.txtIncidentTypeCode = new System.Windows.Forms.TextBox();
            this.txtTypeName = new System.Windows.Forms.TextBox();
            this.tipMenu = new System.Windows.Forms.ToolTip(this.components);
            this.tipTextFields = new System.Windows.Forms.ToolTip(this.components);
            this.tmrTextFields = new System.Windows.Forms.Timer(this.components);
            this.tipHome = new System.Windows.Forms.ToolTip(this.components);
            this.tipBack = new System.Windows.Forms.ToolTip(this.components);
            this.tipHelp = new System.Windows.Forms.ToolTip(this.components);
            this.tipSearch = new System.Windows.Forms.ToolTip(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dgvData1 = new System.Windows.Forms.DataGridView();
            this.tmrTimeUpdate = new System.Windows.Forms.Timer(this.components);
            this.pnlTopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHelp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMenu)).BeginInit();
            this.pnlBottomPanel.SuspendLayout();
            this.pnlSidePanel.SuspendLayout();
            this.pnlTextFieldPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTextFieldMoveLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTextFieldMoveRight)).BeginInit();
            this.tabCtrlFields.SuspendLayout();
            this.tabDisplayRecords.SuspendLayout();
            this.tabFilterRecords.SuspendLayout();
            this.tabDisplayType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTopPanel
            // 
            this.pnlTopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(222)))), ((int)(((byte)(211)))));
            this.pnlTopPanel.Controls.Add(this.btnRefresh);
            this.pnlTopPanel.Controls.Add(this.txtSearch);
            this.pnlTopPanel.Controls.Add(this.lblHeading);
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
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(755, 41);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(303, 23);
            this.txtSearch.TabIndex = 9;
            this.txtSearch.Click += new System.EventHandler(this.txtSearch_Click);
            this.txtSearch.TextChanged += new System.EventHandler(this.textSearch_TextChanged);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Arial", 28F, System.Drawing.FontStyle.Bold);
            this.lblHeading.Location = new System.Drawing.Point(368, 27);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(187, 45);
            this.lblHeading.TabIndex = 8;
            this.lblHeading.Text = "Incidents";
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
            this.picHelp.Image = ((System.Drawing.Image)(resources.GetObject("picHelp.Image")));
            this.picHelp.Location = new System.Drawing.Point(1186, 4);
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
            this.picHome.Image = ((System.Drawing.Image)(resources.GetObject("picHome.Image")));
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
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
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
            this.picMenu.Image = ((System.Drawing.Image)(resources.GetObject("picMenu.Image")));
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
            this.pnlBottomPanel.Controls.Add(this.btnDisplayType);
            this.pnlBottomPanel.Controls.Add(this.btnDisplayIncidents);
            this.pnlBottomPanel.Controls.Add(this.btnDelete);
            this.pnlBottomPanel.Controls.Add(this.btnUpdate);
            this.pnlBottomPanel.Controls.Add(this.btnInsert);
            this.pnlBottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottomPanel.Location = new System.Drawing.Point(0, 627);
            this.pnlBottomPanel.Margin = new System.Windows.Forms.Padding(4);
            this.pnlBottomPanel.Name = "pnlBottomPanel";
            this.pnlBottomPanel.Size = new System.Drawing.Size(1370, 122);
            this.pnlBottomPanel.TabIndex = 1;
            // 
            // btnDisplayType
            // 
            this.btnDisplayType.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayType.Location = new System.Drawing.Point(774, 30);
            this.btnDisplayType.Margin = new System.Windows.Forms.Padding(4);
            this.btnDisplayType.Name = "btnDisplayType";
            this.btnDisplayType.Size = new System.Drawing.Size(150, 65);
            this.btnDisplayType.TabIndex = 12;
            this.btnDisplayType.Text = "Display Incidents Type";
            this.btnDisplayType.UseVisualStyleBackColor = true;
            this.btnDisplayType.Click += new System.EventHandler(this.btnDisplayType_Click);
            // 
            // btnDisplayIncidents
            // 
            this.btnDisplayIncidents.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayIncidents.Location = new System.Drawing.Point(637, 30);
            this.btnDisplayIncidents.Margin = new System.Windows.Forms.Padding(4);
            this.btnDisplayIncidents.Name = "btnDisplayIncidents";
            this.btnDisplayIncidents.Size = new System.Drawing.Size(129, 65);
            this.btnDisplayIncidents.TabIndex = 11;
            this.btnDisplayIncidents.Text = "Display Incidents";
            this.btnDisplayIncidents.UseVisualStyleBackColor = true;
            this.btnDisplayIncidents.Click += new System.EventHandler(this.btnDisplayIncidents_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(332, 30);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(150, 65);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete Incidents";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(174, 29);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(150, 65);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update Incidents";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(16, 29);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(150, 65);
            this.btnInsert.TabIndex = 1;
            this.btnInsert.Text = "Insert Incidents";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
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
            this.btnReports.Location = new System.Drawing.Point(17, 468);
            this.btnReports.Margin = new System.Windows.Forms.Padding(4);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(150, 59);
            this.btnReports.TabIndex = 22;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnShift
            // 
            this.btnShift.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShift.Location = new System.Drawing.Point(17, 111);
            this.btnShift.Margin = new System.Windows.Forms.Padding(4);
            this.btnShift.Name = "btnShift";
            this.btnShift.Size = new System.Drawing.Size(150, 59);
            this.btnShift.TabIndex = 21;
            this.btnShift.Text = "Shifts";
            this.btnShift.UseVisualStyleBackColor = true;
            this.btnShift.Click += new System.EventHandler(this.btnShift_Click);
            // 
            // btnIncidents
            // 
            this.btnIncidents.Enabled = false;
            this.btnIncidents.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncidents.Location = new System.Drawing.Point(17, 380);
            this.btnIncidents.Margin = new System.Windows.Forms.Padding(4);
            this.btnIncidents.Name = "btnIncidents";
            this.btnIncidents.Size = new System.Drawing.Size(150, 59);
            this.btnIncidents.TabIndex = 20;
            this.btnIncidents.Text = "Incidents";
            this.btnIncidents.UseVisualStyleBackColor = true;
            this.btnIncidents.Click += new System.EventHandler(this.btnIncidents_Click);
            // 
            // btnSectors
            // 
            this.btnSectors.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSectors.Location = new System.Drawing.Point(17, 290);
            this.btnSectors.Margin = new System.Windows.Forms.Padding(4);
            this.btnSectors.Name = "btnSectors";
            this.btnSectors.Size = new System.Drawing.Size(150, 59);
            this.btnSectors.TabIndex = 19;
            this.btnSectors.Text = "Sectors";
            this.btnSectors.UseVisualStyleBackColor = true;
            this.btnSectors.Click += new System.EventHandler(this.btnSectors_Click);
            // 
            // btnEquipment
            // 
            this.btnEquipment.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquipment.Location = new System.Drawing.Point(17, 200);
            this.btnEquipment.Margin = new System.Windows.Forms.Padding(4);
            this.btnEquipment.Name = "btnEquipment";
            this.btnEquipment.Size = new System.Drawing.Size(150, 59);
            this.btnEquipment.TabIndex = 18;
            this.btnEquipment.Text = "Equipment";
            this.btnEquipment.UseVisualStyleBackColor = true;
            this.btnEquipment.Click += new System.EventHandler(this.btnEquipment_Click);
            // 
            // btnSecurityPersonnel
            // 
            this.btnSecurityPersonnel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSecurityPersonnel.Location = new System.Drawing.Point(17, 22);
            this.btnSecurityPersonnel.Margin = new System.Windows.Forms.Padding(4);
            this.btnSecurityPersonnel.Name = "btnSecurityPersonnel";
            this.btnSecurityPersonnel.Size = new System.Drawing.Size(150, 59);
            this.btnSecurityPersonnel.TabIndex = 17;
            this.btnSecurityPersonnel.Text = "Security Personnel";
            this.btnSecurityPersonnel.UseVisualStyleBackColor = true;
            this.btnSecurityPersonnel.Click += new System.EventHandler(this.btnSecurityPersonnel_Click);
            // 
            // tmrMenu
            // 
            this.tmrMenu.Interval = 50;
            this.tmrMenu.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnlTextFieldPanel
            // 
            this.pnlTextFieldPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlTextFieldPanel.Controls.Add(this.picTextFieldMoveLeft);
            this.pnlTextFieldPanel.Controls.Add(this.picTextFieldMoveRight);
            this.pnlTextFieldPanel.Controls.Add(this.tabCtrlFields);
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
            // tabCtrlFields
            // 
            this.tabCtrlFields.Controls.Add(this.tabDisplayRecords);
            this.tabCtrlFields.Controls.Add(this.tabFilterRecords);
            this.tabCtrlFields.Controls.Add(this.tabDisplayType);
            this.tabCtrlFields.Location = new System.Drawing.Point(0, 0);
            this.tabCtrlFields.Name = "tabCtrlFields";
            this.tabCtrlFields.SelectedIndex = 0;
            this.tabCtrlFields.Size = new System.Drawing.Size(364, 548);
            this.tabCtrlFields.TabIndex = 35;
            // 
            // tabDisplayRecords
            // 
            this.tabDisplayRecords.Controls.Add(this.lblPersonnelLastName);
            this.tabDisplayRecords.Controls.Add(this.cbxLastN);
            this.tabDisplayRecords.Controls.Add(this.lblShiftDateAndTime);
            this.tabDisplayRecords.Controls.Add(this.cbxShift);
            this.tabDisplayRecords.Controls.Add(this.lblSectorName);
            this.tabDisplayRecords.Controls.Add(this.cbxSector);
            this.tabDisplayRecords.Controls.Add(this.lblIncidentTypeName);
            this.tabDisplayRecords.Controls.Add(this.cbxTypeName);
            this.tabDisplayRecords.Controls.Add(this.rtbSummary);
            this.tabDisplayRecords.Controls.Add(this.lblSummary);
            this.tabDisplayRecords.Controls.Add(this.lblDisplayFirstName);
            this.tabDisplayRecords.Controls.Add(this.txtIncident_ID);
            this.tabDisplayRecords.Location = new System.Drawing.Point(4, 25);
            this.tabDisplayRecords.Name = "tabDisplayRecords";
            this.tabDisplayRecords.Padding = new System.Windows.Forms.Padding(3);
            this.tabDisplayRecords.Size = new System.Drawing.Size(356, 519);
            this.tabDisplayRecords.TabIndex = 0;
            this.tabDisplayRecords.Text = "Update Incident";
            this.tabDisplayRecords.UseVisualStyleBackColor = true;
            // 
            // lblPersonnelLastName
            // 
            this.lblPersonnelLastName.AutoSize = true;
            this.lblPersonnelLastName.Location = new System.Drawing.Point(4, 263);
            this.lblPersonnelLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPersonnelLastName.Name = "lblPersonnelLastName";
            this.lblPersonnelLastName.Size = new System.Drawing.Size(146, 16);
            this.lblPersonnelLastName.TabIndex = 65;
            this.lblPersonnelLastName.Text = "Personnel Last Name:";
            // 
            // cbxLastN
            // 
            this.cbxLastN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLastN.Enabled = false;
            this.cbxLastN.FormattingEnabled = true;
            this.cbxLastN.Location = new System.Drawing.Point(170, 260);
            this.cbxLastN.Margin = new System.Windows.Forms.Padding(4);
            this.cbxLastN.Name = "cbxLastN";
            this.cbxLastN.Size = new System.Drawing.Size(159, 24);
            this.cbxLastN.TabIndex = 64;
            this.cbxLastN.SelectionChangeCommitted += new System.EventHandler(this.cbxLastN_SelectionChangeCommitted);
            // 
            // lblShiftDateAndTime
            // 
            this.lblShiftDateAndTime.AutoSize = true;
            this.lblShiftDateAndTime.Location = new System.Drawing.Point(4, 348);
            this.lblShiftDateAndTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblShiftDateAndTime.Name = "lblShiftDateAndTime";
            this.lblShiftDateAndTime.Size = new System.Drawing.Size(165, 16);
            this.lblShiftDateAndTime.TabIndex = 63;
            this.lblShiftDateAndTime.Text = "Shift Start Date and Time";
            // 
            // cbxShift
            // 
            this.cbxShift.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxShift.Enabled = false;
            this.cbxShift.FormattingEnabled = true;
            this.cbxShift.Location = new System.Drawing.Point(170, 345);
            this.cbxShift.Margin = new System.Windows.Forms.Padding(4);
            this.cbxShift.Name = "cbxShift";
            this.cbxShift.Size = new System.Drawing.Size(159, 24);
            this.cbxShift.TabIndex = 62;
            this.cbxShift.SelectionChangeCommitted += new System.EventHandler(this.cbxShift_SelectionChangeCommitted);
            // 
            // lblSectorName
            // 
            this.lblSectorName.AutoSize = true;
            this.lblSectorName.Location = new System.Drawing.Point(4, 306);
            this.lblSectorName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSectorName.Name = "lblSectorName";
            this.lblSectorName.Size = new System.Drawing.Size(92, 16);
            this.lblSectorName.TabIndex = 61;
            this.lblSectorName.Text = "Sector Name:";
            // 
            // cbxSector
            // 
            this.cbxSector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSector.Enabled = false;
            this.cbxSector.FormattingEnabled = true;
            this.cbxSector.Location = new System.Drawing.Point(170, 303);
            this.cbxSector.Margin = new System.Windows.Forms.Padding(4);
            this.cbxSector.Name = "cbxSector";
            this.cbxSector.Size = new System.Drawing.Size(159, 24);
            this.cbxSector.TabIndex = 60;
            this.cbxSector.SelectionChangeCommitted += new System.EventHandler(this.cbxSector_SelectionChangeCommitted);
            // 
            // lblIncidentTypeName
            // 
            this.lblIncidentTypeName.AutoSize = true;
            this.lblIncidentTypeName.Location = new System.Drawing.Point(4, 218);
            this.lblIncidentTypeName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIncidentTypeName.Name = "lblIncidentTypeName";
            this.lblIncidentTypeName.Size = new System.Drawing.Size(131, 16);
            this.lblIncidentTypeName.TabIndex = 59;
            this.lblIncidentTypeName.Text = "Incident Type Name";
            // 
            // cbxTypeName
            // 
            this.cbxTypeName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTypeName.Enabled = false;
            this.cbxTypeName.FormattingEnabled = true;
            this.cbxTypeName.Location = new System.Drawing.Point(170, 215);
            this.cbxTypeName.Margin = new System.Windows.Forms.Padding(4);
            this.cbxTypeName.Name = "cbxTypeName";
            this.cbxTypeName.Size = new System.Drawing.Size(159, 24);
            this.cbxTypeName.TabIndex = 58;
            this.cbxTypeName.SelectionChangeCommitted += new System.EventHandler(this.cbxTypeName_SelectionChangeCommitted);
            // 
            // rtbSummary
            // 
            this.rtbSummary.Enabled = false;
            this.rtbSummary.Location = new System.Drawing.Point(6, 114);
            this.rtbSummary.Name = "rtbSummary";
            this.rtbSummary.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbSummary.Size = new System.Drawing.Size(261, 96);
            this.rtbSummary.TabIndex = 28;
            this.rtbSummary.Text = "";
            this.rtbSummary.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // lblSummary
            // 
            this.lblSummary.AutoSize = true;
            this.lblSummary.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSummary.Location = new System.Drawing.Point(4, 86);
            this.lblSummary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSummary.Name = "lblSummary";
            this.lblSummary.Size = new System.Drawing.Size(132, 16);
            this.lblSummary.TabIndex = 27;
            this.lblSummary.Text = "Summary of events:";
            // 
            // lblDisplayFirstName
            // 
            this.lblDisplayFirstName.AutoSize = true;
            this.lblDisplayFirstName.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayFirstName.Location = new System.Drawing.Point(5, 47);
            this.lblDisplayFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDisplayFirstName.Name = "lblDisplayFirstName";
            this.lblDisplayFirstName.Size = new System.Drawing.Size(73, 16);
            this.lblDisplayFirstName.TabIndex = 25;
            this.lblDisplayFirstName.Text = "Incident ID";
            // 
            // txtIncident_ID
            // 
            this.txtIncident_ID.Enabled = false;
            this.txtIncident_ID.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIncident_ID.Location = new System.Drawing.Point(132, 44);
            this.txtIncident_ID.Margin = new System.Windows.Forms.Padding(4);
            this.txtIncident_ID.Name = "txtIncident_ID";
            this.txtIncident_ID.Size = new System.Drawing.Size(137, 23);
            this.txtIncident_ID.TabIndex = 24;
            // 
            // tabFilterRecords
            // 
            this.tabFilterRecords.Controls.Add(this.txtDescriptionF);
            this.tabFilterRecords.Controls.Add(this.label1);
            this.tabFilterRecords.Controls.Add(this.label12);
            this.tabFilterRecords.Controls.Add(this.label13);
            this.tabFilterRecords.Controls.Add(this.txtCodeF);
            this.tabFilterRecords.Controls.Add(this.txtNameF);
            this.tabFilterRecords.Location = new System.Drawing.Point(4, 25);
            this.tabFilterRecords.Name = "tabFilterRecords";
            this.tabFilterRecords.Padding = new System.Windows.Forms.Padding(3);
            this.tabFilterRecords.Size = new System.Drawing.Size(356, 519);
            this.tabFilterRecords.TabIndex = 1;
            this.tabFilterRecords.Text = "Filter Incident Type";
            this.tabFilterRecords.UseVisualStyleBackColor = true;
            // 
            // txtDescriptionF
            // 
            this.txtDescriptionF.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescriptionF.Location = new System.Drawing.Point(142, 141);
            this.txtDescriptionF.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescriptionF.Name = "txtDescriptionF";
            this.txtDescriptionF.Size = new System.Drawing.Size(126, 23);
            this.txtDescriptionF.TabIndex = 29;
            this.txtDescriptionF.TextChanged += new System.EventHandler(this.txtDescriptionF_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 144);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "Incident Description:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(4, 98);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(135, 16);
            this.label12.TabIndex = 27;
            this.label12.Text = "Incident Type Name:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(5, 47);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(133, 16);
            this.label13.TabIndex = 25;
            this.label13.Text = "Incident Type Code:";
            // 
            // txtCodeF
            // 
            this.txtCodeF.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodeF.Location = new System.Drawing.Point(142, 44);
            this.txtCodeF.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodeF.Name = "txtCodeF";
            this.txtCodeF.Size = new System.Drawing.Size(126, 23);
            this.txtCodeF.TabIndex = 24;
            this.txtCodeF.TextChanged += new System.EventHandler(this.txtCodeF_TextChanged);
            // 
            // txtNameF
            // 
            this.txtNameF.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameF.Location = new System.Drawing.Point(142, 95);
            this.txtNameF.Margin = new System.Windows.Forms.Padding(4);
            this.txtNameF.Name = "txtNameF";
            this.txtNameF.Size = new System.Drawing.Size(126, 23);
            this.txtNameF.TabIndex = 26;
            this.txtNameF.TextChanged += new System.EventHandler(this.txtNameF_TextChanged);
            // 
            // tabDisplayType
            // 
            this.tabDisplayType.Controls.Add(this.label3);
            this.tabDisplayType.Controls.Add(this.txtTypeID);
            this.tabDisplayType.Controls.Add(this.lblTypeDescription);
            this.tabDisplayType.Controls.Add(this.txtTypeDescription);
            this.tabDisplayType.Controls.Add(this.lblTypeName);
            this.tabDisplayType.Controls.Add(this.lblIncidentTypeCode);
            this.tabDisplayType.Controls.Add(this.txtIncidentTypeCode);
            this.tabDisplayType.Controls.Add(this.txtTypeName);
            this.tabDisplayType.Location = new System.Drawing.Point(4, 25);
            this.tabDisplayType.Name = "tabDisplayType";
            this.tabDisplayType.Size = new System.Drawing.Size(356, 519);
            this.tabDisplayType.TabIndex = 2;
            this.tabDisplayType.Text = "Update Incident Type";
            this.tabDisplayType.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 16);
            this.label3.TabIndex = 37;
            this.label3.Text = "Incident Type ID";
            // 
            // txtTypeID
            // 
            this.txtTypeID.Enabled = false;
            this.txtTypeID.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTypeID.Location = new System.Drawing.Point(48, 50);
            this.txtTypeID.Margin = new System.Windows.Forms.Padding(4);
            this.txtTypeID.Name = "txtTypeID";
            this.txtTypeID.Size = new System.Drawing.Size(150, 23);
            this.txtTypeID.TabIndex = 36;
            // 
            // lblTypeDescription
            // 
            this.lblTypeDescription.AutoSize = true;
            this.lblTypeDescription.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeDescription.Location = new System.Drawing.Point(45, 227);
            this.lblTypeDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTypeDescription.Name = "lblTypeDescription";
            this.lblTypeDescription.Size = new System.Drawing.Size(170, 16);
            this.lblTypeDescription.TabIndex = 35;
            this.lblTypeDescription.Text = "Incident Type Description:";
            // 
            // txtTypeDescription
            // 
            this.txtTypeDescription.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTypeDescription.Location = new System.Drawing.Point(48, 247);
            this.txtTypeDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtTypeDescription.Name = "txtTypeDescription";
            this.txtTypeDescription.Size = new System.Drawing.Size(150, 23);
            this.txtTypeDescription.TabIndex = 34;
            this.txtTypeDescription.TextChanged += new System.EventHandler(this.txtTypeDescription_TextChanged);
            // 
            // lblTypeName
            // 
            this.lblTypeName.AutoSize = true;
            this.lblTypeName.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeName.Location = new System.Drawing.Point(51, 159);
            this.lblTypeName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTypeName.Name = "lblTypeName";
            this.lblTypeName.Size = new System.Drawing.Size(135, 16);
            this.lblTypeName.TabIndex = 33;
            this.lblTypeName.Text = "Incident Type Name:";
            // 
            // lblIncidentTypeCode
            // 
            this.lblIncidentTypeCode.AutoSize = true;
            this.lblIncidentTypeCode.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncidentTypeCode.Location = new System.Drawing.Point(51, 91);
            this.lblIncidentTypeCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIncidentTypeCode.Name = "lblIncidentTypeCode";
            this.lblIncidentTypeCode.Size = new System.Drawing.Size(129, 16);
            this.lblIncidentTypeCode.TabIndex = 31;
            this.lblIncidentTypeCode.Text = "Incident Type Code";
            // 
            // txtIncidentTypeCode
            // 
            this.txtIncidentTypeCode.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIncidentTypeCode.Location = new System.Drawing.Point(48, 111);
            this.txtIncidentTypeCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtIncidentTypeCode.Name = "txtIncidentTypeCode";
            this.txtIncidentTypeCode.Size = new System.Drawing.Size(150, 23);
            this.txtIncidentTypeCode.TabIndex = 30;
            this.txtIncidentTypeCode.TextChanged += new System.EventHandler(this.txtIncidentTypeCode_TextChanged);
            // 
            // txtTypeName
            // 
            this.txtTypeName.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTypeName.Location = new System.Drawing.Point(48, 179);
            this.txtTypeName.Margin = new System.Windows.Forms.Padding(4);
            this.txtTypeName.Name = "txtTypeName";
            this.txtTypeName.Size = new System.Drawing.Size(150, 23);
            this.txtTypeName.TabIndex = 32;
            this.txtTypeName.TextChanged += new System.EventHandler(this.txtTypeName_TextChanged);
            // 
            // tmrTextFields
            // 
            this.tmrTextFields.Interval = 50;
            this.tmrTextFields.Tick += new System.EventHandler(this.tmrTextFields_Tick);
            // 
            // dgvData1
            // 
            this.dgvData1.AllowUserToAddRows = false;
            this.dgvData1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvData1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvData1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData1.Location = new System.Drawing.Point(690, 132);
            this.dgvData1.Name = "dgvData1";
            this.dgvData1.ReadOnly = true;
            this.dgvData1.Size = new System.Drawing.Size(825, 501);
            this.dgvData1.TabIndex = 6;
            this.dgvData1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData1_CellClick);
            this.dgvData1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData1_CellValueChanged);
            this.dgvData1.SelectionChanged += new System.EventHandler(this.dgvData1_SelectionChanged);
            this.dgvData1.VisibleChanged += new System.EventHandler(this.dgvData1_VisibleChanged);
            // 
            // tmrTimeUpdate
            // 
            this.tmrTimeUpdate.Enabled = true;
            this.tmrTimeUpdate.Interval = 1000;
            this.tmrTimeUpdate.Tick += new System.EventHandler(this.tmrTimeUpdate_Tick);
            // 
            // frmIncidents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.dgvData1);
            this.Controls.Add(this.pnlTextFieldPanel);
            this.Controls.Add(this.pnlSidePanel);
            this.Controls.Add(this.pnlBottomPanel);
            this.Controls.Add(this.pnlTopPanel);
            this.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmIncidents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Incident";
            this.Activated += new System.EventHandler(this.frmIncidents_Activated);
            this.Load += new System.EventHandler(this.frmTemplate_Load);
            this.Shown += new System.EventHandler(this.frmIncidents_Shown);
            this.pnlTopPanel.ResumeLayout(false);
            this.pnlTopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHelp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMenu)).EndInit();
            this.pnlBottomPanel.ResumeLayout(false);
            this.pnlSidePanel.ResumeLayout(false);
            this.pnlTextFieldPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picTextFieldMoveLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTextFieldMoveRight)).EndInit();
            this.tabCtrlFields.ResumeLayout(false);
            this.tabDisplayRecords.ResumeLayout(false);
            this.tabDisplayRecords.PerformLayout();
            this.tabFilterRecords.ResumeLayout(false);
            this.tabFilterRecords.PerformLayout();
            this.tabDisplayType.ResumeLayout(false);
            this.tabDisplayType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Panel pnlTopPanel;
        private System.Windows.Forms.Panel pnlBottomPanel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Panel pnlSidePanel;
        private System.Windows.Forms.PictureBox picMenu;
        private System.Windows.Forms.Timer tmrMenu;
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
        private System.Windows.Forms.ToolTip tipHome;
        private System.Windows.Forms.ToolTip tipBack;
        private System.Windows.Forms.ToolTip tipHelp;
        private System.Windows.Forms.ToolTip tipSearch;
        private System.Windows.Forms.Button btnDisplayType;
        private System.Windows.Forms.Button btnDisplayIncidents;
        private System.Windows.Forms.TabControl tabCtrlFields;
        private System.Windows.Forms.TabPage tabDisplayRecords;
        private System.Windows.Forms.Label lblDisplayFirstName;
        private System.Windows.Forms.TextBox txtIncident_ID;
        private System.Windows.Forms.TabPage tabFilterRecords;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCodeF;
        private System.Windows.Forms.TextBox txtNameF;
        private System.Windows.Forms.TabPage tabDisplayType;
        private System.Windows.Forms.Label lblTypeDescription;
        private System.Windows.Forms.TextBox txtTypeDescription;
        private System.Windows.Forms.Label lblTypeName;
        private System.Windows.Forms.Label lblIncidentTypeCode;
        private System.Windows.Forms.TextBox txtIncidentTypeCode;
        private System.Windows.Forms.TextBox txtTypeName;
        private System.Windows.Forms.Label lblSummary;
        private System.Windows.Forms.TextBox txtDescriptionF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTypeID;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.RichTextBox rtbSummary;
        private System.Windows.Forms.DataGridView dgvData1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Timer tmrTimeUpdate;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnShift;
        private System.Windows.Forms.Button btnIncidents;
        private System.Windows.Forms.Button btnSectors;
        private System.Windows.Forms.Button btnEquipment;
        private System.Windows.Forms.Button btnSecurityPersonnel;
        private System.Windows.Forms.Label lblPersonnelLastName;
        private System.Windows.Forms.ComboBox cbxLastN;
        private System.Windows.Forms.Label lblShiftDateAndTime;
        private System.Windows.Forms.ComboBox cbxShift;
        private System.Windows.Forms.Label lblSectorName;
        private System.Windows.Forms.ComboBox cbxSector;
        private System.Windows.Forms.Label lblIncidentTypeName;
        private System.Windows.Forms.ComboBox cbxTypeName;
    }
}

