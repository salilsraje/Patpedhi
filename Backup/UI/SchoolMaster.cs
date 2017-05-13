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
    public partial class SchoolMaster : Form
    {
        private IDataProvider _IDataProvider;
        private Int16 _SchoolId;
        DataView dvSchool;
        DataTable dtTaluka;
        Int16 OperationFlag = 0;
        public SchoolMaster()
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
        public Int16 SchoolId
        {
            get
            {
                return _SchoolId;
            }
            set
            {
                _SchoolId = value;
            }
        }
        #endregion

        private void SchoolMaster_Load(object sender, EventArgs e)
        {
            try
            {
                dvSchool = IDataProvider.GetSchoolList("").DefaultView;
                dgvSchoolList.DataSource = dvSchool;
                dgvSchoolList.Columns[0].Visible = false;

                dtTaluka = IDataProvider.GetTalukaList("");
                DataRow dr1 = dtTaluka.NewRow();
                dr1["Taluka ID"] = 0;
                dr1["Taluka Name"] = "Select";
                dtTaluka.Rows.InsertAt(dr1, 0);
                cmbTaluka.DataSource = dtTaluka;                
                cmbTaluka.DisplayMember = "Taluka Name";
                cmbTaluka.ValueMember = "Taluka ID";
                
                
            }
            catch (Exception ex)
            {
                CustomException.CustomExceptionLog(ex);
            }

            txtSchoolCode.Text = "";
            txtSchoolName.Text = "";
            txtSchoolAddress.Text = "";
            txtPhone.Text = "";

            cmbTaluka.Enabled = false;
            txtSchoolCode.Enabled = false;
            txtSchoolName.Enabled = false;
            txtSchoolAddress.Enabled = false;
            txtPhone.Enabled = false;

            btnAdd.Enabled = true;
            btnModify.Enabled = false;
            btnSave.Enabled = false;

        }

        private void dgvSchoolList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OperationFlag = 1;
            cmbTaluka.Enabled = true;
            txtSchoolName.Enabled = true;
            txtSchoolAddress.Enabled = true;
            txtPhone.Enabled = true;
            btnAdd.Enabled = false;
            btnModify.Enabled = false;
            btnSave.Enabled = true;
            SchoolId = 0;
            //cmbTaluka.SelectedValue = 0;
            cmbTaluka.Focus();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            OperationFlag = 2;
            txtSchoolName.Enabled = true;
            txtSchoolAddress.Enabled = true;
            txtPhone.Enabled = true;
            btnAdd.Enabled = false;
            btnModify.Enabled = false;
            btnSave.Enabled = true;
            txtSchoolName.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //cmbTaluka.SelectedValue = 0;
            txtSchoolCode.Text = "";
            txtSchoolName.Text = "";
            txtSchoolAddress.Text = "";
            txtPhone.Text = "";
            cmbTaluka.Enabled = false;
            txtSchoolName.Enabled = false;
            txtSchoolAddress.Enabled = false;
            txtPhone.Enabled = false;
            btnAdd.Enabled = true;
            btnModify.Enabled = false;
            btnSave.Enabled = false;
            OperationFlag = 5;
            SchoolId = 0;
            btnAdd.Focus();
        }
        private Boolean Validation()
        {
            if (cmbTaluka.Text.Trim() == "" || cmbTaluka.Text.Trim() == "Select")
            {
                MessageBox.Show("Please select the taluka", "Patpedhi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbTaluka.Focus();
                return false;
            }
            else if (txtSchoolName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter the school name", "Patpedhi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSchoolName.Focus();
                return false;
            }
            else if (txtSchoolAddress.Text.Trim() == "")
            {
                MessageBox.Show("Please enter the school address", "Patpedhi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSchoolAddress.Focus();
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
                        Flag = IDataProvider.InsertModifySchool(txtSchoolCode.Text.Trim(), txtSchoolName.Text.Trim(),txtSchoolAddress.Text.Trim(),txtPhone.Text.Trim(),Convert.ToInt16(cmbTaluka.SelectedValue), 'I', LoginInfo.UserId, 0);
                        if (Flag == 0)
                            MessageBox.Show("Record Added successfully", "Patpedhi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Record already exist", "Patpedhi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (OperationFlag == 2)
                    {
                        Flag = IDataProvider.InsertModifySchool(txtSchoolCode.Text.Trim(),txtSchoolName.Text.Trim(), txtSchoolAddress.Text.Trim(), txtPhone.Text.Trim(), Convert.ToInt16(cmbTaluka.SelectedValue), 'M', LoginInfo.UserId, SchoolId);
                        if (Flag == 0)
                            MessageBox.Show("Record modified successfully", "Patpedhi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Record already exist", "Patpedhi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    SchoolId = 0;
                    //cmbTaluka.SelectedValue = 0;
                    txtSchoolCode.Text = "";
                    txtSchoolName.Text = "";
                    txtSchoolAddress.Text = "";
                    txtPhone.Text = "";
                    cmbTaluka.Enabled = false;
                    txtSchoolCode.Enabled = false;
                    txtSchoolName.Enabled = false;
                    txtSchoolAddress.Enabled = false;
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
                dvSchool = IDataProvider.GetSchoolList(txtFilterSchool.Text.Trim().Replace("'", "''")).DefaultView;
                dgvSchoolList.DataSource = dvSchool;
            }
            catch (Exception ex)
            {
                CustomException.CustomExceptionLog(ex);
            }
        }

        private void dgvSchoolList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                SchoolId = Convert.ToInt16(dgvSchoolList["School ID", e.RowIndex].Value);
                txtSchoolCode.Text = dgvSchoolList["School Code", e.RowIndex].Value.ToString();
                txtSchoolName.Text = dgvSchoolList["School Name", e.RowIndex].Value.ToString();
                cmbTaluka.Text = dgvSchoolList["Taluka", e.RowIndex].Value.ToString();
                txtSchoolAddress.Text = dgvSchoolList["School Address", e.RowIndex].Value.ToString();
                txtPhone.Text = dgvSchoolList["School Phone", e.RowIndex].Value.ToString();
                tabCtlSchoolMaster.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                CustomException.CustomExceptionLog(ex);
            }
            cmbTaluka.Enabled = false;
            txtSchoolName.Enabled = false;
            txtSchoolAddress.Enabled = false;
            txtPhone.Enabled = false;
            btnAdd.Enabled = false;
            btnModify.Enabled = true;
            btnSave.Enabled = false;
            btnModify.Focus();
        }
    }
}