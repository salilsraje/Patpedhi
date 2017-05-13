using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Patpedhi.Interfaces;
using Patpedhi.Utilities;
using CrystalDecisions.CrystalReports.Engine;

namespace Patpedhi.UI
{
    public partial class BankBranchWiseReport : Form
    {
        private IDataProvider _IDataProvider;
        private ReportDocument rptBankBranchWiseReport = new ReportDocument();
        private ReportDocument rptBankBranchWiseDivInterReport = new ReportDocument();
        private ReportViewer objReportViewer = new ReportViewer(); 
        public BankBranchWiseReport()
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
        #endregion

        private void BankBranchWiseReport_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = IDataProvider.GetBankList("");
                DataRow dr2 = dt.NewRow();
                dr2["Bank ID"] = 0;
                dr2["Bank Name"] = "Select";
                dt.Rows.InsertAt(dr2, 0);
                cmbBank.DisplayMember = "Bank Name";
                cmbBank.ValueMember = "Bank ID";
                cmbBank.DataSource = dt;
                cmbRoundOff.Items.Insert(0, "No");
                cmbRoundOff.Items.Insert(1, "Yes");
                cmbRoundOff.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                CustomException.CustomExceptionLog(ex);
            }
        }

        private void cmbBank_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = IDataProvider.GetBranchInBank(Convert.ToInt32(cmbBank.SelectedValue));
                DataRow dr2 = dt.NewRow();
                dr2["Branch ID"] = 0;
                dr2["Branch Name"] = "Select";
                dt.Rows.InsertAt(dr2, 0);
                cmbBranch.DisplayMember = "Branch Name";
                cmbBranch.ValueMember = "Branch ID";
                cmbBranch.DataSource = dt;
            }
            catch (Exception ex)
            {
                CustomException.CustomExceptionLog(ex);
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            if (String.CompareOrdinal("Select", cmbBank.Text) == 0)
            {
                MessageBox.Show("Please select bank", "Patpedhi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbBank.Focus();
                return;
            }
            else if (String.CompareOrdinal("Select", cmbBranch.Text) == 0)
            {
                MessageBox.Show("Please select branch", "Patpedhi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbBranch.Focus();
                return;
            }
            else
            {

                try
                {
                    DataTable dt = new DataTable();
                    DataTable dtRateDtl = new DataTable();
                    StringBuilder Filter = new StringBuilder();
                    dt = IDataProvider.GetDividentInterestReport(0, 0, Convert.ToInt32(cmbBank.SelectedValue), Convert.ToInt32(cmbBranch.SelectedValue), 0, (cmbRoundOff.SelectedItem.ToString() == "No" ? 0 : 1));
                    dtRateDtl = IDataProvider.GetYearInterestRateDetails();
                    if (chkDivInter.Checked)
                    {
                        //rptBankBranchWiseDivInterReport.FileName = "D:\\Sheetal\\Work\\Patpedhi_new\\Patpedhi\\Patpedhi\\UI\\rptBankBranchWiseDivInterTotal.rpt";
                        rptBankBranchWiseDivInterReport.FileName = Application.StartupPath + "\\Reports\\rptBankBranchWiseDivInterTotal.rpt";
                        rptBankBranchWiseDivInterReport.SetDataSource(dt);
                        if (dtRateDtl.Rows.Count > 0)
                        {
                            rptBankBranchWiseDivInterReport.SetParameterValue("YearCode", dtRateDtl.Rows[0]["YearCode"].ToString());
                            rptBankBranchWiseDivInterReport.SetParameterValue("Bank", cmbBank.Text);
                            rptBankBranchWiseDivInterReport.SetParameterValue("Branch", cmbBranch.Text);

                            objReportViewer.crystalReportViewer1.ReportSource = rptBankBranchWiseDivInterReport;
                            objReportViewer.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("No data", "Patpedhi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        //rptBankBranchWiseReport.FileName = "D:\\Sheetal\\Work\\Patpedhi_new\\Patpedhi\\Patpedhi\\UI\\rptBankBranchWiseTotal.rpt";
                        rptBankBranchWiseReport.FileName = Application.StartupPath + "\\Reports\\rptBankBranchWiseTotal.rpt";
                        rptBankBranchWiseReport.SetDataSource(dt);
                        if (dtRateDtl.Rows.Count > 0)
                        {
                            rptBankBranchWiseReport.SetParameterValue("YearCode", dtRateDtl.Rows[0]["YearCode"].ToString());
                            rptBankBranchWiseReport.SetParameterValue("Bank", cmbBank.Text);
                            rptBankBranchWiseReport.SetParameterValue("Branch", cmbBranch.Text);

                            objReportViewer.crystalReportViewer1.ReportSource = rptBankBranchWiseReport;
                            objReportViewer.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("No data", "Patpedhi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
                catch (Exception ex)
                {
                    CustomException.CustomExceptionLog(ex);
                }
            }
        }
    }
}