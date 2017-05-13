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
using System.Text;

namespace Patpedhi.UI
{
    public partial class DividentInterestRegister : Form
    {
        private IDataProvider _IDataProvider;
        private ReportDocument rptDividentInterest = new ReportDocument();
        private ReportViewer objReportViewer = new ReportViewer();        
        public DividentInterestRegister()
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

        private void DividentInterestRegister_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = IDataProvider.GetTalukaList("");
                DataRow dr1 = dt.NewRow();
                dr1["Taluka ID"] = 0;
                dr1["Taluka Name"] = "All";
                dt.Rows.InsertAt(dr1, 0);
                cmbTaluka.DisplayMember = "Taluka Name";
                cmbTaluka.ValueMember = "Taluka ID";
                cmbTaluka.DataSource = dt;

                dt = IDataProvider.GetBankList("");
                DataRow dr2 = dt.NewRow();
                dr2["Bank ID"] = 0;
                dr2["Bank Name"] = "All";
                dt.Rows.InsertAt(dr2, 0);
                cmbBank.DisplayMember = "Bank Name";
                cmbBank.ValueMember = "Bank ID";
                cmbBank.DataSource = dt;
                cmbTag.SelectedIndex = 0;
                cmbRoundOff.Items.Insert(0, "No");
                cmbRoundOff.Items.Insert(1, "Yes");
                cmbRoundOff.SelectedIndex = 0;

            }
            catch (Exception ex)
            {
                CustomException.CustomExceptionLog(ex);
            }
        }

        private void cmbTaluka_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = IDataProvider.GetSchoolsInTaluka(Convert.ToInt32(cmbTaluka.SelectedValue));
                DataRow dr1 = dt.NewRow();
                dr1["School ID"] = 0;
                dr1["School Name"] = "All";
                dt.Rows.InsertAt(dr1, 0);
                cmbSchool.DisplayMember = "School Name";
                cmbSchool.ValueMember = "School ID";
                cmbSchool.DataSource = dt;
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
                dr2["Branch Name"] = "All";
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
            try
            {
                DataTable dt = new DataTable();
                DataTable dtRateDtl = new DataTable();
                StringBuilder Filter = new StringBuilder();
                dt = IDataProvider.GetDividentInterestReport(Convert.ToInt32(cmbTaluka.SelectedValue), Convert.ToInt32(cmbSchool.SelectedValue), Convert.ToInt32(cmbBank.SelectedValue), Convert.ToInt32(cmbBranch.SelectedValue),Convert.ToInt16(cmbTag.Text),(cmbRoundOff.SelectedItem.ToString() == "No" ?0:1));
                dtRateDtl = IDataProvider.GetYearInterestRateDetails();

                if (chkTotalOnly.Checked)
                {
                    //rptDividentInterest.FileName = "D:\\Sheetal\\Work\\Patpedhi_new\\Patpedhi\\Patpedhi\\UI\\rptDividentInterestReportTotal.rpt"; 
                    rptDividentInterest.FileName = Application.StartupPath + "\\Reports\\rptDividentInterestReportTotal.rpt";
                }
                else
                {
                    //rptDividentInterest.FileName = "D:\\Sheetal\\Work\\Patpedhi_new\\Patpedhi\\Patpedhi\\UI\\rptDividentInterestReport.rpt"; 
                    rptDividentInterest.FileName = Application.StartupPath + "\\Reports\\rptDividentInterestReport.rpt";
                }
                rptDividentInterest.SetDataSource(dt);
                if (dtRateDtl.Rows.Count > 0)
                {
                    rptDividentInterest.SetParameterValue("YearCode", dtRateDtl.Rows[0]["YearCode"].ToString());
                    rptDividentInterest.SetParameterValue("AGMDate", dtRateDtl.Rows[0]["AGMDate"].ToString());
                    rptDividentInterest.SetParameterValue("InterestRate", dtRateDtl.Rows[0]["Interest Rate"].ToString());
                    rptDividentInterest.SetParameterValue("DividendRate", dtRateDtl.Rows[0]["Dividened Rate"].ToString());
                    if (cmbTag.Text == "0")
                        rptDividentInterest.SetParameterValue("Tag", "");
                    else if (cmbTag.Text == "1")
                        rptDividentInterest.SetParameterValue("Tag", "Bank A/C No. exists but Dividend not allowed");
                    else if (cmbTag.Text == "2")
                        rptDividentInterest.SetParameterValue("Tag", "Bank A/C No. does not exists");
                    if (cmbTaluka.Text != "All")
                        Filter.Append("Taluka : ").Append(cmbTaluka.Text.ToString().ToUpper());
                    if (cmbSchool.Text != "All")
                        Filter.Append("     School : ").Append(cmbSchool.Text.ToString().ToUpper());
                    if (cmbBank.Text != "All")
                        Filter.Append("     Bank : ").Append(cmbBank.Text.ToString().ToUpper());
                    if (cmbBranch.Text != "All")
                        Filter.Append("     Branch : ").Append(cmbBranch.Text.ToString().ToUpper());

                    rptDividentInterest.SetParameterValue("Filter", Filter.ToString());
                    objReportViewer.crystalReportViewer1.ReportSource = rptDividentInterest;
                    objReportViewer.ShowDialog();
                }
                else
                {
                    MessageBox.Show("No data", "Patpedhi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                                
            }
            catch (Exception ex)
            {
                CustomException.CustomExceptionLog(ex);
            }

        }

    }
}