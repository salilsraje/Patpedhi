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
    public partial class BankMaster : Form
    {
        private IDataProvider _IDataProvider;
        private Int32 _BankId;
        DataView dvBank;
        Int16 OperationFlag = 0;

        public BankMaster()
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
        public Int32 BankId
        {
            get
            {
                return _BankId;
            }
            set
            {
                _BankId = value;
            }
        }
        #endregion

        private void BankMaster_Load(object sender, EventArgs e)
        {
            try
            {
                dvBank = IDataProvider.GetBankList("").DefaultView;
                dgvBankList.DataSource = dvBank;
                dgvBankList.Columns["Bank ID"].Visible = false;
            }
            catch (Exception ex)
            {
                CustomException.CustomExceptionLog(ex);
            }

            txtBankCode.Text = "";
            txtBankName.Text = "";
            txtBankName.Enabled = false;
            btnAdd.Enabled = true;
            btnModify.Enabled = false;
            btnSave.Enabled = false;
        }

        private void dgvBankList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                BankId = Convert.ToInt32(dgvBankList["Bank ID", e.RowIndex].Value);
                txtBankCode.Text = dgvBankList["Bank Code", e.RowIndex].Value.ToString();
                txtBankName.Text = dgvBankList["Bank Name", e.RowIndex].Value.ToString();
                tabCtlBankMaster.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                CustomException.CustomExceptionLog(ex);
            }

            txtBankName.Enabled = false;
            btnAdd.Enabled = false;
            btnModify.Enabled = true;
            btnSave.Enabled = false;
            btnModify.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OperationFlag = 1;
            txtBankName.Enabled = true;
            btnAdd.Enabled = false;
            btnModify.Enabled = false;
            btnSave.Enabled = true;
            BankId = 0;
            txtBankName.Focus();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            OperationFlag = 2;
            txtBankName.Enabled = true;
            btnAdd.Enabled = false;
            btnModify.Enabled = false;
            btnSave.Enabled = true;
            txtBankName.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtBankName.Text = "";
            txtBankCode.Text = "";
            txtBankName.Enabled = false;
            btnAdd.Enabled = true;
            btnModify.Enabled = false;
            btnSave.Enabled = false;
            OperationFlag = 5;
            BankId = 0;
            btnAdd.Focus();
        }
        private Boolean Validation()
        {
            if (txtBankName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter bank name", "Election", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBankName.Focus();
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
                        Flag = IDataProvider.InsertModifyBank(txtBankName.Text.Trim(), 'I', LoginInfo.UserId, 0);
                        if (Flag == 0)
                            MessageBox.Show("Record Added successfully", "Patpedhi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Record already exist", "Patpedhi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (OperationFlag == 2)
                    {
                        Flag = IDataProvider.InsertModifyBank(txtBankName.Text.Trim(), 'M', LoginInfo.UserId, BankId);
                        if (Flag == 0)
                            MessageBox.Show("Record modified successfully", "Patpedhi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Record already exist", "Patpedhi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    BankId = 0;
                    txtBankCode.Text = "";
                    txtBankName.Text = "";
                    txtBankName.Enabled = false;
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
                dvBank = IDataProvider.GetBankList(txtFilterBank.Text.Trim().Replace("'", "''")).DefaultView;
                dgvBankList.DataSource = dvBank;
            }
            catch (Exception ex)
            {
                CustomException.CustomExceptionLog(ex);
            }
        }

        private void dgvBankList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}