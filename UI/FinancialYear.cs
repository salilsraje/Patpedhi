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
    public partial class FinancialYear : Form
    {
        private IDataProvider _IDataProvider;
        private Int16 _YearId;
        DataView dvFinancialYear;
        Int16 OperationFlag = 0;
        
        public FinancialYear()
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
        public Int16 YearId
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

        private void FinancialYear_Load(object sender, EventArgs e)
        {
            try
            {
                dvFinancialYear = IDataProvider.GetFinancialYear().DefaultView;
                dgvFinancialYear.DataSource = dvFinancialYear;
                dgvFinancialYear.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {
                CustomException.CustomExceptionLog(ex);
            }
            txtYearCode.Text = "";
            dtpYearStarting.Value = DateTime.Now;
            dtpYearEnding.Value = DateTime.Now;
            chkDefaulter.Checked = false;

            chkDefaulter.Enabled = false;
            btnModify.Enabled = false;
            btnSave.Enabled = false;
        }

        private void dgvFinancialYear_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                YearId = Convert.ToInt16(dgvFinancialYear["Year Id", e.RowIndex].Value);
                txtYearCode.Text = dgvFinancialYear["Year COde", e.RowIndex].Value.ToString();
                dtpYearStarting.Value = Convert.ToDateTime(dgvFinancialYear["Year Start", e.RowIndex].Value);
                dtpYearEnding.Value = Convert.ToDateTime(dgvFinancialYear["Year End", e.RowIndex].Value);
                if (dgvFinancialYear["Default", e.RowIndex].Value.ToString() == "No")
                    chkDefaulter.Checked = false;
                else
                    chkDefaulter.Checked = true;
                tabCtlTalukaMaster.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                CustomException.CustomExceptionLog(ex);
            }
            chkDefaulter.Enabled = false;
            btnModify.Enabled = true;
            btnSave.Enabled = false;
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            OperationFlag = 2;
            chkDefaulter.Enabled = true;            
            btnModify.Enabled = false;
            btnSave.Enabled = true;
            chkDefaulter.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnModify.Enabled = false;
            btnSave.Enabled = false;
            OperationFlag = 5;
            btnModify.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Int16 Flag = 0;
            Int16 IsDefault = 0;
            try
            {
                if(chkDefaulter.Checked)
                    IsDefault = 1;
                else
                    IsDefault = 0;
                Flag = IDataProvider.UpdateFinancialYear(YearId, IsDefault, LoginInfo.UserId);
                if (Flag == 1)
                    MessageBox.Show("Record modified successfully", "Patpedhi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Error in modification", "Patpedhi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                YearId = 0;
                chkDefaulter.Enabled = false; 
                btnModify.Enabled = false;
                btnSave.Enabled = false;
                OperationFlag = 4;

                dvFinancialYear = IDataProvider.GetFinancialYear().DefaultView;
                dgvFinancialYear.DataSource = dvFinancialYear;
                dgvFinancialYear.Columns[0].Visible = false;
                
                DataTable dt = IDataProvider.GetDefaultYear();                 
                if (dt.Rows.Count > 0)
                {
                    LoginInfo.YearId = Convert.ToInt32(dt.Rows[0]["yearid"].ToString());
                    LoginInfo.YearCode = dt.Rows[0]["yearcode"].ToString();
                    this.ParentForm.Text = "MainForm Financial Year - " + LoginInfo.YearCode; 
                }
                else
                {
                    LoginInfo.YearId = 0;
                    LoginInfo.YearCode = "";
                    this.ParentForm.Text = "MainForm"; 
                }
                btnModify.Focus();
                
            }
            catch (Exception ex)
            {
                CustomException.CustomExceptionLog(ex);
            }
        }
    }
}