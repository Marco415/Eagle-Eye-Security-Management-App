namespace MainForm
{
    partial class InsertType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertType));
            this.pnlTopPanel = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelType = new System.Windows.Forms.Button();
            this.btnInsertType = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtInsertDescription = new System.Windows.Forms.TextBox();
            this.txtInsertTypesName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlTopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTopPanel
            // 
            this.pnlTopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(222)))), ((int)(((byte)(211)))));
            this.pnlTopPanel.Controls.Add(this.picLogo);
            this.pnlTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopPanel.Location = new System.Drawing.Point(0, 0);
            this.pnlTopPanel.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTopPanel.Name = "pnlTopPanel";
            this.pnlTopPanel.Size = new System.Drawing.Size(300, 108);
            this.pnlTopPanel.TabIndex = 6;
            // 
            // picLogo
            // 
            this.picLogo.Image = global::MainForm.Properties.Resources.Eagle_Eye_Logo;
            this.picLogo.Location = new System.Drawing.Point(84, 4);
            this.picLogo.Margin = new System.Windows.Forms.Padding(4);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(108, 104);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancelType);
            this.panel1.Controls.Add(this.btnInsertType);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtInsertDescription);
            this.panel1.Controls.Add(this.txtInsertTypesName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 290);
            this.panel1.TabIndex = 5;
            // 
            // btnCancelType
            // 
            this.btnCancelType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelType.Location = new System.Drawing.Point(15, 231);
            this.btnCancelType.Name = "btnCancelType";
            this.btnCancelType.Size = new System.Drawing.Size(249, 50);
            this.btnCancelType.TabIndex = 14;
            this.btnCancelType.Text = "Cancel";
            this.btnCancelType.UseVisualStyleBackColor = true;
            // 
            // btnInsertType
            // 
            this.btnInsertType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertType.Location = new System.Drawing.Point(15, 161);
            this.btnInsertType.Name = "btnInsertType";
            this.btnInsertType.Size = new System.Drawing.Size(249, 50);
            this.btnInsertType.TabIndex = 1;
            this.btnInsertType.Text = "Insert Record";
            this.btnInsertType.UseVisualStyleBackColor = true;
            this.btnInsertType.Click += new System.EventHandler(this.btnInsertType_Click);
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
            // txtInsertDescription
            // 
            this.txtInsertDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInsertDescription.Location = new System.Drawing.Point(133, 108);
            this.txtInsertDescription.Name = "txtInsertDescription";
            this.txtInsertDescription.Size = new System.Drawing.Size(131, 23);
            this.txtInsertDescription.TabIndex = 8;
            // 
            // txtInsertTypesName
            // 
            this.txtInsertTypesName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInsertTypesName.Location = new System.Drawing.Point(133, 63);
            this.txtInsertTypesName.Name = "txtInsertTypesName";
            this.txtInsertTypesName.Size = new System.Drawing.Size(131, 23);
            this.txtInsertTypesName.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Type Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description :";
            // 
            // InsertType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 345);
            this.Controls.Add(this.pnlTopPanel);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InsertType";
            this.Text = "Insert Equipment Type";
            this.pnlTopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopPanel;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancelType;
        private System.Windows.Forms.Button btnInsertType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtInsertDescription;
        private System.Windows.Forms.TextBox txtInsertTypesName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}