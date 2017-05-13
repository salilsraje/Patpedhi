namespace Patpedhi.UI
{
    partial class TalukaMaster
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnFilter = new System.Windows.Forms.Button();
            this.txtFilterTaluka = new System.Windows.Forms.TextBox();
            this.lblFilterTaluka = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvTalukaList = new System.Windows.Forms.DataGridView();
            this.tabTalukaMaintenance = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtTalukaName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabCtlTalukaMaster.SuspendLayout();
            this.tabTalukaList.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTalukaList)).BeginInit();
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
            this.tabCtlTalukaMaster.Size = new System.Drawing.Size(444, 299);
            this.tabCtlTalukaMaster.TabIndex = 0;
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
            this.panel3.Controls.Add(this.txtFilterTaluka);
            this.panel3.Controls.Add(this.lblFilterTaluka);
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
            this.btnFilter.TabIndex = 1;
            this.btnFilter.Text = "&Filter";
            this.btnFilter.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // txtFilterTaluka
            // 
            this.txtFilterTaluka.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFilterTaluka.Location = new System.Drawing.Point(97, 4);
            this.txtFilterTaluka.MaxLength = 50;
            this.txtFilterTaluka.Name = "txtFilterTaluka";
            this.txtFilterTaluka.Size = new System.Drawing.Size(233, 21);
            this.txtFilterTaluka.TabIndex = 0;
            // 
            // lblFilterTaluka
            // 
            this.lblFilterTaluka.AutoSize = true;
            this.lblFilterTaluka.Location = new System.Drawing.Point(2, 7);
            this.lblFilterTaluka.Name = "lblFilterTaluka";
            this.lblFilterTaluka.Size = new System.Drawing.Size(81, 15);
            this.lblFilterTaluka.TabIndex = 0;
            this.lblFilterTaluka.Text = "Taluka Name";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dgvTalukaList);
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(436, 228);
            this.panel1.TabIndex = 0;
            // 
            // dgvTalukaList
            // 
            this.dgvTalukaList.AllowUserToAddRows = false;
            this.dgvTalukaList.AllowUserToDeleteRows = false;
            this.dgvTalukaList.AllowUserToOrderColumns = true;
            this.dgvTalukaList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Honeydew;
            this.dgvTalukaList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTalukaList.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvTalukaList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTalukaList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTalukaList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTalukaList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTalukaList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTalukaList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvTalukaList.GridColor = System.Drawing.Color.White;
            this.dgvTalukaList.Location = new System.Drawing.Point(0, 0);
            this.dgvTalukaList.MultiSelect = false;
            this.dgvTalukaList.Name = "dgvTalukaList";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTalukaList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTalukaList.RowHeadersVisible = false;
            this.dgvTalukaList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTalukaList.Size = new System.Drawing.Size(434, 226);
            this.dgvTalukaList.TabIndex = 1;
            this.dgvTalukaList.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTalukaList_CellMouseDoubleClick);
            this.dgvTalukaList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTalukaList_CellContentClick);
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
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.btnModify);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.txtTalukaName);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(436, 262);
            this.panel2.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(305, 106);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(64, 25);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(222, 106);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(64, 25);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "&Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnModify
            // 
            this.btnModify.BackColor = System.Drawing.Color.White;
            this.btnModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModify.Location = new System.Drawing.Point(139, 106);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(64, 25);
            this.btnModify.TabIndex = 4;
            this.btnModify.Text = "&Modify";
            this.btnModify.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(56, 106);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(64, 25);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "&Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtTalukaName
            // 
            this.txtTalukaName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTalukaName.Location = new System.Drawing.Point(137, 51);
            this.txtTalukaName.MaxLength = 50;
            this.txtTalukaName.Name = "txtTalukaName";
            this.txtTalukaName.Size = new System.Drawing.Size(233, 21);
            this.txtTalukaName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Taluka";
            // 
            // TalukaMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 299);
            this.Controls.Add(this.tabCtlTalukaMaster);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TalukaMaster";
            this.Text = "Taluka Master";
            this.Load += new System.EventHandler(this.TalukaMaster_Load);
            this.tabCtlTalukaMaster.ResumeLayout(false);
            this.tabTalukaList.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTalukaList)).EndInit();
            this.tabTalukaMaintenance.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCtlTalukaMaster;
        private System.Windows.Forms.TabPage tabTalukaList;
        private System.Windows.Forms.TabPage tabTalukaMaintenance;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvTalukaList;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.TextBox txtFilterTaluka;
        private System.Windows.Forms.Label lblFilterTaluka;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtTalukaName;
        private System.Windows.Forms.Label label1;
    }
}