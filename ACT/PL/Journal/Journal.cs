using ACT.tool;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ACT.PL.Journal
{
    public partial class Journal : Form
    {
        BL.SysFormat.SysFormat SysFormat = new BL.SysFormat.SysFormat();
        BL.Journal.Journal journal = new BL.Journal.Journal();
        DL.ConnectionDB ConnectionDB = new DL.ConnectionDB();
        BL.Helper helper = new BL.Helper();
        public Journal()
        {
            InitializeComponent();
            show();
        }
       void show()
        {
          cmbCurr.DataSource=SysFormat.GetAllCurrency();
            cmbCurr.ValueMember = "ID";
            cmbCurr.DisplayMember= "Name";
            DataTable dt = new DataTable();
            dt = SysFormat.CurrExc(cmbCurr.Text);
            if (dt.Rows.Count > 0)
            {
                txtExchange.Text = dt.Rows[0][2].ToString();
                txtDescribe.Focus();
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt=SysFormat.CurrExc(cmbCurr.Text);
            if (dt.Rows.Count > 0)
            {
                txtExchange.Text = dt.Rows[0][2].ToString();
                txtDescribe.Focus();
            }
        }

        private void txtAccNum_KeyDown(object sender, KeyEventArgs e)
        {
            PL.Account.Search search = new PL.Account.Search();
            if (e.KeyCode == Keys.Enter)
            {
                search.txtSearch.Text = txtAccNum.Text;
                search.ShowDialog();
                if (search.isok == true)
                {

                    txtAccNum.Text = search.gridSearchResult.CurrentRow.Cells[0].Value.ToString();
                    txtAccName.Text = search.gridSearchResult.CurrentRow.Cells[2].Value.ToString();
                    txtAccDebit.Focus();
                   

                }
            }

        }
        void EnterRow() {
            double TD=Convert.ToDouble(txtAccDebit.Text)*Convert.ToDouble(txtExchange.Text);
            double TC = Convert.ToDouble(txtCredite.Text) * Convert.ToDouble(txtExchange.Text);
            
            gridjournalL.Rows.Add(txtNum.Text,txtAccNum.Text,txtAccName.Text,txtAccDebit.Text,txtCredite.Text,cmbCurr.SelectedValue,cmbCurr.Text,txtExchange.Text,txtDescribe.Text,TD,TC);
        }
        void clear() {
            txtAccNum.Text = " ";
            txtAccNum.Focus();
            txtAccName.Text = " ";
            txtAccDebit.Text = "0.00";
            txtCredite.Text = "0.00";
            show();
           // txtExchange.Text = " ";
            txtDescribe.Text = " ";

        }
        void calTotal() {
            double TD = 0;
            double TC = 0;
            double TDf = 0;
            for (int i = 0;i< gridjournalL.Rows.Count;i++)
            {
                TD = TD + Convert.ToDouble(gridjournalL.Rows[i].Cells[9].Value);
                TC = TC + Convert.ToDouble(gridjournalL.Rows[i].Cells[10].Value);
                TDf=TDf+(TD-TC);
              

            }
            txtFDebit.Text = TD.ToString("0.00");
            txtFCredit.Text = TC.ToString("0.00");
            txtFdiv.Text = (TD - TC).ToString("0.00");
            txtbf.Text =( TDf*PL.SYSFormat.Setting.SYSExch).ToString("0.00");
        }
        private void btnEnter_Click(object sender, EventArgs e)
        {
            if(txtAccNum.Text==" ")
            {

                MessageBox.Show("يجب اختيار حساب", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (Convert.ToDouble( txtExchange.Text)==0.00 )
            {

                MessageBox.Show("يرجى اختيار عملة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }


            if (Convert.ToDouble(txtAccDebit.Text) == 0.00 && Convert.ToDouble(txtCredite.Text) == 0.00)
            {

                MessageBox.Show("لايوجد مبلغ في طرف القيد ..! يرجى ادخال المبلغ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            for (int i = 0; i < gridjournalL.Rows.Count; i++)
            {

                if (gridjournalL.Rows[i].Cells[1].Value.ToString() == txtAccNum.Text)
                {
                    MessageBox.Show("لا يمكن تكرار الحساب","تنبيه",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
         // enter data to grid
            EnterRow();
         //clear data from textbox
            clear();
         //calculte total of debite and credit balance
            calTotal();
        }

        private void حذفصفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gridjournalL.Rows.RemoveAt(gridjournalL.CurrentRow.Index);
            calTotal();
        }

        private void gridjournalL_DoubleClick(object sender, EventArgs e)
        {
           
            txtAccNum.Text = gridjournalL.CurrentRow.Cells[1].Value.ToString();
            txtAccName.Text = gridjournalL.CurrentRow.Cells[2].Value.ToString();
            txtAccDebit.Text = gridjournalL.CurrentRow.Cells[3].Value.ToString();
            txtCredite.Text = gridjournalL.CurrentRow.Cells[4].Value.ToString();
            cmbCurr.SelectedValue = gridjournalL.CurrentRow.Cells[5].Value.ToString();
            txtExchange.Text = gridjournalL.CurrentRow.Cells[7].Value.ToString();
            txtDescribe.Text = gridjournalL.CurrentRow.Cells[8].Value.ToString();
            gridjournalL.Rows.RemoveAt(gridjournalL.CurrentRow.Index);
            calTotal();
        }

        private void تعديلصفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtAccNum.Text = gridjournalL.CurrentRow.Cells[1].Value.ToString();
            txtAccName.Text = gridjournalL.CurrentRow.Cells[2].Value.ToString();
            txtAccDebit.Text = gridjournalL.CurrentRow.Cells[3].Value.ToString();
            txtCredite.Text = gridjournalL.CurrentRow.Cells[4].Value.ToString();
            cmbCurr.SelectedValue = gridjournalL.CurrentRow.Cells[5].Value.ToString();
            txtExchange.Text = gridjournalL.CurrentRow.Cells[7].Value.ToString();
            txtDescribe.Text = gridjournalL.CurrentRow.Cells[8].Value.ToString();
            gridjournalL.Rows.RemoveAt(gridjournalL.CurrentRow.Index);
            calTotal();

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            BL.Journal.Journal jo = new BL.Journal.Journal();
            txtNum.Text = jo.GetJournalID().Rows[0][0].ToString();
            txtDescription.Text = " ";
            clear();
            gridjournalL.Rows.Clear();
            calTotal();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            txtNum.Text = " ";
            txtDescription.Text = " ";
            clear();
            gridjournalL.Rows.Clear();
            calTotal();

        }
        void journalHeaderAdd()
        {
            SqlTransaction sqlTransaction = null;
            try
            {
                SqlCommand cmd = new SqlCommand();

                SqlConnection conn = DL. ConnectionDB.GetConnection();
                conn.Open();
                sqlTransaction = conn.BeginTransaction("transall");


                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Connection = conn;
                cmd.Transaction = sqlTransaction;
                DateTime jda = Convert.ToDateTime(dateTimePicker1.Value.ToLongDateString());
                int uno = Convert.ToInt32(journal.GetUserID(Program.UName).Rows[0][0].ToString());
                int jtype = 0;
                if (rbGeneral.Checked == true)
                {
                    jtype = 1;
                }
                if (radioButton2.Checked == true)
                {
                    jtype = 4;
                }
                int jpost = 0;
                DateTime adata = DateTime.Now;
                if (chkPost.Checked == true) { jpost = 1; }
                else { jpost = 0; }
                double exch = Convert.ToDouble(txtExchange.Text);

                // journal.JournalH_Add(, , , , , 0, ,, , , , uno, adata, , ,);
                SqlParameter[] sqlp = helper.JournalH_Add();
                sqlp[0].Value = Convert.ToInt32(txtNum.Text);
                sqlp[1].Value = jda;
                sqlp[2].Value = txtDescription.Text;
                sqlp[3].Value = jtype;
                sqlp[4].Value = jpost;
                sqlp[5].Value = 0;
                sqlp[6].Value = Convert.ToDouble(txtFDebit.Text) ;
                sqlp[7].Value = Convert.ToDouble(txtFCredit.Text);
                sqlp[8].Value = Convert.ToDouble(txtFdiv.Text);
                sqlp[9].Value = uno;
                sqlp[10].Value = adata;
                sqlp[11].Value = uno;
                sqlp[12].Value = adata;
                sqlp[13].Value = Convert.ToInt32(cmbCurr.SelectedValue);
                sqlp[14].Value = exch;
           
                sqlp[15].Value = 1;
                sqlp[16].Value = Convert.ToDouble(txtbf.Text);

                if (sqlp != null)
                {
                    cmd.Parameters.Clear();

                    cmd.Parameters.AddRange(sqlp);
                }
                cmd.CommandText = "JournalH_Add";
                cmd.ExecuteNonQuery();


                //add line
                SqlParameter[] sql = helper.JournalL_Add();
                for (int i = 0; i < gridjournalL.Rows.Count; i++)
                {
                    sql[0].Value = Convert.ToInt32(gridjournalL.Rows[i].Cells[1].Value.ToString());
                    sql[1].Value = Convert.ToDouble(gridjournalL.Rows[i].Cells[3].Value.ToString());
                    sql[2].Value = Convert.ToDouble(gridjournalL.Rows[i].Cells[4].Value.ToString());
                    sql[3].Value = gridjournalL.Rows[i].Cells[8].Value.ToString();
                    sql[4].Value = Convert.ToInt32(gridjournalL.Rows[i].Cells[0].Value.ToString());
                    sql[5].Value = 0;

                    //   journal.JournalL_Add(accno, accD, accC, note, jno);


                    if (sql != null)
                    {
                        cmd.Parameters.Clear();

                        cmd.Parameters.AddRange(sql);
                    }
                    cmd.CommandText = "JournalL_Add";
                    cmd.ExecuteNonQuery();




                }

                sqlTransaction.Commit();
                conn.Close();

                MessageBox.Show("تمت عملية الحفظ بنجاح", "عملية الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);





            }
            catch (Exception ex)
            {
                MessageBox.Show(" " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                try
                {
                    sqlTransaction.Rollback();
                }
                catch (Exception ex2)
                {
                    MessageBox.Show(" " + ex2.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        void journalLineAdd()
        {
           try{ for(int i= 0; i < gridjournalL.Rows.Count; i++)
            {
               int accno = Convert.ToInt32(gridjournalL.Rows[i].Cells[1].Value.ToString());
                double accD = Convert.ToDouble(gridjournalL.Rows[i].Cells[3].Value.ToString());
                double accC = Convert.ToDouble(gridjournalL.Rows[i].Cells[4].Value.ToString());

                string note = gridjournalL.Rows[i].Cells[8].Value.ToString();
                int jno = Convert.ToInt32(gridjournalL.Rows[i].Cells[0].Value.ToString());
                journal.JournalL_Add(accno, accD, accC, note,jno);

            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
           
            journalHeaderAdd();
         //   journalLineAdd();
            show();
                   }

        private void txtFDebit_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            clear();
            gridjournalL.Rows.Clear();
            calTotal();
            txtJNum.Text= txtSearch.Text;
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtJNum_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();
            btnNext.Enabled = true;
            btnPrev.Enabled = true;
            dt =journal.GetCompletJournal(Convert.ToInt32(txtJNum.Text));
            dt2=journal.GetCompletJournalLine(Convert.ToInt32(txtJNum.Text));
            if(dt.Rows.Count > 0) {
                if (dt.Rows[0][3].ToString() == "1") { rbGeneral.Checked = true; }
                if (dt.Rows[0][3].ToString() == "4") { radioButton2.Checked = true; }
                txtDescription.Text = dt.Rows[0][2].ToString();
                if (dt.Rows[0][4].ToString() == "1") { chkPost.Checked = true; } else { chkPost.Checked = false; }
                txtNum.Text = dt.Rows[0][0].ToString();
                cmbCurr.SelectedValue = Convert.ToInt32(dt.Rows[0][13].ToString());
                txtExchange.Text = dt.Rows[0][14].ToString();
                txtFDebit.Text = dt.Rows[0][6].ToString();
                txtFCredit.Text = dt.Rows[0][7].ToString();
                txtFdiv.Text = dt.Rows[0][8].ToString();
                txtProc.Text= dt.Rows[0][17].ToString();

                if (dt2.Rows.Count > 0)
                {
                    gridjournalL.Rows.Clear();
                    int i = 0;
                    gridjournalL.RowCount = dt2.Rows.Count;
                    for (int j = 0; j < dt2.Rows.Count; j++)
                    {
                        gridjournalL.Rows[i].Cells[0].Value = dt2.Rows[j][6].ToString();
                        gridjournalL.Rows[i].Cells[1].Value = dt2.Rows[j][2].ToString();
                        gridjournalL.Rows[i].Cells[2].Value = dt2.Rows[j][0].ToString();
                        gridjournalL.Rows[i].Cells[3].Value = dt2.Rows[j][3].ToString();
                        gridjournalL.Rows[i].Cells[4].Value = dt2.Rows[j][4].ToString();
                        gridjournalL.Rows[i].Cells[5].Value = dt.Rows[0][13].ToString();
                        gridjournalL.Rows[i].Cells[6].Value = dt.Rows[0][15].ToString();
                        gridjournalL.Rows[i].Cells[7].Value = dt.Rows[0][14].ToString();
                        gridjournalL.Rows[i].Cells[8].Value = dt2.Rows[j][5].ToString();
                        gridjournalL.Rows[i].Cells[9].Value = (Convert.ToDouble(dt2.Rows[j][3].ToString()) * Convert.ToDouble(dt.Rows[0][14].ToString())).ToString();
                        gridjournalL.Rows[i].Cells[10].Value = (Convert.ToDouble(dt2.Rows[j][4].ToString()) * Convert.ToDouble(dt.Rows[0][14].ToString())).ToString();

                        i++;
                    }
                }
            }
            else
            {
                MessageBox.Show("القيد غير موجود", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;


            }




        }

        void journalHeaderUpdate()
        {
            SqlTransaction sqlTransaction = null;
            try
            {
                SqlCommand cmd = new SqlCommand();

                SqlConnection conn = DL. ConnectionDB.GetConnection();
                conn.Open();
                sqlTransaction = conn.BeginTransaction("transall");


                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Connection = conn;
                cmd.Transaction = sqlTransaction;

                DateTime jda = Convert.ToDateTime(dateTimePicker1.Value.ToLongDateString());
                int uno = Convert.ToInt32(journal.GetUserID(Program.UName).Rows[0][0].ToString());
                int jtype = 0;
                if (rbGeneral.Checked == true)
                {
                    jtype = 1;
                }
                if (radioButton2.Checked == true)
                {
                    jtype = 4;
                }
                int jpost = 0;
                DateTime adata = DateTime.Now;
                if (chkPost.Checked == true) { jpost = 1; }
                else { jpost = 0; }
                double exch = Convert.ToDouble(txtExchange.Text);
              /*  journal.JournalHUpdate(Convert.ToInt32(txtNum.Text), jda, txtDescription.Text, jtype, jpost, 0, Convert.ToDouble(txtFDebit.Text), Convert.ToDouble(txtFCredit.Text), Convert.ToDouble(txtFdiv.Text), uno,  adata, Convert.ToInt32(cmbCurr.SelectedValue), exch, Convert.ToInt32(txtProc.Text));*/
                SqlParameter[] sqlp = helper.JournalHUpdate();
                sqlp[0].Value = Convert.ToInt32(txtNum.Text);
                sqlp[1].Value = jda;
                sqlp[2].Value = txtDescription.Text;
                sqlp[3].Value = jtype;
                sqlp[4].Value = jpost;
                sqlp[5].Value = 0;
                sqlp[6].Value = Convert.ToDouble(txtFDebit.Text);

                sqlp[7].Value = Convert.ToDouble(txtFCredit.Text);
                sqlp[8].Value = Convert.ToDouble(txtFdiv.Text);
                sqlp[9].Value = uno;
               
                sqlp[10].Value = adata;
                sqlp[11].Value = Convert.ToInt32(cmbCurr.SelectedValue);
                sqlp[12].Value = exch;
                sqlp[13].Value = Convert.ToDouble(txtbf.Text);
                ;
               // sqlp[12].Value = 1;
                if (sqlp != null)
                {
                    cmd.Parameters.Clear();

                    cmd.Parameters.AddRange(sqlp);
                }
                cmd.CommandText = "JournalHUpdate";
                cmd.ExecuteNonQuery();

                SqlParameter[] sqll = helper.JournalLUpdate();

               

                for (int i = 0; i < gridjournalL.Rows.Count; i++)
                {
                    sqll[0].Value = Convert.ToInt32(gridjournalL.Rows[i].Cells[1].Value.ToString());
                    sqll[1].Value = Convert.ToDouble(gridjournalL.Rows[i].Cells[3].Value.ToString());
                    sqll[2].Value = Convert.ToDouble(gridjournalL.Rows[i].Cells[4].Value.ToString());

                    sqll[3].Value = gridjournalL.Rows[i].Cells[8].Value.ToString();
                    sqll[4].Value = Convert.ToInt32(txtNum.Text);
                    sqll[5].Value = 0;
                    // journal.JournalLUpdate(accno, accD, accC, note, jno);

                    if (sqll != null)
                    {
                        cmd.Parameters.Clear();

                        cmd.Parameters.AddRange(sqll);
                    }
                    cmd.CommandText = "JournalLUpdate";
                    cmd.ExecuteNonQuery();


                }

                sqlTransaction.Commit();
                conn.Close();
                MessageBox.Show("تمت عملية التعديل بنجاح", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex){
                MessageBox.Show(""+ex.Message,"خطأ",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            }
        void journalLineUpdate()
        {
            try
            {
                for (int i = 0; i < gridjournalL.Rows.Count; i++)
                {
                    int accno = Convert.ToInt32(gridjournalL.Rows[i].Cells[1].Value.ToString());
                    double accD = Convert.ToDouble(gridjournalL.Rows[i].Cells[3].Value.ToString());
                    double accC = Convert.ToDouble(gridjournalL.Rows[i].Cells[4].Value.ToString());

                    string note = gridjournalL.Rows[i].Cells[8].Value.ToString();
                    int jno = Convert.ToInt32(gridjournalL.Rows[i].Cells[0].Value.ToString());
                    journal.JournalLUpdate(accno, accD, accC, note, jno);

                }
            } catch (Exception ex){
                MessageBox.Show(""+ex.Message,"خطأ",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

}

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(txtProc.Text== "سند صرف" || txtProc.Text== "سند قبض")
            {
                MessageBox.Show("هذا القيد ناتج عن عملية صرف او قبض لا يمكن تعديله ","تنبيه",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (chkPost.Checked==true)
            {
                MessageBox.Show("هذا القيد مرحل لا يمكن تعديله ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Convert.ToDouble(txtFdiv.Text)!=0&&rbGeneral.Checked==true)
            {
                MessageBox.Show("القيد المحاسبي غير متوازن ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            journalHeaderUpdate();
            //journalLineUpdate();
            show();
           // MessageBox.Show("تمت عملية التعديل بنجاح", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void journalHeaderDel()
        {
            SqlTransaction sqlTransaction = null;
            try
            {
                SqlCommand cmd = new SqlCommand();

                SqlConnection conn = DL.ConnectionDB.GetConnection();
                conn.Open();
                sqlTransaction = conn.BeginTransaction("transallDel");


                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Connection = conn;
                cmd.Transaction = sqlTransaction;
             
                int jno =Convert.ToInt32( txtNum.Text);
                //  journal.JournalHDelete(jno);
                SqlParameter[] sqlp = new SqlParameter[1];
                sqlp[0] = new SqlParameter("@NO", SqlDbType.Int);
                sqlp[0].Value = jno;
                cmd.CommandText = "JournalHDelete";
                cmd.Parameters.Clear();

                cmd.Parameters.AddRange(sqlp);
                cmd.ExecuteNonQuery();
                cmd.CommandText = "JournalLDelete";
                sqlp[0] = new SqlParameter("@JNO", SqlDbType.Int);
                sqlp[0].Value = jno;
                cmd.Parameters.Clear();

                cmd.Parameters.AddRange(sqlp);
                cmd.ExecuteNonQuery();


                sqlTransaction.Commit();
                conn.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(" " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                try
                {
                    sqlTransaction.Rollback();
                }
                catch (Exception ex2)
                {
                    MessageBox.Show(" " + ex2.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        void journalLineDel()
        {
            try
            {
               
                   
                    int jno = Convert.ToInt32(txtNum.Text);
                    journal.JournalLDelete( jno);

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtProc.Text == "سند صرف" || txtProc.Text == "سند قبض")
                {
                    MessageBox.Show("هذا القيد ناتج عن عملية صرف او قبض لا يمكن حذفه ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (chkPost.Checked == true)
                {
                    MessageBox.Show("هذا القيد مرحل لا يمكن حذفه ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if ((MessageBox.Show("هل تريد حذف هذا السجل", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)) == DialogResult.Yes)
                {

                    journalHeaderDel();
                   // journalLineDel();
                    show();
                    MessageBox.Show("تمت عملية الحذف بنجاح", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                     gridjournalL.Rows.Clear();
                     calTotal();
                    txtNum.Text = null;
                    txtDescription.Text = null;
                    txtJNum.Text = null;
                }
            }catch(Exception ex)
            {
                MessageBox.Show(""+ex.Message,"",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            txtJNum.Text=journal.GET_JournalFirst().Rows[0][0].ToString();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            txtJNum.Text = journal.GET_JournalLast().Rows[0][0].ToString();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int j = Convert.ToInt32( journal.GET_JournalLast().Rows[0][0]);
            if (Convert.ToInt32(txtNum.Text) == j)
            {
                MessageBox.Show("هذا اخر قيد","تنبيه",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            else {
                txtJNum.Text = journal.GET_JournalNext(Convert.ToInt32(txtNum.Text)).Rows[0][0].ToString();
            }
         
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            int j = Convert.ToInt32(journal.GET_JournalFirst().Rows[0][0]);
            if (Convert.ToInt32(txtNum.Text) == j)
            {
                MessageBox.Show("هذا أول قيد", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }
            else
            {
                txtJNum.Text = journal.GET_JournalPrev(Convert.ToInt32(txtNum.Text)).Rows[0][0].ToString();
            }

        }

        private void txtNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtProc_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAccNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void Journal_Load(object sender, EventArgs e)
        {

        }
    }
}
