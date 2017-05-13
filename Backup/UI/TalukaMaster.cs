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
    public partial class TalukaMaster : Form
    {
        private IDataProvider _IDataProvider;
        private Int16 _TalukaId;
        DataView dvTaluka;
        Int16 OperationFlag = 0;
        public TalukaMaster()
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
        public Int16 TalukaId
        {
            get
            {
                return _TalukaId;
            }
            set
            {
                _TalukaId = value;
            }
        }
        #endregion

        private void TalukaMaster_Load(object sender, EventArgs e)
        {
            try
            {
                dvTaluka = IDataProvider.GetTalukaList("").DefaultView;
                dgvTalukaList.DataSource = dvTaluka;
                dgvTalukaList.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {
                CustomException.CustomExceptionLog(ex); 
            }

            txtTalukaName.Text = "";
            txtTalukaName.Enabled = false;
            btnAdd.Enabled = true;
            btnModify.Enabled = false;
            btnSave.Enabled = false;
        }

        private void dgvTalukaList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                TalukaId = Convert.ToInt16(dgvTalukaList["Taluka ID", e.RowIndex].Value);
                txtTalukaName.Text = dgvTalukaList["Taluka Name", e.RowIndex].Value.ToString();
                tabCtlTalukaMaster.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                CustomException.CustomExceptionLog(ex);
            }

            txtTalukaName.Enabled = false;
            btnAdd.Enabled = false;
            btnModify.Enabled = true;
            btnSave.Enabled = false;
            btnModify.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OperationFlag = 1;
            txtTalukaName.Enabled = true;
            btnAdd.Enabled = false;
            btnModify.Enabled = false;            
            btnSave.Enabled = true;
            TalukaId = 0;
            txtTalukaName.Focus();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            OperationFlag = 2;
            txtTalukaName.Enabled = true;
            btnAdd.Enabled = false;
            btnModify.Enabled = false;
            btnSave.Enabled = true;
            txtTalukaName.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtTalukaName.Text = "";
            txtTalukaName.Enabled = false;
            btnAdd.Enabled = true;
            btnModify.Enabled = false;
            btnSave.Enabled = false;
            OperationFlag = 5;
            TalukaId = 0;
            btnAdd.Focus();
        }

        private Boolean Validation()
        {
            if (txtTalukaName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter taluka name", "Patpedhi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTalukaName.Focus();
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
                        Flag = IDataProvider.InsertModifyTaluka(txtTalukaName.Text.Trim(), 'I',LoginInfo.UserId, 0);
                        if (Flag == 0)
                            MessageBox.Show("Record Added successfully", "Patpedhi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Record already exist", "Patpedhi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (OperationFlag == 2)
                    {
                        Flag = IDataProvider.InsertModifyTaluka(txtTalukaName.Text.Trim(), 'M', LoginInfo.UserId, TalukaId);
                        if (Flag == 0)
                            MessageBox.Show("Record modified successfully", "Patpedhi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Record already exist", "Patpedhi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    TalukaId = 0;
                    txtTalukaName.Text = "";
                    txtTalukaName.Enabled = false;
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

        private void tabCtlTalukaMaster_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("test");
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            try
            {
                dvTaluka = IDataProvider.GetTalukaList(txtFilterTaluka.Text.Trim().Replace("'", "''")).DefaultView;
                dgvTalukaList.DataSource = dvTaluka;
            }
            catch (Exception ex)
            {
                CustomException.CustomExceptionLog(ex);
            }
        }

        private void dgvTalukaList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}