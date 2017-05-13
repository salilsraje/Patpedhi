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
    public partial class BranchWiseSummary : Form
    {
        private IDataProvider _IDataProvider;
        DataTable dt;
        DataTable dtRateDtl;

        private ReportDocument rptBranchSummary = new ReportDocument();
        private ReportViewer objReportViewer = new ReportViewer();  
        public BranchWiseSummary()
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

        private void btnReport_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            dtRateDtl = new DataTable();
            Int32 BankId = 0;
            if (rdbTDCCB.Checked)
                BankId = 1;
            else
                BankId = 0;

            dt = IDataProvider.GetBranchWiseSummaryReport(BankId, (cmbRoundOff.SelectedItem.ToString() == "No" ? 0 : 1));
            dtRateDtl = IDataProvider.GetYearInterestRateDetails();
            //rptBranchSummary.FileName = "D:\\Sheetal\\Work\\Patpedhi_new\\Patpedhi\\Patpedhi\\UI\\rptBranchWiseSummary.rpt";
            rptBranchSummary.FileName = Application.StartupPath + "\\Reports\\rptBranchWiseSummary.rpt";
            rptBranchSummary.SetDataSource(dt);
            if (dtRateDtl.Rows.Count > 0)
            {
                rptBranchSummary.SetParameterValue("YearCode", dtRateDtl.Rows[0]["YearCode"].ToString());
            }
            else
            {
                MessageBox.Show("No data", "Patpedhi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            objReportViewer.crystalReportViewer1.ReportSource = rptBranchSummary;
            objReportViewer.ShowDialog();

        }

        private void BranchWiseSummary_Load(object sender, EventArgs e)
        {
            cmbRoundOff.Items.Insert(0, "No");
            cmbRoundOff.Items.Insert(1, "Yes");
            cmbRoundOff.SelectedIndex = 0;
        }
    }
}