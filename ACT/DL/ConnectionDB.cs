using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;
using ACT.BL.Bounds;

namespace ACT.DL
{
     class ConnectionDB
    {
       
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter sda = new SqlDataAdapter();
        //connection
        public ConnectionDB() { 
            //win auth
          
            //sql auth
            //conn = new SqlConnection("server=DESKTOP-FDPP0DS\\SQLEXPRESS;database=ALmotakamlDB;integrated security=false ;userid= ;password=")
        }
        //open 
        public static SqlConnection GetConnection()
        {
            SqlConnection conn;
            // string strConnectionString = string.Empty;
            /*  strConnectionString = string.Concat(strConnectionString, "Driver={" + DarAbdullahService.Driver + "};");
              strConnectionString = string.Concat(strConnectionString, "ServerNode=", DarAbdullahService.DBServer, ";");
              strConnectionString = string.Concat(strConnectionString, "UID=", DarAbdullahService.DBUserName, ";");
              strConnectionString = string.Concat(strConnectionString, "PWD=", DarAbdullahService.DBPassword, ";");
              strConnectionString = string.Concat(strConnectionString, "CS=", DarAbdullahService.DBName, ";");
              OdbcConnection HanaConn = new OdbcConnection(strConnectionString.ToString());*/
            conn = new SqlConnection("server=DESKTOP-FDPP0DS\\SQLEXPRESS;database=ALmotakamlDB;integrated security=true");
            return conn;
        }
       
        //execute insert dalete update 
        public void execute( string spname, SqlParameter[] para) {
            SqlConnection conn = GetConnection();
            conn.Open();
            cmd.CommandType= CommandType.StoredProcedure;
            cmd.CommandText= spname;
            cmd.Connection = conn;
            if (para != null ) {
                cmd.Parameters.AddRange(para);
            }
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void executetransBOUND(string spname, SqlParameter[] para,string sp2, BoundLineCls[]para2)
        {   SqlTransaction sqlTransaction ;
            SqlConnection conn = GetConnection();
           
            conn.Open();
            sqlTransaction = conn.BeginTransaction("transall");

            cmd.CommandType = CommandType.StoredProcedure;
            
            cmd.Connection = conn;
            cmd.Transaction = sqlTransaction;
            try
            {
                SqlParameter[] sqlpl = new SqlParameter[5];

                if (para != null)
                {
                    cmd.Parameters.AddRange(para);
                }
                cmd.CommandText = spname;
                cmd.ExecuteNonQuery();
                if (para2 != null)
                {
                    for(int i = 0; i < para2.Length; i++) {
                        sqlpl[0] = new SqlParameter("@AccNo", SqlDbType.Int);
                        sqlpl[0].Value = para2[i].accno;
                        sqlpl[1] = new SqlParameter("@Amount", SqlDbType.Money);
                        sqlpl[1].Value = para2[i].accD;
                        sqlpl[2] = new SqlParameter("@Note", SqlDbType.NVarChar, 200);
                        sqlpl[2].Value = para2[i].note;
                        sqlpl[3] = new SqlParameter("@Curr", SqlDbType.Int);
                        sqlpl[3].Value = para2[i].currid;
                        sqlpl[4] = new SqlParameter("@BNo", SqlDbType.Int);
                        sqlpl[4].Value = para2[i].bno;
                        cmd.Parameters.AddRange(para2);
                        cmd.CommandText = sp2;
                        cmd.ExecuteNonQuery();
                    }
                  
                }

               
                sqlTransaction.Commit();
            }
            catch (Exception ex)
            {
               MessageBox.Show(" "+ex.Message,"",MessageBoxButtons.OK,MessageBoxIcon.Error);
                try {
                    sqlTransaction.Rollback();
                } catch (Exception ex2){
                    MessageBox.Show(" " + ex2.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            
            conn.Close();
        }
        //get data from databease
        public DataTable SelectData(string spname, SqlParameter[] para)
        {
            SqlConnection conn = GetConnection();
            conn.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = spname;
            cmd.Connection = conn;
            if (para != null)
            {
                for(int j=0; j < para.Length; j++)
                {
                    cmd.Parameters.Add(para[j]);
                }
            }
            sda= new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            conn.Close();
            dt.Clear();
            sda.Fill(dt);
            return dt;
           
        }

        public DataTable SelectDatabyqery(string qery)
        {
            SqlConnection conn = GetConnection();
            
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = qery;
          
           
            sda = new SqlDataAdapter(qery,conn);
            DataTable dt = new DataTable();
           
            dt.Clear();
            sda.Fill(dt);
            return dt;

        }
        public void GetBack(string spname)
        {
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = spname;
            SqlConnection conn = GetConnection();
           conn.Open();
           
            
            cmd.Connection = conn;
            cmd= new SqlCommand(spname, conn);

           
            cmd.ExecuteNonQuery();
            conn.Close();
        }

    }
}
