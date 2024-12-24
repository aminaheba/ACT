using ACT.BL.Account;
using ACT.BL.User;
using CrystalDecisions.CrystalReports.Engine;
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

namespace ACT.PL.Account
{
    public partial class Account : Form
    {
         public  BL.Account.Account account = new BL.Account.Account();
       public bool isnew = false;
       
        public Account()
        {
            InitializeComponent();
            fill_CB();
            isnew = false;



        }
        void fill_CB()
        {
            CreateNode();
            cBReport.DataSource = account.GetAllRepoType();
            cBReport.ValueMember = "NO";
            cBReport.DisplayMember = "AccName";
            cBAccType.DataSource = account.GetAllAccType();
            cBAccType.ValueMember = "NO";
            cBAccType.DisplayMember = "AccName";
        }
       
        private void CreateNode()
        {
            TreeNode Tnode = new TreeNode();
           
          DataView  dataView = new DataView(account.GetAllAcc());
            dataView.RowFilter = "ParentNo=0";
            treeAccount.Nodes.Clear();
            treeAccount.Nodes.Add("0","الدليل المحاسبي");
           /* foreach (DataRowView drv in dataView)
            {
                Tnode=new TreeNode( drv["NO"].ToString()+" " + drv["Name"].ToString());
                Tnode.Tag = drv["NO"].ToString();
                //treeAccount.Nodes.Add(Tnode);

            }*/
            foreach(TreeNode tnode in treeAccount.Nodes)
            {
                NodeChild(tnode);
            }
            
        }
        void NodeChild(TreeNode nd)
        {
            TreeNode Cn = new TreeNode();
            DataView dataView = new DataView(account.GetAllAcc());

            dataView.RowFilter = "ParentNo="+Convert.ToInt32( nd.Tag);
            foreach (DataRowView dv in dataView)
            {
                Cn = new TreeNode(dv["NO"].ToString() + " " + dv["Name"].ToString());
                Cn.Tag = dv["NO"].ToString();
                nd.Nodes.Add(Cn);
                NodeChild(Cn);

            }
            


        }
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
              DataTable dt = new DataTable();
                dt = account.AccTest(Convert.ToInt32(txtnum.Text));
                if(dt.Rows.Count > 0)
                {
                    MessageBox.Show("هذا الحساب مرتبط بحسابات فرعية لايمكن حذفه ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                    
                }
                DataTable dtj = new DataTable();
                dtj = account.AccJournalTest(Convert.ToInt32(txtnum.Text));
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("هذا الحساب لديه عمليات محاسبية مرتبطة به لايمكن حذفه ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;

                }
                account.DelAcc(Convert.ToInt32(txtnum.Text));
                MessageBox.Show("تمت عملية الحذف بنجاح", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // isnew = false;
                foreach (var c in GBInput.Controls)
                {
                    if (c is TextBox)
                    {
                        ((TextBox)c).Text = string.Empty;
                        //((TextBox)c).Enabled = true;
                    }
                }

                CreateNode();

            }
            catch (Exception exp)
            {
                MessageBox.Show("الرجاء ادخال بيانات صحيحة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void cBAccType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void treeAccount_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
            if (isnew == true) {
                txtParent.Text = treeAccount.SelectedNode.Tag.ToString();
                txtParent.Enabled = false;
                int NUM = Convert.ToInt32( account.GenerateAccNum(Convert.ToInt32(txtParent.Text)).Rows[0][0]);
               
                int res;
                if (NUM != 1)
                {
                   

                     res= Convert.ToInt32( NUM.ToString().Substring(txtParent.Text.Length))+1;
                    
                 
                }
                else
                {
                    res = 1;
                    
                }
                txtnum.Text = txtParent.Text+ res.ToString();
                txtnum.Enabled = false; 
            }
            else
            {

                foreach (var c in GBInput.Controls)
                {
                    if (c is TextBox)
                    {
                      //  ((TextBox)c).Text = string.Empty;
                        ((TextBox)c).Enabled = true;
                    }
                }
                btnSave.Enabled = false;
                if (treeAccount.SelectedNode.Tag == null)
                {
                    txtTag.Text = "0";
                }
                else
                {
                    txtTag.Text = treeAccount.SelectedNode.Tag.ToString();
                }
                
            }    
        }

        private void txtTag_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
           dt= account.GetAcc(Convert.ToInt32(txtTag.Text));
            if(dt.Rows.Count > 0)
            {
                txtnum.Text = dt.Rows[0][0].ToString();
                txtParent.Text = dt.Rows[0][1].ToString();
                txtName.Text = dt.Rows[0][2].ToString();
                txtLevel.Text = dt.Rows[0][6].ToString();
                txtDebit.Text = dt.Rows[0][7].ToString();
                txtCredit.Text = dt.Rows[0][8].ToString();
                txtBalance.Text = dt.Rows[0][9].ToString();
                cBReport.SelectedValue = dt.Rows[0][5].ToString();
                cBAccType.SelectedValue = dt.Rows[0][4].ToString();

            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            isnew=true;
            foreach (var c in GBInput.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = string.Empty;
                    ((TextBox)c).Enabled = true;
                }
            }
                txtnum.Focus();
                btnSave.Enabled = true;
                cBAccType.Enabled = true;
                cBReport.Enabled = true;
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try {
              
               account.AddAcc(Convert.ToInt32(txtnum.Text), Convert.ToInt32(txtParent.Text), txtName.Text, string.Empty, Convert.ToInt32(cBAccType.SelectedValue), Convert.ToInt32(cBReport.SelectedValue), Convert.ToInt32(txtLevel.Text), Convert.ToDouble(txtDebit.Text), Convert.ToDouble(txtCredit.Text), Convert.ToDouble(txtBalance.Text));
                MessageBox.Show("تمت عملية الحفظ بنجاح", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                isnew=false;
                CreateNode();

            }
            catch (Exception exp) {
                MessageBox.Show("الرجاء ادخال بيانات صحيحة","تنبيه",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var c in GBInput.Controls)
                {
                    if (c is TextBox)
                    {
                        // ((TextBox)c).Text = string.Empty;
                        ((TextBox)c).Enabled = true;
                    }
                }
                    // txtnum.Focus();
                    cBAccType.Enabled = true;
                    cBReport.Enabled = true;
                    btnSave.Enabled = true;
                

                    account.UpdateAcc(Convert.ToInt32(txtnum.Text), Convert.ToInt32(txtParent.Text), txtName.Text, string.Empty, Convert.ToInt32(cBAccType.SelectedValue), Convert.ToInt32(cBReport.SelectedValue), Convert.ToInt32(txtLevel.Text), Convert.ToDouble(txtDebit.Text), Convert.ToDouble(txtCredit.Text), Convert.ToDouble(txtBalance.Text));
                MessageBox.Show("تمت عملية التعديل بنجاح", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
              //  isnew = false;
                CreateNode();

            }
            catch (Exception exp)
            {
                MessageBox.Show("الرجاء ادخال بيانات صحيحة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        private TreeNode SearchNode(string text, TreeNode treeNode)
        {
            TreeNode node = null;
            while (treeNode != null)
            {
                if(treeNode.Text.Contains(text))
                {
                    node= treeNode;
                    break;  
                }
                if (treeNode.Nodes.Count != 0)
                {
                    node = SearchNode(text, treeNode.Nodes[0]);
                    if(node != null)
                    {
                        break;
                    }
                }
                treeNode= treeNode.NextNode;

            }
            return node;    
        }
        private void btnsearch_Click(object sender, EventArgs e)
        {
            if(txtsearch.Text=="")
            {
                return;
            }
            TreeNode SelectNode = SearchNode(txtsearch.Text, treeAccount.Nodes[0]);
             if(SelectNode != null)
            {
                treeAccount.SelectedNode= SelectNode;
                treeAccount.SelectedNode.Expand();
                treeAccount.Select();
            }
            else
            {
                MessageBox.Show("هذا الحساب غير موجود","تنبيه",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReportDocument Rdoc= new ReportDocument();
            Rdoc.Load(txtsearch.Text);
           PL. Report.Repo rep = new PL. Report.Repo();
           // rep.CRV.ReportSource = Rdoc;
            rep.ShowDialog();


        }
    }
}
