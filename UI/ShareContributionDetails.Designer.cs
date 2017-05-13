namespace Patpedhi.UI
{
    partial class ShareContributionDetails
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
            this.tabCtlShareContribution = new System.Windows.Forms.TabControl();
            this.tabTalukaList = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtFilterMemberCode = new System.Windows.Forms.TextBox();
            this.lblFilterMemCode = new System.Windows.Forms.Label();
            this.txtFilterMember = new System.Windows.Forms.TextBox();
            this.lblFilterMember = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvShareContribution = new System.Windows.Forms.DataGridView();
            this.tabTalukaMaintenance = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnUpload = new System.Windows.Forms.Button();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.lblMemberName = new System.Windows.Forms.Label();
            this.txtMemberCode = new System.Windows.Forms.TextBox();
            this.lblMemberCode = new System.Windows.Forms.Label();
            this.txtContribution = new System.Windows.Forms.TextBox();
            this.lblContribution = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtShare = new System.Windows.Forms.TextBox();
            this.lblShare = new System.Windows.Forms.Label();
            this.lblTotalMemberVal = new System.Windows.Forms.Label();
            this.lblTotalMember = new System.Windows.Forms.Label();
            this.tabCtlShareContribution.SuspendLayout();
            this.tabTalukaList.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShareContribution)).BeginInit();
            this.tabTalukaMaintenance.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCtlShareContribution
            // 
            this.tabCtlShareContribution.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabCtlShareContribution.Controls.Add(this.tabTalukaList);
            this.tabCtlShareContribution.Controls.Add(this.tabTalukaMaintenance);
            this.tabCtlShareContribution.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCtlShareContribution.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCtlShareContribution.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tabCtlShareContribution.Location = new System.Drawing.Point(0, 0);
            this.tabCtlShareContribution.Name = "tabCtlShareContribution";
            this.tabCtlShareContribution.SelectedIndex = 0;
            this.tabCtlShareContribution.Size = new System.Drawing.Size(598, 460);
            this.tabCtlShareContribution.TabIndex = 2;
            // 
            // tabTalukaList
            // 
            this.tabTalukaList.Controls.Add(this.panel3);
            this.tabTalukaList.Controls.Add(this.panel1);
            this.tabTalukaList.Location = new System.Drawing.Point(4, 27);
            this.tabTalukaList.Name = "tabTalukaList";
            this.tabTalukaList.Padding = new System.Windows.Forms.Padding(3);
            this.tabTalukaList.Size = new System.Drawing.Size(590, 429);
            this.tabTalukaList.TabIndex = 0;
            this.tabTalukaList.Text = "List";
            this.tabTalukaList.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblTotalMemberVal);
            this.panel3.Controls.Add(this.lblTotalMember);
            this.panel3.Controls.Add(this.txtFilterMemberCode);
            this.panel3.Controls.Add(this.lblFilterMemCode);
            this.panel3.Controls.Add(this.txtFilterMember);
            this.panel3.Controls.Add(this.lblFilterMember);
            this.panel3.Controls.Add(this.btnRefresh);
            this.panel3.Location = new System.Drawing.Point(4, 365);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(582, 61);
            this.panel3.TabIndex = 1;
            // 
            // txtFilterMemberCode
            // 
            this.txtFilterMemberCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFilterMemberCode.Location = new System.Drawing.Point(82, 7);
            this.txtFilterMemberCode.MaxLength = 50;
            this.txtFilterMemberCode.Name = "txtFilterMemberCode";
            this.txtFilterMemberCode.Size = new System.Drawing.Size(92, 21);
            this.txtFilterMemberCode.TabIndex = 14;
            // 
            // lblFilterMemCode
            // 
            this.lblFilterMemCode.AutoSize = true;
            this.lblFilterMemCode.Location = new System.Drawing.Point(4, 9);
            this.lblFilterMemCode.Name = "lblFilterMemCode";
            this.lblFilterMemCode.Size = new System.Drawing.Size(68, 15);
            this.lblFilterMemCode.TabIndex = 13;
            this.lblFilterMemCode.Text = "Mem Code";
            // 
            // txtFilterMember
            // 
            this.txtFilterMember.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFilterMember.Location = new System.Drawing.Point(253, 7);
            this.txtFilterMember.MaxLength = 50;
            this.txtFilterMember.Name = "txtFilterMember";
            this.txtFilterMember.Size = new System.Drawing.Size(254, 21);
            this.txtFilterMember.TabIndex = 12;
            // 
            // lblFilterMember
            // 
            this.lblFilterMember.AutoSize = true;
            this.lblFilterMember.Location = new System.Drawing.Point(183, 9);
            this.lblFilterMember.Name = "lblFilterMember";
            this.lblFilterMember.Size = new System.Drawing.Size(73, 15);
            this.lblFilterMember.TabIndex = 11;
            this.lblFilterMember.Text = "Mem Name";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.White;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Location = new System.Drawing.Point(513, 4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(64, 25);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "&Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dgvShareContribution);
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(587, 358);
            this.panel1.TabIndex = 0;
            // 
            // dgvShareContribution
            // 
            this.dgvShareContribution.AllowUserToAddRows = false;
            this.dgvShareContribution.AllowUserToDeleteRows = false;
            this.dgvShareContribution.AllowUserToOrderColumns = true;
            this.dgvShareContribution.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Honeydew;
            this.dgvShareContribution.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvShareContribution.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvShareContribution.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvShareContribution.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShareContribution.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvShareContribution.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvShareContribution.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvShareContribution.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvShareContribution.GridColor = System.Drawing.Color.White;
            this.dgvShareContribution.Location = new System.Drawing.Point(0, 0);
            this.dgvShareContribution.MultiSelect = false;
            this.dgvShareContribution.Name = "dgvShareContribution";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShareContribution.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvShareContribution.RowHeadersVisible = false;
            this.dgvShareContribution.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShareContribution.Size = new System.Drawing.Size(585, 356);
            this.dgvShareContribution.TabIndex = 0;
            this.dgvShareContribution.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvShareContribution_CellMouseDoubleClick);
            // 
            // tabTalukaMaintenance
            // 
            this.tabTalukaMaintenance.Controls.Add(this.panel2);
            this.tabTalukaMaintenance.Location = new System.Drawing.Point(4, 27);
            this.tabTalukaMaintenance.Name = "tabTalukaMaintenance";
            this.tabTalukaMaintenance.Padding = new System.Windows.Forms.Padding(3);
            this.tabTalukaMaintenance.Size = new System.Drawing.Size(590, 402);
            this.tabTalukaMaintenance.TabIndex = 1;
            this.tabTalukaMaintenance.Text = "Maintenance";
            this.tabTalukaMaintenance.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnUpload);
            this.panel2.Controls.Add(this.txtMemberName);
            this.panel2.Controls.Add(this.lblMemberName);
            this.panel2.Controls.Add(this.txtMemberCode);
            this.panel2.Controls.Add(this.lblMemberCode);
            this.panel2.Controls.Add(this.txtContribution);
            this.panel2.Controls.Add(this.lblContribution);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.btnModify);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.txtShare);
            this.panel2.Controls.Add(this.lblShare);
            this.panel2.Location = new System.Drawing.Point(0, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(512, 396);
            this.panel2.TabIndex = 1;
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.Color.White;
            this.btnUpload.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpload.Location = new System.Drawing.Point(303, 214);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(64, 25);
            this.btnUpload.TabIndex = 8;
            this.btnUpload.Text = "&Upload";
            this.btnUpload.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // txtMemberName
            // 
            this.txtMemberName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMemberName.Location = new System.Drawing.Point(160, 71);
            this.txtMemberName.MaxLength = 6;
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.ReadOnly = true;
            this.txtMemberName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMemberName.Size = new System.Drawing.Size(337, 21);
            this.txtMemberName.TabIndex = 2;
            // 
            // lblMemberName
            // 
            this.lblMemberName.AutoSize = true;
            this.lblMemberName.Location = new System.Drawing.Point(57, 73);
            this.lblMemberName.Name = "lblMemberName";
            this.lblMemberName.Size = new System.Drawing.Size(91, 15);
            this.lblMemberName.TabIndex = 15;
            this.lblMemberName.Text = "Member Name";
            // 
            // txtMemberCode
            // 
            this.txtMemberCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMemberCode.Location = new System.Drawing.Point(160, 26);
            this.txtMemberCode.MaxLength = 5;
            this.txtMemberCode.Name = "txtMemberCode";
            this.txtMemberCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMemberCode.Size = new System.Drawing.Size(112, 21);
            this.txtMemberCode.TabIndex = 1;
            this.txtMemberCode.Leave += new System.EventHandler(this.txtMemberCode_Leave);
            this.txtMemberCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMemberCode_KeyPress);
            // 
            // lblMemberCode
            // 
            this.lblMemberCode.AutoSize = true;
            this.lblMemberCode.Location = new System.Drawing.Point(57, 28);
            this.lblMemberCode.Name = "lblMemberCode";
            this.lblMemberCode.Size = new System.Drawing.Size(86, 15);
            this.lblMemberCode.TabIndex = 13;
            this.lblMemberCode.Text = "Member Code";
            // 
            // txtContribution
            // 
            this.txtContribution.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContribution.Location = new System.Drawing.Point(160, 161);
            this.txtContribution.MaxLength = 10;
            this.txtContribution.Name = "txtContribution";
            this.txtContribution.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtContribution.Size = new System.Drawing.Size(112, 21);
            this.txtContribution.TabIndex = 4;
            this.txtContribution.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContribution_KeyPress);
            // 
            // lblContribution
            // 
            this.lblContribution.AutoSize = true;
            this.lblContribution.Location = new System.Drawing.Point(57, 163);
            this.lblContribution.Name = "lblContribution";
            this.lblContribution.Size = new System.Drawing.Size(73, 15);
            this.lblContribution.TabIndex = 9;
            this.lblContribution.Text = "Contribution";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(385, 214);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(64, 25);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(221, 214);
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
            this.btnModify.Location = new System.Drawing.Point(139, 214);
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
            // txtShare
            // 
            this.txtShare.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtShare.Location = new System.Drawing.Point(160, 116);
            this.txtShare.MaxLength = 10;
            this.txtShare.Name = "txtShare";
            this.txtShare.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtShare.Size = new System.Drawing.Size(112, 21);
            this.txtShare.TabIndex = 3;
            this.txtShare.Leave += new System.EventHandler(this.txtShare_Leave);
            this.txtShare.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtShare_KeyPress);
            // 
            // lblShare
            // 
            this.lblShare.AutoSize = true;
            this.lblShare.Location = new System.Drawing.Point(57, 118);
            this.lblShare.Name = "lblShare";
            this.lblShare.Size = new System.Drawing.Size(40, 15);
            this.lblShare.TabIndex = 2;
            this.lblShare.Text = "Share";
            // 
            // lblTotalMemberVal
            // 
            this.lblTotalMemberVal.AutoSize = true;
            this.lblTotalMemberVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalMemberVal.Location = new System.Drawing.Point(123, 37);
            this.lblTotalMemberVal.Name = "lblTotalMemberVal";
            this.lblTotalMemberVal.Size = new System.Drawing.Size(12, 16);
            this.lblTotalMemberVal.TabIndex = 16;
            this.lblTotalMemberVal.Text = "t";
            // 
            // lblTotalMember
            // 
            this.lblTotalMember.AutoSize = true;
            this.lblTotalMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalMember.Location = new System.Drawing.Point(7, 37);
            this.lblTotalMember.Name = "lblTotalMember";
            this.lblTotalMember.Size = new System.Drawing.Size(112, 16);
            this.lblTotalMember.TabIndex = 15;
            this.lblTotalMember.Text = "Total Members";
            // 
            // ShareContributionDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 460);
            this.Controls.Add(this.tabCtlShareContribution);
            this.Name = "ShareContributionDetails";
            this.Text = "ShareContributionDetails";
            this.Load += new System.EventHandler(this.ShareContributionDetails_Load);
            this.tabCtlShareContribution.ResumeLayout(false);
            this.tabTalukaList.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShareContribution)).EndInit();
            this.tabTalukaMaintenance.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCtlShareContribution;
        private System.Windows.Forms.TabPage tabTalukaList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvShareContribution;
        private System.Windows.Forms.TabPage tabTalukaMaintenance;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.Label lblMemberName;
        private System.Windows.Forms.TextBox txtMemberCode;
        private System.Windows.Forms.Label lblMemberCode;
        private System.Windows.Forms.TextBox txtContribution;
        private System.Windows.Forms.Label lblContribution;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtShare;
        private System.Windows.Forms.Label lblShare;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox txtFilterMemberCode;
        private System.Windows.Forms.Label lblFilterMemCode;
        private System.Windows.Forms.TextBox txtFilterMember;
        private System.Windows.Forms.Label lblFilterMember;
        private System.Windows.Forms.Label lblTotalMemberVal;
        private System.Windows.Forms.Label lblTotalMember;
    }
}