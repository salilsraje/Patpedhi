namespace Patpedhi.UI
{
    partial class BackUpDatabase
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
            this.Panel1 = new System.Windows.Forms.Panel();
            this.btnDatabaseBackUp = new System.Windows.Forms.Button();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.btnDatabaseBackUp);
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(291, 67);
            this.Panel1.TabIndex = 0;
            // 
            // btnDatabaseBackUp
            // 
            this.btnDatabaseBackUp.Location = new System.Drawing.Point(59, 22);
            this.btnDatabaseBackUp.Name = "btnDatabaseBackUp";
            this.btnDatabaseBackUp.Size = new System.Drawing.Size(174, 23);
            this.btnDatabaseBackUp.TabIndex = 0;
            this.btnDatabaseBackUp.Text = "Take Database BackUp";
            this.btnDatabaseBackUp.UseVisualStyleBackColor = true;
            this.btnDatabaseBackUp.Click += new System.EventHandler(this.btnDatabaseBackUp_Click);
            // 
            // BackUpDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 68);
            this.Controls.Add(this.Panel1);
            this.Name = "BackUpDatabase";
            this.Text = "BackUpDatabase";
            this.Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.Button btnDatabaseBackUp;
    }
}