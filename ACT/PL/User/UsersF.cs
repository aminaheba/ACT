using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace ACT.PL
{
    public partial class Login : Form
    {
        public SqlConnection Connection=DL.ConnectionDB.GetConnection();
        public Login()
        {
            InitializeComponent();
        }
       
        public DataTable loginTest(string name ,string pass) { 
            DL.ConnectionDB db = new DL.ConnectionDB();
           // Connection.Open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@UName", SqlDbType.NVarChar, 200);
            param[0].Value = name;
            param[1] = new SqlParameter("@UPWD", SqlDbType.NVarChar, 200);
            param[1].Value = pass;
            DataTable dt = new DataTable();
            dt = db.SelectData("LoginTest", param);
           // Connection.Close();
            return dt;

        }

        private void textname_TextChanged(object sender, EventArgs e)
        {

        }

        private void textpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            PL.Login login = new PL.Login();
            dt=login.loginTest(textname.Text,textpassword.Text);
            if(dt.Rows.Count > 0)
            {
                this.Hide();
                Program.UName=textname.Text;
                Program.roleu = Convert.ToInt32(dt.Rows[0][7].ToString());
                
                Main main = new Main();
                main.Show();
            }
            else
            {
                MessageBox.Show("كلمة المرور أو اسم المستخدم خاطئة");
            }
        }
    }
}
