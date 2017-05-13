namespace Patpedhi.UI
{
    partial class DividentInterestRegister
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbRoundOff = new System.Windows.Forms.ComboBox();
            this.lblRoundOff = new System.Windows.Forms.Label();
            this.cmbTag = new System.Windows.Forms.ComboBox();
            this.lblTag = new System.Windows.Forms.Label();
            this.btnReport = new System.Windows.Forms.Button();
            this.cmbTaluka = new System.Windows.Forms.ComboBox();
            this.lblTaluka = new System.Windows.Forms.Label();
            this.cmbBranch = new System.Windows.Forms.ComboBox();
            this.lblBranch = new System.Windows.Forms.Label();
            this.cmbBank = new System.Windows.Forms.ComboBox();
            this.lblBank = new System.Windows.Forms.Label();
            this.cmbSchool = new System.Windows.Forms.ComboBox();
            this.lblSchool = new System.Windows.Forms.Label();
            this.chkTotalOnly = new System.Windows.Forms.CheckBox();
            this.lblTotalOnly = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTotalOnly);
            this.panel1.Controls.Add(this.chkTotalOnly);
            this.panel1.Controls.Add(this.cmbRoundOff);
            this.panel1.Controls.Add(this.lblRoundOff);
            this.panel1.Controls.Add(this.cmbTag);
            this.panel1.Controls.Add(this.lblTag);
            this.panel1.Controls.Add(this.btnReport);
            this.panel1.Controls.Add(this.cmbTaluka);
            this.panel1.Controls.Add(this.lblTaluka);
            this.panel1.Controls.Add(this.cmbBranch);
            this.panel1.Controls.Add(this.lblBranch);
            this.panel1.Controls.Add(this.cmbBank);
            this.panel1.Controls.Add(this.lblBank);
            this.panel1.Controls.Add(this.cmbSchool);
            this.panel1.Controls.Add(this.lblSchool);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 303);
            this.panel1.TabIndex = 0;
            // 
            // cmbRoundOff
            // 
            this.cmbRoundOff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoundOff.FormattingEnabled = true;
            this.cmbRoundOff.Location = new System.Drawing.Point(70, 201);
            this.cmbRoundOff.Name = "cmbRoundOff";
            this.cmbRoundOff.Size = new System.Drawing.Size(50, 21);
            this.cmbRoundOff.TabIndex = 31;
            // 
            // lblRoundOff
            // 
            this.lblRoundOff.AutoSize = true;
            this.lblRoundOff.Location = new System.Drawing.Point(8, 205);
            this.lblRoundOff.Name = "lblRoundOff";
            this.lblRoundOff.Size = new System.Drawing.Size(53, 13);
            this.lblRoundOff.TabIndex = 32;
            this.lblRoundOff.Text = "RoundOff";
            // 
            // cmbTag
            // 
            this.cmbTag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTag.FormattingEnabled = true;
            this.cmbTag.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.cmbTag.Location = new System.Drawing.Point(70, 166);
            this.cmbTag.Name = "cmbTag";
            this.cmbTag.Size = new System.Drawing.Size(50, 21);
            this.cmbTag.TabIndex = 4;
            // 
            // lblTag
            // 
            this.lblTag.AutoSize = true;
            this.lblTag.Location = new System.Drawing.Point(8, 170);
            this.lblTag.Name = "lblTag";
            this.lblTag.Size = new System.Drawing.Size(26, 13);
            this.lblTag.TabIndex = 30;
            this.lblTag.Text = "Tag";
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.White;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Location = new System.Drawing.Point(70, 266);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(64, 25);
            this.btnReport.TabIndex = 5;
            this.btnReport.Text = "&Report";
            this.btnReport.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // cmbTaluka
            // 
            this.cmbTaluka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTaluka.FormattingEnabled = true;
            this.cmbTaluka.Location = new System.Drawing.Point(70, 28);
            this.cmbTaluka.Name = "cmbTaluka";
            this.cmbTaluka.Size = new System.Drawing.Size(174, 21);
            this.cmbTaluka.TabIndex = 0;
            this.cmbTaluka.SelectedIndexChanged += new System.EventHandler(this.cmbTaluka_SelectedIndexChanged);
            // 
            // lblTaluka
            // 
            this.lblTaluka.AutoSize = true;
            this.lblTaluka.Location = new System.Drawing.Point(8, 32);
            this.lblTaluka.Name = "lblTaluka";
            this.lblTaluka.Size = new System.Drawing.Size(40, 13);
            this.lblTaluka.TabIndex = 26;
            this.lblTaluka.Text = "Taluka";
            // 
            // cmbBranch
            // 
            this.cmbBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBranch.FormattingEnabled = true;
            this.cmbBranch.Location = new System.Drawing.Point(70, 130);
            this.cmbBranch.Name = "cmbBranch";
            this.cmbBranch.Size = new System.Drawing.Size(228, 21);
            this.cmbBranch.TabIndex = 3;
            // 
            // lblBranch
            // 
            this.lblBranch.AutoSize = true;
            this.lblBranch.Location = new System.Drawing.Point(8, 134);
            this.lblBranch.Name = "lblBranch";
            this.lblBranch.Size = new System.Drawing.Size(41, 13);
            this.lblBranch.TabIndex = 25;
            this.lblBranch.Text = "Branch";
            // 
            // cmbBank
            // 
            this.cmbBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBank.FormattingEnabled = true;
            this.cmbBank.Location = new System.Drawing.Point(70, 96);
            this.cmbBank.Name = "cmbBank";
            this.cmbBank.Size = new System.Drawing.Size(228, 21);
            this.cmbBank.TabIndex = 2;
            this.cmbBank.SelectedIndexChanged += new System.EventHandler(this.cmbBank_SelectedIndexChanged);
            // 
            // lblBank
            // 
            this.lblBank.AutoSize = true;
            this.lblBank.Location = new System.Drawing.Point(8, 100);
            this.lblBank.Name = "lblBank";
            this.lblBank.Size = new System.Drawing.Size(32, 13);
            this.lblBank.TabIndex = 24;
            this.lblBank.Text = "Bank";
            // 
            // cmbSchool
            // 
            this.cmbSchool.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSchool.FormattingEnabled = true;
            this.cmbSchool.Location = new System.Drawing.Point(70, 62);
            this.cmbSchool.Name = "cmbSchool";
            this.cmbSchool.Size = new System.Drawing.Size(228, 21);
            this.cmbSchool.TabIndex = 1;
            // 
            // lblSchool
            // 
            this.lblSchool.AutoSize = true;
            this.lblSchool.Location = new System.Drawing.Point(8, 66);
            this.lblSchool.Name = "lblSchool";
            this.lblSchool.Size = new System.Drawing.Size(40, 13);
            this.lblSchool.TabIndex = 20;
            this.lblSchool.Text = "School";
            // 
            // chkTotalOnly
            // 
            this.chkTotalOnly.AutoSize = true;
            this.chkTotalOnly.Location = new System.Drawing.Point(70, 236);
            this.chkTotalOnly.Name = "chkTotalOnly";
            this.chkTotalOnly.Size = new System.Drawing.Size(15, 14);
            this.chkTotalOnly.TabIndex = 33;
            this.chkTotalOnly.UseVisualStyleBackColor = true;
            // 
            // lblTotalOnly
            // 
            this.lblTotalOnly.AutoSize = true;
            this.lblTotalOnly.Location = new System.Drawing.Point(8, 237);
            this.lblTotalOnly.Name = "lblTotalOnly";
            this.lblTotalOnly.Size = new System.Drawing.Size(31, 13);
            this.lblTotalOnly.TabIndex = 34;
            this.lblTotalOnly.Text = "Total";
            // 
            // DividentInterestRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 308);
            this.Controls.Add(this.panel1);
            this.Name = "DividentInterestRegister";
            this.Text = "DividentInterestRegister";
            this.Load += new System.EventHandler(this.DividentInterestRegister_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbTaluka;
        private System.Windows.Forms.Label lblTaluka;
        private System.Windows.Forms.ComboBox cmbBranch;
        private System.Windows.Forms.Label lblBranch;
        private System.Windows.Forms.ComboBox cmbBank;
        private System.Windows.Forms.Label lblBank;
        private System.Windows.Forms.ComboBox cmbSchool;
        private System.Windows.Forms.Label lblSchool;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.ComboBox cmbTag;
        private System.Windows.Forms.Label lblTag;
        private System.Windows.Forms.ComboBox cmbRoundOff;
        private System.Windows.Forms.Label lblRoundOff;
        private System.Windows.Forms.Label lblTotalOnly;
        private System.Windows.Forms.CheckBox chkTotalOnly;
    }
}