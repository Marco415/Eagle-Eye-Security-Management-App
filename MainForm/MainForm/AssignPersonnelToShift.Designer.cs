namespace MainForm
{
    partial class frmAssignPersonnelToShift
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAssignPersonnelToShift));
            this.lblHeading = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlTopPanel = new System.Windows.Forms.Panel();
            this.btnAssign = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cmbPersonnelID = new System.Windows.Forms.ComboBox();
            this.lblPersonnelID = new System.Windows.Forms.Label();
            this.lblDisplayLastName = new System.Windows.Forms.Label();
            this.lblDisplayFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.gbxPersonnel = new System.Windows.Forms.GroupBox();
            this.cmbShiftID = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStartTime = new System.Windows.Forms.TextBox();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.lblAlreadyAssigned = new System.Windows.Forms.Label();
            this.grpShift = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlTopPanel.SuspendLayout();
            this.gbxPersonnel.SuspendLayout();
            this.grpShift.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(14, 24);
            this.lblHeading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(290, 91);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Assign Personnel To Shift";
            // 
            // picLogo
            // 
            this.picLogo.Location = new System.Drawing.Point(1641, 0);
            this.picLogo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(126, 128);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(312, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            // 
            // pnlTopPanel
            // 
            this.pnlTopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(222)))), ((int)(((byte)(211)))));
            this.pnlTopPanel.Controls.Add(this.pictureBox1);
            this.pnlTopPanel.Controls.Add(this.picLogo);
            this.pnlTopPanel.Controls.Add(this.lblHeading);
            this.pnlTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopPanel.Location = new System.Drawing.Point(0, 0);
            this.pnlTopPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlTopPanel.Name = "pnlTopPanel";
            this.pnlTopPanel.Size = new System.Drawing.Size(459, 133);
            this.pnlTopPanel.TabIndex = 54;
            // 
            // btnAssign
            // 
            this.btnAssign.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssign.Location = new System.Drawing.Point(131, 517);
            this.btnAssign.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(175, 72);
            this.btnAssign.TabIndex = 3;
            this.btnAssign.Text = "Assign";
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(131, 617);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(175, 72);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // cmbPersonnelID
            // 
            this.cmbPersonnelID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPersonnelID.FormattingEnabled = true;
            this.cmbPersonnelID.Location = new System.Drawing.Point(144, 31);
            this.cmbPersonnelID.Name = "cmbPersonnelID";
            this.cmbPersonnelID.Size = new System.Drawing.Size(202, 24);
            this.cmbPersonnelID.TabIndex = 1;
            this.cmbPersonnelID.SelectedIndexChanged += new System.EventHandler(this.cmbPersonnelID_SelectedIndexChanged_1);
            // 
            // lblPersonnelID
            // 
            this.lblPersonnelID.AutoSize = true;
            this.lblPersonnelID.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonnelID.Location = new System.Drawing.Point(13, 34);
            this.lblPersonnelID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPersonnelID.Name = "lblPersonnelID";
            this.lblPersonnelID.Size = new System.Drawing.Size(88, 16);
            this.lblPersonnelID.TabIndex = 62;
            this.lblPersonnelID.Text = "Personnel ID";
            // 
            // lblDisplayLastName
            // 
            this.lblDisplayLastName.AutoSize = true;
            this.lblDisplayLastName.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayLastName.Location = new System.Drawing.Point(13, 122);
            this.lblDisplayLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDisplayLastName.Name = "lblDisplayLastName";
            this.lblDisplayLastName.Size = new System.Drawing.Size(74, 16);
            this.lblDisplayLastName.TabIndex = 60;
            this.lblDisplayLastName.Text = "Last Name";
            // 
            // lblDisplayFirstName
            // 
            this.lblDisplayFirstName.AutoSize = true;
            this.lblDisplayFirstName.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayFirstName.Location = new System.Drawing.Point(13, 79);
            this.lblDisplayFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDisplayFirstName.Name = "lblDisplayFirstName";
            this.lblDisplayFirstName.Size = new System.Drawing.Size(75, 16);
            this.lblDisplayFirstName.TabIndex = 59;
            this.lblDisplayFirstName.Text = "First Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Enabled = false;
            this.txtFirstName.Location = new System.Drawing.Point(144, 76);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(202, 23);
            this.txtFirstName.TabIndex = 6;
            this.txtFirstName.TabStop = false;
            // 
            // txtLastName
            // 
            this.txtLastName.Enabled = false;
            this.txtLastName.Location = new System.Drawing.Point(144, 119);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(202, 23);
            this.txtLastName.TabIndex = 7;
            this.txtLastName.TabStop = false;
            // 
            // gbxPersonnel
            // 
            this.gbxPersonnel.Controls.Add(this.txtLastName);
            this.gbxPersonnel.Controls.Add(this.txtFirstName);
            this.gbxPersonnel.Controls.Add(this.lblDisplayFirstName);
            this.gbxPersonnel.Controls.Add(this.lblDisplayLastName);
            this.gbxPersonnel.Controls.Add(this.lblPersonnelID);
            this.gbxPersonnel.Controls.Add(this.cmbPersonnelID);
            this.gbxPersonnel.Location = new System.Drawing.Point(44, 153);
            this.gbxPersonnel.Name = "gbxPersonnel";
            this.gbxPersonnel.Size = new System.Drawing.Size(368, 169);
            this.gbxPersonnel.TabIndex = 65;
            this.gbxPersonnel.TabStop = false;
            this.gbxPersonnel.Text = "Security Personnel";
            // 
            // cmbShiftID
            // 
            this.cmbShiftID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShiftID.FormattingEnabled = true;
            this.cmbShiftID.Location = new System.Drawing.Point(144, 31);
            this.cmbShiftID.Name = "cmbShiftID";
            this.cmbShiftID.Size = new System.Drawing.Size(202, 24);
            this.cmbShiftID.TabIndex = 2;
            this.cmbShiftID.SelectedIndexChanged += new System.EventHandler(this.cmbShiftID_SelectedIndexChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 62;
            this.label3.Text = "Shift ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 60;
            this.label2.Text = "Duration";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 59;
            this.label1.Text = "Start Time";
            // 
            // txtStartTime
            // 
            this.txtStartTime.Enabled = false;
            this.txtStartTime.Location = new System.Drawing.Point(144, 76);
            this.txtStartTime.Name = "txtStartTime";
            this.txtStartTime.Size = new System.Drawing.Size(202, 23);
            this.txtStartTime.TabIndex = 67;
            this.txtStartTime.TabStop = false;
            // 
            // txtDuration
            // 
            this.txtDuration.Enabled = false;
            this.txtDuration.Location = new System.Drawing.Point(144, 119);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(202, 23);
            this.txtDuration.TabIndex = 68;
            this.txtDuration.TabStop = false;
            // 
            // lblAlreadyAssigned
            // 
            this.lblAlreadyAssigned.AutoSize = true;
            this.lblAlreadyAssigned.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlreadyAssigned.ForeColor = System.Drawing.Color.Red;
            this.lblAlreadyAssigned.Location = new System.Drawing.Point(141, 55);
            this.lblAlreadyAssigned.Name = "lblAlreadyAssigned";
            this.lblAlreadyAssigned.Size = new System.Drawing.Size(194, 15);
            this.lblAlreadyAssigned.TabIndex = 69;
            this.lblAlreadyAssigned.Text = "Already assigned to all Equipment";
            this.lblAlreadyAssigned.Visible = false;
            // 
            // grpShift
            // 
            this.grpShift.Controls.Add(this.lblAlreadyAssigned);
            this.grpShift.Controls.Add(this.txtDuration);
            this.grpShift.Controls.Add(this.txtStartTime);
            this.grpShift.Controls.Add(this.label1);
            this.grpShift.Controls.Add(this.label2);
            this.grpShift.Controls.Add(this.label3);
            this.grpShift.Controls.Add(this.cmbShiftID);
            this.grpShift.Location = new System.Drawing.Point(44, 330);
            this.grpShift.Name = "grpShift";
            this.grpShift.Size = new System.Drawing.Size(368, 169);
            this.grpShift.TabIndex = 66;
            this.grpShift.TabStop = false;
            this.grpShift.Text = "Shift";
            // 
            // frmAssignPersonnelToShift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 715);
            this.Controls.Add(this.grpShift);
            this.Controls.Add(this.gbxPersonnel);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.pnlTopPanel);
            this.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAssignPersonnelToShift";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Assign Personnel To Shift";
            this.Load += new System.EventHandler(this.frmAssignPersonnelToShift_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlTopPanel.ResumeLayout(false);
            this.gbxPersonnel.ResumeLayout(false);
            this.gbxPersonnel.PerformLayout();
            this.grpShift.ResumeLayout(false);
            this.grpShift.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlTopPanel;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cmbPersonnelID;
        private System.Windows.Forms.Label lblPersonnelID;
        private System.Windows.Forms.Label lblDisplayLastName;
        private System.Windows.Forms.Label lblDisplayFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.GroupBox gbxPersonnel;
        private System.Windows.Forms.ComboBox cmbShiftID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStartTime;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.Label lblAlreadyAssigned;
        private System.Windows.Forms.GroupBox grpShift;
    }
}