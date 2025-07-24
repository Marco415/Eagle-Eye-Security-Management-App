namespace MainForm
{
    partial class frmInsertSecurityPersonnel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInsertSecurityPersonnel));
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblDisplaySalary = new System.Windows.Forms.Label();
            this.lblDisplayExpLvl = new System.Windows.Forms.Label();
            this.lblDisplayEmailAddress = new System.Windows.Forms.Label();
            this.txtInsertEmail = new System.Windows.Forms.TextBox();
            this.lblDisplayPhoneNumber = new System.Windows.Forms.Label();
            this.txtInsertPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblDisplayIDNumber = new System.Windows.Forms.Label();
            this.txtInsertIDNumber = new System.Windows.Forms.TextBox();
            this.lblDisplayLastName = new System.Windows.Forms.Label();
            this.lblDisplayFirstName = new System.Windows.Forms.Label();
            this.txtInsertFirstName = new System.Windows.Forms.TextBox();
            this.txtInsertLastName = new System.Windows.Forms.TextBox();
            this.nudExpLvl = new System.Windows.Forms.NumericUpDown();
            this.nudSalary = new System.Windows.Forms.NumericUpDown();
            this.pnlTopPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblHeading = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudExpLvl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSalary)).BeginInit();
            this.pnlTopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(113, 420);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(150, 59);
            this.btnInsert.TabIndex = 8;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(113, 502);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 59);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblDisplaySalary
            // 
            this.lblDisplaySalary.AutoSize = true;
            this.lblDisplaySalary.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplaySalary.Location = new System.Drawing.Point(34, 381);
            this.lblDisplaySalary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDisplaySalary.Name = "lblDisplaySalary";
            this.lblDisplaySalary.Size = new System.Drawing.Size(47, 16);
            this.lblDisplaySalary.TabIndex = 51;
            this.lblDisplaySalary.Text = "Salary";
            // 
            // lblDisplayExpLvl
            // 
            this.lblDisplayExpLvl.AutoSize = true;
            this.lblDisplayExpLvl.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayExpLvl.Location = new System.Drawing.Point(33, 338);
            this.lblDisplayExpLvl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDisplayExpLvl.Name = "lblDisplayExpLvl";
            this.lblDisplayExpLvl.Size = new System.Drawing.Size(115, 16);
            this.lblDisplayExpLvl.TabIndex = 50;
            this.lblDisplayExpLvl.Text = "Experience Level";
            // 
            // lblDisplayEmailAddress
            // 
            this.lblDisplayEmailAddress.AutoSize = true;
            this.lblDisplayEmailAddress.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayEmailAddress.Location = new System.Drawing.Point(34, 295);
            this.lblDisplayEmailAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDisplayEmailAddress.Name = "lblDisplayEmailAddress";
            this.lblDisplayEmailAddress.Size = new System.Drawing.Size(96, 16);
            this.lblDisplayEmailAddress.TabIndex = 49;
            this.lblDisplayEmailAddress.Text = "Email Address";
            // 
            // txtInsertEmail
            // 
            this.txtInsertEmail.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInsertEmail.Location = new System.Drawing.Point(165, 292);
            this.txtInsertEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtInsertEmail.Name = "txtInsertEmail";
            this.txtInsertEmail.Size = new System.Drawing.Size(202, 23);
            this.txtInsertEmail.TabIndex = 5;
            // 
            // lblDisplayPhoneNumber
            // 
            this.lblDisplayPhoneNumber.AutoSize = true;
            this.lblDisplayPhoneNumber.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayPhoneNumber.Location = new System.Drawing.Point(34, 252);
            this.lblDisplayPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDisplayPhoneNumber.Name = "lblDisplayPhoneNumber";
            this.lblDisplayPhoneNumber.Size = new System.Drawing.Size(101, 16);
            this.lblDisplayPhoneNumber.TabIndex = 47;
            this.lblDisplayPhoneNumber.Text = "Phone Number";
            // 
            // txtInsertPhoneNumber
            // 
            this.txtInsertPhoneNumber.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInsertPhoneNumber.Location = new System.Drawing.Point(165, 249);
            this.txtInsertPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtInsertPhoneNumber.Name = "txtInsertPhoneNumber";
            this.txtInsertPhoneNumber.Size = new System.Drawing.Size(202, 23);
            this.txtInsertPhoneNumber.TabIndex = 4;
            // 
            // lblDisplayIDNumber
            // 
            this.lblDisplayIDNumber.AutoSize = true;
            this.lblDisplayIDNumber.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayIDNumber.Location = new System.Drawing.Point(34, 209);
            this.lblDisplayIDNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDisplayIDNumber.Name = "lblDisplayIDNumber";
            this.lblDisplayIDNumber.Size = new System.Drawing.Size(73, 16);
            this.lblDisplayIDNumber.TabIndex = 45;
            this.lblDisplayIDNumber.Text = "ID Number";
            // 
            // txtInsertIDNumber
            // 
            this.txtInsertIDNumber.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInsertIDNumber.Location = new System.Drawing.Point(165, 206);
            this.txtInsertIDNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtInsertIDNumber.Name = "txtInsertIDNumber";
            this.txtInsertIDNumber.Size = new System.Drawing.Size(202, 23);
            this.txtInsertIDNumber.TabIndex = 3;
            // 
            // lblDisplayLastName
            // 
            this.lblDisplayLastName.AutoSize = true;
            this.lblDisplayLastName.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayLastName.Location = new System.Drawing.Point(34, 166);
            this.lblDisplayLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDisplayLastName.Name = "lblDisplayLastName";
            this.lblDisplayLastName.Size = new System.Drawing.Size(74, 16);
            this.lblDisplayLastName.TabIndex = 43;
            this.lblDisplayLastName.Text = "Last Name";
            // 
            // lblDisplayFirstName
            // 
            this.lblDisplayFirstName.AutoSize = true;
            this.lblDisplayFirstName.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayFirstName.Location = new System.Drawing.Point(34, 123);
            this.lblDisplayFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDisplayFirstName.Name = "lblDisplayFirstName";
            this.lblDisplayFirstName.Size = new System.Drawing.Size(75, 16);
            this.lblDisplayFirstName.TabIndex = 41;
            this.lblDisplayFirstName.Text = "First Name";
            // 
            // txtInsertFirstName
            // 
            this.txtInsertFirstName.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInsertFirstName.Location = new System.Drawing.Point(165, 120);
            this.txtInsertFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.txtInsertFirstName.Name = "txtInsertFirstName";
            this.txtInsertFirstName.Size = new System.Drawing.Size(202, 23);
            this.txtInsertFirstName.TabIndex = 1;
            // 
            // txtInsertLastName
            // 
            this.txtInsertLastName.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInsertLastName.Location = new System.Drawing.Point(165, 163);
            this.txtInsertLastName.Margin = new System.Windows.Forms.Padding(4);
            this.txtInsertLastName.Name = "txtInsertLastName";
            this.txtInsertLastName.Size = new System.Drawing.Size(202, 23);
            this.txtInsertLastName.TabIndex = 2;
            // 
            // nudExpLvl
            // 
            this.nudExpLvl.Location = new System.Drawing.Point(165, 338);
            this.nudExpLvl.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudExpLvl.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudExpLvl.Name = "nudExpLvl";
            this.nudExpLvl.Size = new System.Drawing.Size(116, 20);
            this.nudExpLvl.TabIndex = 6;
            this.nudExpLvl.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudExpLvl.ValueChanged += new System.EventHandler(this.nudExpLvl_ValueChanged);
            // 
            // nudSalary
            // 
            this.nudSalary.DecimalPlaces = 2;
            this.nudSalary.Increment = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudSalary.Location = new System.Drawing.Point(165, 380);
            this.nudSalary.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nudSalary.Name = "nudSalary";
            this.nudSalary.Size = new System.Drawing.Size(116, 20);
            this.nudSalary.TabIndex = 52;
            // 
            // pnlTopPanel
            // 
            this.pnlTopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(222)))), ((int)(((byte)(211)))));
            this.pnlTopPanel.Controls.Add(this.pictureBox1);
            this.pnlTopPanel.Controls.Add(this.picLogo);
            this.pnlTopPanel.Controls.Add(this.lblHeading);
            this.pnlTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopPanel.Location = new System.Drawing.Point(0, 0);
            this.pnlTopPanel.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTopPanel.Name = "pnlTopPanel";
            this.pnlTopPanel.Size = new System.Drawing.Size(394, 108);
            this.pnlTopPanel.TabIndex = 53;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(267, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
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
            // lblHeading
            // 
            this.lblHeading.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(12, 20);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(247, 74);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Insert Security Personnel";
            // 
            // frmInsertSecurityPersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 581);
            this.Controls.Add(this.nudSalary);
            this.Controls.Add(this.nudExpLvl);
            this.Controls.Add(this.lblDisplaySalary);
            this.Controls.Add(this.lblDisplayExpLvl);
            this.Controls.Add(this.lblDisplayEmailAddress);
            this.Controls.Add(this.txtInsertEmail);
            this.Controls.Add(this.lblDisplayPhoneNumber);
            this.Controls.Add(this.txtInsertPhoneNumber);
            this.Controls.Add(this.lblDisplayIDNumber);
            this.Controls.Add(this.txtInsertIDNumber);
            this.Controls.Add(this.lblDisplayLastName);
            this.Controls.Add(this.lblDisplayFirstName);
            this.Controls.Add(this.txtInsertFirstName);
            this.Controls.Add(this.txtInsertLastName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.pnlTopPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInsertSecurityPersonnel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Insert Security Personnel";
            this.Load += new System.EventHandler(this.InsertSecurityPersonnel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudExpLvl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSalary)).EndInit();
            this.pnlTopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblDisplaySalary;
        private System.Windows.Forms.Label lblDisplayExpLvl;
        private System.Windows.Forms.Label lblDisplayEmailAddress;
        private System.Windows.Forms.TextBox txtInsertEmail;
        private System.Windows.Forms.Label lblDisplayPhoneNumber;
        private System.Windows.Forms.TextBox txtInsertPhoneNumber;
        private System.Windows.Forms.Label lblDisplayIDNumber;
        private System.Windows.Forms.TextBox txtInsertIDNumber;
        private System.Windows.Forms.Label lblDisplayLastName;
        private System.Windows.Forms.Label lblDisplayFirstName;
        private System.Windows.Forms.TextBox txtInsertFirstName;
        private System.Windows.Forms.TextBox txtInsertLastName;
        private System.Windows.Forms.NumericUpDown nudExpLvl;
        private System.Windows.Forms.NumericUpDown nudSalary;
        private System.Windows.Forms.Panel pnlTopPanel;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}