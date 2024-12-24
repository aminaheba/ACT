using ACT.tool;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT.BL.Journal
{
    public class Journal
    {
        public void JournalH_Add(int NO,DateTime Date,string Note, int Type,int Post, int Acc_Report,double Sum_Debit,double Sum_Credit,double Balance,int UAdd, DateTime AddDate,int UEdit, DateTime EditDate,int CurrNo,double CurrExc,int ProcID)
        {
            DL.ConnectionDB db = new DL.ConnectionDB();
            SqlParameter[] sqlp = new SqlParameter[16];
            sqlp[0]=new SqlParameter("@NO", SqlDbType.Int);
            sqlp[0].Value = NO;
            sqlp[1] = new SqlParameter("@Date", SqlDbType.DateTime);
            sqlp[1].Value = Date;
            sqlp[2] = new SqlParameter("@Note", SqlDbType.NVarChar,200);
            sqlp[2].Value = Note;
            sqlp[3] = new SqlParameter("@Type", SqlDbType.Int);
            sqlp[3].Value = Type;
            sqlp[4] = new SqlParameter("@Post", SqlDbType.Int);
            sqlp[4].Value = Post;
            sqlp[5] = new SqlParameter("@Acc_Report", SqlDbType.Int);
            sqlp[5].Value = Acc_Report;
            sqlp[6] = new SqlParameter("@Sum_Debit", SqlDbType.Money);
            sqlp[6].Value = Sum_Debit;
            sqlp[7] = new SqlParameter("@Sum_Credit", SqlDbType.Money);
            sqlp[7].Value = Sum_Credit;
            sqlp[8] = new SqlParameter("@Balance", SqlDbType.Money);
            sqlp[8].Value = CurrExc;
            sqlp[9] = new SqlParameter("@UAdd", SqlDbType.Int);
            sqlp[9].Value = UAdd;
            sqlp[10] = new SqlParameter("@AddDate", SqlDbType.DateTime);
            sqlp[10].Value = AddDate;
            sqlp[11] = new SqlParameter("@UEdit", SqlDbType.Int);
            sqlp[11].Value = UEdit;
            sqlp[12] = new SqlParameter("@EditDate", SqlDbType.DateTime);
            sqlp[12].Value = EditDate;
            sqlp[13] = new SqlParameter("@CurNo", SqlDbType.Int);
            sqlp[13].Value = CurrNo;
            

            sqlp[14] = new SqlParameter("@CurrExc", SqlDbType.Money);
            sqlp[14].Value = Balance;
            sqlp[15] = new SqlParameter("@ProcID", SqlDbType.Int);
            sqlp[15].Value = ProcID;
            db.execute("JournalH_Add", sqlp);
           
        }


        public void JournalHUpdate(int NO, DateTime Date, string Note, int Type, int Post, int Acc_Report, double Sum_Debit, double Sum_Credit, double Balance, int UEdit, DateTime EditDate, int CurrNo, double CurrExc,int ProcID)
        {
            DL.ConnectionDB db = new DL.ConnectionDB();
            SqlParameter[] sqlp = new SqlParameter[14];
            sqlp[0] = new SqlParameter("@NO", SqlDbType.Int);
            sqlp[0].Value = NO;
            sqlp[1] = new SqlParameter("@Date", SqlDbType.DateTime);
            sqlp[1].Value = Date;
            sqlp[2] = new SqlParameter("@Note", SqlDbType.NVarChar, 200);
            sqlp[2].Value = Note;
            sqlp[3] = new SqlParameter("@Type", SqlDbType.Int);
            sqlp[3].Value = Type;
            sqlp[4] = new SqlParameter("@Post", SqlDbType.Int);
            sqlp[4].Value = Post;
            sqlp[5] = new SqlParameter("@Acc_Report", SqlDbType.Int);
            sqlp[5].Value = Acc_Report;
            sqlp[6] = new SqlParameter("@Sum_Debit", SqlDbType.Money);
            sqlp[6].Value = Sum_Debit;
            sqlp[7] = new SqlParameter("@Sum_Credit", SqlDbType.Money);
            sqlp[7].Value = Sum_Credit;
            sqlp[8] = new SqlParameter("@Balance", SqlDbType.Money);
            sqlp[8].Value = Balance;
           
            sqlp[9] = new SqlParameter("@UEdit", SqlDbType.Int);
            sqlp[9].Value = UEdit;
            sqlp[10] = new SqlParameter("@EditDate", SqlDbType.DateTime);
            sqlp[10].Value = EditDate;
            sqlp[11] = new SqlParameter("@CurrNo", SqlDbType.Int);
            sqlp[11].Value = CurrNo;

            sqlp[12] = new SqlParameter("@CurrExc", SqlDbType.Money);
            sqlp[12].Value = CurrExc;
            sqlp[13] = new SqlParameter("@ProcID", SqlDbType.Int);
            sqlp[13].Value = ProcID;
            db.execute("JournalHUpdate", sqlp);

        }
        public void JournalHDelete(int AccNo)
        {
            DL.ConnectionDB db = new DL.ConnectionDB();
            SqlParameter[] sqlp = new SqlParameter[1];
            sqlp[0] = new SqlParameter("@NO", SqlDbType.Int);
            sqlp[0].Value = AccNo;


            db.execute("JournalHDelete", sqlp);

        }


        public void JournalL_Add(int AccNo,double AccDebit, double AcCredit, string Note, int JNo)
        {
            DL.ConnectionDB db = new DL.ConnectionDB();
            SqlParameter[] sqlp = new SqlParameter[5];
            sqlp[0] = new SqlParameter("@AccNo", SqlDbType.Int);
            sqlp[0].Value = AccNo;
            sqlp[1] = new SqlParameter("@AccDebit", SqlDbType.Money);
            sqlp[1].Value = AccDebit;
            sqlp[2] = new SqlParameter("@AcCredit", SqlDbType.Money);
            sqlp[2].Value = AcCredit;

            sqlp[3] = new SqlParameter("@Note", SqlDbType.NVarChar, 200);
            sqlp[3].Value = Note;
            sqlp[4] = new SqlParameter("@JNo", SqlDbType.Int);
            sqlp[4].Value = JNo;
           
          
            db.execute("JournalL_Add", sqlp);

        }
        public void JournalLUpdate(int AccNo, double AccDebit, double AcCredit, string Note, int JNo)
        {
            DL.ConnectionDB db = new DL.ConnectionDB();
            SqlParameter[] sqlp = new SqlParameter[5];
            sqlp[0] = new SqlParameter("@AccNo", SqlDbType.Int);
            sqlp[0].Value = AccNo;
            sqlp[1] = new SqlParameter("@AccDebit", SqlDbType.Money);
            sqlp[1].Value = AccDebit;
            sqlp[2] = new SqlParameter("@AcCredit", SqlDbType.Money);
            sqlp[2].Value = AcCredit;

            sqlp[3] = new SqlParameter("@Note", SqlDbType.NVarChar, 200);
            sqlp[3].Value = Note;
            sqlp[4] = new SqlParameter("@JNo", SqlDbType.Int);
            sqlp[4].Value = JNo;


            db.execute("JournalLUpdate", sqlp);

        }
        public void JournalLDelete(int AccNo)
        {
            DL.ConnectionDB db = new DL.ConnectionDB();
            SqlParameter[] sqlp = new SqlParameter[1];
            sqlp[0] = new SqlParameter("@JNO", SqlDbType.Int);
            sqlp[0].Value = AccNo;
           


            db.execute("JournalLDelete", sqlp);

        }


        
        public DataTable GET_JournalNext(int jno)
        {
            DL.ConnectionDB db = new DL.ConnectionDB();
            DataTable dt = new DataTable();
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@jno", SqlDbType.Int);
            para[0].Value = jno;
            dt = db.SelectData("GET_JournalNext", para);
            return dt;
        }
        public DataTable GET_JournalPrev(int jno)
        {
            DL.ConnectionDB db = new DL.ConnectionDB();
            DataTable dt = new DataTable();
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@jno", SqlDbType.Int);
            para[0].Value = jno;
            dt = db.SelectData("GET_JournalPrev", para);
            return dt;
        }
        public DataTable GetJournalID()
        {
            DL.ConnectionDB db = new DL.ConnectionDB();
            DataTable dt = new DataTable();
           
            dt = db.SelectData("GetJournalID", null);
            return dt;
        }
        
       public DataTable GET_JournalFirst()
        {
            DL.ConnectionDB db = new DL.ConnectionDB();
            DataTable dt = new DataTable();

            dt = db.SelectData("GET_JournalFirst", null);
            return dt;
        }
        
       public DataTable GET_JournalLast()
        {
            DL.ConnectionDB db = new DL.ConnectionDB();
            DataTable dt = new DataTable();

            dt = db.SelectData("GET_JournalLast", null);
            return dt;
        }

        public DataTable GetUserID(string name)
        {
            DL.ConnectionDB db = new DL.ConnectionDB();
            DataTable dt = new DataTable();
            SqlParameter[] para = new SqlParameter[1];
            para[0]=new SqlParameter("Name",SqlDbType.NVarChar,50);
            para[0].Value = name;
            dt = db.SelectData("GetUserID", para);
            return dt;
        }
        public DataTable GetCompletJournal(int jno)
        {
            DL.ConnectionDB db = new DL.ConnectionDB();
            DataTable dt = new DataTable();
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@NO", SqlDbType.Int);
            para[0].Value = jno;
            dt = db.SelectData("GetCompletJournal", para);
            return dt;
        }
        public DataTable GetCompletJournalLine(int jno)
        {
            DL.ConnectionDB db = new DL.ConnectionDB();
            DataTable dt = new DataTable();
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@JNo", SqlDbType.Int);
            para[0].Value = jno;
            dt = db.SelectData("GetCompletJournalLine", para);
            return dt;
        }
    }
}
