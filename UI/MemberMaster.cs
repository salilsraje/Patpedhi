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
    public partial class MemberMaster : Form
    {
        private IDataProvider _IDataProvider;
        private Int16 _MemberId;
        DataView dvMember;
        DataTable dtBank;
        DataTable dtSchool;
        DataTable dtBranch;
        Int16 OperationFlag = 0;

        public MemberMaster()
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
        public Int16 MemberId
        {
            get
            {
                return _MemberId;
            }
            set
            {
                _MemberId = value;
            }
        }
        #endregion

        private void MemberMaster_Load(object sender, EventArgs e)
        {
            cmbStatus.Items.Insert(0, "Active");
            cmbStatus.Items.Insert(1, "InActive");
            cmbStatus.SelectedIndex = 0;
            try
            {
                dvMember = IDataProvider.GetMemberList("").DefaultView;
                dgvMemberList.DataSource = dvMember;                
                lblTotalMemberVal.Text = dvMember.Count.ToString();

                dgvMemberList.Columns["Member ID"].Visible = false;

                dtSchool = IDataProvider.GetSchoolList("");
                DataRow dr1 = dtSchool.NewRow();
                dr1["School ID"] = 0;
                dr1["School Name"] = "Select";
                dtSchool.Rows.InsertAt(dr1, 0);
                cmbSchoolName.DataSource = dtSchool;
                cmbSchoolName.DisplayMember = "School Name";
                cmbSchoolName.ValueMember = "School ID";

                dtBank = IDataProvider.GetBankList("");
                DataRow dr2 = dtBank.NewRow();
                dr2["Bank ID"] = 0;
                dr2["Bank Name"] = "Select";
                dtBank.Rows.InsertAt(dr2, 0);
                cmbBankName.DataSource = dtBank;
                cmbBankName.DisplayMember = "Bank Name";
                cmbBankName.ValueMember = "Bank ID";
            }
            catch (Exception ex)
            {
                CustomException.CustomExceptionLog(ex);
            }

            txtMemberCode.Text = "";
            txtMemberName.Text = "";
            cmbSchoolName.SelectedValue = 0;
            cmbBankName.SelectedValue = 0;
            cmbBranchName.SelectedValue = 0;
            txtBankAccountNo.Text = "";
            dtpMemberShipDate.Value = DateTime.Now.Date;            
            chkDefaulter.Checked = false;
            cmbStatus.SelectedValue = 0;
            txtMemberAddress.Text = "";
            txtPhone.Text = "";

            txtMemberCode.Enabled = false;
            txtMemberName.Enabled = false;
            cmbSchoolName.Enabled = false;
            cmbBankName.Enabled = false;
            cmbBranchName.Enabled = false;
            txtBankAccountNo.Enabled = false;
            dtpMemberShipDate.Enabled = false;
            chkDefaulter.Enabled = false;
            cmbStatus.Enabled = false;
            txtMemberAddress.Enabled = false;
            txtPhone.Enabled = false;


            btnAdd.Enabled = true;
            btnModify.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = false;
        }

        private void dgvMemberList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                MemberId = Convert.ToInt16(dgvMemberList["Member ID", e.RowIndex].Value);
                txtMemberCode.Text = dgvMemberList["Member Code", e.RowIndex].Value.ToString();
                txtMemberName.Text = dgvMemberList["Member Name", e.RowIndex].Value.ToString();
                cmbSchoolName.Text = dgvMemberList["School Name", e.RowIndex].Value.ToString();
                cmbBankName.Text = (dgvMemberList["Bank Name", e.RowIndex].Value.ToString() == "" ? "Select" : dgvMemberList["Bank Name", e.RowIndex].Value.ToString());
                cmbBranchName.Text = (dgvMemberList["Branch Name", e.RowIndex].Value.ToString() == "" ? "Select" : dgvMemberList["Branch Name", e.RowIndex].Value.ToString());
                txtBankAccountNo.Text = dgvMemberList["Bank Accout No", e.RowIndex].Value.ToString();
                dtpMemberShipDate.Value = Convert.ToDateTime(dgvMemberList["Membership Date", e.RowIndex].Value);
                if (Convert.ToInt16(dgvMemberList["Tag", e.RowIndex].Value) == 0)
                    chkDefaulter.Checked = false;
                else if (Convert.ToInt16(dgvMemberList["Tag", e.RowIndex].Value) == 1)
                    chkDefaulter.Checked = true;
                else if (Convert.ToInt16(dgvMemberList["Tag", e.RowIndex].Value) == 2)
                    chkDefaulter.Checked = false;
                //cmbDefaulter.Text = dgvMemberList["Defaulter", e.RowIndex].Value.ToString();
                cmbStatus.Text = dgvMemberList["Status", e.RowIndex].Value.ToString();
                txtMemberAddress.Text = dgvMemberList["Address", e.RowIndex].Value.ToString();
                txtPhone.Text = dgvMemberList["Phone", e.RowIndex].Value.ToString();
                tabCtlMemberMaster.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                CustomException.CustomExceptionLog(ex);
            }
            txtMemberCode.Enabled = false;
            txtMemberName.Enabled = false;
            cmbSchoolName.Enabled = false;
            cmbBankName.Enabled = false;
            cmbBranchName.Enabled = false;
            txtBankAccountNo.Enabled = false;
            dtpMemberShipDate.Enabled = false;
            chkDefaulter.Enabled = false;
            cmbStatus.Enabled = false;
            txtMemberAddress.Enabled = false;
            txtPhone.Enabled = false;

            btnAdd.Enabled = false;
            btnModify.Enabled = true;
            btnDelete.Enabled = true;
            btnSave.Enabled = false;
            btnModify.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OperationFlag = 1;
            txtMemberCode.Enabled = true;
            txtMemberName.Enabled = true;
            cmbSchoolName.Enabled = true;
            cmbBankName.Enabled = true;
            cmbBranchName.Enabled = true;
            txtBankAccountNo.Enabled = true;
            dtpMemberShipDate.Enabled = true;
            chkDefaulter.Enabled = true;
            cmbStatus.Enabled = true;
            txtMemberAddress.Enabled = true;
            txtPhone.Enabled = true;

            btnAdd.Enabled = false;
            btnModify.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
            MemberId = 0;
            txtMemberCode.Focus();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            OperationFlag = 2;
            txtMemberCode.Enabled = false;
            txtMemberName.Enabled = true;
            cmbSchoolName.Enabled = true;
            cmbBankName.Enabled = true;
            cmbBranchName.Enabled = true;
            txtBankAccountNo.Enabled = true;
            dtpMemberShipDate.Enabled = true;
            chkDefaulter.Enabled = true;
            cmbStatus.Enabled = true;
            txtMemberAddress.Enabled = true;
            txtPhone.Enabled = true;

            btnAdd.Enabled = false;
            btnModify.Enabled = false;            
            btnSave.Enabled = true;
            txtMemberName.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtMemberCode.Text = "";
            txtMemberName.Text = "";
            //cmbSchoolName.SelectedValue = 0;
            //cmbBankName.SelectedValue = 0;
            //cmbBranchName.SelectedValue = 0;
            txtBankAccountNo.Text = "";
            dtpMemberShipDate.Value = DateTime.Now.Date;
            //chkDefaulter.Checked = false;
            cmbStatus.SelectedValue = 0;
            txtMemberAddress.Text = "";
            txtPhone.Text = "";

            txtMemberCode.Enabled = false;
            txtMemberName.Enabled = false;
            cmbSchoolName.Enabled = false;
            cmbBankName.Enabled = false;
            cmbBranchName.Enabled = false;
            txtBankAccountNo.Enabled = false;
            dtpMemberShipDate.Enabled = false;
            chkDefaulter.Enabled = false;
            cmbStatus.Enabled = false;
            txtMemberAddress.Enabled = false;
            txtPhone.Enabled = false;

            btnAdd.Enabled = true;
            btnModify.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = false;
            OperationFlag = 5;
            MemberId = 0;
            btnAdd.Focus();
        }

        private void cmbBankName_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtBranch = IDataProvider.GetBranchList(cmbBankName.Text.Trim(), "");
            DataRow dr2 = dtBranch.NewRow();
            dr2["Branch ID"] = 0;
            dr2["Branch Name"] = "Select";
            dtBranch.Rows.InsertAt(dr2, 0);
            cmbBranchName.DataSource = dtBranch;
            cmbBranchName.DisplayMember = "Branch Name";
            cmbBranchName.ValueMember = "Branch ID";
        }


        private Boolean Validation()
        {
            if (txtMemberCode.Text.Trim() == "")
            {
                MessageBox.Show("Please enter member code", "Patpedhi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMemberCode.Focus();
                return false;
            }
            else if (txtMemberName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter member name", "Patpedhi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMemberCode.Focus();
                return false;
            }
            else if (cmbSchoolName.Text.Trim() == "" || cmbSchoolName.Text.Trim() == "Select")
            {
                MessageBox.Show("Please school name", "Patpedhi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMemberCode.Focus();
                return false;
            }
            //else if (cmbBankName.Text.Trim() == "" || cmbBankName.Text.Trim() == "Select")
            //{
            //    MessageBox.Show("Please bank name", "Patpedhi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    txtMemberCode.Focus();
            //    return false;
            //}
            //else if (cmbBranchName.Text.Trim() == "" || cmbBranchName.Text.Trim() == "Select")
            //{
            //    MessageBox.Show("Please branch name", "Patpedhi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    txtMemberCode.Focus();
            //    return false;
            //}
            //else if (txtBankAccountNo.Text.Trim() == "")
            //{
            //    MessageBox.Show("Please enter bank account no", "Patpedhi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    txtMemberCode.Focus();
            //    return false;
            //}
            else
                return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Int16 Flag = 0;
            Int16 Tag = 0;
            try
            {
                if (Validation())
                {
                    if(chkDefaulter.Checked == true)
                        Tag = 1;
                    else if(cmbBankName.Text.Trim() == "Select" || cmbBranchName.Text.Trim() == "Select" || txtBankAccountNo.Text.Trim() == "")
                        Tag = 2;
                    else
                        Tag = 0;
                    if (OperationFlag == 1)
                    {
                        Flag = IDataProvider.InsertModifyMember(txtMemberCode.Text.Trim(), txtMemberName.Text.Trim(), Convert.ToInt32(cmbSchoolName.SelectedValue), Convert.ToInt32(cmbBankName.SelectedValue), Convert.ToInt32(cmbBranchName.SelectedValue),
                                txtBankAccountNo.Text.Trim(), dtpMemberShipDate.Value, Tag, Convert.ToInt16(cmbStatus.SelectedValue),
                                txtMemberAddress.Text.Trim(), txtPhone.Text.Trim(), 'I', LoginInfo.UserId, MemberId);
                        if (Flag == 0)
                            MessageBox.Show("Record Added successfully", "Patpedhi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Record already exist", "Patpedhi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (OperationFlag == 2)
                    {
                        Flag = IDataProvider.InsertModifyMember(txtMemberCode.Text.Trim(), txtMemberName.Text.Trim(), Convert.ToInt32(cmbSchoolName.SelectedValue), Convert.ToInt32(cmbBankName.SelectedValue), Convert.ToInt32(cmbBranchName.SelectedValue),
                                txtBankAccountNo.Text.Trim(), dtpMemberShipDate.Value, Tag, Convert.ToInt16(cmbStatus.SelectedValue),
                                txtMemberAddress.Text.Trim(), txtPhone.Text.Trim(), 'M', LoginInfo.UserId, MemberId);
                        if (Flag == 0)
                            MessageBox.Show("Record modified successfully", "Patpedhi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Record already exist", "Patpedhi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    
                    MemberId = 0;
                    txtMemberCode.Text = "";
                    txtMemberName.Text = "";
                    //cmbSchoolName.SelectedValue = 0;
                    //cmbBankName.SelectedValue = 0;
                    //cmbBranchName.SelectedValue = 0;
                    txtBankAccountNo.Text = "";
                    dtpMemberShipDate.Value = DateTime.Now.Date;
                    //chkDefaulter.Checked = false;
                    cmbStatus.SelectedValue = 0;
                    txtMemberAddress.Text = "";
                    txtPhone.Text = "";

                    txtMemberCode.Enabled = false;
                    txtMemberName.Enabled = false;
                    cmbSchoolName.Enabled = false;
                    cmbBankName.Enabled = false;
                    cmbBranchName.Enabled = false;
                    txtBankAccountNo.Enabled = false;
                    dtpMemberShipDate.Enabled = false;
                    chkDefaulter.Enabled = false;
                    cmbStatus.Enabled = false;
                    txtMemberAddress.Enabled = false;
                    txtPhone.Enabled = false;


                    btnAdd.Enabled = true;
                    btnModify.Enabled = false;
                    btnDelete.Enabled = false;
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
                dvMember = IDataProvider.GetMemberList(txtFilterMember.Text.Trim().Replace("'", "''")).DefaultView;
                dgvMemberList.DataSource = dvMember;
                lblTotalMemberVal.Text = dvMember.Count.ToString();
            }
            catch (Exception ex)
            {
                CustomException.CustomExceptionLog(ex);
            }
        }

        private void txtMemberCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ValidationLogic.IsInteger(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtBankAccountNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbBankName.Text == "Select" || cmbBranchName.Text == "Select")
            {
                MessageBox.Show("Please select bank branch", "Patpedhi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
            }
            else
                e.Handled = false;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr =  MessageBox.Show("Are you sure, you want to delete member", "Patpedhi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                Int32 RowEffected = IDataProvider.DeleteMember(txtMemberCode.Text.Trim());
                if (RowEffected > 0)
                    MessageBox.Show("Member Deleted successfully", "Patpedhi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("No Member found", "Patpedhi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            MemberId = 0;
            txtMemberCode.Text = "";
            txtMemberName.Text = "";
            //cmbSchoolName.SelectedValue = 0;
            //cmbBankName.SelectedValue = 0;
            //cmbBranchName.SelectedValue = 0;
            txtBankAccountNo.Text = "";
            dtpMemberShipDate.Value = DateTime.Now.Date;
            //chkDefaulter.Checked = false;
            cmbStatus.SelectedValue = 0;
            txtMemberAddress.Text = "";
            txtPhone.Text = "";

            txtMemberCode.Enabled = false;
            txtMemberName.Enabled = false;
            cmbSchoolName.Enabled = false;
            cmbBankName.Enabled = false;
            cmbBranchName.Enabled = false;
            txtBankAccountNo.Enabled = false;
            dtpMemberShipDate.Enabled = false;
            chkDefaulter.Enabled = false;
            cmbStatus.Enabled = false;
            txtMemberAddress.Enabled = false;
            txtPhone.Enabled = false;


            btnAdd.Enabled = true;
            btnModify.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = false;
            OperationFlag = 4;
            btnAdd.Focus();
        }

        private void txtMemberCode_Leave(object sender, EventArgs e)
        {
            Int32 CheckCount = IDataProvider.CheckMember(txtMemberCode.Text.Trim());
            if (CheckCount > 0)
            {
                MessageBox.Show("Member code already exists", "Patpedhi", MessageBoxButtons.OK, MessageBoxIcon.Information);                
                txtMemberCode.Focus();
            }
        }

        private void dgvMemberList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}