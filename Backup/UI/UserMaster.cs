using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Patpedhi.Interfaces;
using Patpedhi.Utilities;

namespace Patpedhi.UI
{
    public partial class UserMaster : Form
    {
        private IDataProvider _IDataProvider;
        private Int32 _UserId;
        DataView dvUser;
        Int16 OperationFlag = 0;

        public UserMaster()
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
        public Int32 UserId
        {
            get
            {
                return _UserId;
            }
            set
            {
                _UserId = value;
            }
        }
        #endregion

        private void UserMaster_Load(object sender, EventArgs e)
        {
            try
            {
                dvUser = IDataProvider.GetUserList("").DefaultView;
                dgvUserList.DataSource = dvUser;
                dgvUserList.Columns["User ID"].Visible = false;
                dgvUserList.Columns["Password"].Visible = false;
            }
            catch (Exception ex)
            {
                CustomException.CustomExceptionLog(ex);
            }

            txtUserCode.Text = "";
            txtUserName.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
            txtUserCode.Enabled = false;
            txtUserName.Enabled = false;
            btnAdd.Enabled = true;
            btnModify.Enabled = false;
            btnSave.Enabled = false;
        }

        private void dgvUserList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                UserId = Convert.ToInt16(dgvUserList["User ID", e.RowIndex].Value);
                txtUserCode.Text = dgvUserList["User Code", e.RowIndex].Value.ToString();
                txtUserName.Text = dgvUserList["User Name", e.RowIndex].Value.ToString();
                txtPassword.Text = dgvUserList["Password", e.RowIndex].Value.ToString();
                txtConfirmPassword.Text = dgvUserList["Password", e.RowIndex].Value.ToString();
                tabCtlUserMaster.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                CustomException.CustomExceptionLog(ex);
            }

            txtUserCode.Enabled = false;
            txtUserName.Enabled = false;
            txtPassword.Enabled = false;
            txtConfirmPassword.Enabled = false;
            btnAdd.Enabled = false;
            btnModify.Enabled = true;
            btnSave.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OperationFlag = 1;
            txtUserCode.Enabled = true;
            txtUserName.Enabled = true;
            txtPassword.Enabled = true;
            txtConfirmPassword.Enabled = true;
            btnAdd.Enabled = false;
            btnModify.Enabled = false;
            btnSave.Enabled = true;
            UserId = 0;
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            OperationFlag = 2;
            txtUserCode.Enabled = false;
            txtUserName.Enabled = true;
            txtPassword.Enabled = true;
            txtConfirmPassword.Enabled = true;
            btnAdd.Enabled = false;
            btnModify.Enabled = false;
            btnSave.Enabled = true;  
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtUserCode.Text = "";
            txtUserName.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
            txtUserCode.Enabled = false;
            txtUserName.Enabled = false;
            btnAdd.Enabled = true;
            btnModify.Enabled = false;
            btnSave.Enabled = false;
            OperationFlag = 5;
            UserId = 0;
        }
        private Boolean Validation()
        {
            if (txtUserName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter user name", "Patpedhi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserName.Focus();
                return false;
            }
            else if (txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Please enter password", "Patpedhi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
                return false;
            }
            else if (txtConfirmPassword.Text.Trim() == "")
            {
                MessageBox.Show("Please enter confirm password", "Patpedhi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtConfirmPassword.Focus();
                return false;
            }
            else if (txtPassword.Text.Trim() != txtConfirmPassword.Text.Trim())
            {
                MessageBox.Show("Password and confirm password are not same", "Patpedhi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtConfirmPassword.Focus();
                return false;
            }
            else
                return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Int16 Flag = 0;
            try
            {
                if (Validation())
                {
                    if (OperationFlag == 1)
                    {
                        Flag = IDataProvider.InsertModifyUser(txtUserCode.Text.Trim(), txtUserName.Text.Trim(),txtPassword.Text.Trim(), 'I',0);
                        if (Flag == 0)
                            MessageBox.Show("Record Added successfully", "Patpedhi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Record already exist", "Patpedhi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (OperationFlag == 2)
                    {
                        Flag = IDataProvider.InsertModifyUser(txtUserCode.Text.Trim(),txtUserName.Text.Trim(), txtPassword.Text.Trim(), 'M', UserId);
                        if (Flag == 0)
                            MessageBox.Show("Record modified successfully", "Patpedhi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Record already exist", "Patpedhi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                CustomException.CustomExceptionLog(ex);
            }
            UserId = 0;
            txtUserCode.Text = "";
            txtUserName.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
            txtUserCode.Enabled = false;
            txtUserName.Enabled = false;
            txtPassword.Enabled = false;
            txtConfirmPassword.Enabled = false;
            btnAdd.Enabled = true;
            btnModify.Enabled = false;
            btnSave.Enabled = false;
            OperationFlag = 4;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            try
            {
                dvUser = IDataProvider.GetUserList(txtFilterUser.Text.Trim().Replace("'", "''")).DefaultView;
                dgvUserList.DataSource = dvUser;
            }
            catch (Exception ex)
            {
                CustomException.CustomExceptionLog(ex);
            }
        }
    }
}