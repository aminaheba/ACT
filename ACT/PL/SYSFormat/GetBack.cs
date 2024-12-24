using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACT.PL.SYSFormat
{
    public partial class GetBack : Form
    {
        public GetBack()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { 
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Backup files (*.Bak)|*.bak";
                if(saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string backName=(DateTime.Now.ToShortDateString().Replace('/',  '-') +DateTime.Now.ToShortTimeString().Replace(':','-') + saveFileDialog.FileName.Replace(':','-')).Replace('\\', '-');
                    string cmdtext = "backup database ALmotakamlDB to disk = '" + backName+"'";
                    DL.ConnectionDB conn=new DL.ConnectionDB();
                    conn.GetBack(cmdtext);
                    MessageBox.Show(" تم اخذ نسخة بنجاح" , "النسخ الاحتياطي", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" "+ex.Message,"تنبيه",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
