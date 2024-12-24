using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ACT.BL.SysFormat
{
    public class SysFormat
    {
       // public SqlConnection connec = DL.ConnectionDB.GetConnection();
        #region company

        public void AddCompany( string companyName,string companyFN,string Adr,string FAdr,string tel,string fax,string email ,string website, byte[] img)
        {
            DL.ConnectionDB connectionDB = new DL.ConnectionDB();
         //   connec.Open();
            SqlParameter[] para = new SqlParameter[9];
            para[0] = new SqlParameter("@Name",SqlDbType.NVarChar,100);
            para[0].Value = companyName;

            para[1] = new SqlParameter("@FName", SqlDbType.NVarChar, 100);
            para[1].Value = companyFN;

            para[2] = new SqlParameter("@Address", SqlDbType.NVarChar, 200);
            para[2].Value = Adr;

            para[3] = new SqlParameter("@FAddress", SqlDbType.NVarChar, 200);
            para[3].Value = FAdr;

            para[4] = new SqlParameter("@TEL", SqlDbType.NVarChar, 50);
            para[4].Value = tel;

            para[5] = new SqlParameter("@FAX", SqlDbType.NVarChar, 50);
            para[5].Value = fax;

            para[6] = new SqlParameter("@Email", SqlDbType.NVarChar, 50);
            para[6].Value = email;

            para[7] = new SqlParameter("@WebSite", SqlDbType.NVarChar, 50);
            para[7].Value = website;

            para[8] = new SqlParameter("@Logo", SqlDbType.Image);
            para[8].Value = img;
            connectionDB.execute("Comp_Add",para);
          //  connec.Close();

        }

        public DataTable GetAllDataC()
        {
            DL.ConnectionDB connectionDB = new DL.ConnectionDB();
           // connec.Open();
            DataTable dt = new DataTable();
            dt = connectionDB.SelectData("GetAllComp", null);
           // connec.Close();
            return dt;

        }

        public void EditCompany(int num, string companyName, string companyFN, string Adr, string FAdr, string tel, string fax, string email, string website, byte[] img)
        {
            DL.ConnectionDB connectionDB = new DL.ConnectionDB();
          //  connec.Open();
            SqlParameter[] para = new SqlParameter[10];
            
            para[0] = new SqlParameter("@NO", SqlDbType.Int);
            para[0].Value = num;

            para[1] = new SqlParameter("@Name", SqlDbType.NVarChar, 100);
            para[1].Value = companyName;

            para[2] = new SqlParameter("@FName", SqlDbType.NVarChar, 100);
            para[2].Value = companyFN;

            para[3] = new SqlParameter("@Address", SqlDbType.NVarChar, 200);
            para[3].Value = Adr;

            para[4] = new SqlParameter("@FAddress", SqlDbType.NVarChar, 200);
            para[4].Value = FAdr;

            para[5] = new SqlParameter("@TEL", SqlDbType.NVarChar, 50);
            para[5].Value = tel;

            para[6] = new SqlParameter("@FAX", SqlDbType.NVarChar, 50);
            para[6].Value = fax;

            para[7] = new SqlParameter("@Email", SqlDbType.NVarChar, 50);
            para[7].Value = email;

            para[8] = new SqlParameter("@WebSite", SqlDbType.NVarChar, 50);
            para[8].Value = website;

            para[9] = new SqlParameter("@Logo", SqlDbType.Image);
            para[9].Value = img;
            connectionDB.execute("CompUpdate", para);
          //  connec.Close();

        }

        public void DeletCompany(int id)
        {
            DL.ConnectionDB connectionDB = new DL.ConnectionDB();
          //  connec.Open();
            SqlParameter[] para = new SqlParameter[1];

            para[0] = new SqlParameter("@NO", SqlDbType.Int);
            para[0].Value = id;
            connectionDB.execute("CompDelete", para);
           // connec.Close();

        }

        #endregion

        #region funds and bank
        public DataTable GetBank_Fun(int numTest)
        {
            DL.ConnectionDB connectionDB= new DL.ConnectionDB();
            DataTable dt = new DataTable();
            SqlParameter[] par = new SqlParameter[1];
            par[0]=new SqlParameter("@CashTest", SqlDbType.Int);
            par[0].Value = numTest;
           dt= connectionDB.SelectData("GETALLCash", par);
            return dt;


        }
        
             public void CashDelete(int AccNum, int numTest)
        {
            DL.ConnectionDB connectionDB = new DL.ConnectionDB();

            SqlParameter[] par = new SqlParameter[2];
          
            par[0] = new SqlParameter("@AccNum", SqlDbType.Int);
            par[0].Value = AccNum;

            par[1] = new SqlParameter("@test", SqlDbType.Int);
            par[1].Value = numTest;

            connectionDB.execute("CashDelete", par);


        }
        public void Dk_Fun(string name ,string fname,int AccNum, int numTest)
        {
            DL.ConnectionDB connectionDB = new DL.ConnectionDB();
           
            SqlParameter[] par = new SqlParameter[4];
            par[0] = new SqlParameter("@AccName", SqlDbType.NVarChar,50);
            par[0].Value = name;

            par[1] = new SqlParameter("@FAccName", SqlDbType.NVarChar,50);
            par[1].Value = fname;
            par[2] = new SqlParameter("@AccNum", SqlDbType.Int);
            par[2].Value = AccNum;

            par[3] = new SqlParameter("@test", SqlDbType.Int);
            par[3].Value = numTest;

            connectionDB.execute("Cash_Add", par);
         

        }

        public DataTable searchinAcc(string numTest)
        {
            DL.ConnectionDB connectionDB = new DL.ConnectionDB();
            DataTable dt = new DataTable();
            SqlParameter[] par = new SqlParameter[1];
            par[0] = new SqlParameter("@text", SqlDbType.NVarChar,25);
            par[0].Value = numTest;
            dt = connectionDB.SelectData("searchinAcc", par);
            return dt;


        }

        public DataTable GetOneCashe(string numTest)
        {
            DL.ConnectionDB connectionDB = new DL.ConnectionDB();
            DataTable dt = new DataTable();
            SqlParameter[] par = new SqlParameter[1];
            par[0] = new SqlParameter("@AccName", SqlDbType.NVarChar, 50);
            par[0].Value = numTest;
            dt = connectionDB.SelectData("GetOneCashe", par);
            return dt;


        }
        public DataTable GetCashes()
        {
            DL.ConnectionDB connectionDB = new DL.ConnectionDB();
            DataTable dt = new DataTable();
          
            dt = connectionDB.SelectData("GetCashes", null);
            return dt;


        }



        #endregion




        #region currency



        public DataTable GetAllCurrency()
        {
            DL.ConnectionDB connectionDB = new DL.ConnectionDB();
            // connec.Open();
            DataTable dt = new DataTable();
            dt = connectionDB.SelectData("GetAllCurrency", null);
            // connec.Close();
            return dt;
        }

        public void CurrencyAdd(string Name,string FName,string CurrSYM,int CurrType,double CurrExch,string CurrDEC)
        {
            DL.ConnectionDB CON = new DL.ConnectionDB();
           
            SqlParameter[] para = new SqlParameter[6];
            para[0] = new SqlParameter("@Name", SqlDbType.NVarChar,20);
            para[0].Value = Name;
            para[1] = new SqlParameter("@FName", SqlDbType.NVarChar, 20);
            para[1].Value = FName;
            para[2] = new SqlParameter("@CurrSYM", SqlDbType.NVarChar, 20);
            para[2].Value = CurrSYM;
            para[3] = new SqlParameter("@CurrType", SqlDbType.Int);
            para[3].Value = CurrType;
            para[4] = new SqlParameter("@CurrExch", SqlDbType.Decimal);
            para[4].Value = CurrExch;
            para[5] = new SqlParameter("@CurrDEC", SqlDbType.NVarChar, 20);
            para[5].Value = CurrDEC;
          
            CON.execute("CurrencyAdd", para);
            
        }


        public void CurrencyUpdate(int ID, string Name, string FName, string CurrSYM, int CurrType, double CurrExch, string CurrDEC)
        {
            DL.ConnectionDB CON = new DL.ConnectionDB();

            SqlParameter[] para = new SqlParameter[7];
            
            para[0] = new SqlParameter("@ID", SqlDbType.Int);
            para[0].Value = ID;
            para[1] = new SqlParameter("@Name", SqlDbType.NVarChar, 20);
            para[1].Value = Name;
            para[2] = new SqlParameter("@FName", SqlDbType.NVarChar, 20);
            para[2].Value = FName;
            para[3] = new SqlParameter("@CurrSYM", SqlDbType.NVarChar, 20);
            para[3].Value = CurrSYM;
            para[4] = new SqlParameter("@CurrType", SqlDbType.Int);
            para[4].Value = CurrType;
            para[5] = new SqlParameter("@CurrExch", SqlDbType.Decimal);
            para[5].Value = CurrExch;
            para[6] = new SqlParameter("@CurrDEC", SqlDbType.NVarChar, 20);
            para[6].Value = CurrDEC;

            CON.execute("CurrencyUpdate", para);

        }

        public void CurrencyDelete(int id)
        {
            DL.ConnectionDB connectionDB = new DL.ConnectionDB();
         
            SqlParameter[] para = new SqlParameter[1];

            para[0] = new SqlParameter("@ID", SqlDbType.Int);
            para[0].Value = id;
            connectionDB.execute("CurrencyDelete", para);
           

        }

        
             public DataTable CurrExc(string Name)
        {
                DL.ConnectionDB connectionDB = new DL.ConnectionDB();
                DataTable dt = new DataTable();
                SqlParameter[] para = new SqlParameter[1];

               para[0] = new SqlParameter("@Name", SqlDbType.NVarChar,20);
               para[0].Value = Name;
               dt= connectionDB.SelectData("CurrExc", para);
               return dt;

        }

        #endregion
    }
}
