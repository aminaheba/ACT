using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Xml.Linq;

namespace ACT.BL.Account
{
    public class Account
    {
        public SqlConnection connec= DL.ConnectionDB.GetConnection();
        public Account() {
            
        }
       
        public DataTable GetAllRepoType()
        { DL.ConnectionDB connectionDB = new DL.ConnectionDB();
          
           // connec.Open();
            DataTable result = new DataTable();
            result = connectionDB.SelectData("GetAllREPOtYPE", null);
            //connec.Close();
            return result;
        }

        public DataTable GetAllAccType()
        {
            DL.ConnectionDB connectionDB = new DL.ConnectionDB();
            //connec.Open();
            DataTable result = new DataTable();
            result = connectionDB.SelectData("GetAllAccType", null);
           // connec.Close();
            return result;
        }
        public DataTable GetAllAcc()
        {
            DL.ConnectionDB connectionDB = new DL.ConnectionDB();
           // connec.Open();
            DataTable result = new DataTable();
            result = connectionDB.SelectData("GetAllAcc", null);
           // connec.Close();
            return result;
        }
        public DataTable GetAcc(int accno)
        {
            DL.ConnectionDB connectionDB = new DL.ConnectionDB();
            // connec.Open();
            DataTable result = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@NO",SqlDbType.Int);
            param[0].Value = accno;
            result = connectionDB.SelectData("GetAcc", param);
            // connec.Close();
            return result;
        }
        public DataTable GenerateAccNum(int Pacc)
        {
            DL.ConnectionDB CON = new DL.ConnectionDB();
            
            DataTable dt = new DataTable();
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@ParentNo", SqlDbType.Int);
            para[0].Value = Pacc;

            dt = CON.SelectData("GenerateAccNum", para);
            return dt;
        }
      
        public void AddAcc(int NO, int ParentNo, string Name, string FName,int  Type,int Report,int Lev, double Debit, double Credit, double Balance)
        {
            DL.ConnectionDB con = new DL.ConnectionDB();
            DataTable dt = new DataTable();
            SqlParameter[] sqlParameters = new SqlParameter[10];
            sqlParameters[0] = new SqlParameter("@NO", SqlDbType.Int);
            sqlParameters[0].Value = NO;
            sqlParameters[1] = new SqlParameter("@ParentNo", SqlDbType.Int);
            sqlParameters[1].Value = ParentNo;
            sqlParameters[2] = new SqlParameter("@Name", SqlDbType.NVarChar,60);
            sqlParameters[2].Value = Name;
            sqlParameters[3] = new SqlParameter("@FName", SqlDbType.NVarChar,50);
            sqlParameters[3].Value = FName;
            sqlParameters[4] = new SqlParameter("@Type", SqlDbType.Int);
            sqlParameters[4].Value = Type;
            sqlParameters[9] = new SqlParameter("@Report", SqlDbType.Int);
            sqlParameters[9].Value = Report;
            sqlParameters[5] = new SqlParameter("@Lev", SqlDbType.Int);
            sqlParameters[5].Value = Lev;
            sqlParameters[6] = new SqlParameter("@Debit", SqlDbType.Decimal);
            sqlParameters[6].Value = Debit;
            sqlParameters[7] = new SqlParameter("@Credit", SqlDbType.Decimal);
            sqlParameters[7].Value = Credit;
            sqlParameters[8] = new SqlParameter("@Balance", SqlDbType.Decimal);
            sqlParameters[8].Value = Balance;
            con.execute("Account_Add", sqlParameters);

          
        }

        public void UpdateAcc(int NO, int ParentNo, string Name, string FName, int Type, int Report, int Lev, double Debit, double Credit, double Balance)
        {
            DL.ConnectionDB con = new DL.ConnectionDB();
            DataTable dt = new DataTable();
            SqlParameter[] sqlParameters = new SqlParameter[10];
            sqlParameters[0] = new SqlParameter("@NO", SqlDbType.Int);
            sqlParameters[0].Value = NO;
            sqlParameters[1] = new SqlParameter("@ParentNo", SqlDbType.Int);
            sqlParameters[1].Value = ParentNo;
            sqlParameters[2] = new SqlParameter("@Name", SqlDbType.NVarChar, 60);
            sqlParameters[2].Value = Name;
            sqlParameters[3] = new SqlParameter("@FName", SqlDbType.NVarChar, 50);
            sqlParameters[3].Value = FName;
            sqlParameters[4] = new SqlParameter("@Type", SqlDbType.Int);
            sqlParameters[4].Value = Type;
            sqlParameters[9] = new SqlParameter("@Report", SqlDbType.Int);
            sqlParameters[9].Value = Report;
            sqlParameters[5] = new SqlParameter("@Lev", SqlDbType.Int);
            sqlParameters[5].Value = Lev;
            sqlParameters[6] = new SqlParameter("@Debit", SqlDbType.Decimal);
            sqlParameters[6].Value = Debit;
            sqlParameters[7] = new SqlParameter("@Credit", SqlDbType.Decimal);
            sqlParameters[7].Value = Credit;
            sqlParameters[8] = new SqlParameter("@Balance", SqlDbType.Decimal);
            sqlParameters[8].Value = Balance;
            con.execute("AccUpdate", sqlParameters);


        }
        public void DelAcc(int NO)
        {
            DL.ConnectionDB CON = new DL.ConnectionDB();

            DataTable dt = new DataTable();
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@NO", SqlDbType.Int);
            para[0].Value = NO;

             CON.execute("AccDelete", para);
            
        }
        public DataTable AccTest(int accno)
        {
            DL.ConnectionDB connectionDB = new DL.ConnectionDB();
            
            DataTable result = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@NO", SqlDbType.Int);
            param[0].Value = accno;
            result = connectionDB.SelectData("AccTest", param);
            
            return result;
        }
        public DataTable AccJournalTest(int accno)
        {
            DL.ConnectionDB connectionDB = new DL.ConnectionDB();

            DataTable result = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@NO", SqlDbType.Int);
            param[0].Value = accno;
            result = connectionDB.SelectData("AccJournalTest", param);

            return result;
        }


    }
}
