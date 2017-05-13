namespace Patpedhi.UI
{
    partial class BankMaster
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
            this.tabCtlBankMaster = new System.Windows.Forms.TabControl();
            this.tabTalukaList = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnFilter = new System.Windows.Forms.Button();
            this.txtFilterBank = new System.Windows.Forms.TextBox();
            this.lblFilterBank = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvBankList = new System.Windows.Forms.DataGridView();
            this.tabTalukaMaintenance = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtBankCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtBankName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabCtlBankMaster.SuspendLayout();
            this.tabTalukaList.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBankList)).BeginInit();
            this.tabTalukaMaintenance.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCtlBankMaster
            // 
            this.tabCtlBankMaster.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabCtlBankMaster.Controls.Add(this.tabTalukaList);
            this.tabCtlBankMaster.Controls.Add(this.tabTalukaMaintenance);
            this.tabCtlBankMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCtlBankMaster.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCtlBankMaster.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tabCtlBankMaster.Location = new System.Drawing.Point(0, 0);
            this.tabCtlBankMaster.Name = "tabCtlBankMaster";
            this.tabCtlBankMaster.SelectedIndex = 0;
            this.tabCtlBankMaster.Size = new System.Drawing.Size(444, 299);
            this.tabCtlBankMaster.TabIndex = 1;
            // 
            // tabTalukaList
            // 
            this.tabTalukaList.Controls.Add(this.panel3);
            this.tabTalukaList.Controls.Add(this.panel1);
            this.tabTalukaList.Location = new System.Drawing.Point(4, 27);
            this.tabTalukaList.Name = "tabTalukaList";
            this.tabTalukaList.Padding = new System.Windows.Forms.Padding(3);
            this.tabTalukaList.Size = new System.Drawing.Size(436, 268);
            this.tabTalukaList.TabIndex = 0;
            this.tabTalukaList.Text = "List";
            this.tabTalukaList.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnFilter);
            this.panel3.Controls.Add(this.txtFilterBank);
            this.panel3.Controls.Add(this.lblFilterBank);
            this.panel3.Location = new System.Drawing.Point(0, 233);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(436, 32);
            this.panel3.TabIndex = 2;
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.White;
            this.btnFilter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Location = new System.Drawing.Point(344, 4);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 25);
            this.btnFilter.TabIndex = 2;
            this.btnFilter.Text = "&Filter";
            this.btnFilter.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // txtFilterBank
            // 
            this.txtFilterBank.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFilterBank.Location = new System.Drawing.Point(97, 4);
            this.txtFilterBank.MaxLength = 50;
            this.txtFilterBank.Name = "txtFilterBank";
            this.txtFilterBank.Size = new System.Drawing.Size(233, 21);
            this.txtFilterBank.TabIndex = 1;
            // 
            // lblFilterBank
            // 
            this.lblFilterBank.AutoSize = true;
            this.lblFilterBank.Location = new System.Drawing.Point(2, 7);
            this.lblFilterBank.Name = "lblFilterBank";
            this.lblFilterBank.Size = new System.Drawing.Size(72, 15);
            this.lblFilterBank.TabIndex = 0;
            this.lblFilterBank.Text = "Bank Name";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dgvBankList);
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(436, 227);
            this.panel1.TabIndex = 0;
            // 
            // dgvBankList
            // 
            this.dgvBankList.AllowUserToAddRows = false;
            this.dgvBankList.AllowUserToDeleteRows = false;
            this.dgvBankList.AllowUserToOrderColumns = true;
            this.dgvBankList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Honeydew;
            this.dgvBankList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBankList.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvBankList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBankList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBankList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBankList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBankList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBankList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvBankList.GridColor = System.Drawing.Color.White;
            this.dgvBankList.Location = new System.Drawing.Point(0, 0);
            this.dgvBankList.MultiSelect = false;
            this.dgvBankList.Name = "dgvBankList";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBankList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBankList.RowHeadersVisible = false;
            this.dgvBankList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBankList.Size = new System.Drawing.Size(434, 225);
            this.dgvBankList.TabIndex = 0;
            this.dgvBankList.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvBankList_CellMouseDoubleClick);
            this.dgvBankList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBankList_CellContentClick);
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
            this.panel2.Controls.Add(this.txtBankCode);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.btnModify);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.txtBankName);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(436, 262);
            this.panel2.TabIndex = 1;
            // 
            // txtBankCode
            // 
            this.txtBankCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBankCode.Location = new System.Drawing.Point(136, 50);
            this.txtBankCode.MaxLength = 50;
            this.txtBankCode.Name = "txtBankCode";
            this.txtBankCode.ReadOnly = true;
            this.txtBankCode.Size = new System.Drawing.Size(109, 21);
            this.txtBankCode.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Bank Code";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(305, 137);
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
            this.btnSave.Location = new System.Drawing.Point(222, 137);
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
            this.btnModify.Location = new System.Drawing.Point(139, 137);
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
            this.btnAdd.Location = new System.Drawing.Point(56, 137);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(64, 25);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "&Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtBankName
            // 
            this.txtBankName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBankName.Location = new System.Drawing.Point(137, 88);
            this.txtBankName.MaxLength = 50;
            this.txtBankName.Name = "txtBankName";
            this.txtBankName.Size = new System.Drawing.Size(233, 21);
            this.txtBankName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bank Name";
            // 
            // BankMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 299);
            this.Controls.Add(this.tabCtlBankMaster);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BankMaster";
            this.Text = "BankMaster";
            this.Load += new System.EventHandler(this.BankMaster_Load);
            this.tabCtlBankMaster.ResumeLayout(false);
            this.tabTalukaList.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBankList)).EndInit();
            this.tabTalukaMaintenance.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCtlBankMaster;
        private System.Windows.Forms.TabPage tabTalukaList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.TextBox txtFilterBank;
        private System.Windows.Forms.Label lblFilterBank;
        private System.Windows.Forms.DataGridView dgvBankList;
        private System.Windows.Forms.TabPage tabTalukaMaintenance;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtBankCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtBankName;
        private System.Windows.Forms.Label label1;
    }
}