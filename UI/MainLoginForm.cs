using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Patpedhi.Interfaces;

namespace Patpedhi.UI
{
    public partial class MainLoginForm : Form, IDataProviderConsumer
    {
        private IDataProvider _IDataProvider;
        public MainLoginForm()
        {
            InitializeComponent();
        }

        #region Property implementation
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.None;
            if (Validation())
            {
                Int32 UserID = IDataProvider.CheckUserLogin(txtUserCode.Text.Trim(), txtPassword.Text.Trim());
                if (UserID == 0)
                {
                    MessageBox.Show("Please enter correct User Name/ Password", "Patpedhi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //this.DialogResult = DialogResult.Retry;
                }
                else
                {
                    LoginInfo.UserId = UserID;
                    LoginInfo.UserName = txtUserCode.Text.Trim();
                    DataTable dt = IDataProvider.GetDefaultYear();
                    if (dt.Rows.Count > 0)
                    {
                        LoginInfo.YearId = Convert.ToInt32(dt.Rows[0]["yearid"].ToString());
                        LoginInfo.YearCode = dt.Rows[0]["yearcode"].ToString();
                    }
                    else
                    {
                        LoginInfo.YearId = 0;
                        LoginInfo.YearCode = "";
                    }
                    this.DialogResult = DialogResult.OK;
                }
            }
        }

        private Boolean Validation()
        {
            if (txtUserCode.Text.Trim() == "")
            {
                MessageBox.Show("Please enter user code", "Patpedhi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserCode.Focus();
                return false;
            }
            else if (txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Please enter password", "Patpedhi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserCode.Focus();
                return false;
            }
            else
                return true;
        }
    }
}