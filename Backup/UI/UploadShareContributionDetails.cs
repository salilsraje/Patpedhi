using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Patpedhi.Interfaces;
using Patpedhi.Utilities;
using System.Collections;



namespace Patpedhi.UI
{
    public partial class UploadShareContributionDetails : Form
    {
        private IDataProvider _IDataProvider;
        private Hashtable HTMember;
        private Hashtable HTUploadedMember;
        public UploadShareContributionDetails()
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

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                btnValidate.Enabled = false;
                btnSubmit.Enabled = false;
                string filetable = "Share-Contribution";
                ShareContriDialog.FileName = "";
                ShareContriDialog.InitialDirectory = @"c:\";
                ShareContriDialog.Filter = "Excel File|*.xls";

                DialogResult dr = ShareContriDialog.ShowDialog();
                if (dr == DialogResult.Cancel)
                    return;
                else
                    btnSubmit.Enabled = false;
                txtExcelFilePath.Text = ShareContriDialog.FileName.ToString();
                DataTable dt = GetDataFromExcel(filetable, txtExcelFilePath.Text.Trim());
                dgvShareContribution.DataSource = dt;
                if (dt.Rows.Count > 0)
                    dgvShareContribution.DataMember = dt.TableName;

                for (int i = 0; i < dgvShareContribution.Columns.Count; i++)
                    dgvShareContribution.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                if (dgvShareContribution.Columns[0].Name != "MemberCode" && dgvShareContribution.Columns[1].Name != "Share" && dgvShareContribution.Columns[2].Name == "Contribution")
                {
                    MessageBox.Show("Invalid excel file", "Patpedhi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                    btnValidate.Enabled = true;
            }
            catch (Exception ex)
            {
                CustomException.CustomExceptionLog(ex);
            }

            
        }

        private DataTable GetDataFromExcel(string filetable, string FilePath)
        {
            DataTable dt = new DataTable();
            try
            {
                string sql_select = String.Empty;
                System.Data.OleDb.OleDbConnection conn;
                string connString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + FilePath + @";Extended Properties=""Excel 8.0;HDR=Yes;IMEX=1""";
                conn = new System.Data.OleDb.OleDbConnection(connString.Trim());
                conn.Open();
                sql_select = "Select [MemberCode],[Share],[Contribution]" +
                            " from [" + filetable + "$]";

                System.Data.OleDb.OleDbDataAdapter obj_oledb_da = new System.Data.OleDb.OleDbDataAdapter(sql_select, conn);
                obj_oledb_da.Fill(dt);
                conn.Close();
            }
            catch (Exception ex)
            {
                CustomException.CustomExceptionLog(ex);
            }
            return dt;
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvShareContribution.Rows.Count > 0)
                {
                    for (int i = 0; i < dgvShareContribution.Rows.Count; i++)
                    {
                        if (dgvShareContribution["MemberCode", i].Value.ToString().Trim() == "")
                        {
                            MessageBox.Show("Member Code can be blank at row " + Convert.ToString(i + 1), "Patpedhi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            dgvShareContribution["MemberCode", i].Style.BackColor = Color.Red;
                            return;
                        }

                        for (int j = i + 1; j < dgvShareContribution.Rows.Count; j++)
                        {
                            if (dgvShareContribution["MemberCode", i].Value.ToString().Trim().ToUpper() == dgvShareContribution["MemberCode", j].Value.ToString().Trim().ToUpper())
                            {
                                MessageBox.Show("Multiple entries of same member code " + dgvShareContribution["MemberCode", i].Value.ToString() + " at rows " + Convert.ToString(i + 1) + " and " + Convert.ToString(j + 1), "Patpedhi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                dgvShareContribution["MemberCode", i].Style.BackColor = Color.Red;
                                dgvShareContribution["MemberCode", j].Style.BackColor = Color.Red;
                                return;
                            }
                        }
                        if (!HTMember.ContainsKey(dgvShareContribution["MemberCode", i].Value.ToString().Trim().ToUpper()) == true)
                        {
                            MessageBox.Show("Invalid Member Code at row " + Convert.ToString(i + 1), "Patpedhi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            dgvShareContribution["MemberCode", i].Style.BackColor = Color.Red;
                            return;
                        }
                        else if (HTUploadedMember.ContainsKey(dgvShareContribution["MemberCode", i].Value.ToString().Trim().ToUpper()) == true)
                        {
                            MessageBox.Show("Data is already uploaded for Member Code " + dgvShareContribution["MemberCode", i].Value.ToString().Trim() + " at row " + Convert.ToString(i + 1), "Patpedhi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            dgvShareContribution["MemberCode", i].Style.BackColor = Color.Red;
                            return;
                        }
                        else if (dgvShareContribution["Share", i].Value.ToString().Trim() == "")
                        {
                            MessageBox.Show("Share can be blank at row " + Convert.ToString(i + 1), "Patpedhi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            dgvShareContribution["Share", i].Style.BackColor = Color.Red;
                            return;
                        }
                        else if (!ValidationLogic.IsNumeric(dgvShareContribution["Share", i].Value.ToString().Trim()))
                        {
                            MessageBox.Show("Invalid entry for share at row " + Convert.ToString(i + 1), "Patpedhi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            dgvShareContribution["Share", i].Style.BackColor = Color.Red;
                            return;
                        }
                        else if (Convert.ToInt64(dgvShareContribution["Share", i].Value.ToString().Trim()) <= 0)
                        {
                            MessageBox.Show("Share can be equal to or less than zero at row " + Convert.ToString(i + 1), "Patpedhi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            dgvShareContribution["Share", i].Style.BackColor = Color.Red;
                            return;
                        }
                        else if (dgvShareContribution["Contribution", i].Value.ToString().Trim() == "")
                        {
                            MessageBox.Show("Contribution can be blank at row " + Convert.ToString(i + 1), "Patpedhi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            dgvShareContribution["Contribution", i].Style.BackColor = Color.Red;
                            return;
                        }
                        else if (!ValidationLogic.IsNumeric(dgvShareContribution["Contribution", i].Value.ToString().Trim()))
                        {
                            MessageBox.Show("Invalid entry for Contribution at row " + Convert.ToString(i + 1), "Patpedhi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            dgvShareContribution["Contribution", i].Style.BackColor = Color.Red;
                            return;
                        }
                        else if (Convert.ToInt64(dgvShareContribution["Contribution", i].Value.ToString().Trim()) <= 0)
                        {
                            MessageBox.Show("Share can be equal to or less than zero at row " + Convert.ToString(i + 1), "Patpedhi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            dgvShareContribution["Contribution", i].Style.BackColor = Color.Red;
                            return;
                        }
                        else if (Convert.ToInt64(dgvShareContribution["Share", i].Value.ToString().Trim()) % 10 != 0)
                        {
                            MessageBox.Show("Shares should be in multiple of 10 only at row " + Convert.ToString(i + 1), "Patpedhi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            dgvShareContribution["Share", i].Style.BackColor = Color.Red;
                            return;
                        }
                        else if (Convert.ToInt64(dgvShareContribution["Contribution", i].Value.ToString().Trim()) % 10 != 0)
                        {
                            MessageBox.Show("Contribution should be in multiple of 10 only at row " + Convert.ToString(i + 1), "Patpedhi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            dgvShareContribution["Contribution", i].Style.BackColor = Color.Red;
                            return;
                        }

                    }
                    MessageBox.Show("Validated successfully ", "Patpedhi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnSubmit.Enabled = true;
                }
                else
                    MessageBox.Show("No data", "Patpedhi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                CustomException.CustomExceptionLog(ex);
            }
        }

        private void UploadShareContributionDetails_Load(object sender, EventArgs e)
        {
            try
            {
                HTMember = new Hashtable();
                DataTable dtMember = IDataProvider.GetMemberCodeName();
                for (int i = 0; i < dtMember.Rows.Count; i++)
                {
                    HTMember.Add(dtMember.Rows[i]["Member Code"].ToString().Trim().ToUpper(), dtMember.Rows[i]["Member Name"].ToString().Trim().ToUpper());
                }
                HTUploadedMember = new Hashtable();
                DataTable dtUploadedMember = IDataProvider.GetUploadedMemberId();
                for (int i = 0; i < dtUploadedMember.Rows.Count; i++)
                {
                    HTUploadedMember.Add(dtUploadedMember.Rows[i]["Member Code"].ToString().Trim().ToUpper(), dtUploadedMember.Rows[i]["Member Id"].ToString().Trim().ToUpper());
                }
                btnOpen.Focus();
            }
            catch (Exception ex)
            {
                CustomException.CustomExceptionLog(ex);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                String InvalidMember = String.Empty;
                String DataAlreadyExist = String.Empty;
                Int16 Flag = 0;
                Int32 NoRecAddSuccessfully = 0;
                for (int i = 0; i < dgvShareContribution.Rows.Count; i++)
                {
                    Flag = IDataProvider.InsertShareContri(dgvShareContribution["MemberCode", i].Value.ToString(), LoginInfo.YearId,
                        Convert.ToInt64(dgvShareContribution["Share", i].Value), Convert.ToInt64(dgvShareContribution["Contribution", i].Value), 'I', LoginInfo.UserId, 0);
                    if (Flag == 0)
                        NoRecAddSuccessfully++;
                    else if (Flag == 2)
                        InvalidMember = InvalidMember + dgvShareContribution["MemberCode", i].Value.ToString() + ",";
                    else if (Flag == 1)
                        DataAlreadyExist = DataAlreadyExist + dgvShareContribution["MemberCode", i].Value.ToString() + ",";
                }
                if (NoRecAddSuccessfully > 0)
                    MessageBox.Show(NoRecAddSuccessfully.ToString() + " Records added successfully", "Patpedhi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (InvalidMember.Substring(0, InvalidMember.Length - 1).Length > 0)
                    MessageBox.Show("Data for invalid member is not uploaded, Invalid Member are " + InvalidMember, "Patpedhi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (DataAlreadyExist.Substring(0, InvalidMember.Length - 1).Length > 0)
                    MessageBox.Show("Data already exist for members " + DataAlreadyExist, "Patpedhi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                HTUploadedMember.Clear();
                DataTable dtUploadedMember = IDataProvider.GetUploadedMemberId();
                for (int i = 0; i < dtUploadedMember.Rows.Count; i++)
                {
                    HTUploadedMember.Add(dtUploadedMember.Rows[i]["Member Code"].ToString().Trim().ToUpper(), dtUploadedMember.Rows[i]["Member Id"].ToString().Trim().ToUpper());
                }
            }
            catch (Exception ex)
            {
                CustomException.CustomExceptionLog(ex);
            }
        }
    }
}