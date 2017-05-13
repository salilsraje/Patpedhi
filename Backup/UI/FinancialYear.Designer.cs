namespace Patpedhi.UI
{
    partial class FinancialYear
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
            this.tabCtlTalukaMaster = new System.Windows.Forms.TabControl();
            this.tabTalukaList = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvFinancialYear = new System.Windows.Forms.DataGridView();
            this.tabTalukaMaintenance = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chkDefaulter = new System.Windows.Forms.CheckBox();
            this.lblIsDefault = new System.Windows.Forms.Label();
            this.dtpYearEnding = new System.Windows.Forms.DateTimePicker();
            this.lblYearEnding = new System.Windows.Forms.Label();
            this.txtYearCode = new System.Windows.Forms.TextBox();
            this.lblFinancialYearCode = new System.Windows.Forms.Label();
            this.dtpYearStarting = new System.Windows.Forms.DateTimePicker();
            this.lblYearStarting = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.tabCtlTalukaMaster.SuspendLayout();
            this.tabTalukaList.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinancialYear)).BeginInit();
            this.tabTalukaMaintenance.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCtlTalukaMaster
            // 
            this.tabCtlTalukaMaster.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabCtlTalukaMaster.Controls.Add(this.tabTalukaList);
            this.tabCtlTalukaMaster.Controls.Add(this.tabTalukaMaintenance);
            this.tabCtlTalukaMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCtlTalukaMaster.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCtlTalukaMaster.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tabCtlTalukaMaster.Location = new System.Drawing.Point(0, 0);
            this.tabCtlTalukaMaster.Name = "tabCtlTalukaMaster";
            this.tabCtlTalukaMaster.SelectedIndex = 0;
            this.tabCtlTalukaMaster.Size = new System.Drawing.Size(447, 262);
            this.tabCtlTalukaMaster.TabIndex = 1;
            // 
            // tabTalukaList
            // 
            this.tabTalukaList.Controls.Add(this.panel1);
            this.tabTalukaList.Location = new System.Drawing.Point(4, 27);
            this.tabTalukaList.Name = "tabTalukaList";
            this.tabTalukaList.Padding = new System.Windows.Forms.Padding(3);
            this.tabTalukaList.Size = new System.Drawing.Size(439, 231);
            this.tabTalukaList.TabIndex = 0;
            this.tabTalukaList.Text = "List";
            this.tabTalukaList.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dgvFinancialYear);
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(436, 228);
            this.panel1.TabIndex = 0;
            // 
            // dgvFinancialYear
            // 
            this.dgvFinancialYear.AllowUserToAddRows = false;
            this.dgvFinancialYear.AllowUserToDeleteRows = false;
            this.dgvFinancialYear.AllowUserToOrderColumns = true;
            this.dgvFinancialYear.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Honeydew;
            this.dgvFinancialYear.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFinancialYear.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvFinancialYear.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFinancialYear.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFinancialYear.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFinancialYear.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvFinancialYear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFinancialYear.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvFinancialYear.GridColor = System.Drawing.Color.White;
            this.dgvFinancialYear.Location = new System.Drawing.Point(0, 0);
            this.dgvFinancialYear.MultiSelect = false;
            this.dgvFinancialYear.Name = "dgvFinancialYear";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFinancialYear.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFinancialYear.RowHeadersVisible = false;
            this.dgvFinancialYear.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFinancialYear.Size = new System.Drawing.Size(434, 226);
            this.dgvFinancialYear.TabIndex = 0;
            this.dgvFinancialYear.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvFinancialYear_CellMouseDoubleClick);
            // 
            // tabTalukaMaintenance
            // 
            this.tabTalukaMaintenance.Controls.Add(this.panel2);
            this.tabTalukaMaintenance.Location = new System.Drawing.Point(4, 27);
            this.tabTalukaMaintenance.Name = "tabTalukaMaintenance";
            this.tabTalukaMaintenance.Padding = new System.Windows.Forms.Padding(3);
            this.tabTalukaMaintenance.Size = new System.Drawing.Size(439, 231);
            this.tabTalukaMaintenance.TabIndex = 1;
            this.tabTalukaMaintenance.Text = "Maintenance";
            this.tabTalukaMaintenance.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.chkDefaulter);
            this.panel2.Controls.Add(this.lblIsDefault);
            this.panel2.Controls.Add(this.dtpYearEnding);
            this.panel2.Controls.Add(this.lblYearEnding);
            this.panel2.Controls.Add(this.txtYearCode);
            this.panel2.Controls.Add(this.lblFinancialYearCode);
            this.panel2.Controls.Add(this.dtpYearStarting);
            this.panel2.Controls.Add(this.lblYearStarting);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.btnModify);
            this.panel2.Location = new System.Drawing.Point(0, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(434, 226);
            this.panel2.TabIndex = 1;
            // 
            // chkDefaulter
            // 
            this.chkDefaulter.AutoSize = true;
            this.chkDefaulter.Location = new System.Drawing.Point(171, 126);
            this.chkDefaulter.Name = "chkDefaulter";
            this.chkDefaulter.Size = new System.Drawing.Size(49, 19);
            this.chkDefaulter.TabIndex = 4;
            this.chkDefaulter.Text = "YES";
            this.chkDefaulter.UseVisualStyleBackColor = true;
            // 
            // lblIsDefault
            // 
            this.lblIsDefault.AutoSize = true;
            this.lblIsDefault.Location = new System.Drawing.Point(63, 128);
            this.lblIsDefault.Name = "lblIsDefault";
            this.lblIsDefault.Size = new System.Drawing.Size(69, 15);
            this.lblIsDefault.TabIndex = 31;
            this.lblIsDefault.Text = "Is Defaulter";
            // 
            // dtpYearEnding
            // 
            this.dtpYearEnding.Enabled = false;
            this.dtpYearEnding.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpYearEnding.Location = new System.Drawing.Point(171, 86);
            this.dtpYearEnding.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpYearEnding.Name = "dtpYearEnding";
            this.dtpYearEnding.Size = new System.Drawing.Size(128, 21);
            this.dtpYearEnding.TabIndex = 3;
            // 
            // lblYearEnding
            // 
            this.lblYearEnding.AutoSize = true;
            this.lblYearEnding.Location = new System.Drawing.Point(63, 89);
            this.lblYearEnding.Name = "lblYearEnding";
            this.lblYearEnding.Size = new System.Drawing.Size(74, 15);
            this.lblYearEnding.TabIndex = 29;
            this.lblYearEnding.Text = "Year Ending";
            // 
            // txtYearCode
            // 
            this.txtYearCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtYearCode.Enabled = false;
            this.txtYearCode.Location = new System.Drawing.Point(171, 8);
            this.txtYearCode.MaxLength = 50;
            this.txtYearCode.Name = "txtYearCode";
            this.txtYearCode.Size = new System.Drawing.Size(128, 21);
            this.txtYearCode.TabIndex = 1;
            // 
            // lblFinancialYearCode
            // 
            this.lblFinancialYearCode.AutoSize = true;
            this.lblFinancialYearCode.Location = new System.Drawing.Point(63, 11);
            this.lblFinancialYearCode.Name = "lblFinancialYearCode";
            this.lblFinancialYearCode.Size = new System.Drawing.Size(64, 15);
            this.lblFinancialYearCode.TabIndex = 26;
            this.lblFinancialYearCode.Text = "Year Code";
            // 
            // dtpYearStarting
            // 
            this.dtpYearStarting.Enabled = false;
            this.dtpYearStarting.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpYearStarting.Location = new System.Drawing.Point(171, 47);
            this.dtpYearStarting.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpYearStarting.Name = "dtpYearStarting";
            this.dtpYearStarting.Size = new System.Drawing.Size(128, 21);
            this.dtpYearStarting.TabIndex = 2;
            // 
            // lblYearStarting
            // 
            this.lblYearStarting.AutoSize = true;
            this.lblYearStarting.Location = new System.Drawing.Point(63, 50);
            this.lblYearStarting.Name = "lblYearStarting";
            this.lblYearStarting.Size = new System.Drawing.Size(77, 15);
            this.lblYearStarting.TabIndex = 25;
            this.lblYearStarting.Text = "Year Starting";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(234, 176);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(64, 25);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(151, 176);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(64, 25);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "&Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnModify
            // 
            this.btnModify.BackColor = System.Drawing.Color.White;
            this.btnModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModify.Location = new System.Drawing.Point(68, 176);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(64, 25);
            this.btnModify.TabIndex = 5;
            this.btnModify.Text = "&Modify";
            this.btnModify.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // FinancialYear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 262);
            this.Controls.Add(this.tabCtlTalukaMaster);
            this.Name = "FinancialYear";
            this.Text = "FinancialYear";
            this.Load += new System.EventHandler(this.FinancialYear_Load);
            this.tabCtlTalukaMaster.ResumeLayout(false);
            this.tabTalukaList.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinancialYear)).EndInit();
            this.tabTalukaMaintenance.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCtlTalukaMaster;
        private System.Windows.Forms.TabPage tabTalukaList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvFinancialYear;
        private System.Windows.Forms.TabPage tabTalukaMaintenance;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.DateTimePicker dtpYearStarting;
        private System.Windows.Forms.Label lblYearStarting;
        private System.Windows.Forms.DateTimePicker dtpYearEnding;
        private System.Windows.Forms.Label lblYearEnding;
        private System.Windows.Forms.TextBox txtYearCode;
        private System.Windows.Forms.Label lblFinancialYearCode;
        private System.Windows.Forms.CheckBox chkDefaulter;
        private System.Windows.Forms.Label lblIsDefault;
    }
}