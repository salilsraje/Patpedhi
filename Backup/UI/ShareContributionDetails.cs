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
    public partial class ShareContributionDetails : Form
    {
        private IDataProvider _IDataProvider;
        private Int64 _ShareContriId;
        private Int32 _YearId;
        private Int32 _MemberId;
        DataView dvShareContriList;        
        Int16 OperationFlag = 0;
        public ShareContributionDetails()
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
        public Int64 ShareContriId
        {
            get
            {
                return _ShareContriId;
            }
            set
            {
                _ShareContriId = value;
            }
        }
        public Int32 YearId
        {
            get
            {
                return _YearId;
            }
            set
            {
                _YearId = value;
            }
        }
        public Int32 MemberId
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

        private void ShareContributionDetails_Load(object sender, EventArgs e)
        {
            DispShareContributionList("","");

            txtMemberCode.Text = "";
            txtMemberName.Text = "";
            txtShare.Text = "";
            txtContribution.Text = "";
            txtMemberCode.Enabled = false;
            txtMemberName.Enabled = false;
            txtShare.Enabled = false;
            txtContribution.Enabled = false;
            btnAdd.Enabled = true;
            btnModify.Enabled = false;
            btnSave.Enabled = false;
            txtShare.BackColor = Color.White;
        }

        private void dgvShareContribution_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                txtShare.BackColor = Color.White;
                ShareContriId = Convert.ToInt64(dgvShareContribution["ShareContriId", e.RowIndex].Value);
                YearId = Convert.ToInt32(dgvShareContribution["YearId", e.RowIndex].Value);
                MemberId = Convert.ToInt32(dgvShareContribution["MemberId", e.RowIndex].Value);
                txtMemberCode.Text = dgvShareContribution["Member Code", e.RowIndex].Value.ToString();
                txtMemberName.Text = dgvShareContribution["Member Name", e.RowIndex].Value.ToString();
                txtShare.Text = dgvShareContribution["Share", e.RowIndex].Value.ToString();
                txtContribution.Text = dgvShareContribution["Contribution", e.RowIndex].Value.ToString();
                tabCtlShareContribution.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                CustomException.CustomExceptionLog(ex);
            }

            txtMemberCode.Enabled = false;            
            txtShare.Enabled = false;
            txtContribution.Enabled = false;
            btnAdd.Enabled = false;
            btnModify.Enabled = true;
            btnSave.Enabled = false;
            btnModify.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OperationFlag = 1;
            txtMemberCode.Enabled = true;            
            txtShare.Enabled = true;
            txtContribution.Enabled = true;
            btnAdd.Enabled = false;
            btnModify.Enabled = false;
            btnSave.Enabled = true;
            ShareContriId = 0;
            txtMemberCode.Focus();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            OperationFlag = 2;            
            txtShare.Enabled = true;
            txtContribution.Enabled = true;
            btnAdd.Enabled = false;
            btnModify.Enabled = false;
            btnSave.Enabled = true;
            txtShare.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtMemberCode.Text = "";
            txtMemberName.Text = "";
            txtShare.Text = "";
            txtContribution.Text = "";
            txtMemberCode.Enabled = false;
            txtMemberName.Enabled = false;
            txtShare.Enabled = false;
            txtContribution.Enabled = false;
            
            btnAdd.Enabled = true;
            btnModify.Enabled = false;
            btnSave.Enabled = false;
            OperationFlag = 5;
            ShareContriId = 0;
            btnAdd.Focus();
        }

        private Boolean Validation()
        {
            try
            {
                if (txtMemberCode.Text.Trim() == "")
                {
                    MessageBox.Show("Please enter member code", "Patpedhi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMemberCode.Focus();
                    return false;
                }
                else if (txtMemberName.Text.Trim() == "")
                {
                    MessageBox.Show("Please enter valid member code", "Patpedhi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMemberCode.Focus();
                    return false;
                }
                else if (txtShare.Text.Trim() == "")
                {
                    MessageBox.Show("Please enter share", "Patpedhi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtShare.Focus();
                    return false;
                }
                else if (txtContribution.Text.Trim() == "")
                {
                    MessageBox.Show("Please enter contribution", "Patpedhi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtContribution.Focus();
                    return false;
                }
                else if ((Convert.ToInt64(txtShare.Text.Trim()) % 10) != 0)
                {
                    MessageBox.Show("Shares should be in multiple of 10 only", "Patpedhi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtShare.Focus();
                    return false;
                }
                else if ((Convert.ToInt64(txtContribution.Text.Trim()) % 10) != 0)
                {
                    MessageBox.Show("Contribution should be in multiple of 10 only", "Patpedhi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtShare.Focus();
                    return false;
                }
                else
                    return true;
            }
            catch (Exception ex)
            {
                CustomException.CustomExceptionLog(ex);
                return false;
            }
        }

        private void txtShare_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ValidationLogic.IsInteger(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtContribution_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ValidationLogic.IsInteger(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
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
                        Flag = IDataProvider.InsertShareContri(txtMemberCode.Text.Trim(), LoginInfo.YearId, Convert.ToInt64(txtShare.Text.Trim()), Convert.ToInt64(txtContribution.Text.Trim()), 'I', LoginInfo.UserId, 0);
                        if (Flag == 0)
                            MessageBox.Show("Record Added successfully", "Patpedhi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else if(Flag == 2)
                            MessageBox.Show("Invalid member code", "Patpedhi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Record already exist", "Patpedhi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (OperationFlag == 2)
                    {
                        Flag = IDataProvider.InsertShareContri(txtMemberCode.Text.Trim(), LoginInfo.YearId, Convert.ToInt64(txtShare.Text.Trim()), Convert.ToInt64(txtContribution.Text.Trim()), 'M', LoginInfo.UserId, ShareContriId);
                        if (Flag == 0)
                            MessageBox.Show("Record modified successfully", "Patpedhi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Record already exist", "Patpedhi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    ShareContriId = 0;
                    txtMemberCode.Text = "";
                    txtMemberName.Text = "";
                    txtShare.Text = "";
                    txtContribution.Text = "";
                    txtMemberCode.Enabled = false;
                    txtMemberName.Enabled = false;
                    txtShare.Enabled = false;
                    txtContribution.Enabled = false;

                    btnAdd.Enabled = true;
                    btnModify.Enabled = false;
                    btnSave.Enabled = false;
                    OperationFlag = 4;
                    btnAdd.Focus();

                    DispShareContributionList("","");
                }
                
            }
            catch (Exception ex)
            {
                CustomException.CustomExceptionLog(ex);
            }
            
        }

        private void txtMemberCode_Leave(object sender, EventArgs e)
        {
            try
            {
                String MemberName = IDataProvider.GetMemberName(txtMemberCode.Text.Trim());
                if (MemberName == "")
                    MessageBox.Show("Please enter valid member code", "Patpedhi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    txtMemberName.Text = MemberName;
            }
            catch (Exception ex)
            {
                CustomException.CustomExceptionLog(ex);
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            
            UploadShareContributionDetails objUploadShareContriDetails = new UploadShareContributionDetails();
            ((UploadShareContributionDetails)objUploadShareContriDetails).IDataProvider = IDataProvider;
            ((Form)objUploadShareContriDetails).Location = new Point(0, 50);
            ((Form)objUploadShareContriDetails).Name = "Share contribution Upload";
            ((Form)objUploadShareContriDetails).ShowDialog();            
        }

        public void DispShareContributionList(string MemCode, String MemName)
        {
            try
            {
                dvShareContriList = IDataProvider.GetShareContributionList(MemCode,MemName).DefaultView;
                dgvShareContribution.DataSource = dvShareContriList;
                dgvShareContribution.Columns[0].Visible = false;
                dgvShareContribution.Columns[1].Visible = false;
                dgvShareContribution.Columns[2].Visible = false;
                lblTotalMemberVal.Text = dvShareContriList.Count.ToString();
            }
            catch (Exception ex)
            {
                CustomException.CustomExceptionLog(ex);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DispShareContributionList(txtFilterMemberCode.Text.Trim(),txtFilterMember.Text.Trim());
        }

        private void txtMemberCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ValidationLogic.IsInteger(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtShare_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtShare.Text) > 50000)
                txtShare.BackColor = Color.LightCoral;
            else
                txtShare.BackColor = Color.White;
        }
    }
}