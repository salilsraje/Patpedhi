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
    public partial class MainForm : Form,IDataProviderConsumer
    {
        private IDataProvider _IDataProvider;
        private TalukaMaster objTalukaMaster;
        private SchoolMaster objSchoolMaster;
        private BankMaster objBankMaster;
        private BranchMaster objBranchMaster;
        private MemberMaster objMemberMaster;
        private UserMaster objUserMaster;
        private FinancialYear objFinanaialYear;
        private RateMaster objRateMaster;
        private ShareContributionDetails objShareContributionDetails;
        private DividentInterestRegister objDividentInterestRegister;
        private BranchWiseSummary objBranchWiseSummary;
        private BackUpDatabase objBackUpDatabase;
        private BankBranchWiseReport objBankBranchWiseReport; 
        public MainForm()
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

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                this.MdiChildren[i].Close();
            }
            Environment.Exit(Environment.ExitCode);
        }

        private void talukaMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (objTalukaMaster == null || objTalukaMaster.IsDisposed)
                {
                    objTalukaMaster = new TalukaMaster();
                    ((Form)objTalukaMaster).MdiParent = this;
                    ((Form)objTalukaMaster).Name = "Taluka Master";
                    ((Form)objTalukaMaster).Text = "Taluka Master";
                    ((TalukaMaster)objTalukaMaster).IDataProvider = IDataProvider;
                    objTalukaMaster.StartPosition = FormStartPosition.CenterScreen;
                    objTalukaMaster.Show();
                }
                else
                {
                    objTalukaMaster.BringToFront();
                    objTalukaMaster.StartPosition = FormStartPosition.CenterScreen;
                    ((Form)objTalukaMaster).MdiParent = this;
                    objTalukaMaster.Focus();

                }
            }
            catch(Exception ex)
            {
                CustomException.CustomExceptionLog(ex);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                this.MdiChildren[i].Close();
            }
            Environment.Exit(Environment.ExitCode);
        }

        private void userMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (objUserMaster == null || objUserMaster.IsDisposed)
                {
                    objUserMaster = new UserMaster();
                    ((Form)objUserMaster).MdiParent = this;
                    ((Form)objUserMaster).Name = "User Master";
                    ((Form)objUserMaster).Text = "User Master";
                    ((UserMaster)objUserMaster).IDataProvider = IDataProvider;
                    objUserMaster.StartPosition = FormStartPosition.CenterScreen;
                    objUserMaster.Show();
                }
                else
                {
                    objUserMaster.BringToFront();
                    objUserMaster.StartPosition = FormStartPosition.CenterScreen;
                    ((Form)objUserMaster).MdiParent = this;
                    objUserMaster.Focus();

                }
            }
            catch (Exception ex)
            {
                CustomException.CustomExceptionLog(ex);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (LoginInfo.UserId == 1)
            {
                talukaMasterToolStripMenuItem.Visible = false;
                schoolMasterToolStripMenuItem.Visible = false;
                bankMasterToolStripMenuItem.Visible = false;
                branchMasterToolStripMenuItem.Visible = false;
                memberMasterToolStripMenuItem.Visible = false;
                rateMasterToolStripMenuItem.Visible = false;
                shareContributionDetailsToolStripMenuItem.Visible = false;
                financialYearToolStripMenuItem.Visible = false;
                dividentInterestRegisterToolStripMenuItem.Visible = false;
                bankBranchWiseReportToolStripMenuItem.Visible = false;
            }
            else
            {
                userMasterToolStripMenuItem.Visible = false;                
            }
        }

        private void schoolMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (objSchoolMaster == null || objSchoolMaster.IsDisposed)
                {
                    objSchoolMaster = new SchoolMaster();
                    ((Form)objSchoolMaster).MdiParent = this;
                    ((Form)objSchoolMaster).Name = "School Master";
                    ((Form)objSchoolMaster).Text = "School Master";
                    ((SchoolMaster)objSchoolMaster).IDataProvider = IDataProvider;
                    objSchoolMaster.StartPosition = FormStartPosition.CenterScreen;
                    objSchoolMaster.Show();
                }
                else
                {
                    objSchoolMaster.BringToFront();
                    objSchoolMaster.StartPosition = FormStartPosition.CenterScreen;
                    ((Form)objSchoolMaster).MdiParent = this;
                    objSchoolMaster.Focus();

                }
            }
            catch (Exception ex)
            {
                CustomException.CustomExceptionLog(ex);
            }
        }

        private void bankMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (objBankMaster == null || objBankMaster.IsDisposed)
                {
                    objBankMaster = new BankMaster();
                    ((Form)objBankMaster).MdiParent = this;
                    ((Form)objBankMaster).Name = "Bank Master";
                    ((Form)objBankMaster).Text = "Bank Master";
                    ((BankMaster)objBankMaster).IDataProvider = IDataProvider;
                    objBankMaster.StartPosition = FormStartPosition.CenterScreen;
                    objBankMaster.Show();
                }
                else
                {
                    objBankMaster.BringToFront();
                    objBankMaster.StartPosition = FormStartPosition.CenterScreen;
                    ((Form)objBankMaster).MdiParent = this;
                    objBankMaster.Focus();

                }
            }
            catch (Exception ex)
            {
                CustomException.CustomExceptionLog(ex);
            }
        }

        private void branchMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (objBranchMaster == null || objBranchMaster.IsDisposed)
                {
                    objBranchMaster = new BranchMaster();
                    ((Form)objBranchMaster).MdiParent = this;
                    ((Form)objBranchMaster).Name = "Branch Master";
                    ((Form)objBranchMaster).Text = "Branch Master";
                    ((BranchMaster)objBranchMaster).IDataProvider = IDataProvider;
                    objBranchMaster.StartPosition = FormStartPosition.CenterScreen;
                    objBranchMaster.Show();
                }
                else
                {
                    objBranchMaster.BringToFront();
                    objBranchMaster.StartPosition = FormStartPosition.CenterScreen;
                    ((Form)objBranchMaster).MdiParent = this;
                    objBranchMaster.Focus();

                }
            }
            catch (Exception ex)
            {
                CustomException.CustomExceptionLog(ex);
            }
        }

        private void memberMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (objMemberMaster == null || objMemberMaster.IsDisposed)
                {
                    objMemberMaster = new MemberMaster();
                    ((Form)objMemberMaster).MdiParent = this;
                    ((Form)objMemberMaster).Name = "Member Master";
                    ((Form)objMemberMaster).Text = "Member Master";
                    ((MemberMaster)objMemberMaster).IDataProvider = IDataProvider;
                    objMemberMaster.StartPosition = FormStartPosition.CenterScreen;
                    objMemberMaster.Show();
                }
                else
                {
                    objMemberMaster.BringToFront();
                    objMemberMaster.StartPosition = FormStartPosition.CenterScreen;
                    ((Form)objMemberMaster).MdiParent = this;
                    objMemberMaster.Focus();

                }
            }
            catch (Exception ex)
            {
                CustomException.CustomExceptionLog(ex);
            }
        }

        private void financialYearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (objFinanaialYear == null || objFinanaialYear.IsDisposed)
                {
                    objFinanaialYear = new FinancialYear();
                    ((Form)objFinanaialYear).MdiParent = this;
                    ((Form)objFinanaialYear).Name = "Financial Year";
                    ((Form)objFinanaialYear).Text = "Financial Year";
                    ((FinancialYear)objFinanaialYear).IDataProvider = IDataProvider;
                    objFinanaialYear.StartPosition = FormStartPosition.CenterScreen;
                    objFinanaialYear.Show();
                }
                else
                {
                    objFinanaialYear.BringToFront();
                    objFinanaialYear.StartPosition = FormStartPosition.CenterScreen;
                    ((Form)objFinanaialYear).MdiParent = this;
                    objFinanaialYear.Focus();

                }
            }
            catch (Exception ex)
            {
                CustomException.CustomExceptionLog(ex);
            }
        }

        private void rateMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (objRateMaster == null || objRateMaster.IsDisposed)
                {
                    objRateMaster = new RateMaster();
                    ((Form)objRateMaster).MdiParent = this;
                    ((Form)objRateMaster).Name = "Rate Master";
                    ((Form)objRateMaster).Text = "Rate Master";
                    ((RateMaster)objRateMaster).IDataProvider = IDataProvider;
                    objRateMaster.StartPosition = FormStartPosition.CenterScreen;
                    objRateMaster.Show();
                }
                else
                {
                    objRateMaster.BringToFront();
                    objRateMaster.StartPosition = FormStartPosition.CenterScreen;
                    ((Form)objRateMaster).MdiParent = this;
                    objRateMaster.Focus();

                }
            }
            catch (Exception ex)
            {
                CustomException.CustomExceptionLog(ex);
            }
        }

        private void shareContributionDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                if (LoginInfo.YearId != 0)
                {
                    if (objShareContributionDetails == null || objShareContributionDetails.IsDisposed)
                    {
                        objShareContributionDetails = new ShareContributionDetails();
                        ((Form)objShareContributionDetails).MdiParent = this;
                        ((Form)objShareContributionDetails).Name = "Share Contribution Details";
                        ((Form)objShareContributionDetails).Text = "Share Contribution Details";
                        ((ShareContributionDetails)objShareContributionDetails).IDataProvider = IDataProvider;
                        objShareContributionDetails.StartPosition = FormStartPosition.CenterScreen;
                        objShareContributionDetails.Show();
                    }
                    else
                    {
                        objShareContributionDetails.BringToFront();
                        objShareContributionDetails.StartPosition = FormStartPosition.CenterScreen;
                        ((Form)objShareContributionDetails).MdiParent = this;
                        objShareContributionDetails.Focus();

                    }
                }
                else
                {
                    MessageBox.Show("Please set current financial year", "Patpedhi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            catch (Exception ex)
            {
                CustomException.CustomExceptionLog(ex);
            }
        }

        private void dividentInterestRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (LoginInfo.YearId != 0)
                {
                    if (objDividentInterestRegister == null || objDividentInterestRegister.IsDisposed)
                    {
                        objDividentInterestRegister = new DividentInterestRegister();
                        ((Form)objDividentInterestRegister).MdiParent = this;
                        ((Form)objDividentInterestRegister).Name = "Divident interest register";
                        ((Form)objDividentInterestRegister).Text = "Divident interest register";
                        ((DividentInterestRegister)objDividentInterestRegister).IDataProvider = IDataProvider;
                        objDividentInterestRegister.StartPosition = FormStartPosition.CenterScreen;
                        objDividentInterestRegister.Show();
                    }
                    else
                    {
                        objDividentInterestRegister.BringToFront();
                        objDividentInterestRegister.StartPosition = FormStartPosition.CenterScreen;
                        ((Form)objDividentInterestRegister).MdiParent = this;
                        objDividentInterestRegister.Focus();

                    }
                }
                else
                {
                    MessageBox.Show("Please set current financial year", "Patpedhi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                CustomException.CustomExceptionLog(ex);
            }
        }

        private void bankBranchWiseReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (LoginInfo.YearId != 0)
                {
                    if (objBankBranchWiseReport == null || objBankBranchWiseReport.IsDisposed)
                    {
                        objBankBranchWiseReport = new BankBranchWiseReport();
                        ((Form)objBankBranchWiseReport).MdiParent = this;
                        ((Form)objBankBranchWiseReport).Name = "Bank Branch Wise Report";
                        ((Form)objBankBranchWiseReport).Text = "Bank Branch Wise Report";
                        ((BankBranchWiseReport)objBankBranchWiseReport).IDataProvider = IDataProvider;
                        objBankBranchWiseReport.StartPosition = FormStartPosition.CenterScreen;
                        objBankBranchWiseReport.Show();
                    }
                    else
                    {
                        objBankBranchWiseReport.BringToFront();
                        objBankBranchWiseReport.StartPosition = FormStartPosition.CenterScreen;
                        ((Form)objBankBranchWiseReport).MdiParent = this;
                        objBankBranchWiseReport.Focus();

                    }
                }
                else
                {
                    MessageBox.Show("Please set current financial year", "Patpedhi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                CustomException.CustomExceptionLog(ex);
            }
        }

        private void databaseBackUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (objBackUpDatabase == null || objBackUpDatabase.IsDisposed)
                {
                    objBackUpDatabase = new BackUpDatabase();
                    ((Form)objBackUpDatabase).MdiParent = this;
                    ((Form)objBackUpDatabase).Name = "BackUp Database";
                    ((Form)objBackUpDatabase).Text = "BackUp Database";
                    ((BackUpDatabase)objBackUpDatabase).IDataProvider = IDataProvider;
                    objBackUpDatabase.StartPosition = FormStartPosition.CenterScreen;
                    objBackUpDatabase.Show();
                }
                else
                {
                    objBackUpDatabase.BringToFront();
                    objBackUpDatabase.StartPosition = FormStartPosition.CenterScreen;
                    ((Form)objBackUpDatabase).MdiParent = this;
                    objBackUpDatabase.Focus();

                }               
                
            }
            catch (Exception ex)
            {
                CustomException.CustomExceptionLog(ex);
            }
        }

        private void branchWiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (LoginInfo.YearId != 0)
                {
                    if (objBranchWiseSummary == null || objBranchWiseSummary.IsDisposed)
                    {
                        objBranchWiseSummary = new BranchWiseSummary();
                        ((Form)objBranchWiseSummary).MdiParent = this;
                        ((Form)objBranchWiseSummary).Name = "Bank Branch Wise Report";
                        ((Form)objBranchWiseSummary).Text = "Bank Branch Wise Report";
                        ((BranchWiseSummary)objBranchWiseSummary).IDataProvider = IDataProvider;
                        objBranchWiseSummary.StartPosition = FormStartPosition.CenterScreen;
                        objBranchWiseSummary.Show();
                    }
                    else
                    {
                        objBranchWiseSummary.BringToFront();
                        objBranchWiseSummary.StartPosition = FormStartPosition.CenterScreen;
                        ((Form)objBranchWiseSummary).MdiParent = this;
                        objBranchWiseSummary.Focus();

                    }
                }
                else
                {
                    MessageBox.Show("Please set current financial year", "Patpedhi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                CustomException.CustomExceptionLog(ex);
            }
        }
    }
}