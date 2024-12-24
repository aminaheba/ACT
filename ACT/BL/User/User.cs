using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Runtime.InteropServices;
using System.Xml.Linq;
using System.Drawing;

namespace ACT.BL.User
{

    public class User {
       // public SqlConnection connec = DL.ConnectionDB.GetConnection();

        public DataTable GenerateUID() {
            DL.ConnectionDB CON = new DL.ConnectionDB();
            //connec.Open();
            DataTable dt = new DataTable();
            dt = CON.SelectData("Generet_UID", null);
           // connec.Close();
            return dt;


    }
        public DataTable GetAll()
        {
            DL.ConnectionDB con = new DL.ConnectionDB();
          //  connec.Open();
            DataTable dt = new DataTable();
            dt = con.SelectData("GETALLUser", null);
           // connec.Close();
            return dt;
        }
        public void AddUser(int NO, string FName,string Name,string PassWord,string Tel,string Email,int UState,int UType,byte[] IMG)
        {
            DL.ConnectionDB CON = new DL.ConnectionDB();
          //  connec.Open();
            SqlParameter[] para = new SqlParameter[9];
            para[0] = new SqlParameter("@NO", SqlDbType.Int);
            para[0].Value = NO;
            para[1] = new SqlParameter("@FName", SqlDbType.NVarChar,60);
            para[1].Value = FName;
            para[2] = new SqlParameter("@Name", SqlDbType.NVarChar,50);
            para[2].Value = Name;
            para[3] = new SqlParameter("@PassWord", SqlDbType.NVarChar,50);
            para[3].Value = PassWord;
            para[4] = new SqlParameter("@Tel", SqlDbType.NVarChar,50);
            para[4].Value = Tel;
            para[5] = new SqlParameter("@Email", SqlDbType.NVarChar, 50);
            para[5].Value = Email;
            para[6] = new SqlParameter("@UState", SqlDbType.Int);
            para[6].Value = UState;
            para[7] = new SqlParameter("@UType", SqlDbType.Int);
            para[7].Value = UType;
            para[8] = new SqlParameter("@IMG", SqlDbType.Image);
            para[8].Value = IMG;
            CON.execute("UserAdd", para);
          //  connec.Close();

        }

        public void UpdateUser(int NO, string FName, string Name, string PassWord, string Tel, string Email, int UState, int UType, byte[] IMG)
        { 
            DL.ConnectionDB connectionDB = new DL.ConnectionDB();
           // connec.Open();
            SqlParameter[] para = new SqlParameter[9];
            para[0] = new SqlParameter("@NO", SqlDbType.Int);
            para[0].Value = NO;
            para[1] = new SqlParameter("@FName", SqlDbType.NVarChar, 60);
            para[1].Value = FName;
            para[2] = new SqlParameter("@Name", SqlDbType.NVarChar, 50);
            para[2].Value = Name;
            para[3] = new SqlParameter("@PassWord", SqlDbType.NVarChar, 50);
            para[3].Value = PassWord;
            para[4] = new SqlParameter("@Tel", SqlDbType.NVarChar, 50);
            para[4].Value = Tel;
            para[5] = new SqlParameter("@Email", SqlDbType.NVarChar, 50);
            para[5].Value = Email;
            para[6] = new SqlParameter("@UState", SqlDbType.Int);
            para[6].Value = UState;
            para[7] = new SqlParameter("@UType", SqlDbType.Int);
            para[7].Value = UType;
            para[8] = new SqlParameter("@IMG", SqlDbType.Image);
            para[8].Value = IMG;
            connectionDB.execute("UserUpdate", para);
           // connec.Close();

        }

        public void DelUser(int ID)
        {
            DL.ConnectionDB CON = new DL.ConnectionDB();
           // connec.Open();
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@NO", SqlDbType.Int);
            para[0].Value = ID ;
            CON.execute("UserDELET", para);
          //  connec.Close();
        }
    }
}
