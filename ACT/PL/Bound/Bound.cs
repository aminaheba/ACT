using ACT.DL;
using ACT.tool;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ACT.PL.Bound
{
    public partial class Bound : Form
    {
        BL.SysFormat.SysFormat SysFormat = new BL.SysFormat.SysFormat();
        BL.Journal.Journal journal = new BL.Journal.Journal();
        BL.Bounds.Bound bound = new BL.Bounds.Bound();
        PL.SYSFormat.Setting setting = new PL.SYSFormat.Setting();
        public Bound()
        {
            InitializeComponent();
        }

        private void Bound_Load(object sender, EventArgs e)
        {
            txtNum.Text = " ";
            show();
        }
        void clear()
        {
            txtAccNum.Text = " ";
            txtAccNum.Focus();
            txtAccName.Text = " ";
            txtAccAmount.Text = "0.00";
           
            show();
            // txtExchange.Text = " ";
            txtDescribe.Text = " ";

        }
        void show()
        {
            cmbCash.DataSource = SysFormat.GetCashes();
            cmbCash.DisplayMember = "AccName";
            cmbCash.ValueMember = "AccNum";
            cmbCurr.DataSource = SysFormat.GetAllCurrency();
            cmbCurr.ValueMember = "ID";
            cmbCurr.DisplayMember = "Name";
           
            DataTable dt = new DataTable();
            dt = SysFormat.CurrExc(cmbCurr.Text);
            if (dt.Rows.Count > 0)
            {
                txtExchange.Text = dt.Rows[0][2].ToString();
                txtDescribe.Focus();
            }
        }

        private void cmbCurr_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = SysFormat.CurrExc(cmbCurr.Text);
            if (dt.Rows.Count > 0)
            {
                txtExchange.Text = dt.Rows[0][2].ToString();
                txtDescribe.Focus();
            }
        }

        private void cmbCash_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = SysFormat.GetOneCashe(cmbCash.Text);
            if (dt.Rows.Count > 0)
            {
                txtCashnum.Text = dt.Rows[0][0].ToString();
                txtAccNum.Focus();
            }
        }

        private void cmbCash_Click(object sender, EventArgs e)
        {
           
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            BL.Bounds.Bound bo = new BL.Bounds.Bound();
           
            txtNum.Text = bo.GenerateNumBound(Convert.ToInt32(txtnametype.Text)).Rows[0][0].ToString();

            BL.Journal.Journal jo = new BL.Journal.Journal();
            txtlinkj.Text = jo.GetJournalID().Rows[0][0].ToString();
            txtDescription.Text = " ";
            clear();
            gridBound.Rows.Clear();
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
                    txtAccAmount.Focus();


                }
            }
        }
        void EnterRow()
        {
            double TA = 0;
            TA= Convert.ToDouble(txtAccAmount.Text) * Convert.ToDouble(txtExchange.Text);

            gridBound.Rows.Add(txtNum.Text, txtAccNum.Text, txtAccName.Text, txtAccAmount.Text,  cmbCurr.SelectedValue, cmbCurr.Text, txtExchange.Text, txtDescribe.Text,TA);
        }
        void calTotal()
        {
            double TD = 0;
            double TDf = 0;

            for (int i = 0; i < gridBound.Rows.Count; i++)
            {
                TD = TD + Convert.ToDouble(gridBound.Rows[i].Cells[8].Value);
                TDf = TDf + (Convert.ToDouble(gridBound.Rows[i].Cells[3].Value)*PL.SYSFormat.Setting.SYSExch);

                txtTAmount.Text = TD.ToString("0.00");
                txtbf.Text = TDf.ToString("0.00");

            }
        }
        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (txtAccNum.Text == " ")
            {

                MessageBox.Show("يجب اختيار حساب", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (Convert.ToDouble(txtExchange.Text) == 0.00)
            {

                MessageBox.Show("يرجى اختيار عملة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (Convert.ToDouble(txtAccAmount.Text) == 0.00 )
            {

                MessageBox.Show("لايوجد مبلغ  ..! يرجى ادخال المبلغ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }


            for (int i = 0; i < gridBound.Rows.Count; i++)
            {

                if (gridBound.Rows[i].Cells[1].Value.ToString() == txtAccNum.Text)
                {
                    MessageBox.Show("لا يمكن تكرار الحساب", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void gridBound_DoubleClick(object sender, EventArgs e)
        {
           /* txtAccNum.Text = gridBound.CurrentRow.Cells[1].Value.ToString();
            txtAccName.Text = gridBound.CurrentRow.Cells[2].Value.ToString();
            txtAccAmount.Text = gridBound.CurrentRow.Cells[3].Value.ToString();
          
            cmbCurr.SelectedValue = gridBound.CurrentRow.Cells[4].Value.ToString();
            txtExchange.Text = gridBound.CurrentRow.Cells[6].Value.ToString();
            txtDescribe.Text = gridBound.CurrentRow.Cells[7].Value.ToString();
            //gridBound.Rows.RemoveAt(gridBound.CurrentRow.Index);
            calTotal();*/
        }

        private void حذفصفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gridBound.Rows.RemoveAt(gridBound.CurrentRow.Index);
            calTotal();
        }

        private void تعديلصفToolStripMenuItem_Click(object sender, EventArgs e)
        {
           /* txtAccNum.Text = gridBound.CurrentRow.Cells[1].Value.ToString();
            txtAccName.Text = gridBound.CurrentRow.Cells[2].Value.ToString();
            txtAccAmount.Text = gridBound.CurrentRow.Cells[3].Value.ToString();
          
            cmbCurr.SelectedValue = gridBound.CurrentRow.Cells[4].Value.ToString();
            txtExchange.Text = gridBound.CurrentRow.Cells[6].Value.ToString();
            txtDescribe.Text = gridBound.CurrentRow.Cells[7].Value.ToString();
            gridBound.Rows.RemoveAt(gridBound.CurrentRow.Index);
            calTotal();*/
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            txtNum.Text = " ";
            txtDescription.Text = " ";
            clear();
            gridBound.Rows.Clear();
            calTotal();
        }
        void BoundHeaderAdd()
        {
            SqlTransaction sqlTransaction=null;
            try
            {
                SqlCommand cmd = new SqlCommand();
               
                SqlConnection conn =ConnectionDB. GetConnection();
                conn.Open();
                sqlTransaction = conn.BeginTransaction("transall");
               

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Connection = conn;
                cmd.Transaction = sqlTransaction;
                DateTime jda = Convert.ToDateTime(dateTimePicker1.Value.ToLongDateString());
                int bno1 = Convert.ToInt32(journal.GetUserID(Program.UName).Rows[0][0].ToString());
                int btype = 0;
                if (rbOut.Checked == true)
                {
                    btype = 1;
                }
                if (rbInput.Checked == true)
                {
                    btype = 2;
                }
                int bpost = 0;
                DateTime adata = DateTime.Now;
                if (chkPost.Checked == true) { bpost = 1; }
                else { bpost = 0; }
                double exch = Convert.ToDouble(txtExchange.Text);
                BL.Helper helper = new BL.Helper();
                SqlParameter[] sqlp = helper.GetParametrBH();
               // SqlParameter[] sqlp = new SqlParameter[15];
                sqlp[0].Value = Convert.ToInt32(txtNum.Text);
                sqlp[1].Value = jda;
                sqlp[2].Value = txtDescription.Text;
                sqlp[3].Value = bpost;
                sqlp[4].Value = Convert.ToDouble(txtTAmount.Text);
                sqlp[5].Value = bno1;
                sqlp[6].Value = adata;
                sqlp[7].Value = bno1;
                sqlp[8].Value = adata;
                sqlp[9].Value = btype;
                sqlp[10].Value = Convert.ToInt32(txtCashnum.Text);
                sqlp[11].Value = Convert.ToInt32(txtCashnum.Text);
                sqlp[12].Value = Convert.ToInt32(txtlinkj.Text);
                sqlp[13].Value = Convert.ToInt32(cmbCurr.SelectedValue);
                sqlp[14].Value = Convert.ToDouble(txtExchange.Text);
                sqlp[15].Value = Convert.ToDouble(txtbf.Text);
                if (sqlp != null)
                {
                    cmd.Parameters.Clear();

                    cmd.Parameters.AddRange(sqlp);
                }
                cmd.CommandText = "BoundH_Add";
                cmd.ExecuteNonQuery();
             //   MessageBox.Show("تمت عملية header بنجاح", "عملية الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //bound.BoundH_Add(, , ,,,,,bno1,adata,btype, , ,, , );

                SqlParameter[] sqll =helper.GetParametrBL();
               


                for (int i = 0; i < gridBound.Rows.Count; i++)
                {

                   
                    sqll[4].Value= Convert.ToInt32(gridBound.Rows[i].Cells[0].Value.ToString());
                    
                    sqll[0].Value = Convert.ToInt32(gridBound.Rows[i].Cells[1].Value.ToString());
                    
                    sqll[1].Value = Convert.ToDouble(gridBound.Rows[i].Cells[3].Value.ToString());
                  
                    sqll[3].Value =  Convert.ToInt32(gridBound.Rows[i].Cells[4].Value.ToString());
                  
                    sqll[2].Value = gridBound.Rows[i].Cells[7].Value.ToString();
                    sqll[5].Value = 0;

                    //  bound.BoundL_Add(accno, accD, note, currid, bno);
                   cmd.Parameters.Clear();
                    
                        cmd.Parameters.AddRange(sqll);
                    
                    cmd.CommandText = "BoundL_Add";
                    cmd.ExecuteNonQuery();
                    #region journal
                    SqlParameter[] sqlj = helper.JournalH_Add();
                    sqlj[0].Value = Convert.ToInt32(txtlinkj.Text);
                    sqlj[1].Value = jda;
                    sqlj[2].Value = txtDescription.Text;
                    sqlj[3].Value = 1;
                    sqlj[4].Value = bpost;
                    sqlj[5].Value = 0;
                    sqlj[6].Value = Convert.ToDouble(txtTAmount.Text);
                    sqlj[7].Value = Convert.ToDouble(txtTAmount.Text);
                    sqlj[8].Value = Convert.ToDouble(txtTAmount.Text)- Convert.ToDouble(txtTAmount.Text);
                    sqlj[9].Value = bno1;
                    sqlj[10].Value = adata;
                    sqlj[11].Value = bno1;
                    sqlj[12].Value = adata;
                    sqlj[13].Value = Convert.ToInt32(cmbCurr.SelectedValue);
                    

                    sqlj[14].Value = exch;

                    sqlj[15].Value = Convert.ToInt32(txtnametype.Text);
                    sqlj[16].Value = Convert.ToDouble(txtbf.Text);


                    if (sqlj != null)
                    {
                        cmd.Parameters.Clear();

                        cmd.Parameters.AddRange(sqlj);
                    }
                    cmd.CommandText = "JournalH_Add";
                    cmd.ExecuteNonQuery();


                    //add line
                    SqlParameter[] sql = helper.JournalL_Add();
                    for (int o = 0; o < gridBound.Rows.Count; o++)
                    {
                        sql[0].Value = Convert.ToInt32(gridBound.Rows[o].Cells[1].Value.ToString());
                        if (txtnametype.Text == "3") {                            sql[1] = new SqlParameter("@AccDebit", SqlDbType.Money);
                            sql[1].Value = 0;//Convert.ToDouble(gridBound.Rows[o].Cells[3].Value.ToString());
                            sql[2].Value = Convert.ToDouble(gridBound.Rows[o].Cells[3].Value.ToString());
                        }
                        else {
                            sql[1].Value = Convert.ToDouble(gridBound.Rows[o].Cells[3].Value.ToString());
                            sql[2].Value = 0;//Convert.ToDouble(gridBound.Rows[o].Cells[4].Value.ToString());
                        }
                        
                       
                       

                        sql[3].Value = gridBound.Rows[0].Cells[7].Value.ToString();
                        sql[4].Value = Convert.ToInt32(txtlinkj.Text);
                        sql[5].Value = 0;
                        //   journal.JournalL_Add(accno, accD, accC, note, jno);


                        if (sql != null)
                        {
                            cmd.Parameters.Clear();

                            cmd.Parameters.AddRange(sql);
                        }
                        cmd.CommandText = "JournalL_Add";
                        cmd.ExecuteNonQuery();

                        sql[0].Value = Convert.ToInt32(txtCashnum.Text); ;
                        if (txtnametype.Text == "3")
                        {
                            sql[1].Value = Convert.ToDouble(gridBound.Rows[o].Cells[3].Value.ToString());
                            sql[2].Value = 0;//Convert.ToDouble(gridBound.Rows[o].Cells[3].Value.ToString());
                        }
                        else
                        {
                            sql[1].Value = 0;// Convert.ToDouble(gridBound.Rows[o].Cells[3].Value.ToString());
                            sql[2].Value = Convert.ToDouble(gridBound.Rows[o].Cells[3].Value.ToString());
                        }




                        sql[3].Value = gridBound.Rows[0].Cells[7].Value.ToString();
                        sql[4].Value = Convert.ToInt32(txtlinkj.Text);
                        sql[5].Value = 0;
                        //   journal.JournalL_Add(accno, accD, accC, note, jno);


                        if (sql != null)
                        {
                            cmd.Parameters.Clear();

                            cmd.Parameters.AddRange(sql);
                        }
                        cmd.CommandText = "JournalL_Add";
                        cmd.ExecuteNonQuery();

                        #endregion


                    }
                }
                sqlTransaction.Commit();
                conn.Close();
                MessageBox.Show("تمت عملية الحفظ بنجاح", "عملية الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(" " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                try
                {
                    sqlTransaction.Rollback();
                }
                catch (Exception ex2)
                {
                    MessageBox.Show(" " + ex2.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        void BoundLineAdd()
        {

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            BoundHeaderAdd();
           // BoundLineAdd();
            show();
           
             }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            clear();
            gridBound.Rows.Clear();
            calTotal();
            txtBNum.Text = txtSearch.Text;
        }

        private void txtBNum_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();
            btnNext.Enabled = true;
            btnPrev.Enabled = true;
            dt = bound.Getbound(Convert.ToInt32(txtBNum.Text));
            dt2 = bound.GetBoundLine(Convert.ToInt32(txtBNum.Text));
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0][9].ToString() == "2") { rbOut.Checked = true; }
                if (dt.Rows[0][9].ToString() == "3") { rbInput.Checked = true; }
                txtDescription.Text = dt.Rows[0][2].ToString();
                if (dt.Rows[0][3].ToString() == "1") { chkPost.Checked = true; } else { chkPost.Checked = false; }
                txtNum.Text = dt.Rows[0][0].ToString();
                cmbCurr.SelectedValue = Convert.ToInt32(dt.Rows[0][13].ToString());
                txtExchange.Text = dt.Rows[0][14].ToString();
                txtTAmount.Text = dt.Rows[0][4].ToString();
                txtlinkj.Text = dt.Rows[0][12].ToString();



                if (dt2.Rows.Count > 0)
                {
                    gridBound.Rows.Clear();
                    int i = 0;
                    gridBound.RowCount = dt2.Rows.Count;
                  // txtAccNum.Text = dt2.Rows[0][2].ToString();
                   //txtAccName.Text = dt2.Rows[0][0].ToString();
                    
                    for (int j = 0; j < dt2.Rows.Count; j++)
                    {
                        gridBound.Rows[j].Cells[0].Value = dt2.Rows[j][6].ToString();
                        gridBound.Rows[j].Cells[1].Value = dt2.Rows[j][2].ToString();
                        gridBound.Rows[j].Cells[2].Value = dt2.Rows[j][0].ToString();
                        gridBound.Rows[j].Cells[3].Value = dt2.Rows[j][3].ToString();
                        gridBound.Rows[j].Cells[4].Value = dt.Rows[0][13].ToString();
                        gridBound.Rows[j].Cells[5].Value = dt.Rows[0][15].ToString();
                        gridBound.Rows[j].Cells[6].Value = dt.Rows[0][14].ToString();
                        gridBound.Rows[j].Cells[7].Value = dt2.Rows[j][4].ToString();

                        gridBound.Rows[j].Cells[8].Value = (Convert.ToDouble(dt2.Rows[j][3].ToString()) * Convert.ToDouble(dt.Rows[0][14].ToString())).ToString();
                        gridBound.Rows[j].Cells[9].Value = dt2.Rows[j][1].ToString();

                        i++;
                    }
                }
            }
            else
            {
                MessageBox.Show("القيد غير موجود", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;


            }

        }

        void BoundHeaderUpdate()
        {
            SqlTransaction sqlTransaction = null;
            try
            {
                SqlCommand cmd = new SqlCommand();

                SqlConnection conn = ConnectionDB.GetConnection();
                conn.Open();
                sqlTransaction = conn.BeginTransaction("transall");


                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Connection = conn;
                cmd.Transaction = sqlTransaction;

                DateTime jda = Convert.ToDateTime(dateTimePicker1.Value.ToLongDateString());
                int bno1 = Convert.ToInt32(journal.GetUserID(Program.UName).Rows[0][0].ToString());
                int btype = 0;
                if (rbOut.Checked == true)
                {
                    btype = 1;
                }
                if (rbInput.Checked == true)
                {
                    btype = 2;
                }
                int bpost = 0;
                DateTime adata = DateTime.Now;
                if (chkPost.Checked == true) { bpost = 1; }
                else { bpost = 0; }
                double exch = Convert.ToDouble(txtExchange.Text);

                //  bound.BoundHUpdate(Convert.ToInt32(txtNum.Text), jda, txtDescription.Text, bpost, Convert.ToDouble(txtTAmount.Text), bno1, adata, btype, Convert.ToInt32(txtCashnum.Text), Convert.ToInt32(txtCashnum.Text),  Convert.ToInt32(cmbCurr.SelectedIndex), Convert.ToDouble(txtExchange.Text));
                //Convert.ToInt32(txtlinkj.Text)

                BL.Helper helper = new BL.Helper();
                SqlParameter[] sqlp = helper.BoundHUpdate();

                sqlp[0].Value = Convert.ToInt32(txtNum.Text);
                sqlp[1].Value = jda;
                sqlp[2].Value = txtDescription.Text;
                sqlp[3].Value = bpost;
                sqlp[4].Value = Convert.ToDouble(txtTAmount.Text);
                sqlp[5].Value = bno1;
                sqlp[6].Value = adata;

                sqlp[7].Value = btype;
                sqlp[8].Value = Convert.ToInt32(txtCashnum.Text);
                sqlp[9].Value = Convert.ToInt32(txtCashnum.Text);
                // sqlp[10].Value = Convert.ToInt32(txtlinkj.Text);
                sqlp[10].Value = Convert.ToInt32(cmbCurr.SelectedValue);
                sqlp[11].Value = Convert.ToDouble(txtExchange.Text);
                sqlp[12].Value = Convert.ToDouble(txtbf.Text);
                if (sqlp != null)
                {
                    cmd.Parameters.Clear();

                    cmd.Parameters.AddRange(sqlp);
                }
                cmd.CommandText = "BoundHUpdate";
                cmd.ExecuteNonQuery();

                SqlParameter[] sqll = helper.BoundLUpdate();



                for (int i = 0; i < gridBound.Rows.Count; i++)
                {


                    sqll[5].Value = Convert.ToInt32(gridBound.Rows[i].Cells[0].Value.ToString());

                    sqll[1].Value = Convert.ToInt32(gridBound.Rows[i].Cells[1].Value.ToString());

                    sqll[2].Value = Convert.ToDouble(gridBound.Rows[i].Cells[3].Value.ToString());

                    sqll[4].Value = Convert.ToInt32(gridBound.Rows[i].Cells[4].Value.ToString());

                    sqll[3].Value = gridBound.Rows[i].Cells[7].Value.ToString();
                    sqll[0].Value = Convert.ToInt32(gridBound.Rows[i].Cells[9].Value);
                    sqll[6].Value = 0;
                    //  bound.BoundL_Add(accno, accD, note, currid, bno);
                    cmd.Parameters.Clear();

                    cmd.Parameters.AddRange(sqll);

                    cmd.CommandText = "BoundLUpdate";
                    cmd.ExecuteNonQuery();
                    #region journal
                    SqlParameter[] sql = helper.JournalHUpdate();
                    sql[0].Value = Convert.ToInt32(txtlinkj.Text);
                    sql[1].Value = jda;
                    sql[2].Value = txtDescription.Text;
                    sql[3].Value = 1;
                    sql[4].Value = bpost;
                    sql[5].Value = 0;
                    sql[6].Value = Convert.ToDouble(txtTAmount.Text);
                    sql[7].Value = Convert.ToDouble(txtTAmount.Text);
                    sql[8].Value = Convert.ToDouble(txtTAmount.Text) - Convert.ToDouble(txtTAmount.Text);
                    sql[9].Value = bno1;
                    sql[10].Value = adata;
                    sql[11].Value = Convert.ToInt32(cmbCurr.SelectedValue);
                    sql[12].Value = exch;
                    sql[13].Value = Convert.ToDouble(txtbf.Text);
                    ;
                    // sqlp[12].Value = 1;
                    if (sql != null)
                    {
                        cmd.Parameters.Clear();

                        cmd.Parameters.AddRange(sql);
                    }
                    cmd.CommandText = "JournalHUpdate";
                    cmd.ExecuteNonQuery();

                    SqlParameter[] sqllj = helper.JournalLUpdate();



                    for (int o = 0; o < gridBound.Rows.Count; o++)
                    {
                        sqllj[0].Value = Convert.ToInt32(gridBound.Rows[o].Cells[1].Value.ToString());
                        if (txtnametype.Text == "3")
                        {
                            sqllj[1] = new SqlParameter("@AccDebit", SqlDbType.Money);
                            sqllj[1].Value = 0;//Convert.ToDouble(gridBound.Rows[o].Cells[3].Value.ToString());
                            sqllj[2].Value = Convert.ToDouble(gridBound.Rows[o].Cells[3].Value.ToString());
                        }
                        else
                        {
                            sqllj[1].Value = Convert.ToDouble(gridBound.Rows[o].Cells[3].Value.ToString());
                            sqllj[2].Value = 0;//Convert.ToDouble(gridBound.Rows[o].Cells[4].Value.ToString());
                        }




                        sqllj[3].Value = gridBound.Rows[0].Cells[7].Value.ToString();
                        sqllj[4].Value = Convert.ToInt32(txtlinkj.Text);
                        sqllj[5].Value = 0;
                        //   journal.JournalL_Add(accno, accD, accC, note, jno);


                        if (sqllj != null)
                        {
                            cmd.Parameters.Clear();

                            cmd.Parameters.AddRange(sqllj);
                        }
                        cmd.CommandText = "JournalLUpdate";
                        cmd.ExecuteNonQuery();

                        sqllj[0].Value = Convert.ToInt32(txtCashnum.Text); ;
                        if (txtnametype.Text == "3")
                        {
                            sqllj[1].Value = Convert.ToDouble(gridBound.Rows[o].Cells[3].Value.ToString());
                            sqllj[2].Value = 0;//Convert.ToDouble(gridBound.Rows[o].Cells[3].Value.ToString());
                        }
                        else
                        {
                            sqllj[1].Value = 0;// Convert.ToDouble(gridBound.Rows[o].Cells[3].Value.ToString());
                            sqllj[2].Value = Convert.ToDouble(gridBound.Rows[o].Cells[3].Value.ToString());
                        }




                        sqllj[3].Value = gridBound.Rows[0].Cells[7].Value.ToString();
                        sqllj[4].Value = Convert.ToInt32(txtlinkj.Text);
                        //   journal.JournalL_Add(accno, accD, accC, note, jno);


                        if (sqllj != null)
                        {
                            cmd.Parameters.Clear();

                            cmd.Parameters.AddRange(sqllj);
                        }
                        cmd.CommandText = "JournalLUpdate";
                        cmd.ExecuteNonQuery();
                        #endregion

                    }
                    sqlTransaction.Commit();
                    conn.Close();
                    MessageBox.Show("تمت عملية التعديل بنجاح", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                try
                {
                    sqlTransaction.Rollback();
                }
                catch (Exception ex2)
                {
                    MessageBox.Show(" " + ex2.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        void BoundLineUpdate()
        {
            try
            {
                for (int i = 0; i < gridBound.Rows.Count; i++)
                {


                   int bno = Convert.ToInt32(gridBound.Rows[i].Cells[0].Value.ToString());

                    int accno = Convert.ToInt32(gridBound.Rows[i].Cells[1].Value.ToString());

                    double amount= Convert.ToDouble(gridBound.Rows[i].Cells[3].Value.ToString());

                    int curid = Convert.ToInt32(gridBound.Rows[i].Cells[4].Value.ToString());

                    string note = gridBound.Rows[i].Cells[7].Value.ToString();
                    int numl = Convert.ToInt32(gridBound.Rows[i].Cells[9].Value);

                    bound.BoundLUpdate(numl, accno, amount, note, curid, bno);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            BoundHeaderUpdate();
           // BoundLineUpdate();
            show();
          //  MessageBox.Show("تمت عملية التعديل بنجاح", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            txtBNum.Text = bound.GET_BoundLast().Rows[0][0].ToString();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int j = Convert.ToInt32(bound.GET_BoundLast().Rows[0][0]);
            if (Convert.ToInt32(txtNum.Text) == j)
            {
                MessageBox.Show("هذا اخر سند", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                txtBNum.Text = bound.GET_BoundNext(Convert.ToInt32(txtNum.Text)).Rows[0][0].ToString();
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            int j = Convert.ToInt32(bound.GET_BoundFirst().Rows[0][0]);
            if (Convert.ToInt32(txtNum.Text) == j)
            {
                MessageBox.Show("هذا أول سند", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }
            else
            {
                txtBNum.Text = bound.GET_BoundPrev(Convert.ToInt32(txtNum.Text)).Rows[0][0].ToString();
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            txtBNum.Text = bound.GET_BoundFirst().Rows[0][0].ToString();
        }

        private void txtnametype_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            SqlTransaction sqlTransaction = null;
            try
            {
                if ((MessageBox.Show("هل تريد حذف هذا السجل", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)) == DialogResult.Yes)
                {
                    int jno = Convert.ToInt16(txtlinkj.Text);

                    SqlCommand cmd = new SqlCommand();

                    SqlConnection conn = DL.ConnectionDB.GetConnection();
                    conn.Open();
                    sqlTransaction = conn.BeginTransaction("transallDel");


                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Connection = conn;
                    cmd.Transaction = sqlTransaction;

                    int bno = Convert.ToInt32(txtNum.Text);
                    //  journal.JournalHDelete(jno);
                    SqlParameter[] sqlp = new SqlParameter[1];
                    sqlp[0] = new SqlParameter("@NO", SqlDbType.Int);
                    sqlp[0].Value = bno;
                    cmd.Parameters.AddRange(sqlp);
                    cmd.CommandText = "BoundHDelete";
                    cmd.Parameters.Clear();

                    cmd.Parameters.AddRange(sqlp);
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "BoundLDelete";
                    sqlp[0] = new SqlParameter("@BNo", SqlDbType.Int);
                    sqlp[0].Value = bno;
                    cmd.Parameters.Clear();

                    cmd.Parameters.AddRange(sqlp);
                    cmd.ExecuteNonQuery();
                    SqlParameter[] sqlhj = new SqlParameter[1];
                    sqlhj[0] = new SqlParameter("@NO", SqlDbType.Int);
                    sqlhj[0].Value = jno;
                    cmd.CommandText = "JournalHDelete";
                    cmd.Parameters.Clear();

                    cmd.Parameters.AddRange(sqlhj);
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "JournalLDelete";
                    sqlhj[0] = new SqlParameter("@JNO", SqlDbType.Int);
                    sqlhj[0].Value = jno;
                    cmd.Parameters.Clear();

                    cmd.Parameters.AddRange(sqlhj);
                    cmd.ExecuteNonQuery();


                    sqlTransaction.Commit();
                    conn.Close();
                    show();
                    MessageBox.Show("تمت عملية الحذف بنجاح", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                    gridBound.Rows.Clear();
                    calTotal();
                    txtNum.Text = null;
                    txtDescription.Text = null;
                 //   txtBNum.Text = null;
                }
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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtExchange_TextChanged(object sender, EventArgs e)
        {
            if (gridBound.Rows.Count > 0)
            {
                for (int j = 0; j < gridBound.Rows.Count; j++)
                {
                   
                    gridBound.Rows[j].Cells[6].Value = txtExchange.Text;


                    gridBound.Rows[j].Cells[8].Value = (Convert.ToDouble(gridBound.Rows[j].Cells[3].Value) * Convert.ToDouble(txtExchange.Text)).ToString();
                   

                  
                }

            }
        }
    }
}

