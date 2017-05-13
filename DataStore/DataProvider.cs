using System;
using System.Collections.Generic;
using System.Text;
using Patpedhi.Interfaces;
using System.Data.SqlClient;
using System.Data;
using Patpedhi.Utilities;

namespace Patpedhi.DataStore
{
    public class DataProvider : IDataProvider 
    {
        //private String _ConStr = "data source=.;initial catalog=Patpedhi_newdb;persist security info=False;user id=sa;pwd=;packet size=4096";
        String _ConStr = String.Empty;
        private SqlConnection _Con;

        #region Property declaration


        public SqlConnection Con
        {
            get
            {
                return _Con;
            }
            set
            {
                _Con = value;
            }
        }
        public String ConStr
        {
            get
            {
                return _ConStr;
            }
            set
            {
                _ConStr = value;
            }
        }

        #endregion

        public DataProvider()
        {
            try
            {
                DataSet ds = new DataSet();
                ds.ReadXml(System.Windows.Forms.Application.StartupPath + "\\Config.xml");
                if (ds.Tables.Count > 0)
                {
                    ConStr = ds.Tables[0].Rows[0]["DNSPath"].ToString();
                }
                Con = new SqlConnection(ConStr);
                Con.Open();
            }
            catch(Exception ex)
            {
                CustomException.CustomExceptionLog(ex); 
            }
        }
        public Int16 Login(String UserCode, String Password)
        {
            return 1;
        }
        public DataTable GetTalukaList(String TalukaName)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            if (Con.State == ConnectionState.Closed)
                Con.Open();
            try
            {
                using (SqlCommand cmd = Con.CreateCommand())
                {
                   cmd.CommandText = "select taluka_id AS 'Taluka ID',taluka AS 'Taluka Name' " +
                       " from Taluka_master (NOLOCK) Where taluka like '" + TalukaName + "%' Order By taluka";
                   cmd.Connection = Con;
                   da.SelectCommand = cmd;
                   da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                CustomException.CustomExceptionLog(ex); 
            }
            return dt;
        }

        public DataTable GetSchoolList(String Schoolname)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            if (Con.State == ConnectionState.Closed)
                Con.Open();
            try
            {
                using (SqlCommand cmd = Con.CreateCommand())
                {
                    cmd.CommandText = "select school_id AS 'School ID',school_code as 'School Code', School_name AS 'School Name', " +
                           " Taluka as 'Taluka', School_address as 'School Address', school_phone as 'School Phone' " +
                           " from School_master SM (NOLOCK) Inner join Taluka_master TM (NOLOCK) on SM.taluka_id=TM.taluka_id " +
                           " Where School_name like '" + Schoolname + "%'";
                    cmd.Connection = Con;
                    da.SelectCommand = cmd;
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                CustomException.CustomExceptionLog(ex);
            }
            return dt;

        }

        public DataTable GetUserList(String UserName)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            if (Con.State == ConnectionState.Closed)
                Con.Open();
            try
            {
                using (SqlCommand cmd = Con.CreateCommand())
                {
                    cmd.CommandText = "select User_id AS 'User ID',User_code as 'User Code', User_name AS 'User Name',Password from user_master (NOLOCK) Where User_Name like '" + UserName + "%'";
                    cmd.Connection = Con;
                    da.SelectCommand = cmd;
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                CustomException.CustomExceptionLog(ex);
            }
            return dt;
        }
        public Int16 InsertModifyTaluka(String TalukaName, Char Editstatus, Int32 EditedBy, Int16 TalukaId)
        {
            if (Con.State == ConnectionState.Closed)
                Con.Open();
            SqlParameter OutParameter = new SqlParameter();
            try
            {
                using (SqlCommand cmdAddCommand = new SqlCommand())
                {
                    cmdAddCommand.Connection = Con;
                    cmdAddCommand.CommandType = CommandType.StoredProcedure;
                    cmdAddCommand.CommandText = "InsertTaluka";

                    cmdAddCommand.Parameters.AddWithValue("@taluka", TalukaName.Replace("'", "''"));
                    cmdAddCommand.Parameters.AddWithValue("@editstatus", Editstatus);
                    cmdAddCommand.Parameters.AddWithValue("@edited_by", EditedBy);
                    cmdAddCommand.Parameters.AddWithValue("@taluka_id", TalukaId);


                    OutParameter.ParameterName = "@Flag";
                    OutParameter.SqlDbType = SqlDbType.Int;
                    OutParameter.Direction = ParameterDirection.Output;
                    cmdAddCommand.Parameters.Add(OutParameter);

                    cmdAddCommand.ExecuteNonQuery();

                }
            }
            catch (Exception ex)
            {
                CustomException.CustomExceptionLog(ex); 
            }
            return Convert.ToInt16(OutParameter.Value);
            
        }

        public Int16 InsertModifySchool(String SchoolCode, String SchoolName,String SchoolAddress,String SchoolPhone,Int16 TalukaId,Char Editstatus, Int32 EditedBy,Int32 SchoolId)
        {
            if (Con.State == ConnectionState.Closed)
                Con.Open();
            SqlParameter OutParameter = new SqlParameter();
            try
            {
                using (SqlCommand cmdAddCommand = new SqlCommand())
                {
                    cmdAddCommand.Connection = Con;
                    cmdAddCommand.CommandType = CommandType.StoredProcedure;
                    cmdAddCommand.CommandText = "InsertSchool";

                    cmdAddCommand.Parameters.AddWithValue("@SchoolCode", SchoolCode.Replace("'", "''"));
                    cmdAddCommand.Parameters.AddWithValue("@SchoolName", SchoolName.Replace("'", "''"));
                    cmdAddCommand.Parameters.AddWithValue("@SchoolAddress", SchoolAddress.Replace("'", "''"));
                    cmdAddCommand.Parameters.AddWithValue("@SchoolPhone", SchoolPhone);
                    cmdAddCommand.Parameters.AddWithValue("@talikaId", TalukaId);
                    cmdAddCommand.Parameters.AddWithValue("@editstatus", Editstatus);
                    cmdAddCommand.Parameters.AddWithValue("@edited_by", EditedBy);
                    cmdAddCommand.Parameters.AddWithValue("@SchoolId", SchoolId);


                    OutParameter.ParameterName = "@Flag";
                    OutParameter.SqlDbType = SqlDbType.Int;
                    OutParameter.Direction = ParameterDirection.Output;
                    cmdAddCommand.Parameters.Add(OutParameter);

                    cmdAddCommand.ExecuteNonQuery();

                }
            }
            catch (Exception ex)
            {
                CustomException.CustomExceptionLog(ex);
            }
            return Convert.ToInt16(OutParameter.Value);

        }

        public Int16 InsertModifyBank(String BankName, Char Editstatus, Int32 EditedBy, Int32 BankId)
        {
            if (Con.State == ConnectionState.Closed)
                Con.Open();
            SqlParameter OutParameter = new SqlParameter();
            try
            {
                using (SqlCommand cmdAddCommand = new SqlCommand())
                {
                    cmdAddCommand.Connection = Con;
                    cmdAddCommand.CommandType = CommandType.StoredProcedure;
                    cmdAddCommand.CommandText = "InsertBank";

                    cmdAddCommand.Parameters.AddWithValue("@BankName", BankName.Replace("'", "''"));
                    cmdAddCommand.Parameters.AddWithValue("@editstatus", Editstatus);
                    cmdAddCommand.Parameters.AddWithValue("@edited_by", EditedBy);
                    cmdAddCommand.Parameters.AddWithValue("@BankId", BankId);


                    OutParameter.ParameterName = "@Flag";
                    OutParameter.SqlDbType = SqlDbType.Int;
                    OutParameter.Direction = ParameterDirection.Output;
                    cmdAddCommand.Parameters.Add(OutParameter);

                    cmdAddCommand.ExecuteNonQuery();

                }
            }
            catch (Exception ex)
            {
                CustomException.CustomExceptionLog(ex);
            }
            return Convert.ToInt16(OutParameter.Value);

        }


        public Int16 InsertModifyUser(String UserCode,String UserName, String Password, Char Editstatus, Int32 UserId)
        {
            if (Con.State == ConnectionState.Closed)
                Con.Open();
            SqlParameter OutParameter = new SqlParameter();
            try
            {
                using (SqlCommand cmdAddCommand = new SqlCommand())
                {
                    cmdAddCommand.Connection = Con;
                    cmdAddCommand.CommandType = CommandType.StoredProcedure;
                    cmdAddCommand.CommandText = "InsertUser";

                    cmdAddCommand.Parameters.AddWithValue("@User_code", UserCode.Replace("'", "''"));
                    cmdAddCommand.Parameters.AddWithValue("@User_name", UserName.Replace("'", "''"));
                    cmdAddCommand.Parameters.AddWithValue("@Password", Password.Replace("'", "''"));
                    cmdAddCommand.Parameters.AddWithValue("@editstatus", Editstatus);
                    cmdAddCommand.Parameters.AddWithValue("@User_id", UserId);


                    OutParameter.ParameterName = "@Flag";
                    OutParameter.SqlDbType = SqlDbType.Int;
                    OutParameter.Direction = ParameterDirection.Output;
                    cmdAddCommand.Parameters.Add(OutParameter);

                    cmdAddCommand.ExecuteNonQuery();

                }
            }
            catch (Exception ex)
            {
                CustomException.CustomExceptionLog(ex);
            }
            return Convert.ToInt16(OutParameter.Value);
        }

        public Int32 CheckUserLogin(String UserName, String Password)
        {
            if (Con.State == ConnectionState.Closed)
                Con.Open();
            SqlParameter OutParameter = new SqlParameter();
            try
            {
                using (SqlCommand cmdAddCommand = new SqlCommand())
                {
                    cmdAddCommand.Connection = Con;
                    cmdAddCommand.CommandType = CommandType.StoredProcedure;
                    cmdAddCommand.CommandText = "CheckUserLogin";

                    cmdAddCommand.Parameters.AddWithValue("@User_code", UserName.Replace("'", "''"));
                    cmdAddCommand.Parameters.AddWithValue("@Password", Password.Replace("'", "''"));

                    OutParameter.ParameterName = "@User_id";
                    OutParameter.SqlDbType = SqlDbType.Int;
                    OutParameter.Direction = ParameterDirection.Output;
                    cmdAddCommand.Parameters.Add(OutParameter);

                    cmdAddCommand.ExecuteNonQuery();

                }
            }
            catch (Exception ex)
            {
                CustomException.CustomExceptionLog(ex);
            }
            return Convert.ToInt32(OutParameter.Value);
        }

        public DataTable GetBankList(String BankName)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            if (Con.State == ConnectionState.Closed)
                Con.Open();
            try
            {
                using (SqlCommand cmd = Con.CreateCommand())
                {
                    cmd.CommandText = "select bank_id AS 'Bank ID',bank_code AS 'Bank Code',bank_name as 'Bank Name' from Bank_master (NOLOCK) Where bank_name like '" + BankName + "%'";
                    cmd.Connection = Con;
                    da.SelectCommand = cmd;
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                CustomException.CustomExceptionLog(ex);
            }
            return dt;
        }
        public DataTable GetBranchList(String BankName,String BranchName)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            if (Con.State == ConnectionState.Closed)
                Con.Open();
            try
            {
                using (SqlCommand cmd = Con.CreateCommand())
                {
                    cmd.CommandText = "select branch_id AS 'Branch ID', BM.bank_id AS 'Bank ID',branch_code as 'Branch Code', " +
                                    " bank_name as 'Bank Name' , branch_name as 'Branch Name',Address as 'Address',Phone as 'Phone' " +
                                    " from Bank_Branch_Details BBD (NOLOCK) INNER JOIN Bank_master BM (NOLOCK) ON BBD.bank_id = BM.bank_id " +
                                    " Where BM.bank_name like '" + BankName + "%' and BBD.branch_name like '" + BranchName + "%'";
                    cmd.Connection = Con;
                    da.SelectCommand = cmd;
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                CustomException.CustomExceptionLog(ex);
            }
            return dt;
        }

        public Int16 InsertModifyMember(String MemberCode, String MemberName, Int32 SchoolId, Int32 BankId, Int32 BranchId, String BankAccountNo, DateTime MemberShipDate,
                                        Int16 IsDefaulter, Int16 Status, String Address, String Phone, Char Editstatus, Int32 EditedBy, Int32 MemberId)
        {
            if (Con.State == ConnectionState.Closed)
                Con.Open();
            SqlParameter OutParameter = new SqlParameter();
            try
            {
                using (SqlCommand cmdAddCommand = new SqlCommand())
                {
                    cmdAddCommand.Connection = Con;
                    cmdAddCommand.CommandType = CommandType.StoredProcedure;
                    cmdAddCommand.CommandText = "InsertMember";

                    cmdAddCommand.Parameters.AddWithValue("@MemberCode", MemberCode);
                    cmdAddCommand.Parameters.AddWithValue("@MemberName", MemberName);
                    cmdAddCommand.Parameters.AddWithValue("@SchoolId", SchoolId);
                    cmdAddCommand.Parameters.AddWithValue("@BankId", BankId);
                    cmdAddCommand.Parameters.AddWithValue("@BranchId", BranchId);
                    cmdAddCommand.Parameters.AddWithValue("@BankAccountNo", BankAccountNo);
                    cmdAddCommand.Parameters.AddWithValue("@MemberShipDate", MemberShipDate);
                    cmdAddCommand.Parameters.AddWithValue("@IsDefaulter", IsDefaulter);
                    cmdAddCommand.Parameters.AddWithValue("@Status", Status);
                    cmdAddCommand.Parameters.AddWithValue("@Address", Address);
                    cmdAddCommand.Parameters.AddWithValue("@Phone", Phone);
                    cmdAddCommand.Parameters.AddWithValue("@editstatus", Editstatus);
                    cmdAddCommand.Parameters.AddWithValue("@edited_by", EditedBy);
                    cmdAddCommand.Parameters.AddWithValue("@MemberId", MemberId);

                    OutParameter.ParameterName = "@Flag";
                    OutParameter.SqlDbType = SqlDbType.Int;
                    OutParameter.Direction = ParameterDirection.Output;
                    cmdAddCommand.Parameters.Add(OutParameter);

                    cmdAddCommand.ExecuteNonQuery();

                }
            }
            catch (Exception ex)
            {
                CustomException.CustomExceptionLog(ex);
            }
            return Convert.ToInt16(OutParameter.Value);
        }

        public Int16 InsertModifyBranch(Int32 BankId,String BranchCode,String BranchName,String Address,String Phone, Char Editstatus, Int32 EditedBy, Int32 BranchId)
        {
            if (Con.State == ConnectionState.Closed)
                Con.Open();
            SqlParameter OutParameter = new SqlParameter();
            try
            {
                using (SqlCommand cmdAddCommand = new SqlCommand())
                {
                    cmdAddCommand.Connection = Con;
                    cmdAddCommand.CommandType = CommandType.StoredProcedure;
                    cmdAddCommand.CommandText = "InsertBranch";

                    cmdAddCommand.Parameters.AddWithValue("@BankId", BankId);
                    cmdAddCommand.Parameters.AddWithValue("@BranchCode", BranchCode);
                    cmdAddCommand.Parameters.AddWithValue("@BranchName", BranchName);
                    cmdAddCommand.Parameters.AddWithValue("@Address", Address);
                    cmdAddCommand.Parameters.AddWithValue("@Phone", Phone);
                    cmdAddCommand.Parameters.AddWithValue("@editstatus", Editstatus);
                    cmdAddCommand.Parameters.AddWithValue("@BranchId", BranchId);
                    cmdAddCommand.Parameters.AddWithValue("@edited_by", EditedBy);

                    OutParameter.ParameterName = "@Flag";
                    OutParameter.SqlDbType = SqlDbType.Int;
                    OutParameter.Direction = ParameterDirection.Output;
                    cmdAddCommand.Parameters.Add(OutParameter);

                    cmdAddCommand.ExecuteNonQuery();

                }
            }
            catch (Exception ex)
            {
                CustomException.CustomExceptionLog(ex);
            }
            return Convert.ToInt16(OutParameter.Value);

        }

        public DataTable GetMemberList(String MemberName)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            if (Con.State == ConnectionState.Closed)
                Con.Open();
            try
            {
                using (SqlCommand cmd = Con.CreateCommand())
                {
                    cmd.CommandText = "select Member_id as 'Member ID', Member_code as 'Member Code'," +
                    " Member_name as 'Member Name',SM.school_name as 'School Name', " +
                    " bank_name as 'Bank Name',branch_name as 'Branch Name', " +
                    " account_no as 'Bank Accout No',membership_date as 'Membership Date', " +
                    " isdefaulter as 'Tag',CASE WHEN Status =0 THEN 'Active' ELSE 'InActive' END AS 'Status', " +
                    " MM.Address as 'Address', MM.Phone as 'Phone' " +
                    " FROM Member_master MM (NOLOCK) INNER JOIN School_master SM (NOLOCK) " +
                    " ON MM.school_id = SM.school_id LEFT JOIN Bank_master BM (NOLOCK) " +
                    " ON MM.bank_id = BM.bank_id LEFT JOIN Bank_Branch_Details BBD (NOLOCK) " +
                    " ON BBD.branch_id = MM.branch_id where Member_name like '" + MemberName + "%' and IsDeleted = 0";
                    cmd.Connection = Con;
                    da.SelectCommand = cmd;
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                CustomException.CustomExceptionLog(ex);
            }
            return dt;
        }
        public DataTable GetFinancialYear()
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            if (Con.State == ConnectionState.Closed)
                Con.Open();
            try
            {
                using (SqlCommand cmd = Con.CreateCommand())
                {
                    cmd.CommandText = "Select yearid AS 'Year Id',yearstarting AS 'Year Start',yearending AS 'Year End',yearcode AS 'Year Code'," +
                    " CASE WHEN IsDefault = 0 THEN 'No' ELSE 'Yes' END AS 'Default' FROM FinancialYear_master";
                    cmd.Connection = Con;
                    da.SelectCommand = cmd;
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                CustomException.CustomExceptionLog(ex);
            }
            return dt;
        }
        public Int16 UpdateFinancialYear(Int32 YearId, Int16 IsDefault, Int32 EditedBy)
        {
            if (Con.State == ConnectionState.Closed)
                Con.Open();
            SqlParameter OutParameter = new SqlParameter();
            try
            {
                using (SqlCommand cmdAddCommand = new SqlCommand())
                {
                    cmdAddCommand.Connection = Con;
                    cmdAddCommand.CommandType = CommandType.StoredProcedure;
                    cmdAddCommand.CommandText = "UpdateDefaultFinancialYear";

                    cmdAddCommand.Parameters.AddWithValue("@YearId", YearId);
                    cmdAddCommand.Parameters.AddWithValue("@IsDefault", IsDefault);
                    cmdAddCommand.Parameters.AddWithValue("@edited_by", EditedBy);                    


                    OutParameter.ParameterName = "@Flag";
                    OutParameter.SqlDbType = SqlDbType.Int;
                    OutParameter.Direction = ParameterDirection.Output;
                    cmdAddCommand.Parameters.Add(OutParameter);

                    cmdAddCommand.ExecuteNonQuery();

                }
            }
            catch (Exception ex)
            {
                CustomException.CustomExceptionLog(ex);
            }
            return Convert.ToInt16(OutParameter.Value);
        }

        public DataTable GetRateList()
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            if (Con.State == ConnectionState.Closed)
                Con.Open();
            try
            {
                using (SqlCommand cmd = Con.CreateCommand())
                {
                    cmd.CommandText = "Select rate_id as 'RateId', FM.yearid as 'YearId', yearcode as 'Financial Year',Interest_rate as 'Interest Rate',Divident_rate as 'Divident Rate', Convert(varchar(10),agmdate,103) as 'AGM Date', Convert(varchar(10),RM.CutOffDate,103) AS 'CutOff Date' " +
                        " FROM Rate_master RM INNER JOIN FinancialYear_master FM ON RM.yearid = FM.yearid ";
                    cmd.Connection = Con;
                    da.SelectCommand = cmd;
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                CustomException.CustomExceptionLog(ex);
            }
            return dt;
        }

        public Int16 InsertModifyRate(Int32 YearId, Single InterestRate, Single DividentRate, DateTime AGMDate, Char Editstatus, Int32 EditedBy, Int16 RateId, DateTime CutOffDate)
        {
            if (Con.State == ConnectionState.Closed)
                Con.Open();
            SqlParameter OutParameter = new SqlParameter();
            try
            {
                using (SqlCommand cmdAddCommand = new SqlCommand())
                {
                    cmdAddCommand.Connection = Con;
                    cmdAddCommand.CommandType = CommandType.StoredProcedure;
                    cmdAddCommand.CommandText = "InsertRate";

                    cmdAddCommand.Parameters.AddWithValue("@YearId", YearId);
                    cmdAddCommand.Parameters.AddWithValue("@InterestRate", InterestRate);
                    cmdAddCommand.Parameters.AddWithValue("@DividentRate", DividentRate);
                    cmdAddCommand.Parameters.AddWithValue("@AGMDate", AGMDate);
                    cmdAddCommand.Parameters.AddWithValue("@CutOffDate", CutOffDate);
                    cmdAddCommand.Parameters.AddWithValue("@edited_by", EditedBy);
                    cmdAddCommand.Parameters.AddWithValue("@editstatus", Editstatus);
                    cmdAddCommand.Parameters.AddWithValue("@RateId", RateId);


                    OutParameter.ParameterName = "@Flag";
                    OutParameter.SqlDbType = SqlDbType.Int;
                    OutParameter.Direction = ParameterDirection.Output;
                    cmdAddCommand.Parameters.Add(OutParameter);

                    cmdAddCommand.ExecuteNonQuery();

                }
            }
            catch (Exception ex)
            {
                CustomException.CustomExceptionLog(ex);
            }
            return Convert.ToInt16(OutParameter.Value);

        }
        
        public DataTable GetDefaultYear()
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            if (Con.State == ConnectionState.Closed)
                Con.Open();
            try
            {
                using (SqlCommand cmd = Con.CreateCommand())
                {
                    cmd.CommandText = "Select yearid,yearcode From FinancialYear_master where IsDefault = 1";
                    cmd.Connection = Con;
                    da.SelectCommand = cmd;
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                CustomException.CustomExceptionLog(ex);
            }
            return dt;
        }

        public DataTable GetShareContributionList(string MemCode, String MemName)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            if (Con.State == ConnectionState.Closed)
                Con.Open();
            try
            {
                using (SqlCommand cmd = Con.CreateCommand())
                {
                    cmd.CommandText = "Select member_shcontri_id AS 'ShareContriId', MM.member_id as 'MemberId', yearid as 'YearId', Member_code as 'Member Code', " +
                            " Member_name AS 'Member Name', Share as 'Share', contribution as 'Contribution' FROM Member_ShareContribution_Details SC INNER JOIN Member_master MM " +
                            " ON MM.Member_id = SC.Member_id Where yearid = " + LoginInfo.YearId + " AND Member_code like '" + MemCode + "%' AND Member_name like '" + MemName + "%' And MM.IsDeleted = 0";
                    cmd.Connection = Con;
                    da.SelectCommand = cmd;
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                CustomException.CustomExceptionLog(ex);
            }
            return dt;
        }

        public Int16 InsertShareContri(String MemberCode,Int32 YearId, Int64 Share,Int64 Contribution,Char Editstatus, Int32 EditedBy, Int64 ShareContriId)
        {
            if (Con.State == ConnectionState.Closed)
                Con.Open();
            SqlParameter OutParameter = new SqlParameter();
            try
            {
                using (SqlCommand cmdAddCommand = new SqlCommand())
                {
                    cmdAddCommand.Connection = Con;
                    cmdAddCommand.CommandType = CommandType.StoredProcedure;
                    cmdAddCommand.CommandText = "InsertShareContri";

                    cmdAddCommand.Parameters.AddWithValue("@MemberCode", MemberCode);
                    cmdAddCommand.Parameters.AddWithValue("@YearId", YearId);
                    cmdAddCommand.Parameters.AddWithValue("@Share", Share);
                    cmdAddCommand.Parameters.AddWithValue("@Contrubution", Contribution);
                    cmdAddCommand.Parameters.AddWithValue("@edited_by", EditedBy);
                    cmdAddCommand.Parameters.AddWithValue("@editstatus", Editstatus);
                    cmdAddCommand.Parameters.AddWithValue("@ShareContriId", ShareContriId);


                    OutParameter.ParameterName = "@Flag";
                    OutParameter.SqlDbType = SqlDbType.Int;
                    OutParameter.Direction = ParameterDirection.Output;
                    cmdAddCommand.Parameters.Add(OutParameter);

                    cmdAddCommand.ExecuteNonQuery();

                }
            }
            catch (Exception ex)
            {
                CustomException.CustomExceptionLog(ex);
            }
            return Convert.ToInt16(OutParameter.Value);

        }
        
        public String GetMemberName(String MemberCode)
        {
            String MemberName = String.Empty;
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    String sql = "Select Member_name FROM Member_master Where Member_code = '" + MemberCode + "'";
                    cmd.Connection = Con;
                    cmd.CommandText = sql;
                    object obj = cmd.ExecuteScalar();
                    if (obj != null)
                        MemberName = obj.ToString();
                    else
                        MemberName = "";
                }
            }
            catch (Exception ex)
            {
                CustomException.CustomExceptionLog(ex);
            }
            return MemberName;
        }

        public DataTable GetMemberCodeName()
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            if (Con.State == ConnectionState.Closed)
                Con.Open();
            try
            {
                using (SqlCommand cmd = Con.CreateCommand())
                {
                    cmd.CommandText = "select Member_code as 'Member Code', Member_name as 'Member Name' FROM Member_master Order by Member_code";
                    cmd.Connection = Con;
                    da.SelectCommand = cmd;
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                CustomException.CustomExceptionLog(ex);
            }
            return dt;
        }

        public DataTable GetUploadedMemberId()
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            if (Con.State == ConnectionState.Closed)
                Con.Open();
            try
            {
                using (SqlCommand cmd = Con.CreateCommand())
                {
                    cmd.CommandText = "select Member_code as 'Member Code', SC.Member_id AS 'Member Id' FROM Member_master MM INNER JOIN Member_ShareContribution_Details SC " +
                        " ON MM.Member_id = SC.Member_id WHERE SC.yearid = " + LoginInfo.YearId + " Order by Member_code";
                    cmd.Connection = Con;
                    da.SelectCommand = cmd;
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                CustomException.CustomExceptionLog(ex);
            }
            return dt;
        }

        public DataTable GetSchoolsInTaluka(Int32 TalukaId)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            if (Con.State == ConnectionState.Closed)
                Con.Open();
            try
            {
                using (SqlCommand cmd = Con.CreateCommand())
                {
                    cmd.CommandText = "select school_id AS 'School ID',school_name as 'School Name'" +
                           " from School_master SM (NOLOCK) Inner join Taluka_master TM (NOLOCK) on SM.taluka_id=TM.taluka_id " +
                           " Where TM.taluka_id = CASE WHEN " + TalukaId + " = 0 THEN TM.taluka_id ELSE " + TalukaId + " END";
                    cmd.Connection = Con;
                    da.SelectCommand = cmd;
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                CustomException.CustomExceptionLog(ex);
            }
            return dt;

        }

        public DataTable GetBranchInBank(Int32 BankId)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            if (Con.State == ConnectionState.Closed)
                Con.Open();
            try
            {
                using (SqlCommand cmd = Con.CreateCommand())
                {
                    cmd.CommandText = "select branch_id AS 'Branch ID', branch_name as 'Branch Name' " +
                                    " from Bank_Branch_Details BBD (NOLOCK) INNER JOIN Bank_master BM (NOLOCK) ON BBD.bank_id = BM.bank_id " +
                                    " Where BBD.bank_id = CASE WHEN " + BankId + " = 0 THEN BBD.bank_id ELSE " + BankId + " END";
                    cmd.Connection = Con;
                    da.SelectCommand = cmd;
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                CustomException.CustomExceptionLog(ex);
            }
            return dt;
        }

        public DataTable GetDividentInterestReport(Int32 TalukaId, Int32 SchoolId, Int32 BankId, Int32 BranchId,Int16 Tag,Int32 RoundOff)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            if (Con.State == ConnectionState.Closed)
                Con.Open();
            try
            {
                using (SqlCommand cmd = Con.CreateCommand())
                {
                    cmd.CommandText = "DividentInterestReport";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TalukaId", TalukaId);
                    cmd.Parameters.AddWithValue("@SchoolId", SchoolId);
                    cmd.Parameters.AddWithValue("@BankId", BankId);
                    cmd.Parameters.AddWithValue("@BranchId", BranchId);
                    cmd.Parameters.AddWithValue("@Tag", Tag);
                    cmd.Parameters.AddWithValue("@RoundOff", RoundOff);
                    da.SelectCommand = cmd;
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                CustomException.CustomExceptionLog(ex);
            }
            return dt;
        }


        public DataTable GetBranchWiseSummaryReport(Int32 BankId, Int32 RoundOff)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            if (Con.State == ConnectionState.Closed)
                Con.Open();
            try
            {
                using (SqlCommand cmd = Con.CreateCommand())
                {
                    cmd.CommandText = "BranchWiseSummeryReport";
                    cmd.CommandType = CommandType.StoredProcedure;                    
                    cmd.Parameters.AddWithValue("@BankId", BankId);
                    cmd.Parameters.AddWithValue("@RoundOff", RoundOff);
                    da.SelectCommand = cmd;
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                CustomException.CustomExceptionLog(ex);
            }
            return dt;
        }

        public DataTable GetYearInterestRateDetails()
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            if (Con.State == ConnectionState.Closed)
                Con.Open();
            try
            {
                using (SqlCommand cmd = Con.CreateCommand()) 
                {
                    cmd.CommandText = "GetYearIntRateDet";
                    cmd.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand = cmd;
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                CustomException.CustomExceptionLog(ex);
            }
            return dt;
        }

        public Int16 BackUpDatabase(String Path)
        {
            if (Con.State == ConnectionState.Closed)
                Con.Open();
            SqlParameter OutParameter = new SqlParameter();
            try
            {
                using (SqlCommand cmdAddCommand = new SqlCommand())
                {
                    cmdAddCommand.Connection = Con;
                    cmdAddCommand.CommandType = CommandType.StoredProcedure;
                    cmdAddCommand.CommandText = "BackUpDatabase";

                    cmdAddCommand.Parameters.AddWithValue("@Path", Path);
                    
                    OutParameter.ParameterName = "@Flag";
                    OutParameter.SqlDbType = SqlDbType.Int;
                    OutParameter.Direction = ParameterDirection.Output;
                    cmdAddCommand.Parameters.Add(OutParameter);

                    cmdAddCommand.ExecuteNonQuery();

                }
            }
            catch (Exception ex)
            {
                CustomException.CustomExceptionLog(ex);
            }
            return Convert.ToInt16(OutParameter.Value);

        }

        public Int32 DeleteMember(String MemberCode)
        {
            if (Con.State == ConnectionState.Closed)
                Con.Open();
            Int32 RowEffected =-1;
            try
            {
                using (SqlCommand cmdDeleteCommand = new SqlCommand())
                {
                    cmdDeleteCommand.Connection = Con;
                    String strDelete = "Update Member_master SET IsDeleted = 1,Modified_date = " + DateTime.Now.ToShortDateString() + ", Modified_By = " + LoginInfo.UserId + " WHERE Member_Code = '" + MemberCode + "'";
                    cmdDeleteCommand.CommandText = strDelete;
                    RowEffected = cmdDeleteCommand.ExecuteNonQuery();

                }
            }
            catch (Exception ex)
            {
                CustomException.CustomExceptionLog(ex);
            }
            return RowEffected;
        }

        public Int32 CheckMember(String MemberCode)
        {
            if (Con.State == ConnectionState.Closed)
                Con.Open();
            Int32 Count = -1;
            try
            {
                using (SqlCommand cmdCheckCommand = new SqlCommand())
                {
                    cmdCheckCommand.Connection = Con;
                    String strCheck = "Select count(*) from Member_master Where Member_Code = '" + MemberCode + "' And IsDeleted = 0";
                    cmdCheckCommand.CommandText = strCheck;
                    Count = Convert.ToInt32(cmdCheckCommand.ExecuteScalar());

                }
            }
            catch (Exception ex)
            {
                CustomException.CustomExceptionLog(ex);
            }
            return Count;
        }

    }
}
