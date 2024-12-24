using ACT.BL.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACT.PL.SYSFormat
{
    public partial class Cash : Form
    {
        BL.SysFormat.SysFormat sys = new BL.SysFormat.SysFormat();
        public Cash()
        {
            InitializeComponent();
           
          
            txtNum.Enabled = false; 
            txtFname.Enabled = false;
            txtName.Enabled=false;
        }

        private void btnVeiw_Click(object sender, EventArgs e)
        {
         
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtName.Enabled = true;
            txtNum.Enabled = true;  
            txtFname.Enabled=true;
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            txtNum.Text=string.Empty;
            txtNum.Enabled=false;
            txtName.Text=string.Empty;
            txtName.Enabled=false;
            txtFname.Text=string.Empty;
            txtFname.Enabled = false;
            txtNum.Focus();
        }

        private void txtNum_TextChanged(object sender,EventArgs e)
        {
           
               
            
        }

        private void txtNum_KeyDown(object sender, KeyEventArgs e)
        {
            PL.Account.Search search = new PL.Account.Search();
            if (e.KeyCode==Keys.Enter)
            {
              search.txtSearch.Text = txtNum.Text;
                search.ShowDialog();
                if (search.isok == true)
                {
                  
                    txtNum.Text = search.gridSearchResult.CurrentRow.Cells[0].Value.ToString();
                    txtName.Text = search.gridSearchResult.CurrentRow.Cells[2].Value.ToString();
                    txtFname.Text = search.gridSearchResult.CurrentRow.Cells[3].Value.ToString();

                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            gridCash.DataSource = sys.GetBank_Fun(Convert.ToInt32(txtFuncation.Text));
            gridCash.Columns[0].HeaderText = "رقم الحساب";
            gridCash.Columns[1].HeaderText = "اسم الحساب";
            gridCash.Columns[2].Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try {
                sys.Dk_Fun(txtName.Text,txtFname.Text,Convert.ToInt32(txtNum.Text), Convert.ToInt32(txtFuncation.Text));
                MessageBox.Show("تمت عملية الحفظ بنجاح", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (Exception err)
            {
                MessageBox.Show(err.Message, "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("هل تريد حذف هذا السجل", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)) == DialogResult.Yes)
            {



                int cno = Convert.ToInt32(txtNum.Text);
                sys.CashDelete(cno,Convert.ToInt32(txtFuncation.Text));
                txtNum.Text = string.Empty;
                txtName.Text = string.Empty;
                gridCash.DataSource = sys.GetBank_Fun(Convert.ToInt32(txtFuncation.Text));
                txtNum.Focus();
                MessageBox.Show("تمت عملية الحذف بنجاح", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);

              
            }
        }
    }
}
