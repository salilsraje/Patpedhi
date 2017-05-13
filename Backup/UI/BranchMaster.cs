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
    public partial class BranchMaster : Form
    {
        private IDataProvider _IDataProvider;
        private Int32 _BranchId;
        DataView dvBranch;
        DataTable dtBank;
        Int16 OperationFlag = 0;

        public BranchMaster()
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
        public Int32 BranchId
        {
            get
            {
                return _BranchId;
            }
            set
            {
                _BranchId = value;
            }
        }
        #endregion

        private void BranchMaster_Load(object sender, EventArgs e)
        {
            try
            {
                dvBranch = IDataProvider.GetBranchList("","").DefaultView;
                dgvBrachList.DataSource = dvBranch;
                dgvBrachList.Columns["Branch ID"].Visible = false;
                dgvBrachList.Columns["Bank ID"].Visible = false;

                dtBank = IDataProvider.GetBankList("");
                DataRow dr1 = dtBank.NewRow();
                dr1["Bank ID"] = 0;
                dr1["Bank Name"] = "Select";
                dtBank.Rows.InsertAt(dr1, 0);
                cmbBankName.DataSource = dtBank;
                cmbBankName.DisplayMember = "Bank Name";
                cmbBankName.ValueMember = "Bank ID";
            }
            catch (Exception ex)
            {
                CustomException.CustomExceptionLog(ex);
            }

            txtBranchCode.Text = "";
            txtBranchName.Text = "";
            txtBranchAddress.Text = "";
            txtPhone.Text = "";
            cmbBankName.Enabled = false;
            txtBranchName.Enabled = false;
            txtBranchAddress.Enabled = false;
            txtPhone.Enabled = false;
            btnAdd.Enabled = true;
            btnModify.Enabled = false;
            btnSave.Enabled = false;
        }

        private void dgvBrachList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                BranchId = Convert.ToInt32(dgvBrachList["Branch ID", e.RowIndex].Value);
                cmbBankName.Text = dgvBrachList["Bank Name", e.RowIndex].Value.ToString();
                txtBranchCode.Text = dgvBrachList["Branch Code", e.RowIndex].Value.ToString();
                txtBranchName.Text = dgvBrachList["Branch Name", e.RowIndex].Value.ToString();
                txtBranchAddress.Text = dgvBrachList["Address", e.RowIndex].Value.ToString();
                txtPhone.Text = dgvBrachList["Phone", e.RowIndex].Value.ToString();
                tabCtlBranchMaster.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                CustomException.CustomExceptionLog(ex);
            }

            cmbBankName.Enabled = false;
            txtBranchName.Enabled = false;
            txtBranchAddress.Enabled = false;
            txtPhone.Enabled = false;
            btnAdd.Enabled = false;
            btnModify.Enabled = true;
            btnSave.Enabled = false;
            btnModify.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OperationFlag = 1;
            cmbBankName.Enabled = true;
            txtBranchName.Enabled = true;
            txtBranchAddress.Enabled = true;
            txtPhone.Enabled = true;
            btnAdd.Enabled = false;
            btnModify.Enabled = false;
            btnSave.Enabled = true;
            BranchId = 0;
            //cmbBankName.SelectedValue = 0;
            cmbBankName.Focus();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            OperationFlag = 2;
            cmbBankName.Enabled = false;
            txtBranchName.Enabled = true;
            txtBranchAddress.Enabled = true;
            txtPhone.Enabled = true;
            btnAdd.Enabled = false;
            btnModify.Enabled = false;
            btnSave.Enabled = true;
            txtBranchName.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //cmbBankName.SelectedValue = 0;
            txtBranchCode.Text = "";
            txtBranchName.Text = "";
            txtBranchAddress.Text = "";
            txtPhone.Text = "";
            cmbBankName.Enabled = false;
            txtBranchName.Enabled = false;
            txtBranchAddress.Enabled = false;
            txtPhone.Enabled = false;
            btnAdd.Enabled = true;
            btnModify.Enabled = false;
            btnSave.Enabled = false;
            OperationFlag = 5;
            BranchId = 0;
            btnAdd.Focus();
        }

        private Boolean Validation()
        {
            if (cmbBankName.Text.Trim() == "" || cmbBankName.Text.Trim() == "Select")
            {
                MessageBox.Show("Please select the Bank", "Patpedhi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbBankName.Focus();
                return false;
            }
            else if (txtBranchName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter branch name", "Election", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBranchName.Focus();
                return false;
            }
            else if (txtBranchAddress.Text.Trim() == "")
            {
                MessageBox.Show("Please enter branch address", "Election", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBranchAddress.Focus();
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
                        Flag = IDataProvider.InsertModifyBranch(Convert.ToInt32(cmbBankName.SelectedValue),txtBranchCode.Text.Trim(),txtBranchName.Text.Trim(),txtBranchAddress.Text.Trim(),txtPhone.Text.Trim(), 'I', LoginInfo.UserId, 0);
                        if (Flag == 0)
                            MessageBox.Show("Record Added successfully", "Patpedhi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Record already exist", "Patpedhi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (OperationFlag == 2)
                    {
                        Flag = IDataProvider.InsertModifyBranch(Convert.ToInt32(cmbBankName.SelectedValue), txtBranchCode.Text.Trim(), txtBranchName.Text.Trim(), txtBranchAddress.Text.Trim(), txtPhone.Text.Trim(), 'M', LoginInfo.UserId, BranchId);
                        if (Flag == 0)
                            MessageBox.Show("Record modified successfully", "Patpedhi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Record already exist", "Patpedhi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    BranchId = 0;
                    //cmbBankName.SelectedValue = 0;
                    txtBranchCode.Text = "";
                    txtBranchName.Text = "";
                    txtBranchAddress.Text = "";
                    txtPhone.Text = "";
                    cmbBankName.Enabled = false;
                    txtBranchName.Enabled = false;
                    txtBranchAddress.Enabled = false;
                    txtPhone.Enabled = false;
                    btnAdd.Enabled = true;
                    btnModify.Enabled = false;
                    btnSave.Enabled = false;
                    OperationFlag = 4;
                    btnAdd.Focus();
                }
            }
            catch (Exception ex)
            {
                CustomException.CustomExceptionLog(ex);
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            try
            {
                dvBranch = IDataProvider.GetBranchList(txtFilterBank.Text.Trim().Replace("'", "''"),txtFilterBranch.Text.Trim().Replace("'","''")).DefaultView;
                dgvBrachList.DataSource = dvBranch;
            }
            catch (Exception ex)
            {
                CustomException.CustomExceptionLog(ex);
            }
        }
    }
}