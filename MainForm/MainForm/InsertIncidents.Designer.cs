namespace TemplateForm
{
    partial class InsertIncidents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertIncidents));
            this.label1 = new System.Windows.Forms.Label();
            this.pnlTopPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnClose2 = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.rtbSummary = new System.Windows.Forms.RichTextBox();
            this.cbxTypeName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxSector = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxShift = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxLastN = new System.Windows.Forms.ComboBox();
            this.pnlTopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Insert Incidents";
            // 
            // pnlTopPanel
            // 
            this.pnlTopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(222)))), ((int)(((byte)(211)))));
            this.pnlTopPanel.Controls.Add(this.label1);
            this.pnlTopPanel.Controls.Add(this.pictureBox1);
            this.pnlTopPanel.Controls.Add(this.picLogo);
            this.pnlTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopPanel.Location = new System.Drawing.Point(0, 0);
            this.pnlTopPanel.Margin = new System.Windows.Forms.Padding(5);
            this.pnlTopPanel.Name = "pnlTopPanel";
            this.pnlTopPanel.Size = new System.Drawing.Size(567, 133);
            this.pnlTopPanel.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MainForm.Properties.Resources.Eagle_Eye_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(435, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // picLogo
            // 
            this.picLogo.Location = new System.Drawing.Point(1640, 0);
            this.picLogo.Margin = new System.Windows.Forms.Padding(5);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(126, 128);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;
            // 
            // btnClose2
            // 
            this.btnClose2.Location = new System.Drawing.Point(248, 571);
            this.btnClose2.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose2.Name = "btnClose2";
            this.btnClose2.Size = new System.Drawing.Size(155, 76);
            this.btnClose2.TabIndex = 43;
            this.btnClose2.Text = "Close";
            this.btnClose2.UseVisualStyleBackColor = true;
            this.btnClose2.Click += new System.EventHandler(this.btnClose2_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(248, 488);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(155, 76);
            this.btnInsert.TabIndex = 44;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 165);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 16);
            this.label3.TabIndex = 46;
            this.label3.Text = "Summary of Events";
            // 
            // rtbSummary
            // 
            this.rtbSummary.Location = new System.Drawing.Point(33, 189);
            this.rtbSummary.Margin = new System.Windows.Forms.Padding(4);
            this.rtbSummary.MaxLength = 500;
            this.rtbSummary.Name = "rtbSummary";
            this.rtbSummary.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbSummary.Size = new System.Drawing.Size(426, 117);
            this.rtbSummary.TabIndex = 47;
            this.rtbSummary.Text = "";
            // 
            // cbxTypeName
            // 
            this.cbxTypeName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTypeName.FormattingEnabled = true;
            this.cbxTypeName.Location = new System.Drawing.Point(213, 331);
            this.cbxTypeName.Margin = new System.Windows.Forms.Padding(4);
            this.cbxTypeName.Name = "cbxTypeName";
            this.cbxTypeName.Size = new System.Drawing.Size(235, 24);
            this.cbxTypeName.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 334);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 16);
            this.label2.TabIndex = 49;
            this.label2.Text = "Incident Type Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 401);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 16);
            this.label5.TabIndex = 53;
            this.label5.Text = "Sector Name:";
            // 
            // cbxSector
            // 
            this.cbxSector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSector.FormattingEnabled = true;
            this.cbxSector.Location = new System.Drawing.Point(213, 398);
            this.cbxSector.Margin = new System.Windows.Forms.Padding(4);
            this.cbxSector.Name = "cbxSector";
            this.cbxSector.Size = new System.Drawing.Size(235, 24);
            this.cbxSector.TabIndex = 52;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 433);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 16);
            this.label6.TabIndex = 55;
            this.label6.Text = "Shift Start Date and Time";
            // 
            // cbxShift
            // 
            this.cbxShift.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxShift.FormattingEnabled = true;
            this.cbxShift.Location = new System.Drawing.Point(213, 430);
            this.cbxShift.Margin = new System.Windows.Forms.Padding(4);
            this.cbxShift.Name = "cbxShift";
            this.cbxShift.Size = new System.Drawing.Size(235, 24);
            this.cbxShift.TabIndex = 54;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 369);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 16);
            this.label7.TabIndex = 57;
            this.label7.Text = "Personnel Last Name:";
            // 
            // cbxLastN
            // 
            this.cbxLastN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLastN.FormattingEnabled = true;
            this.cbxLastN.Location = new System.Drawing.Point(213, 366);
            this.cbxLastN.Margin = new System.Windows.Forms.Padding(4);
            this.cbxLastN.Name = "cbxLastN";
            this.cbxLastN.Size = new System.Drawing.Size(235, 24);
            this.cbxLastN.TabIndex = 56;
            // 
            // InsertIncidents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 666);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbxLastN);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbxShift);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbxSector);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxTypeName);
            this.Controls.Add(this.rtbSummary);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnClose2);
            this.Controls.Add(this.pnlTopPanel);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "InsertIncidents";
            this.Text = "Insert Incidents";
            this.Load += new System.EventHandler(this.InsertIncidents_Load);
            this.Shown += new System.EventHandler(this.InsertIncidents_Shown);
            this.pnlTopPanel.ResumeLayout(false);
            this.pnlTopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlTopPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btnClose2;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtbSummary;
        private System.Windows.Forms.ComboBox cbxTypeName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxSector;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxShift;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxLastN;
    }
}