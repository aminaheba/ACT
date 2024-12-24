using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Data.SqlClient;
using ACT.tool;
using System.Data;
using System.Runtime.InteropServices;
using System.Xml.Linq;

namespace ACT.BL
{
    public class Helper
    {
       public MemoryStream me=new MemoryStream();
       public byte[] data;
        //convert img to byte
        public byte[] ConvertByte() {
            return me.ToArray(); 
        }
        //convert byte to img
        public MemoryStream ConvertImg() { 
            me = new MemoryStream(data);
            return me;
 
                }
        public bool checkEmail(string email)
        {
            Regex reg = new Regex(@"^\w+([-_.]\w+)*@\w+([-.]\w+)*\.\w+$");
            if (!reg.IsMatch(email))
            {
                MessageBox.Show("الصيغة التي ادخلتها غير صحبجة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
               return false;
            }
            else { return true; }
        }
        public SqlParameter[] GetParametrBH()
        {
            SqlParameter[] sqlp = new SqlParameter[16];
            sqlp[0] = new SqlParameter("@NO", SqlDbType.Int);
            sqlp[1] = new SqlParameter("@Date", SqlDbType.DateTime);
            sqlp[2] = new SqlParameter("@Note", SqlDbType.NVarChar, 200);
            sqlp[3] = new SqlParameter("@Post", SqlDbType.Int);
            sqlp[4] = new SqlParameter("@Balance", SqlDbType.Money);
            sqlp[5] = new SqlParameter("@UAdd", SqlDbType.Int);
            sqlp[6] = new SqlParameter("@AddDate", SqlDbType.DateTime);
            sqlp[7] = new SqlParameter("@UEdit", SqlDbType.Int);
            sqlp[8] = new SqlParameter("@EditDate", SqlDbType.DateTime);
            sqlp[9] = new SqlParameter("@Type", SqlDbType.Int);
            sqlp[10] = new SqlParameter("@CachNo", SqlDbType.Int);
            sqlp[11] = new SqlParameter("@BankNo", SqlDbType.Int);
            sqlp[12] = new SqlParameter("@JNO", SqlDbType.Int);
            sqlp[13] = new SqlParameter("@CurrNo", SqlDbType.Int);
            sqlp[14] = new SqlParameter("@CurrExc", SqlDbType.Money);
            //@BalanceF
            sqlp[15] = new SqlParameter("@BalanceF", SqlDbType.Money);

            return sqlp;
        }
        public SqlParameter[] GetParametrBL()
        {
            SqlParameter[] sqlp = new SqlParameter[6];
            sqlp[0] = new SqlParameter("@AccNo", SqlDbType.Int);
            sqlp[1] = new SqlParameter("@Amount", SqlDbType.Money);
            sqlp[2] = new SqlParameter("@Note", SqlDbType.NVarChar, 200);
            sqlp[3] = new SqlParameter("@Curr", SqlDbType.Int);
            sqlp[4] = new SqlParameter("@BNo", SqlDbType.Int);
            sqlp[5] = new SqlParameter("@BalanceF", SqlDbType.Money);

            return sqlp;
        }
        public SqlParameter[] BoundLUpdate()
        {
           
            SqlParameter[] sqlp = new SqlParameter[7];
            sqlp[0] = new SqlParameter("@NO", SqlDbType.Money);
           
            sqlp[1] = new SqlParameter("@AccNo", SqlDbType.Int);
         
            sqlp[2] = new SqlParameter("@Amount", SqlDbType.Money);
           
            sqlp[3] = new SqlParameter("@Note", SqlDbType.NVarChar, 200);

            sqlp[4] = new SqlParameter("@Curr", SqlDbType.Int);
           
            sqlp[5] = new SqlParameter("@BNo", SqlDbType.Int);
            sqlp[6] = new SqlParameter("@BalanceF", SqlDbType.Money);

            return sqlp ;

          

        }
        public SqlParameter[] BoundHUpdate()
        {
            //
           
            SqlParameter[] sqlp = new SqlParameter[13];
            sqlp[0] = new SqlParameter("@NO", SqlDbType.Int);
            sqlp[1] = new SqlParameter("@Date", SqlDbType.DateTime);
            sqlp[2] = new SqlParameter("@Note", SqlDbType.NVarChar, 200);
            sqlp[3] = new SqlParameter("@Post", SqlDbType.Int);
            sqlp[4] = new SqlParameter("@Balance", SqlDbType.Money);

            sqlp[5] = new SqlParameter("@UEdit", SqlDbType.Int);
            sqlp[6] = new SqlParameter("@EditDate", SqlDbType.DateTime);
            sqlp[7] = new SqlParameter("@Type", SqlDbType.Int);
            sqlp[8] = new SqlParameter("@CachNo", SqlDbType.Int);
            sqlp[9] = new SqlParameter("@BankNo", SqlDbType.Int);
            sqlp[10] = new SqlParameter("@CurrNo", SqlDbType.Int);
            sqlp[11] = new SqlParameter("@CurrExc", SqlDbType.Money);
            sqlp[12] = new SqlParameter("@BalanceF", SqlDbType.Money);
            return sqlp ;
            

        }

        public SqlParameter[] JournalHUpdate()
        {
           
            SqlParameter[] sqlp = new SqlParameter[14];
            sqlp[0] = new SqlParameter("@NO", SqlDbType.Int);
            sqlp[1] = new SqlParameter("@Date", SqlDbType.DateTime);
            sqlp[2] = new SqlParameter("@Note", SqlDbType.NVarChar, 200);
            sqlp[3] = new SqlParameter("@Type", SqlDbType.Int);
            sqlp[4] = new SqlParameter("@Post", SqlDbType.Int);
            sqlp[5] = new SqlParameter("@Acc_Report", SqlDbType.Int);
            sqlp[6] = new SqlParameter("@Sum_Debit", SqlDbType.Money);
            sqlp[7] = new SqlParameter("@Sum_Credit", SqlDbType.Money);
            sqlp[8] = new SqlParameter("@Balance", SqlDbType.Money);

            sqlp[9] = new SqlParameter("@UEdit", SqlDbType.Int);
            sqlp[10] = new SqlParameter("@EditDate", SqlDbType.DateTime);
            sqlp[11] = new SqlParameter("@CurrNo", SqlDbType.Int);

            sqlp[12] = new SqlParameter("@CurrExc", SqlDbType.Money);
            //sqlp[12] = new SqlParameter("@ProcID", SqlDbType.Int);
            sqlp[13] = new SqlParameter("@BalanceF", SqlDbType.Money);
            return sqlp;
        }
        public SqlParameter[] JournalLUpdate()
        {
          
            SqlParameter[] sqlp = new SqlParameter[6];
            sqlp[0] = new SqlParameter("@AccNo", SqlDbType.Int);
            sqlp[1] = new SqlParameter("@AccDebit", SqlDbType.Money);
            sqlp[2] = new SqlParameter("@AcCredit", SqlDbType.Money);

            sqlp[3] = new SqlParameter("@Note", SqlDbType.NVarChar, 200);
            sqlp[4] = new SqlParameter("@JNo", SqlDbType.Int);
            sqlp[5] = new SqlParameter("@BalanceF", SqlDbType.Money);


            return sqlp;

        }
        public SqlParameter[] JournalH_Add()
        {
           
            SqlParameter[] sqlp = new SqlParameter[17];
            sqlp[0] = new SqlParameter("@NO", SqlDbType.Int);
            sqlp[1] = new SqlParameter("@Date", SqlDbType.DateTime);
            sqlp[2] = new SqlParameter("@Note", SqlDbType.NVarChar, 200);
            sqlp[3] = new SqlParameter("@Type", SqlDbType.Int);
            sqlp[4] = new SqlParameter("@Post", SqlDbType.Int);
            sqlp[5] = new SqlParameter("@Acc_Report", SqlDbType.Int);
            sqlp[6] = new SqlParameter("@Sum_Debit", SqlDbType.Money);
            sqlp[7] = new SqlParameter("@Sum_Credit", SqlDbType.Money);
            sqlp[8] = new SqlParameter("@Balance", SqlDbType.Money);
            sqlp[9] = new SqlParameter("@UAdd", SqlDbType.Int);
            sqlp[10] = new SqlParameter("@AddDate", SqlDbType.DateTime);
            sqlp[11] = new SqlParameter("@UEdit", SqlDbType.Int);
            sqlp[12] = new SqlParameter("@EditDate", SqlDbType.DateTime);
            sqlp[13] = new SqlParameter("@CurNo", SqlDbType.Int);
            sqlp[14] = new SqlParameter("@CurrExc", SqlDbType.Money);
            sqlp[15] = new SqlParameter("@ProcID", SqlDbType.Int);
            sqlp[16] = new SqlParameter("@BalanceF", SqlDbType.Money);
            return sqlp;
        }
        public SqlParameter[] JournalL_Add()
        {
            DL.ConnectionDB db = new DL.ConnectionDB();
            SqlParameter[] sqlp = new SqlParameter[6];
            sqlp[0] = new SqlParameter("@AccNo", SqlDbType.Int);
            sqlp[1] = new SqlParameter("@AccDebit", SqlDbType.Money);
            sqlp[2] = new SqlParameter("@AcCredit", SqlDbType.Money);
            sqlp[3] = new SqlParameter("@Note", SqlDbType.NVarChar, 200);
            sqlp[4] = new SqlParameter("@JNo", SqlDbType.Int);
            sqlp[5] = new SqlParameter("@BalanceF", SqlDbType.Money);
            return sqlp;


        }




    }
}
