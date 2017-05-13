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
    public partial class RateMaster : Form
    {
        private IDataProvider _IDataProvider;
        private Int16 _RateId;
        private Int32 _YearId;
        DataView dvRate;
        DataTable dtFinancialYear;
        Int16 OperationFlag = 0;

        public RateMaster()
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
        public Int16 RateId
        {
            get
            {
                return _RateId;
            }
            set
            {
                _RateId = value;
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

        #endregion

        private void RateMaster_Load(object sender, EventArgs e)
        {
            try
            {
                dtFinancialYear = IDataProvider.GetFinancialYear();
                dtFinancialYear.Columns.Remove("Year Start");
                dtFinancialYear.Columns.Remove("Year End");
                dtFinancialYear.Columns.Remove("Default");
                

                DataRow dr = dtFinancialYear.NewRow();
                dr["Year Id"] = "0";
                dr["Year Code"] = "Select";
                dtFinancialYear.Rows.Add(dr);

                cmbFinancialYear.DataSource = dtFinancialYear;
                cmbFinancialYear.DisplayMember = "Year Code";
                cmbFinancialYear.ValueMember = "Year Id";
                cmbFinancialYear.SelectedIndex = cmbFinancialYear.FindStringExact("Select");

                dvRate = IDataProvider.GetRateList().DefaultView;
                dgvRateList.DataSource = dvRate;
                dgvRateList.Columns[0].Visible = false;
                dgvRateList.Columns[1].Visible = false;
            }
            catch (Exception ex)
            {
                CustomException.CustomExceptionLog(ex);
            }

            txtInterestRate.Text = "";
            txtDividentRate.Text = "";
            dtpAGMDate.Value = DateTime.Now;
            cmbFinancialYear.Enabled = false;
            txtInterestRate.Enabled = false;
            txtDividentRate.Enabled = false;
            dtpAGMDate.Enabled = false;
            dtpCutOffDate.Enabled = false;
            btnAdd.Enabled = true;
            btnModify.Enabled = false;
            btnSave.Enabled = false;
        }

        private void dgvRateList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                RateId = Convert.ToInt16(dgvRateList["RateId", e.RowIndex].Value);
                YearId = Convert.ToInt32(dgvRateList["YearId", e.RowIndex].Value);
                cmbFinancialYear.SelectedValue = YearId;
                txtInterestRate.Text = dgvRateList["Interest Rate", e.RowIndex].Value.ToString();
                txtDividentRate.Text = dgvRateList["Divident Rate", e.RowIndex].Value.ToString();
                dtpAGMDate.Value = Convert.ToDateTime(dgvRateList["AGM Date", e.RowIndex].Value);
                dtpCutOffDate.Value = Convert.ToDateTime(dgvRateList["CutOff Date", e.RowIndex].Value);
                tabCtlRateMaster.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                CustomException.CustomExceptionLog(ex);
            }

            cmbFinancialYear.Enabled = false;
            txtInterestRate.Enabled = false;
            txtDividentRate.Enabled = false;
            dtpAGMDate.Enabled = false;
            dtpCutOffDate.Enabled = false;
            btnAdd.Enabled = false;
            btnModify.Enabled = true;
            btnSave.Enabled = false;
            btnModify.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OperationFlag = 1;
            cmbFinancialYear.Enabled = true;
            txtInterestRate.Enabled = true;
            txtDividentRate.Enabled = true;
            dtpAGMDate.Enabled = true;
            dtpCutOffDate.Enabled = true;
            btnAdd.Enabled = false;
            btnModify.Enabled = false;
            btnSave.Enabled = true;
            RateId = 0;
            cmbFinancialYear.Focus();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            OperationFlag = 2;
            cmbFinancialYear.Enabled = false;
            txtInterestRate.Enabled = true;
            txtDividentRate.Enabled = true;
            dtpAGMDate.Enabled = true;
            dtpCutOffDate.Enabled = true;
            btnAdd.Enabled = false;
            btnModify.Enabled = false;
            btnSave.Enabled = true;
            txtInterestRate.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cmbFinancialYear.SelectedIndex = cmbFinancialYear.FindStringExact("Select");
            txtInterestRate.Text = "";
            txtDividentRate.Text = "";
            dtpAGMDate.Value = DateTime.Now;
            cmbFinancialYear.Enabled = false;
            txtInterestRate.Enabled = false;
            txtDividentRate.Enabled = false;
            dtpAGMDate.Enabled = false;
            dtpCutOffDate.Enabled = false;

            btnAdd.Enabled = true;
            btnModify.Enabled = false;
            btnSave.Enabled = false;
            OperationFlag = 5;
            RateId = 0;
            btnAdd.Focus();
        }

        private Boolean Validation()
        {
            if (cmbFinancialYear.Text.Trim() == "" || cmbFinancialYear.Text.Trim() == "Select")
            {
                MessageBox.Show("Please select financial year", "Patpedhi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbFinancialYear.Focus();
                return false;
            }
            else if (txtInterestRate.Text.Trim() == "")
            {
                MessageBox.Show("Please enter interest rate", "Patpedhi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtInterestRate.Focus();
                return false;
            }
            else if (txtDividentRate.Text.Trim() == "")
            {
                MessageBox.Show("Please enter divident rate", "Patpedhi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDividentRate.Focus();
                return false;
            }
            else
                return true;
        }

        private void txtInterestRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ValidationLogic.IsPrice(e.KeyChar, txtInterestRate.Text))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtDividentRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ValidationLogic.IsPrice(e.KeyChar, txtDividentRate.Text))
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
                        Flag = IDataProvider.InsertModifyRate(Convert.ToInt32(cmbFinancialYear.SelectedValue), Convert.ToSingle(txtInterestRate.Text.Trim()), Convert.ToSingle(txtDividentRate.Text.Trim()), dtpAGMDate.Value, 'I', LoginInfo.UserId, 0,dtpCutOffDate.Value);
                        if (Flag == 0)
                            MessageBox.Show("Record Added successfully", "Patpedhi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Record already exist", "Patpedhi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (OperationFlag == 2)
                    {
                        Flag = IDataProvider.InsertModifyRate(Convert.ToInt32(cmbFinancialYear.SelectedValue), Convert.ToSingle(txtInterestRate.Text.Trim()), Convert.ToSingle(txtDividentRate.Text.Trim()), dtpAGMDate.Value, 'M', LoginInfo.UserId, RateId, dtpCutOffDate.Value);
                        if (Flag == 0)
                            MessageBox.Show("Record modified successfully", "Patpedhi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Record already exist", "Patpedhi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    RateId = 0;
                    cmbFinancialYear.SelectedIndex = cmbFinancialYear.FindStringExact("Select");
                    txtInterestRate.Text = "";
                    txtDividentRate.Text = "";
                    dtpAGMDate.Value = DateTime.Now;
                    cmbFinancialYear.Enabled = false;
                    txtInterestRate.Enabled = false;
                    txtDividentRate.Enabled = false;
                    dtpAGMDate.Enabled = false;
                    dtpCutOffDate.Enabled = false;

                    btnAdd.Enabled = true;
                    btnModify.Enabled = false;
                    btnSave.Enabled = false;
                    OperationFlag = 4;
                    btnAdd.Focus();
                }
                dvRate = IDataProvider.GetRateList().DefaultView;
                dgvRateList.DataSource = dvRate;
                dgvRateList.Columns[0].Visible = false;
                dgvRateList.Columns[1].Visible = false;


            }
            catch (Exception ex)
            {
                CustomException.CustomExceptionLog(ex);
            }
            
        }

    }
}