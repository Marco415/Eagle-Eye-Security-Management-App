namespace TemplateForm
{
    partial class InsertSectorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertSectorForm));
            this.lblName = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rdoYes = new System.Windows.Forms.RadioButton();
            this.rdoNo = new System.Windows.Forms.RadioButton();
            this.grpDangerlvl = new System.Windows.Forms.GroupBox();
            this.rdoOne = new System.Windows.Forms.RadioButton();
            this.rdoFive = new System.Windows.Forms.RadioButton();
            this.rdoTwo = new System.Windows.Forms.RadioButton();
            this.rdoFour = new System.Windows.Forms.RadioButton();
            this.rdoThree = new System.Windows.Forms.RadioButton();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpDangerlvl.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(11, 9);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(92, 16);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Sector Name:";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(11, 57);
            this.lblArea.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(122, 16);
            this.lblArea.TabIndex = 6;
            this.lblArea.Text = "Sector Area (km²):";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(158, 6);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(176, 23);
            this.txtName.TabIndex = 7;
            // 
            // txtArea
            // 
            this.txtArea.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArea.Location = new System.Drawing.Point(158, 54);
            this.txtArea.Margin = new System.Windows.Forms.Padding(4);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(176, 23);
            this.txtArea.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 106);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Is Active:";
            // 
            // rdoYes
            // 
            this.rdoYes.AutoSize = true;
            this.rdoYes.Location = new System.Drawing.Point(158, 106);
            this.rdoYes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoYes.Name = "rdoYes";
            this.rdoYes.Size = new System.Drawing.Size(48, 20);
            this.rdoYes.TabIndex = 26;
            this.rdoYes.TabStop = true;
            this.rdoYes.Text = "Yes";
            this.rdoYes.UseVisualStyleBackColor = true;
            // 
            // rdoNo
            // 
            this.rdoNo.AutoSize = true;
            this.rdoNo.Location = new System.Drawing.Point(228, 106);
            this.rdoNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoNo.Name = "rdoNo";
            this.rdoNo.Size = new System.Drawing.Size(42, 20);
            this.rdoNo.TabIndex = 27;
            this.rdoNo.TabStop = true;
            this.rdoNo.Text = "No";
            this.rdoNo.UseVisualStyleBackColor = true;
            // 
            // grpDangerlvl
            // 
            this.grpDangerlvl.Controls.Add(this.rdoOne);
            this.grpDangerlvl.Controls.Add(this.rdoFive);
            this.grpDangerlvl.Controls.Add(this.rdoTwo);
            this.grpDangerlvl.Controls.Add(this.rdoFour);
            this.grpDangerlvl.Controls.Add(this.rdoThree);
            this.grpDangerlvl.Location = new System.Drawing.Point(15, 145);
            this.grpDangerlvl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDangerlvl.Name = "grpDangerlvl";
            this.grpDangerlvl.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDangerlvl.Size = new System.Drawing.Size(283, 172);
            this.grpDangerlvl.TabIndex = 28;
            this.grpDangerlvl.TabStop = false;
            this.grpDangerlvl.Text = "Danger Level";
            // 
            // rdoOne
            // 
            this.rdoOne.AutoSize = true;
            this.rdoOne.Location = new System.Drawing.Point(0, 26);
            this.rdoOne.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoOne.Name = "rdoOne";
            this.rdoOne.Size = new System.Drawing.Size(33, 20);
            this.rdoOne.TabIndex = 19;
            this.rdoOne.TabStop = true;
            this.rdoOne.Text = "1";
            this.rdoOne.UseVisualStyleBackColor = true;
            // 
            // rdoFive
            // 
            this.rdoFive.AutoSize = true;
            this.rdoFive.Location = new System.Drawing.Point(0, 142);
            this.rdoFive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoFive.Name = "rdoFive";
            this.rdoFive.Size = new System.Drawing.Size(33, 20);
            this.rdoFive.TabIndex = 23;
            this.rdoFive.TabStop = true;
            this.rdoFive.Text = "5";
            this.rdoFive.UseVisualStyleBackColor = true;
            // 
            // rdoTwo
            // 
            this.rdoTwo.AutoSize = true;
            this.rdoTwo.Location = new System.Drawing.Point(0, 55);
            this.rdoTwo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoTwo.Name = "rdoTwo";
            this.rdoTwo.Size = new System.Drawing.Size(33, 20);
            this.rdoTwo.TabIndex = 20;
            this.rdoTwo.TabStop = true;
            this.rdoTwo.Text = "2";
            this.rdoTwo.UseVisualStyleBackColor = true;
            // 
            // rdoFour
            // 
            this.rdoFour.AutoSize = true;
            this.rdoFour.Location = new System.Drawing.Point(0, 113);
            this.rdoFour.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoFour.Name = "rdoFour";
            this.rdoFour.Size = new System.Drawing.Size(33, 20);
            this.rdoFour.TabIndex = 22;
            this.rdoFour.TabStop = true;
            this.rdoFour.Text = "4";
            this.rdoFour.UseVisualStyleBackColor = true;
            // 
            // rdoThree
            // 
            this.rdoThree.AutoSize = true;
            this.rdoThree.Location = new System.Drawing.Point(0, 84);
            this.rdoThree.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoThree.Name = "rdoThree";
            this.rdoThree.Size = new System.Drawing.Size(33, 20);
            this.rdoThree.TabIndex = 21;
            this.rdoThree.TabStop = true;
            this.rdoThree.Text = "3";
            this.rdoThree.UseVisualStyleBackColor = true;
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(85, 322);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(150, 64);
            this.btnInsert.TabIndex = 29;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(85, 410);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 62);
            this.btnCancel.TabIndex = 30;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // InsertSectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 484);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.grpDangerlvl);
            this.Controls.Add(this.rdoNo);
            this.Controls.Add(this.rdoYes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblName);
            this.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "InsertSectorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Insert Sector";
            this.grpDangerlvl.ResumeLayout(false);
            this.grpDangerlvl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdoYes;
        private System.Windows.Forms.RadioButton rdoNo;
        private System.Windows.Forms.GroupBox grpDangerlvl;
        private System.Windows.Forms.RadioButton rdoOne;
        private System.Windows.Forms.RadioButton rdoFive;
        private System.Windows.Forms.RadioButton rdoTwo;
        private System.Windows.Forms.RadioButton rdoFour;
        private System.Windows.Forms.RadioButton rdoThree;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnCancel;
    }
}