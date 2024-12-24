using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACT.PL.Report
{
    public partial class AccQery : Form
    {
        BL.SysFormat.SysFormat SysFormat = new BL.SysFormat.SysFormat();
        DL.ConnectionDB ConnectionDB = new DL.ConnectionDB();
        PL.Report.AccCheck AccCheck = new PL.Report.AccCheck();
        public AccQery()
        {
            InitializeComponent();
           
        }
        void show()
        {
            cmbCurr.DataSource = SysFormat.GetAllCurrency();
            cmbCurr.ValueMember = "ID";
            cmbCurr.DisplayMember = "Name";
            DataTable dt = new DataTable();
            dt = SysFormat.CurrExc(cmbCurr.Text);
            if (dt.Rows.Count > 0)
            {
                txtExchange.Text = dt.Rows[0][2].ToString();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void AccQery_Load(object sender, EventArgs e)
        {
            show();
        }

        private void cmbCurr_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = SysFormat.CurrExc(cmbCurr.Text);
            if (dt.Rows.Count > 0)
            {
                txtExchange.Text = dt.Rows[0][2].ToString();
               
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            PL.Account.Search search = new PL.Account.Search();
           
             //   search.txtSearch.Text = txtAccNum.Text;
                search.ShowDialog();
                if (search.isok == true)
                {

                    txtAccNum.Text = search.gridSearchResult.CurrentRow.Cells[0].Value.ToString();
                    txtAccName.Text = search.gridSearchResult.CurrentRow.Cells[2].Value.ToString();
                   

                }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ProcesType = "T_H_Journal.ProcID=0";
            string qery = "";
          if (chkJournal.Checked == false && chkBoundIn.Checked==false&& chkBoundOut.Checked==false) {
                MessageBox.Show("يجب اختيار عملية واحدة على الأقل","تنبيه",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
           
            if (chkJournal.Checked == true)
            {
                ProcesType = ProcesType + " " + "or T_H_Journal.ProcID=1";
            }
            if (chkBoundIn.Checked == true)
            {
                ProcesType = ProcesType + " " + "or T_H_Journal.ProcID=2";
            }
            if (chkBoundOut.Checked == true)
            {
                ProcesType = ProcesType + " " + "or T_H_Journal.ProcID=3";
            }
            if (txtAccNum.Text == "")
            {
                MessageBox.Show("يجب ادخال رقم الحساب", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            else
            {
                qery = "SELECT        dbo.T_Account.NO, dbo.Proces.no AS Expr1, dbo.T_H_Journal.Date AS التاريخ, dbo.T_L_Journal.AccNo AS [رقم الحساب], dbo.T_Account.Name AS [اسم الحساب], dbo.T_L_Journal.AccDebit/"+Convert.ToDouble(txtExchange.Text)+" AS [رصيد مدين], \r\n                         dbo.T_L_Journal.AcCredit/"+Convert.ToDouble(txtExchange.Text)+" AS [رصيد دائن], dbo.T_L_Journal.Note AS ملاحظات, dbo.Proces.Name AS العملية, dbo.T_H_Journal.NO AS Expr3, dbo.T_H_Journal.Post AS الترحيل\r\nFROM            dbo.T_H_Journal INNER JOIN\r\n                         dbo.T_L_Journal ON dbo.T_H_Journal.NO = dbo.T_L_Journal.JNo INNER JOIN\r\n                         dbo.T_Account ON dbo.T_L_Journal.AccNo = dbo.T_Account.NO INNER JOIN\r\n                         dbo.Proces ON dbo.T_H_Journal.ProcID = dbo.Proces.no\r\nWHERE        (dbo.T_L_Journal.AccNo = '"+Convert.ToInt32( txtAccNum.Text)+ "') AND (dbo.T_H_Journal.Date BETWEEN CONVERT(DATETIME,'"+DTPFrom.Value.Month+"/"+DTPFrom.Value.Day+"/"+DTPFrom.Value.Year+ "',102) AND CONVERT(DATETIME,'"+DTPTo.Value.Month+"/"+DTPTo.Value.Day+"/"+DTPTo.Value.Year+"',102)) AND (dbo.T_H_Journal.Post = 0)";
                DataTable dt = new DataTable();
                dt=ConnectionDB.SelectDatabyqery(qery);
                if(dt.Rows.Count > 0)
                {

                    AccCheck.dtpFrom.Value = DTPFrom.Value;
                    AccCheck.dtpTo.Value = DTPTo.Value;
                    AccCheck.cmbCurr.Text = cmbCurr.Text;
                    AccCheck.txtExchange.Text = txtExchange.Text;
                    AccCheck.txtAccName.Text = txtAccName.Text;
                    AccCheck.txtAccNum.Text = txtAccNum.Text;
                    AccCheck.gridAccCheck.DataSource = dt;
                    double accDeb= 0;
                    double accCred= 0;
                    double Balance= 0;
                    for(int i=0; i < AccCheck.gridAccCheck.Rows.Count; i++)
                    {
                        accDeb = accDeb + Convert.ToDouble(AccCheck.gridAccCheck.Rows[i].Cells[5].Value);
                        accCred = accCred + Convert.ToDouble(AccCheck.gridAccCheck.Rows[i].Cells[6].Value);

                    }
                    AccCheck.txtTotalDeb.Text=accDeb.ToString();
                    AccCheck.txtTotalCred.Text=accCred.ToString();
                    AccCheck.txtBalance.Text=(accDeb-accCred).ToString();
                    AccCheck.ShowDialog();
                }
            
            }
        }
    }
}
