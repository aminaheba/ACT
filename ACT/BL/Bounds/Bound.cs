using ACT.tool;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT.BL.Bounds
{
    internal class Bound
    {
        public DataTable GenerateNumBound(int numtest)
        {
            DL.ConnectionDB connectionDB = new DL.ConnectionDB();
            SqlParameter[] par = new SqlParameter[1];
            par[0] = new SqlParameter("@numtest", SqlDbType.Int);
            par[0].Value = numtest;

            // connec.Open();
            DataTable result = new DataTable();
            result = connectionDB.SelectData("GenerateNumBound", par);
            //connec.Close();
            return result;
        }
        public void BoundH_Add(int NO,DateTime Date, string Note,int Post,double Balance, int UAdd, DateTime AddDate, int UEdit,DateTime EditDate, int Type,int CachNo,int BankNo,int jno,int currid
            ,double currexch)
        {
            //
            DL.ConnectionDB db = new DL.ConnectionDB();
            SqlParameter[] sqlp = new SqlParameter[15];
            sqlp[0] = new SqlParameter("@NO", SqlDbType.Int);
            sqlp[0].Value = NO;
            sqlp[1] = new SqlParameter("@Date", SqlDbType.DateTime);
            sqlp[1].Value = Date;
            sqlp[2] = new SqlParameter("@Note", SqlDbType.NVarChar, 200);
            sqlp[2].Value = Note;
            sqlp[3] = new SqlParameter("@Post", SqlDbType.Int);
            sqlp[3].Value = Post;
            sqlp[4] = new SqlParameter("@Balance", SqlDbType.Money);
            sqlp[4].Value = Balance;
            sqlp[5] = new SqlParameter("@UAdd", SqlDbType.Int);
            sqlp[5].Value = UAdd;
            sqlp[6] = new SqlParameter("@AddDate", SqlDbType.DateTime);
            sqlp[6].Value = AddDate;
            sqlp[7] = new SqlParameter("@UEdit", SqlDbType.Int);
            sqlp[7].Value = UEdit;
            sqlp[8] = new SqlParameter("@EditDate", SqlDbType.DateTime);
            sqlp[8].Value = EditDate;
            sqlp[9] = new SqlParameter("@Type", SqlDbType.Int);
            sqlp[9].Value = Type;
            sqlp[10] = new SqlParameter("@CachNo", SqlDbType.Int);
            sqlp[10].Value = CachNo;
            sqlp[11] = new SqlParameter("@BankNo", SqlDbType.Int);
            sqlp[11].Value = BankNo;

            sqlp[12] = new SqlParameter("@JNO", SqlDbType.Int);
            sqlp[12].Value = jno;
            sqlp[13] = new SqlParameter("@CurrNo", SqlDbType.Int);
            sqlp[13].Value = currid;

            sqlp[14] = new SqlParameter("@CurrExc", SqlDbType.Money);
            sqlp[14].Value = currexch;
            
            db.execute("BoundH_Add", sqlp);

        }
        public void BoundHUpdate(int NO, DateTime Date, string Note, int Post, double Balance,  int UEdit, DateTime EditDate, int Type, int CachNo, int BankNo, int currid, double currexch)
        {
            //
            DL.ConnectionDB db = new DL.ConnectionDB();
            SqlParameter[] sqlp = new SqlParameter[12];
            sqlp[0] = new SqlParameter("@NO", SqlDbType.Int);
            sqlp[0].Value = NO;
            sqlp[1] = new SqlParameter("@Date", SqlDbType.DateTime);
            sqlp[1].Value = Date;
            sqlp[2] = new SqlParameter("@Note", SqlDbType.NVarChar, 200);
            sqlp[2].Value = Note;
            sqlp[3] = new SqlParameter("@Post", SqlDbType.Int);
            sqlp[3].Value = Post;
            sqlp[4] = new SqlParameter("@Balance", SqlDbType.Money);
            sqlp[4].Value = Balance;
           
            sqlp[5] = new SqlParameter("@UEdit", SqlDbType.Int);
            sqlp[5].Value = UEdit;
            sqlp[6] = new SqlParameter("@EditDate", SqlDbType.DateTime);
            sqlp[6].Value = EditDate;
            sqlp[7] = new SqlParameter("@Type", SqlDbType.Int);
            sqlp[7].Value = Type;
            sqlp[8] = new SqlParameter("@CachNo", SqlDbType.Int);
            sqlp[8].Value = CachNo;
            sqlp[9] = new SqlParameter("@BankNo", SqlDbType.Int);
            sqlp[9].Value = BankNo;
            sqlp[10] = new SqlParameter("@CurrNo", SqlDbType.Int);
            sqlp[10].Value = currid;

            sqlp[11] = new SqlParameter("@CurrExc", SqlDbType.Money);
            sqlp[11].Value = currexch;
           
            db.execute("BoundHUpdate", sqlp);

        }
        public void BoundHDelete(int AccNo)
        {
            DL.ConnectionDB db = new DL.ConnectionDB();
            SqlParameter[] sqlp = new SqlParameter[1];
            sqlp[0] = new SqlParameter("@NO", SqlDbType.Int);
            sqlp[0].Value = AccNo;


            db.execute("BoundHDelete", sqlp);

        }
        public void BoundL_Add( int AccNo,double Amount,string Note,int Curr,int BNo)
        {
            DL.ConnectionDB db = new DL.ConnectionDB();
            SqlParameter[] sqlp = new SqlParameter[5];
          
            sqlp[0] = new SqlParameter("@AccNo", SqlDbType.Int);
            sqlp[0].Value = AccNo;
            sqlp[1] = new SqlParameter("@Amount", SqlDbType.Money);
            sqlp[1].Value = Amount;
            sqlp[2] = new SqlParameter("@Note", SqlDbType.NVarChar, 200);
            sqlp[2].Value = Note;
            sqlp[3] = new SqlParameter("@Curr", SqlDbType.Int);
            sqlp[3].Value = Curr;
            sqlp[4] = new SqlParameter("@BNo", SqlDbType.Int);
            sqlp[4].Value = BNo;


            db.execute("BoundL_Add", sqlp);

        }
        public void BoundLUpdate(int NO, int AccNo, double Amount, string Note, int Curr, int BNo)
        {
            DL.ConnectionDB db = new DL.ConnectionDB();
            SqlParameter[] sqlp = new SqlParameter[6];
            sqlp[0] = new SqlParameter("@NO", SqlDbType.Money);
            sqlp[0].Value = NO;
            sqlp[1] = new SqlParameter("@AccNo", SqlDbType.Int);
            sqlp[1].Value = AccNo;
            sqlp[2] = new SqlParameter("@Amount", SqlDbType.Money);
            sqlp[2].Value = Amount;
            sqlp[3] = new SqlParameter("@Note", SqlDbType.NVarChar, 200);
            sqlp[3].Value = Note;
            sqlp[4] = new SqlParameter("@Curr", SqlDbType.Int);
            sqlp[4].Value = Curr;
            sqlp[5] = new SqlParameter("@BNo", SqlDbType.Int);
            sqlp[5].Value = BNo;


            db.execute("BoundLUpdate", sqlp);

        }
        public void BoundLDelete(int AccNo)
        {
            DL.ConnectionDB db = new DL.ConnectionDB();
            SqlParameter[] sqlp = new SqlParameter[1];
            sqlp[0] = new SqlParameter("@BNo", SqlDbType.Int);
            sqlp[0].Value = AccNo;



            db.execute("BoundLDelete", sqlp);

        }
        /*
         * 
         */

        public DataTable Getbound(int jno)
        {
            DL.ConnectionDB db = new DL.ConnectionDB();
            DataTable dt = new DataTable();
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@NO", SqlDbType.Int);
            para[0].Value = jno;
            dt = db.SelectData("Getbound", para);
            return dt;
        }
        public DataTable GetBoundLine(int bno)
        {
            DL.ConnectionDB db = new DL.ConnectionDB();
            DataTable dt = new DataTable();
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@BNo", SqlDbType.Int);
            para[0].Value = bno;
            dt = db.SelectData("GetBoundLine", para);
            return dt;
        }
        public DataTable GET_BoundNext(int jno)
        {
            DL.ConnectionDB db = new DL.ConnectionDB();
            DataTable dt = new DataTable();
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@jno", SqlDbType.Int);
            para[0].Value = jno;
            dt = db.SelectData("GET_BoundNext", para);
            return dt;
        }
        public DataTable GET_BoundPrev(int jno)
        {
            DL.ConnectionDB db = new DL.ConnectionDB();
            DataTable dt = new DataTable();
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@jno", SqlDbType.Int);
            para[0].Value = jno;
            dt = db.SelectData("GET_BoundPrev", para);
            return dt;
        }
       

        public DataTable GET_BoundFirst()
        {
            DL.ConnectionDB db = new DL.ConnectionDB();
            DataTable dt = new DataTable();

            dt = db.SelectData("GET_BoundFirst", null);
            return dt;
        }

        public DataTable GET_BoundLast()
        {
            DL.ConnectionDB db = new DL.ConnectionDB();
            DataTable dt = new DataTable();

            dt = db.SelectData("GET_BoundLast", null);
            return dt;
        }

    }

}
