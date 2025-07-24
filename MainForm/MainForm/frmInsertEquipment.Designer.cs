namespace MainForm
{
    partial class frmInsertEquipment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInsertEquipment));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbLastName = new System.Windows.Forms.ComboBox();
            this.cmbName = new System.Windows.Forms.ComboBox();
            this.cmbEquipType = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnInsertRecord = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtInsertEquipName = new System.Windows.Forms.TextBox();
            this.txtInsertPLastName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlTopPanel = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.pnlTopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbLastName);
            this.panel1.Controls.Add(this.cmbName);
            this.panel1.Controls.Add(this.cmbEquipType);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnInsertRecord);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtInsertEquipName);
            this.panel1.Controls.Add(this.txtInsertPLastName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(0, 111);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 340);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cmbLastName
            // 
            this.cmbLastName.FormattingEnabled = true;
            this.cmbLastName.Location = new System.Drawing.Point(168, 157);
            this.cmbLastName.Name = "cmbLastName";
            this.cmbLastName.Size = new System.Drawing.Size(121, 21);
            this.cmbLastName.TabIndex = 17;
            // 
            // cmbName
            // 
            this.cmbName.FormattingEnabled = true;
            this.cmbName.Location = new System.Drawing.Point(168, 116);
            this.cmbName.Name = "cmbName";
            this.cmbName.Size = new System.Drawing.Size(121, 21);
            this.cmbName.TabIndex = 16;
            // 
            // cmbEquipType
            // 
            this.cmbEquipType.FormattingEnabled = true;
            this.cmbEquipType.Location = new System.Drawing.Point(168, 78);
            this.cmbEquipType.Name = "cmbEquipType";
            this.cmbEquipType.Size = new System.Drawing.Size(121, 21);
            this.cmbEquipType.TabIndex = 15;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(25, 276);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(249, 50);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnInsertRecord
            // 
            this.btnInsertRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertRecord.Location = new System.Drawing.Point(25, 210);
            this.btnInsertRecord.Name = "btnInsertRecord";
            this.btnInsertRecord.Size = new System.Drawing.Size(249, 50);
            this.btnInsertRecord.TabIndex = 1;
            this.btnInsertRecord.Text = "Insert Record";
            this.btnInsertRecord.UseVisualStyleBackColor = true;
            this.btnInsertRecord.Click += new System.EventHandler(this.btnInsertRecord_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(235, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Insert a new record in the database.";
            // 
            // txtInsertEquipName
            // 
            this.txtInsertEquipName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInsertEquipName.Location = new System.Drawing.Point(168, 37);
            this.txtInsertEquipName.Name = "txtInsertEquipName";
            this.txtInsertEquipName.Size = new System.Drawing.Size(121, 23);
            this.txtInsertEquipName.TabIndex = 8;
            // 
            // txtInsertPLastName
            // 
            this.txtInsertPLastName.AutoSize = true;
            this.txtInsertPLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInsertPLastName.Location = new System.Drawing.Point(22, 157);
            this.txtInsertPLastName.Name = "txtInsertPLastName";
            this.txtInsertPLastName.Size = new System.Drawing.Size(148, 17);
            this.txtInsertPLastName.TabIndex = 6;
            this.txtInsertPLastName.Text = "Personnel Last Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Equipment Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Equipent Type:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Personnel Name:";
            // 
            // pnlTopPanel
            // 
            this.pnlTopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(222)))), ((int)(((byte)(211)))));
            this.pnlTopPanel.Controls.Add(this.picLogo);
            this.pnlTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopPanel.Location = new System.Drawing.Point(0, 0);
            this.pnlTopPanel.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTopPanel.Name = "pnlTopPanel";
            this.pnlTopPanel.Size = new System.Drawing.Size(301, 104);
            this.pnlTopPanel.TabIndex = 4;
            // 
            // picLogo
            // 
            this.picLogo.Image = global::MainForm.Properties.Resources.Eagle_Eye_Logo;
            this.picLogo.Location = new System.Drawing.Point(90, 0);
            this.picLogo.Margin = new System.Windows.Forms.Padding(4);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(108, 104);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;
            // 
            // frmInsertEquipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 456);
            this.Controls.Add(this.pnlTopPanel);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInsertEquipment";
            this.Text = "Insert Equipment";
            this.Load += new System.EventHandler(this.frmInsertEquipment_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlTopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtInsertEquipName;
        private System.Windows.Forms.Label txtInsertPLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnInsertRecord;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel pnlTopPanel;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.ComboBox cmbEquipType;
        private System.Windows.Forms.ComboBox cmbLastName;
        private System.Windows.Forms.ComboBox cmbName;
    }
}