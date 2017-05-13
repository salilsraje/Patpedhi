namespace Patpedhi.UI
{
    partial class BranchWiseSummary
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
            this.btnReport = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbOtherBanks = new System.Windows.Forms.RadioButton();
            this.rdbTDCCB = new System.Windows.Forms.RadioButton();
            this.cmbRoundOff = new System.Windows.Forms.ComboBox();
            this.lblRoundOff = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbRoundOff);
            this.panel1.Controls.Add(this.lblRoundOff);
            this.panel1.Controls.Add(this.btnReport);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(3, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 141);
            this.panel1.TabIndex = 0;
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(46, 115);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(103, 23);
            this.btnReport.TabIndex = 1;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbOtherBanks);
            this.groupBox1.Controls.Add(this.rdbTDCCB);
            this.groupBox1.Location = new System.Drawing.Point(11, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 63);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // rdbOtherBanks
            // 
            this.rdbOtherBanks.AutoSize = true;
            this.rdbOtherBanks.Location = new System.Drawing.Point(35, 38);
            this.rdbOtherBanks.Name = "rdbOtherBanks";
            this.rdbOtherBanks.Size = new System.Drawing.Size(84, 17);
            this.rdbOtherBanks.TabIndex = 1;
            this.rdbOtherBanks.TabStop = true;
            this.rdbOtherBanks.Text = "Other Banks";
            this.rdbOtherBanks.UseVisualStyleBackColor = true;
            // 
            // rdbTDCCB
            // 
            this.rdbTDCCB.AutoSize = true;
            this.rdbTDCCB.Location = new System.Drawing.Point(35, 13);
            this.rdbTDCCB.Name = "rdbTDCCB";
            this.rdbTDCCB.Size = new System.Drawing.Size(76, 17);
            this.rdbTDCCB.TabIndex = 0;
            this.rdbTDCCB.TabStop = true;
            this.rdbTDCCB.Text = "T.D.C.C.B.";
            this.rdbTDCCB.UseVisualStyleBackColor = true;
            // 
            // cmbRoundOff
            // 
            this.cmbRoundOff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoundOff.FormattingEnabled = true;
            this.cmbRoundOff.Location = new System.Drawing.Point(112, 78);
            this.cmbRoundOff.Name = "cmbRoundOff";
            this.cmbRoundOff.Size = new System.Drawing.Size(50, 21);
            this.cmbRoundOff.TabIndex = 33;
            // 
            // lblRoundOff
            // 
            this.lblRoundOff.AutoSize = true;
            this.lblRoundOff.Location = new System.Drawing.Point(50, 82);
            this.lblRoundOff.Name = "lblRoundOff";
            this.lblRoundOff.Size = new System.Drawing.Size(53, 13);
            this.lblRoundOff.TabIndex = 34;
            this.lblRoundOff.Text = "RoundOff";
            // 
            // BranchWiseSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 150);
            this.Controls.Add(this.panel1);
            this.Name = "BranchWiseSummary";
            this.Text = "BranchWiseSummary";
            this.Load += new System.EventHandler(this.BranchWiseSummary_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbTDCCB;
        private System.Windows.Forms.RadioButton rdbOtherBanks;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.ComboBox cmbRoundOff;
        private System.Windows.Forms.Label lblRoundOff;
    }
}