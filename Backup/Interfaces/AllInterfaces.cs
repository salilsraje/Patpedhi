using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Patpedhi.Interfaces
{
    #region DataProvider Interface
    public interface IDataProvider
    {
        Int16 Login(String UserCode, String Password);
        DataTable GetTalukaList(String TalukaName);
        Int16 InsertModifyTaluka(String TalukaName, Char Editstatus, Int32 EditedBy, Int16 TalukaId);
        Int16 InsertModifyUser(String UserCode, String UserName,String Password, Char Editstatus, Int32 UserId);
        DataTable GetUserList(String UserName);
        Int32 CheckUserLogin(String UserName, String Password);
        DataTable GetBankList(String BankName);
        DataTable GetSchoolList(String Schoolname);
        Int16 InsertModifySchool(String SchoolCode, String SchoolName, String SchoolAddress, String SchoolPhone, Int16 TalukaId, Char Editstatus, Int32 EditedBy, Int32 SchoolId);
        Int16 InsertModifyBank(String BankName, Char Editstatus, Int32 EditedBy, Int32 BankId);
        DataTable GetBranchList(String BankName, String BranchName);
        Int16 InsertModifyBranch(Int32 BankId, String BranchCode, String BranchName, String Address, String Phone, Char Editstatus, Int32 EditedBy, Int32 BranchId);
        DataTable GetMemberList(String MemberName);
        Int16 InsertModifyMember(String MemberCode, String MemberName, Int32 SchoolId, Int32 BankId, Int32 BranchId, String BankAccountNo, DateTime MemberShipDate,
                                        Int16 IsDefaulter, Int16 Status, String Address, String Phone, Char Editstatus, Int32 EditedBy, Int32 MemberId);
        DataTable GetFinancialYear();
        Int16 UpdateFinancialYear(Int32 YearId, Int16 IsDefault, Int32 EditedBy);
        DataTable GetRateList();
        Int16 InsertModifyRate(Int32 YearId, Single InterestRate, Single DividentRate, DateTime AGMDate, Char Editstatus, Int32 EditedBy, Int16 RateId, DateTime CutOffDate);
        DataTable GetDefaultYear();
        DataTable GetShareContributionList(string MemCode, String MemName);
        Int16 InsertShareContri(String MemberCode, Int32 YearId, Int64 Share, Int64 Contribution, Char Editstatus, Int32 EditedBy, Int64 ShareContriId);
        String GetMemberName(String MemberCode);
        DataTable GetMemberCodeName();
        DataTable GetUploadedMemberId();
        DataTable GetSchoolsInTaluka(Int32 TalukaId);
        DataTable GetBranchInBank(Int32 BankId);
        DataTable GetDividentInterestReport(Int32 TalukaId, Int32 SchoolId, Int32 BankId, Int32 BranchId, Int16 Tag,Int32 RoundOff);
        DataTable GetYearInterestRateDetails();
        Int16 BackUpDatabase(String Path);
        Int32 DeleteMember(String MemberCode);
        Int32 CheckMember(String MemberCode);
        DataTable GetBranchWiseSummaryReport(Int32 BankId, Int32 RoundOff);
    }
    #endregion

    #region DataProvider Consumer Interface
    public interface IDataProviderConsumer
    {
        IDataProvider IDataProvider
        {
            get;
            set;
        }        
    }
    #endregion

    public sealed class LoginInfo
    {
        static Int32 _UserId;
        static String _UserName;
        static Int32 _yearId;
        static String _YearCode;
        public static Int32 UserId
        {
            get
            {
                return _UserId;
            }
            set
            {
                _UserId = value;
            }
        }
        public static String UserName
        {
            get
            {
                return _UserName;
            }
            set
            {
                _UserName = value;
            }
        }
        public static Int32 YearId
        {
            get
            {
                return _yearId;
            }
            set
            {
                _yearId = value;
            }
        }
        public static String YearCode
        {
            get
            {
                return _YearCode;
            }
            set
            {
                _YearCode = value;
            }
        }

    }
}
