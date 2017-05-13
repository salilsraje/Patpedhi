namespace Patpedhi.UI
{
    partial class SchoolMaster
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
            this.tabCtlSchoolMaster = new System.Windows.Forms.TabControl();
            this.tabTalukaList = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnFilter = new System.Windows.Forms.Button();
            this.txtFilterSchool = new System.Windows.Forms.TextBox();
            this.lblFilterSchool = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvSchoolList = new System.Windows.Forms.DataGridView();
            this.tabTalukaMaintenance = new System.Windows.Forms.TabPage();
            this.pnlSchool = new System.Windows.Forms.Panel();
            this.cmbTaluka = new System.Windows.Forms.ComboBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSchoolAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSchoolName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSchoolCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabCtlSchoolMaster.SuspendLayout();
            this.tabTalukaList.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchoolList)).BeginInit();
            this.tabTalukaMaintenance.SuspendLayout();
            this.pnlSchool.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCtlSchoolMaster
            // 
            this.tabCtlSchoolMaster.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabCtlSchoolMaster.Controls.Add(this.tabTalukaList);
            this.tabCtlSchoolMaster.Controls.Add(this.tabTalukaMaintenance);
            this.tabCtlSchoolMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCtlSchoolMaster.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCtlSchoolMaster.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tabCtlSchoolMaster.Location = new System.Drawing.Point(0, 0);
            this.tabCtlSchoolMaster.Name = "tabCtlSchoolMaster";
            this.tabCtlSchoolMaster.SelectedIndex = 0;
            this.tabCtlSchoolMaster.Size = new System.Drawing.Size(549, 335);
            this.tabCtlSchoolMaster.TabIndex = 0;
            // 
            // tabTalukaList
            // 
            this.tabTalukaList.Controls.Add(this.panel3);
            this.tabTalukaList.Controls.Add(this.panel1);
            this.tabTalukaList.Location = new System.Drawing.Point(4, 27);
            this.tabTalukaList.Name = "tabTalukaList";
            this.tabTalukaList.Padding = new System.Windows.Forms.Padding(3);
            this.tabTalukaList.Size = new System.Drawing.Size(541, 304);
            this.tabTalukaList.TabIndex = 0;
            this.tabTalukaList.Text = "List";
            this.tabTalukaList.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnFilter);
            this.panel3.Controls.Add(this.txtFilterSchool);
            this.panel3.Controls.Add(this.lblFilterSchool);
            this.panel3.Location = new System.Drawing.Point(1, 269);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(538, 32);
            this.panel3.TabIndex = 2;
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.White;
            this.btnFilter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Location = new System.Drawing.Point(453, 4);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 25);
            this.btnFilter.TabIndex = 2;
            this.btnFilter.Text = "&Filter";
            this.btnFilter.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // txtFilterSchool
            // 
            this.txtFilterSchool.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFilterSchool.Location = new System.Drawing.Point(99, 4);
            this.txtFilterSchool.MaxLength = 50;
            this.txtFilterSchool.Name = "txtFilterSchool";
            this.txtFilterSchool.Size = new System.Drawing.Size(348, 21);
            this.txtFilterSchool.TabIndex = 1;
            // 
            // lblFilterSchool
            // 
            this.lblFilterSchool.AutoSize = true;
            this.lblFilterSchool.Location = new System.Drawing.Point(4, 7);
            this.lblFilterSchool.Name = "lblFilterSchool";
            this.lblFilterSchool.Size = new System.Drawing.Size(82, 15);
            this.lblFilterSchool.TabIndex = 0;
            this.lblFilterSchool.Text = "School Name";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dgvSchoolList);
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(538, 262);
            this.panel1.TabIndex = 0;
            // 
            // dgvSchoolList
            // 
            this.dgvSchoolList.AllowUserToAddRows = false;
            this.dgvSchoolList.AllowUserToDeleteRows = false;
            this.dgvSchoolList.AllowUserToOrderColumns = true;
            this.dgvSchoolList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Honeydew;
            this.dgvSchoolList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSchoolList.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvSchoolList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSchoolList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSchoolList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSchoolList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSchoolList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSchoolList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvSchoolList.GridColor = System.Drawing.Color.White;
            this.dgvSchoolList.Location = new System.Drawing.Point(0, 0);
            this.dgvSchoolList.MultiSelect = false;
            this.dgvSchoolList.Name = "dgvSchoolList";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSchoolList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSchoolList.RowHeadersVisible = false;
            this.dgvSchoolList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSchoolList.Size = new System.Drawing.Size(536, 260);
            this.dgvSchoolList.TabIndex = 1;
            this.dgvSchoolList.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSchoolList_CellMouseDoubleClick);
            // 
            // tabTalukaMaintenance
            // 
            this.tabTalukaMaintenance.Controls.Add(this.pnlSchool);
            this.tabTalukaMaintenance.Location = new System.Drawing.Point(4, 27);
            this.tabTalukaMaintenance.Name = "tabTalukaMaintenance";
            this.tabTalukaMaintenance.Padding = new System.Windows.Forms.Padding(3);
            this.tabTalukaMaintenance.Size = new System.Drawing.Size(541, 304);
            this.tabTalukaMaintenance.TabIndex = 1;
            this.tabTalukaMaintenance.Text = "Maintenance";
            this.tabTalukaMaintenance.UseVisualStyleBackColor = true;
            // 
            // pnlSchool
            // 
            this.pnlSchool.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlSchool.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSchool.Controls.Add(this.cmbTaluka);
            this.pnlSchool.Controls.Add(this.txtPhone);
            this.pnlSchool.Controls.Add(this.label5);
            this.pnlSchool.Controls.Add(this.txtSchoolAddress);
            this.pnlSchool.Controls.Add(this.label4);
            this.pnlSchool.Controls.Add(this.txtSchoolName);
            this.pnlSchool.Controls.Add(this.label3);
            this.pnlSchool.Controls.Add(this.txtSchoolCode);
            this.pnlSchool.Controls.Add(this.label2);
            this.pnlSchool.Controls.Add(this.btnCancel);
            this.pnlSchool.Controls.Add(this.btnSave);
            this.pnlSchool.Controls.Add(this.btnModify);
            this.pnlSchool.Controls.Add(this.btnAdd);
            this.pnlSchool.Controls.Add(this.label1);
            this.pnlSchool.Location = new System.Drawing.Point(0, 3);
            this.pnlSchool.Name = "pnlSchool";
            this.pnlSchool.Size = new System.Drawing.Size(538, 298);
            this.pnlSchool.TabIndex = 1;
            // 
            // cmbTaluka
            // 
            this.cmbTaluka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTaluka.FormattingEnabled = true;
            this.cmbTaluka.Location = new System.Drawing.Point(151, 6);
            this.cmbTaluka.Name = "cmbTaluka";
            this.cmbTaluka.Size = new System.Drawing.Size(128, 23);
            this.cmbTaluka.TabIndex = 3;
            // 
            // txtPhone
            // 
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.Location = new System.Drawing.Point(151, 222);
            this.txtPhone.MaxLength = 10;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(128, 21);
            this.txtPhone.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Phone";
            // 
            // txtSchoolAddress
            // 
            this.txtSchoolAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSchoolAddress.Location = new System.Drawing.Point(151, 112);
            this.txtSchoolAddress.MaxLength = 200;
            this.txtSchoolAddress.Multiline = true;
            this.txtSchoolAddress.Name = "txtSchoolAddress";
            this.txtSchoolAddress.Size = new System.Drawing.Size(291, 96);
            this.txtSchoolAddress.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "SchoolAddress";
            // 
            // txtSchoolName
            // 
            this.txtSchoolName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSchoolName.Location = new System.Drawing.Point(151, 77);
            this.txtSchoolName.MaxLength = 75;
            this.txtSchoolName.Name = "txtSchoolName";
            this.txtSchoolName.Size = new System.Drawing.Size(291, 21);
            this.txtSchoolName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "SchoolName";
            // 
            // txtSchoolCode
            // 
            this.txtSchoolCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSchoolCode.Location = new System.Drawing.Point(151, 42);
            this.txtSchoolCode.MaxLength = 4;
            this.txtSchoolCode.Name = "txtSchoolCode";
            this.txtSchoolCode.ReadOnly = true;
            this.txtSchoolCode.Size = new System.Drawing.Size(128, 21);
            this.txtSchoolCode.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "SchoolCode";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(329, 259);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(64, 25);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(238, 259);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(64, 25);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "&Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnModify
            // 
            this.btnModify.BackColor = System.Drawing.Color.White;
            this.btnModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModify.Location = new System.Drawing.Point(147, 259);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(64, 25);
            this.btnModify.TabIndex = 9;
            this.btnModify.Text = "&Modify";
            this.btnModify.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(56, 259);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(64, 25);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "&Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Taluka";
            // 
            // SchoolMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 335);
            this.Controls.Add(this.tabCtlSchoolMaster);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SchoolMaster";
            this.Text = "SchoolMaster";
            this.Load += new System.EventHandler(this.SchoolMaster_Load);
            this.tabCtlSchoolMaster.ResumeLayout(false);
            this.tabTalukaList.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchoolList)).EndInit();
            this.tabTalukaMaintenance.ResumeLayout(false);
            this.pnlSchool.ResumeLayout(false);
            this.pnlSchool.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCtlSchoolMaster;
        private System.Windows.Forms.TabPage tabTalukaList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.TextBox txtFilterSchool;
        private System.Windows.Forms.Label lblFilterSchool;
        private System.Windows.Forms.DataGridView dgvSchoolList;
        private System.Windows.Forms.TabPage tabTalukaMaintenance;
        private System.Windows.Forms.Panel pnlSchool;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSchoolCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSchoolAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSchoolName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbTaluka;
    }
}