using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACT
{
    public partial class Main : Form
    { 
        PL.HomePage frm_HomePage = new PL.HomePage();
        PL.Catigory frm_catigory = new PL.Catigory();
        PL.Vendors frm_vendors = new PL.Vendors();
        PL.Customer frm_customer = new PL.Customer();
        PL.User.Form1 user = new PL.User.Form1();
        public Main()
        { 
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            pn_cont.Controls.Clear();
            label1.Text = Program.UName;
            if (Program.roleu == 1) {
                label2.Text = "مدير";
            }
            else {
                label2.Text = "مستخدم عادي";
                  }

          // pn_cont.Controls.Add(frm_HomePage.home);

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }
       
      
        
      
        private void button1_Click(object sender, EventArgs e)
        {
            pn_cont.Controls.Clear();
            pn_cont.Controls.Add(frm_HomePage.home);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            pn_cont.Controls.Clear();
            pn_cont.Controls.Add(frm_catigory.category);
        }
        //close app
        private void btnclose_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        //max app
        private void btnmax_Click_1(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }

        }
        //min app
        private void btnmin_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
       
        private void note_Click(object sender, EventArgs e)
        {
           

        }
        //collaps

        private void btncollapse_Click(object sender, EventArgs e)
        {
            if (nvbar.Width == 200)
            {
                navheader.Width = 47;
                nvbar.Width = 47;

                // pnlinfousre .Visible = false;
                // navheader.Height = 40;
            }
            else
            {

                nvbar.Width = 200;
                navheader.Width = 194;


                pnlinfousre.Visible = true;
                navheader.Height = 194;

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            pn_cont.Controls.Clear();
            pn_cont.Controls.Add(frm_vendors.vendor);

        }

        private void button11_Click(object sender, EventArgs e)
        {
            pn_cont.Controls.Clear();
            pn_cont.Controls.Add(frm_customer.custmer);
        }

        private void تعبىةتطمToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void مساعدةToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void بياناتالشركةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.SYSFormat.Company company = new PL.SYSFormat.Company();  
            company.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
          
           
            pn_cont.Controls.Clear();
            pn_cont.Controls.Add(user.pnlUser);
        }

        private void دليلالحساباتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.Account.Account account = new PL.Account.Account();  
            account.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            PL.SYSFormat.Cash cash = new PL.SYSFormat.Cash();
            cash.Text = "الصناديق";
            cash.txtFuncation.Text = "1";
            cash.gbCash.Text = "الصناديق";
            cash.ShowDialog();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            PL.SYSFormat.Cash cash = new PL.SYSFormat.Cash();
            cash.Text = "البنوك";
            cash.txtFuncation.Text = "2";
            cash.gbCash.Text = "البنوك";
            cash.ShowDialog();

        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            PL.SYSFormat.Currencies cur = new PL.SYSFormat.Currencies();
            
            
            cur.ShowDialog();

        }

        private void قيداليوميةالعامToolStripMenuItem_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void قيداليوميةالعامToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.Journal.Journal journal = new PL.Journal.Journal();
            journal.txtProc.Text = "1";

            journal.ShowDialog();

        }

        private void سندالصرفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.Bound.Bound bound = new PL.Bound.Bound();
            bound.Text = "سند صرف";
            bound.txtnametype.Text = "2";
            bound.gbBound.Text = "بيانات سند الصرف";
            bound.ShowDialog();

        }

        private void سندالقبضToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.Bound.Bound bound = new PL.Bound.Bound();
            bound.Text = "سند قبض";
            bound.txtnametype.Text = "3";
            bound.gbBound.Text = "بيانات سند القبض";
            bound.ShowDialog();
        }

        private void عملنسخةاحتياطيةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.SYSFormat.GetBack getBack = new PL.SYSFormat.GetBack();
            getBack.ShowDialog();
        }

        private void استرجاعنسخةاحتياطيةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.SYSFormat.reGetBack reGetBack= new PL.SYSFormat.reGetBack();
            reGetBack.ShowDialog();
        }

        private void تسجيلالخروجToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void تبديلالمستخدمToolStripMenuItem1_Click(object sender, EventArgs e)
        {

          PL.Login f= new PL.Login();

            f.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void كشفحسابToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.Report.AccQery accQery = new PL.Report.AccQery();
            accQery.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            PL.SYSFormat.Setting setting = new PL.SYSFormat.Setting();
            setting.ShowDialog();
        }
    }
}
