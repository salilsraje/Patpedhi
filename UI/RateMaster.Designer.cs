namespace Patpedhi.UI
{
    partial class RateMaster
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabCtlRateMaster = new System.Windows.Forms.TabControl();
            this.tabTalukaList = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvRateList = new System.Windows.Forms.DataGridView();
            this.tabTalukaMaintenance = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtpAGMDate = new System.Windows.Forms.DateTimePicker();
            this.lblAgmDate = new System.Windows.Forms.Label();
            this.txtDividentRate = new System.Windows.Forms.TextBox();
            this.lblDividentRate = new System.Windows.Forms.Label();
            this.cmbFinancialYear = new System.Windows.Forms.ComboBox();
            this.lblFinancialYear = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtInterestRate = new System.Windows.Forms.TextBox();
            this.lblInterestRate = new System.Windows.Forms.Label();
            this.dtpCutOffDate = new System.Windows.Forms.DateTimePicker();
            this.lblCutOffDate = new System.Windows.Forms.Label();
            this.tabCtlRateMaster.SuspendLayout();
            this.tabTalukaList.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRateList)).BeginInit();
            this.tabTalukaMaintenance.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCtlRateMaster
            // 
            this.tabCtlRateMaster.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabCtlRateMaster.Controls.Add(this.tabTalukaList);
            this.tabCtlRateMaster.Controls.Add(this.tabTalukaMaintenance);
            this.tabCtlRateMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCtlRateMaster.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCtlRateMaster.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tabCtlRateMaster.Location = new System.Drawing.Point(0, 0);
            this.tabCtlRateMaster.Name = "tabCtlRateMaster";
            this.tabCtlRateMaster.SelectedIndex = 0;
            this.tabCtlRateMaster.Size = new System.Drawing.Size(444, 299);
            this.tabCtlRateMaster.TabIndex = 1;
            // 
            // tabTalukaList
            // 
            this.tabTalukaList.Controls.Add(this.panel1);
            this.tabTalukaList.Location = new System.Drawing.Point(4, 27);
            this.tabTalukaList.Name = "tabTalukaList";
            this.tabTalukaList.Padding = new System.Windows.Forms.Padding(3);
            this.tabTalukaList.Size = new System.Drawing.Size(436, 268);
            this.tabTalukaList.TabIndex = 0;
            this.tabTalukaList.Text = "List";
            this.tabTalukaList.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dgvRateList);
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(436, 262);
            this.panel1.TabIndex = 0;
            // 
            // dgvRateList
            // 
            this.dgvRateList.AllowUserToAddRows = false;
            this.dgvRateList.AllowUserToDeleteRows = false;
            this.dgvRateList.AllowUserToOrderColumns = true;
            this.dgvRateList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Honeydew;
            this.dgvRateList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRateList.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvRateList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRateList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRateList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRateList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRateList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRateList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvRateList.GridColor = System.Drawing.Color.White;
            this.dgvRateList.Location = new System.Drawing.Point(0, 0);
            this.dgvRateList.MultiSelect = false;
            this.dgvRateList.Name = "dgvRateList";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRateList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRateList.RowHeadersVisible = false;
            this.dgvRateList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRateList.Size = new System.Drawing.Size(434, 260);
            this.dgvRateList.TabIndex = 0;
            this.dgvRateList.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvRateList_CellMouseDoubleClick);
            // 
            // tabTalukaMaintenance
            // 
            this.tabTalukaMaintenance.Controls.Add(this.panel2);
            this.tabTalukaMaintenance.Location = new System.Drawing.Point(4, 27);
            this.tabTalukaMaintenance.Name = "tabTalukaMaintenance";
            this.tabTalukaMaintenance.Padding = new System.Windows.Forms.Padding(3);
            this.tabTalukaMaintenance.Size = new System.Drawing.Size(436, 268);
            this.tabTalukaMaintenance.TabIndex = 1;
            this.tabTalukaMaintenance.Text = "Maintenance";
            this.tabTalukaMaintenance.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dtpCutOffDate);
            this.panel2.Controls.Add(this.lblCutOffDate);
            this.panel2.Controls.Add(this.dtpAGMDate);
            this.panel2.Controls.Add(this.lblAgmDate);
            this.panel2.Controls.Add(this.txtDividentRate);
            this.panel2.Controls.Add(this.lblDividentRate);
            this.panel2.Controls.Add(this.cmbFinancialYear);
            this.panel2.Controls.Add(this.lblFinancialYear);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.btnModify);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.txtInterestRate);
            this.panel2.Controls.Add(this.lblInterestRate);
            this.panel2.Location = new System.Drawing.Point(0, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(436, 262);
            this.panel2.TabIndex = 1;
            // 
            // dtpAGMDate
            // 
            this.dtpAGMDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAGMDate.Location = new System.Drawing.Point(160, 138);
            this.dtpAGMDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpAGMDate.Name = "dtpAGMDate";
            this.dtpAGMDate.Size = new System.Drawing.Size(112, 21);
            this.dtpAGMDate.TabIndex = 4;
            // 
            // lblAgmDate
            // 
            this.lblAgmDate.AutoSize = true;
            this.lblAgmDate.Location = new System.Drawing.Point(57, 140);
            this.lblAgmDate.Name = "lblAgmDate";
            this.lblAgmDate.Size = new System.Drawing.Size(63, 15);
            this.lblAgmDate.TabIndex = 11;
            this.lblAgmDate.Text = "AGM Date";
            // 
            // txtDividentRate
            // 
            this.txtDividentRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDividentRate.Location = new System.Drawing.Point(160, 66);
            this.txtDividentRate.MaxLength = 6;
            this.txtDividentRate.Name = "txtDividentRate";
            this.txtDividentRate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDividentRate.Size = new System.Drawing.Size(112, 21);
            this.txtDividentRate.TabIndex = 2;
            this.txtDividentRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDividentRate_KeyPress);
            // 
            // lblDividentRate
            // 
            this.lblDividentRate.AutoSize = true;
            this.lblDividentRate.Location = new System.Drawing.Point(57, 68);
            this.lblDividentRate.Name = "lblDividentRate";
            this.lblDividentRate.Size = new System.Drawing.Size(80, 15);
            this.lblDividentRate.TabIndex = 9;
            this.lblDividentRate.Text = "Divident Rate";
            // 
            // cmbFinancialYear
            // 
            this.cmbFinancialYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFinancialYear.FormattingEnabled = true;
            this.cmbFinancialYear.Location = new System.Drawing.Point(160, 28);
            this.cmbFinancialYear.Name = "cmbFinancialYear";
            this.cmbFinancialYear.Size = new System.Drawing.Size(112, 23);
            this.cmbFinancialYear.TabIndex = 1;
            // 
            // lblFinancialYear
            // 
            this.lblFinancialYear.AutoSize = true;
            this.lblFinancialYear.Location = new System.Drawing.Point(57, 32);
            this.lblFinancialYear.Name = "lblFinancialYear";
            this.lblFinancialYear.Size = new System.Drawing.Size(85, 15);
            this.lblFinancialYear.TabIndex = 7;
            this.lblFinancialYear.Text = "Financial Year";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(306, 214);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(64, 25);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(223, 214);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(64, 25);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "&Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnModify
            // 
            this.btnModify.BackColor = System.Drawing.Color.White;
            this.btnModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModify.Location = new System.Drawing.Point(140, 214);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(64, 25);
            this.btnModify.TabIndex = 6;
            this.btnModify.Text = "&Modify";
            this.btnModify.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(57, 214);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(64, 25);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "&Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtInterestRate
            // 
            this.txtInterestRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInterestRate.Location = new System.Drawing.Point(160, 102);
            this.txtInterestRate.MaxLength = 6;
            this.txtInterestRate.Name = "txtInterestRate";
            this.txtInterestRate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtInterestRate.Size = new System.Drawing.Size(112, 21);
            this.txtInterestRate.TabIndex = 3;
            this.txtInterestRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInterestRate_KeyPress);
            // 
            // lblInterestRate
            // 
            this.lblInterestRate.AutoSize = true;
            this.lblInterestRate.Location = new System.Drawing.Point(57, 104);
            this.lblInterestRate.Name = "lblInterestRate";
            this.lblInterestRate.Size = new System.Drawing.Size(76, 15);
            this.lblInterestRate.TabIndex = 2;
            this.lblInterestRate.Text = "Interest Rate";
            // 
            // dtpCutOffDate
            // 
            this.dtpCutOffDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCutOffDate.Location = new System.Drawing.Point(160, 174);
            this.dtpCutOffDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpCutOffDate.Name = "dtpCutOffDate";
            this.dtpCutOffDate.Size = new System.Drawing.Size(112, 21);
            this.dtpCutOffDate.TabIndex = 12;
            // 
            // lblCutOffDate
            // 
            this.lblCutOffDate.AutoSize = true;
            this.lblCutOffDate.Location = new System.Drawing.Point(57, 176);
            this.lblCutOffDate.Name = "lblCutOffDate";
            this.lblCutOffDate.Size = new System.Drawing.Size(69, 15);
            this.lblCutOffDate.TabIndex = 13;
            this.lblCutOffDate.Text = "CutOff Date";
            // 
            // RateMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 299);
            this.Controls.Add(this.tabCtlRateMaster);
            this.Name = "RateMaster";
            this.Text = "RateMaster";
            this.Load += new System.EventHandler(this.RateMaster_Load);
            this.tabCtlRateMaster.ResumeLayout(false);
            this.tabTalukaList.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRateList)).EndInit();
            this.tabTalukaMaintenance.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCtlRateMaster;
        private System.Windows.Forms.TabPage tabTalukaList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvRateList;
        private System.Windows.Forms.TabPage tabTalukaMaintenance;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtInterestRate;
        private System.Windows.Forms.Label lblInterestRate;
        private System.Windows.Forms.Label lblAgmDate;
        private System.Windows.Forms.TextBox txtDividentRate;
        private System.Windows.Forms.Label lblDividentRate;
        private System.Windows.Forms.ComboBox cmbFinancialYear;
        private System.Windows.Forms.Label lblFinancialYear;
        private System.Windows.Forms.DateTimePicker dtpAGMDate;
        private System.Windows.Forms.DateTimePicker dtpCutOffDate;
        private System.Windows.Forms.Label lblCutOffDate;
    }
}