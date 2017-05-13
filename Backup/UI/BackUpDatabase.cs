using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Patpedhi.Interfaces;
using Patpedhi.Utilities;
using System.IO;

namespace Patpedhi.UI
{
    public partial class BackUpDatabase : Form
    {
        private IDataProvider _IDataProvider;
        public BackUpDatabase()
        {
            InitializeComponent();
        }

        #region Property Implementation
        public IDataProvider IDataProvider
        {
            get
            {
                return _IDataProvider;
            }
            set
            {
                _IDataProvider = value;
            }
        }
        #endregion

        private void btnDatabaseBackUp_Click(object sender, EventArgs e)
        {
            Int16 Flag = 0;
            StringBuilder Path = new StringBuilder();
            Path.Append(Application.StartupPath + "\\DBBackUp\\Patpedhi_New_" + DateTime.Now.ToShortDateString().Replace("/","-") + ".bak");
            try
            {
                if (Directory.Exists(Application.StartupPath + "\\DBBackUp") == false)
                    Directory.CreateDirectory(Application.StartupPath + "\\DBBackUp");

                Flag = IDataProvider.BackUpDatabase(Path.ToString());
                if (Flag == 0)
                    MessageBox.Show("Successfully", "Patpedhi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Failure, Please check the logs", "Patpedhi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
            }
            catch (Exception ex)
            {
                CustomException.CustomExceptionLog(ex);
            }
        }
    }
}