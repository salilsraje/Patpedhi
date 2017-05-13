namespace Patpedhi.UI
{
    partial class BankBranchWiseReport
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
            this.btnReport = new System.Windows.Forms.Button();
            this.cmbBranch = new System.Windows.Forms.ComboBox();
            this.lblBranch = new System.Windows.Forms.Label();
            this.cmbBank = new System.Windows.Forms.ComboBox();
            this.lblBank = new System.Windows.Forms.Label();
            this.chkDivInter = new System.Windows.Forms.CheckBox();
            this.lblDivInter = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblDivInter);
            this.panel1.Controls.Add(this.chkDivInter);
            this.panel1.Controls.Add(this.cmbRoundOff);
            this.panel1.Controls.Add(this.lblRoundOff);
            this.panel1.Controls.Add(this.btnReport);
            this.panel1.Controls.Add(this.cmbBranch);
            this.panel1.Controls.Add(this.lblBranch);
            this.panel1.Controls.Add(this.cmbBank);
            this.panel1.Controls.Add(this.lblBank);
            this.panel1.Location = new System.Drawing.Point(4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 173);
            this.panel1.TabIndex = 1;
            // 
            // cmbRoundOff
            // 
            this.cmbRoundOff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoundOff.FormattingEnabled = true;
            this.cmbRoundOff.Location = new System.Drawing.Point(68, 67);
            this.cmbRoundOff.Name = "cmbRoundOff";
            this.cmbRoundOff.Size = new System.Drawing.Size(50, 21);
            this.cmbRoundOff.TabIndex = 33;
            // 
            // lblRoundOff
            // 
            this.lblRoundOff.AutoSize = true;
            this.lblRoundOff.Location = new System.Drawing.Point(8, 71);
            this.lblRoundOff.Name = "lblRoundOff";
            this.lblRoundOff.Size = new System.Drawing.Size(53, 13);
            this.lblRoundOff.TabIndex = 34;
            this.lblRoundOff.Text = "RoundOff";
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.White;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Location = new System.Drawing.Point(68, 139);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(64, 25);
            this.btnReport.TabIndex = 2;
            this.btnReport.Text = "&Report";
            this.btnReport.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // cmbBranch
            // 
            this.cmbBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBranch.FormattingEnabled = true;
            this.cmbBranch.Location = new System.Drawing.Point(68, 37);
            this.cmbBranch.Name = "cmbBranch";
            this.cmbBranch.Size = new System.Drawing.Size(228, 21);
            this.cmbBranch.TabIndex = 1;
            // 
            // lblBranch
            // 
            this.lblBranch.AutoSize = true;
            this.lblBranch.Location = new System.Drawing.Point(8, 41);
            this.lblBranch.Name = "lblBranch";
            this.lblBranch.Size = new System.Drawing.Size(41, 13);
            this.lblBranch.TabIndex = 25;
            this.lblBranch.Text = "Branch";
            // 
            // cmbBank
            // 
            this.cmbBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBank.FormattingEnabled = true;
            this.cmbBank.Location = new System.Drawing.Point(68, 7);
            this.cmbBank.Name = "cmbBank";
            this.cmbBank.Size = new System.Drawing.Size(228, 21);
            this.cmbBank.TabIndex = 0;
            this.cmbBank.SelectedIndexChanged += new System.EventHandler(this.cmbBank_SelectedIndexChanged);
            // 
            // lblBank
            // 
            this.lblBank.AutoSize = true;
            this.lblBank.Location = new System.Drawing.Point(8, 11);
            this.lblBank.Name = "lblBank";
            this.lblBank.Size = new System.Drawing.Size(32, 13);
            this.lblBank.TabIndex = 24;
            this.lblBank.Text = "Bank";
            // 
            // chkDivInter
            // 
            this.chkDivInter.AutoSize = true;
            this.chkDivInter.Location = new System.Drawing.Point(68, 105);
            this.chkDivInter.Name = "chkDivInter";
            this.chkDivInter.Size = new System.Drawing.Size(15, 14);
            this.chkDivInter.TabIndex = 35;
            this.chkDivInter.UseVisualStyleBackColor = true;
            // 
            // lblDivInter
            // 
            this.lblDivInter.AutoSize = true;
            this.lblDivInter.Location = new System.Drawing.Point(9, 106);
            this.lblDivInter.Name = "lblDivInter";
            this.lblDivInter.Size = new System.Drawing.Size(47, 13);
            this.lblDivInter.TabIndex = 36;
            this.lblDivInter.Text = "Div-Inter";
            // 
            // BankBranchWiseReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 180);
            this.Controls.Add(this.panel1);
            this.Name = "BankBranchWiseReport";
            this.Text = "BankBranchWiseReport";
            this.Load += new System.EventHandler(this.BankBranchWiseReport_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.ComboBox cmbBranch;
        private System.Windows.Forms.Label lblBranch;
        private System.Windows.Forms.ComboBox cmbBank;
        private System.Windows.Forms.Label lblBank;
        private System.Windows.Forms.ComboBox cmbRoundOff;
        private System.Windows.Forms.Label lblRoundOff;
        private System.Windows.Forms.Label lblDivInter;
        private System.Windows.Forms.CheckBox chkDivInter;
    }
}