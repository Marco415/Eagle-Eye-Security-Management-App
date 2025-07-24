namespace MainForm
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pnlBottomMenu = new System.Windows.Forms.Panel();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnIncidents = new System.Windows.Forms.Button();
            this.btnSectors = new System.Windows.Forms.Button();
            this.btnEquipment = new System.Windows.Forms.Button();
            this.btnShifts = new System.Windows.Forms.Button();
            this.btnSecurityPersonnel = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pnlBottomMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Arial", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(604, 28);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(328, 78);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome";
            // 
            // pnlBottomMenu
            // 
            this.pnlBottomMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(136)))), ((int)(((byte)(125)))));
            this.pnlBottomMenu.Controls.Add(this.btnReports);
            this.pnlBottomMenu.Controls.Add(this.btnIncidents);
            this.pnlBottomMenu.Controls.Add(this.btnSectors);
            this.pnlBottomMenu.Controls.Add(this.btnEquipment);
            this.pnlBottomMenu.Controls.Add(this.btnShifts);
            this.pnlBottomMenu.Controls.Add(this.btnSecurityPersonnel);
            this.pnlBottomMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottomMenu.Location = new System.Drawing.Point(0, 618);
            this.pnlBottomMenu.Name = "pnlBottomMenu";
            this.pnlBottomMenu.Size = new System.Drawing.Size(1527, 160);
            this.pnlBottomMenu.TabIndex = 2;
            // 
            // btnReports
            // 
            this.btnReports.Location = new System.Drawing.Point(1271, 52);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(150, 60);
            this.btnReports.TabIndex = 5;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnIncidents
            // 
            this.btnIncidents.Location = new System.Drawing.Point(1037, 52);
            this.btnIncidents.Name = "btnIncidents";
            this.btnIncidents.Size = new System.Drawing.Size(150, 60);
            this.btnIncidents.TabIndex = 4;
            this.btnIncidents.Text = "Incidents";
            this.btnIncidents.UseVisualStyleBackColor = true;
            this.btnIncidents.Click += new System.EventHandler(this.btnIncidents_Click);
            // 
            // btnSectors
            // 
            this.btnSectors.Location = new System.Drawing.Point(803, 52);
            this.btnSectors.Name = "btnSectors";
            this.btnSectors.Size = new System.Drawing.Size(150, 60);
            this.btnSectors.TabIndex = 3;
            this.btnSectors.Text = "Sectors";
            this.btnSectors.UseVisualStyleBackColor = true;
            this.btnSectors.Click += new System.EventHandler(this.btnSectors_Click);
            // 
            // btnEquipment
            // 
            this.btnEquipment.Location = new System.Drawing.Point(574, 52);
            this.btnEquipment.Name = "btnEquipment";
            this.btnEquipment.Size = new System.Drawing.Size(150, 60);
            this.btnEquipment.TabIndex = 2;
            this.btnEquipment.Text = "Equipment";
            this.btnEquipment.UseVisualStyleBackColor = true;
            this.btnEquipment.Click += new System.EventHandler(this.btnEquipment_Click);
            // 
            // btnShifts
            // 
            this.btnShifts.Location = new System.Drawing.Point(340, 52);
            this.btnShifts.Name = "btnShifts";
            this.btnShifts.Size = new System.Drawing.Size(150, 60);
            this.btnShifts.TabIndex = 1;
            this.btnShifts.Text = "Shifts";
            this.btnShifts.UseVisualStyleBackColor = true;
            this.btnShifts.Click += new System.EventHandler(this.btnShifts_Click);
            // 
            // btnSecurityPersonnel
            // 
            this.btnSecurityPersonnel.Location = new System.Drawing.Point(106, 52);
            this.btnSecurityPersonnel.Name = "btnSecurityPersonnel";
            this.btnSecurityPersonnel.Size = new System.Drawing.Size(150, 60);
            this.btnSecurityPersonnel.TabIndex = 0;
            this.btnSecurityPersonnel.Text = "Security Personnel";
            this.btnSecurityPersonnel.UseVisualStyleBackColor = true;
            this.btnSecurityPersonnel.Click += new System.EventHandler(this.btnSecurityPersonnel_Click_1);
            // 
            // picLogo
            // 
            this.picLogo.Image = global::MainForm.Properties.Resources.Eagle_Eye_Logo;
            this.picLogo.Location = new System.Drawing.Point(538, 140);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(450, 450);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1527, 778);
            this.Controls.Add(this.pnlBottomMenu);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.lblWelcome);
            this.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlBottomMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel pnlBottomMenu;
        private System.Windows.Forms.Button btnIncidents;
        private System.Windows.Forms.Button btnSectors;
        private System.Windows.Forms.Button btnEquipment;
        private System.Windows.Forms.Button btnShifts;
        private System.Windows.Forms.Button btnSecurityPersonnel;
        private System.Windows.Forms.Button btnReports;
    }
}

