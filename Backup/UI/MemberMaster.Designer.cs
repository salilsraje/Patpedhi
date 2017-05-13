namespace Patpedhi.UI
{
    partial class MemberMaster
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
            this.tabCtlMemberMaster = new System.Windows.Forms.TabControl();
            this.tabTalukaList = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnFilter = new System.Windows.Forms.Button();
            this.txtFilterMember = new System.Windows.Forms.TextBox();
            this.lblFilterMember = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvMemberList = new System.Windows.Forms.DataGridView();
            this.tabTalukaMaintenance = new System.Windows.Forms.TabPage();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.chkDefaulter = new System.Windows.Forms.CheckBox();
            this.dtpMemberShipDate = new System.Windows.Forms.DateTimePicker();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBankAccountNo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbBranchName = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbBankName = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbSchoolName = new System.Windows.Forms.ComboBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMemberAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMemberCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalMember = new System.Windows.Forms.Label();
            this.lblTotalMemberVal = new System.Windows.Forms.Label();
            this.tabCtlMemberMaster.SuspendLayout();
            this.tabTalukaList.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberList)).BeginInit();
            this.tabTalukaMaintenance.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCtlMemberMaster
            // 
            this.tabCtlMemberMaster.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabCtlMemberMaster.Controls.Add(this.tabTalukaList);
            this.tabCtlMemberMaster.Controls.Add(this.tabTalukaMaintenance);
            this.tabCtlMemberMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCtlMemberMaster.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCtlMemberMaster.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tabCtlMemberMaster.Location = new System.Drawing.Point(0, 0);
            this.tabCtlMemberMaster.Name = "tabCtlMemberMaster";
            this.tabCtlMemberMaster.SelectedIndex = 0;
            this.tabCtlMemberMaster.Size = new System.Drawing.Size(760, 495);
            this.tabCtlMemberMaster.TabIndex = 0;
            // 
            // tabTalukaList
            // 
            this.tabTalukaList.Controls.Add(this.panel3);
            this.tabTalukaList.Controls.Add(this.panel1);
            this.tabTalukaList.Location = new System.Drawing.Point(4, 27);
            this.tabTalukaList.Name = "tabTalukaList";
            this.tabTalukaList.Padding = new System.Windows.Forms.Padding(3);
            this.tabTalukaList.Size = new System.Drawing.Size(752, 464);
            this.tabTalukaList.TabIndex = 0;
            this.tabTalukaList.Text = "List";
            this.tabTalukaList.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblTotalMemberVal);
            this.panel3.Controls.Add(this.lblTotalMember);
            this.panel3.Controls.Add(this.btnFilter);
            this.panel3.Controls.Add(this.txtFilterMember);
            this.panel3.Controls.Add(this.lblFilterMember);
            this.panel3.Location = new System.Drawing.Point(0, 432);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(749, 32);
            this.panel3.TabIndex = 2;
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.White;
            this.btnFilter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Location = new System.Drawing.Point(453, 2);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 25);
            this.btnFilter.TabIndex = 2;
            this.btnFilter.Text = "&Filter";
            this.btnFilter.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // txtFilterMember
            // 
            this.txtFilterMember.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFilterMember.Location = new System.Drawing.Point(99, 4);
            this.txtFilterMember.MaxLength = 50;
            this.txtFilterMember.Name = "txtFilterMember";
            this.txtFilterMember.Size = new System.Drawing.Size(348, 21);
            this.txtFilterMember.TabIndex = 1;
            // 
            // lblFilterMember
            // 
            this.lblFilterMember.AutoSize = true;
            this.lblFilterMember.Location = new System.Drawing.Point(4, 7);
            this.lblFilterMember.Name = "lblFilterMember";
            this.lblFilterMember.Size = new System.Drawing.Size(91, 15);
            this.lblFilterMember.TabIndex = 0;
            this.lblFilterMember.Text = "Member Name";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dgvMemberList);
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(749, 427);
            this.panel1.TabIndex = 0;
            // 
            // dgvMemberList
            // 
            this.dgvMemberList.AllowUserToAddRows = false;
            this.dgvMemberList.AllowUserToDeleteRows = false;
            this.dgvMemberList.AllowUserToOrderColumns = true;
            this.dgvMemberList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Honeydew;
            this.dgvMemberList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMemberList.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvMemberList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMemberList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMemberList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMemberList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMemberList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMemberList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvMemberList.GridColor = System.Drawing.Color.White;
            this.dgvMemberList.Location = new System.Drawing.Point(0, 0);
            this.dgvMemberList.MultiSelect = false;
            this.dgvMemberList.Name = "dgvMemberList";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMemberList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMemberList.RowHeadersVisible = false;
            this.dgvMemberList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMemberList.Size = new System.Drawing.Size(747, 425);
            this.dgvMemberList.TabIndex = 1;
            this.dgvMemberList.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvMemberList_CellMouseDoubleClick);
            // 
            // tabTalukaMaintenance
            // 
            this.tabTalukaMaintenance.Controls.Add(this.Panel2);
            this.tabTalukaMaintenance.Location = new System.Drawing.Point(4, 27);
            this.tabTalukaMaintenance.Name = "tabTalukaMaintenance";
            this.tabTalukaMaintenance.Padding = new System.Windows.Forms.Padding(3);
            this.tabTalukaMaintenance.Size = new System.Drawing.Size(752, 464);
            this.tabTalukaMaintenance.TabIndex = 1;
            this.tabTalukaMaintenance.Text = "Maintenance";
            this.tabTalukaMaintenance.UseVisualStyleBackColor = true;
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel2.Controls.Add(this.btnDelete);
            this.Panel2.Controls.Add(this.chkDefaulter);
            this.Panel2.Controls.Add(this.dtpMemberShipDate);
            this.Panel2.Controls.Add(this.cmbStatus);
            this.Panel2.Controls.Add(this.label11);
            this.Panel2.Controls.Add(this.label10);
            this.Panel2.Controls.Add(this.label9);
            this.Panel2.Controls.Add(this.txtBankAccountNo);
            this.Panel2.Controls.Add(this.label8);
            this.Panel2.Controls.Add(this.cmbBranchName);
            this.Panel2.Controls.Add(this.label7);
            this.Panel2.Controls.Add(this.cmbBankName);
            this.Panel2.Controls.Add(this.label6);
            this.Panel2.Controls.Add(this.cmbSchoolName);
            this.Panel2.Controls.Add(this.txtPhone);
            this.Panel2.Controls.Add(this.label5);
            this.Panel2.Controls.Add(this.txtMemberAddress);
            this.Panel2.Controls.Add(this.label4);
            this.Panel2.Controls.Add(this.txtMemberName);
            this.Panel2.Controls.Add(this.label3);
            this.Panel2.Controls.Add(this.txtMemberCode);
            this.Panel2.Controls.Add(this.label2);
            this.Panel2.Controls.Add(this.btnCancel);
            this.Panel2.Controls.Add(this.btnSave);
            this.Panel2.Controls.Add(this.btnModify);
            this.Panel2.Controls.Add(this.btnAdd);
            this.Panel2.Controls.Add(this.label1);
            this.Panel2.Location = new System.Drawing.Point(0, 3);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(538, 455);
            this.Panel2.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(234, 421);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(64, 25);
            this.btnDelete.TabIndex = 28;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // chkDefaulter
            // 
            this.chkDefaulter.AutoSize = true;
            this.chkDefaulter.Location = new System.Drawing.Point(160, 221);
            this.chkDefaulter.Name = "chkDefaulter";
            this.chkDefaulter.Size = new System.Drawing.Size(49, 19);
            this.chkDefaulter.TabIndex = 10;
            this.chkDefaulter.Text = "YES";
            this.chkDefaulter.UseVisualStyleBackColor = true;
            // 
            // dtpMemberShipDate
            // 
            this.dtpMemberShipDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpMemberShipDate.Location = new System.Drawing.Point(160, 190);
            this.dtpMemberShipDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpMemberShipDate.Name = "dtpMemberShipDate";
            this.dtpMemberShipDate.Size = new System.Drawing.Size(128, 21);
            this.dtpMemberShipDate.TabIndex = 9;
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(160, 250);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(128, 23);
            this.cmbStatus.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(56, 254);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 15);
            this.label11.TabIndex = 27;
            this.label11.Text = "Status";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(56, 223);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 15);
            this.label10.TabIndex = 25;
            this.label10.Text = "Is Defaulter";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(56, 193);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 15);
            this.label9.TabIndex = 23;
            this.label9.Text = "Membership Date";
            // 
            // txtBankAccountNo
            // 
            this.txtBankAccountNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBankAccountNo.Location = new System.Drawing.Point(160, 161);
            this.txtBankAccountNo.MaxLength = 20;
            this.txtBankAccountNo.Name = "txtBankAccountNo";
            this.txtBankAccountNo.Size = new System.Drawing.Size(128, 21);
            this.txtBankAccountNo.TabIndex = 8;
            this.txtBankAccountNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBankAccountNo_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(56, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 15);
            this.label8.TabIndex = 21;
            this.label8.Text = "Bank Account No";
            // 
            // cmbBranchName
            // 
            this.cmbBranchName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBranchName.FormattingEnabled = true;
            this.cmbBranchName.Location = new System.Drawing.Point(160, 130);
            this.cmbBranchName.Name = "cmbBranchName";
            this.cmbBranchName.Size = new System.Drawing.Size(291, 23);
            this.cmbBranchName.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 15);
            this.label7.TabIndex = 19;
            this.label7.Text = "Branch Name";
            // 
            // cmbBankName
            // 
            this.cmbBankName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBankName.FormattingEnabled = true;
            this.cmbBankName.Location = new System.Drawing.Point(160, 99);
            this.cmbBankName.Name = "cmbBankName";
            this.cmbBankName.Size = new System.Drawing.Size(291, 23);
            this.cmbBankName.TabIndex = 6;
            this.cmbBankName.SelectedIndexChanged += new System.EventHandler(this.cmbBankName_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "Bank Name";
            // 
            // cmbSchoolName
            // 
            this.cmbSchoolName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSchoolName.FormattingEnabled = true;
            this.cmbSchoolName.Location = new System.Drawing.Point(160, 68);
            this.cmbSchoolName.Name = "cmbSchoolName";
            this.cmbSchoolName.Size = new System.Drawing.Size(291, 23);
            this.cmbSchoolName.TabIndex = 5;
            // 
            // txtPhone
            // 
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.Location = new System.Drawing.Point(160, 385);
            this.txtPhone.MaxLength = 50;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(128, 21);
            this.txtPhone.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 388);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Phone";
            // 
            // txtMemberAddress
            // 
            this.txtMemberAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMemberAddress.Location = new System.Drawing.Point(160, 281);
            this.txtMemberAddress.MaxLength = 200;
            this.txtMemberAddress.Multiline = true;
            this.txtMemberAddress.Name = "txtMemberAddress";
            this.txtMemberAddress.Size = new System.Drawing.Size(291, 96);
            this.txtMemberAddress.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Address";
            // 
            // txtMemberName
            // 
            this.txtMemberName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMemberName.Location = new System.Drawing.Point(160, 39);
            this.txtMemberName.MaxLength = 50;
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.Size = new System.Drawing.Size(291, 21);
            this.txtMemberName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Member Name";
            // 
            // txtMemberCode
            // 
            this.txtMemberCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMemberCode.Location = new System.Drawing.Point(160, 10);
            this.txtMemberCode.MaxLength = 5;
            this.txtMemberCode.Name = "txtMemberCode";
            this.txtMemberCode.Size = new System.Drawing.Size(128, 21);
            this.txtMemberCode.TabIndex = 3;
            this.txtMemberCode.Leave += new System.EventHandler(this.txtMemberCode_Leave);
            this.txtMemberCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMemberCode_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Member Code";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(412, 421);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(64, 25);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(323, 421);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(64, 25);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "&Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnModify
            // 
            this.btnModify.BackColor = System.Drawing.Color.White;
            this.btnModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModify.Location = new System.Drawing.Point(145, 421);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(64, 25);
            this.btnModify.TabIndex = 15;
            this.btnModify.Text = "&Modify";
            this.btnModify.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(56, 421);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(64, 25);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "&Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "School Name";
            // 
            // lblTotalMember
            // 
            this.lblTotalMember.AutoSize = true;
            this.lblTotalMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalMember.Location = new System.Drawing.Point(534, 6);
            this.lblTotalMember.Name = "lblTotalMember";
            this.lblTotalMember.Size = new System.Drawing.Size(112, 16);
            this.lblTotalMember.TabIndex = 3;
            this.lblTotalMember.Text = "Total Members";
            // 
            // lblTotalMemberVal
            // 
            this.lblTotalMemberVal.AutoSize = true;
            this.lblTotalMemberVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalMemberVal.Location = new System.Drawing.Point(650, 6);
            this.lblTotalMemberVal.Name = "lblTotalMemberVal";
            this.lblTotalMemberVal.Size = new System.Drawing.Size(12, 16);
            this.lblTotalMemberVal.TabIndex = 4;
            this.lblTotalMemberVal.Text = "t";
            // 
            // MemberMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 495);
            this.Controls.Add(this.tabCtlMemberMaster);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MemberMaster";
            this.Text = "MemberMaster";
            this.Load += new System.EventHandler(this.MemberMaster_Load);
            this.tabCtlMemberMaster.ResumeLayout(false);
            this.tabTalukaList.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberList)).EndInit();
            this.tabTalukaMaintenance.ResumeLayout(false);
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCtlMemberMaster;
        private System.Windows.Forms.TabPage tabTalukaList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.TextBox txtFilterMember;
        private System.Windows.Forms.Label lblFilterMember;
        private System.Windows.Forms.DataGridView dgvMemberList;
        private System.Windows.Forms.TabPage tabTalukaMaintenance;
        private System.Windows.Forms.Panel Panel2;
        private System.Windows.Forms.ComboBox cmbSchoolName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMemberAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMemberCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBranchName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbBankName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBankAccountNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpMemberShipDate;
        private System.Windows.Forms.CheckBox chkDefaulter;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblTotalMemberVal;
        private System.Windows.Forms.Label lblTotalMember;
    }
}