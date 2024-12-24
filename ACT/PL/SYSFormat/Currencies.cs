using ACT.BL.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACT.PL.SYSFormat
{
    public partial class Currencies : Form
    {
        BL.SysFormat.SysFormat SysFormat = new BL.SysFormat.SysFormat();
        public Currencies()
        {
            InitializeComponent();
            Show();
          
        }
        void Show()
        {
            gridCurr.DataSource = SysFormat.GetAllCurrency();
            gridCurr.Columns[0].HeaderText = "رقم العملة";
            gridCurr.Columns[1].HeaderText = "اسم العملة ";
            gridCurr.Columns[3].Visible = false;
            gridCurr.Columns[4].Visible = false;
            gridCurr.Columns[5].Visible = false;
            gridCurr.Columns[6].Visible = false;
        }
        void Clears()
        {
            foreach (var c in gbInput.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = string.Empty;

                    ((TextBox)c).Enabled = true;
                }
            }
            txtName.Focus();
            rblocal.Enabled = true;
            rbf.Enabled = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                
                int utype = 0;
                if (rblocal.Checked == true)
                {
                    utype = 1;
                }
                else
                {
                    utype = 2;
                }

                SysFormat.CurrencyUpdate(Convert.ToInt32(gridCurr.CurrentRow.Cells[0].Value), txtName.Text, txtFname.Text, txtSym.Text, utype, Convert.ToInt32(txtexch.Text), txtDec.Text);
                MessageBox.Show("تمت عملية التعديل بنجاح", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Show();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
            }

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Clears();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            foreach (var c in gbInput.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = string.Empty;

                    ((TextBox)c).Enabled = false;
                }
            }
            txtName.Focus();
            rblocal.Enabled = false;
            rbf.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] bimg;

                int utype = 0;

                if (rblocal.Checked == true)
                {
                    utype = 1;
                }
                else
                {
                    utype = 2;
                }

                SysFormat.CurrencyAdd(txtName.Text, txtFname.Text, txtSym.Text, utype, Convert.ToInt32(txtexch.Text), txtDec.Text);
                MessageBox.Show("تمت عملية الحفظ بنجاح", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Show();
                foreach (var c in gbInput.Controls)
                {
                    if (c is TextBox)
                    {
                        ((TextBox)c).Text = string.Empty;

                      
                    }
                }
                txtName.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
            }

        }

        private void gbInput_Enter(object sender, EventArgs e)
        {

        }

        private void gridCurr_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Clears();
            txtName.Text = gridCurr.CurrentRow.Cells[1].Value.ToString();
            txtFname.Text = gridCurr.CurrentRow.Cells[2].Value.ToString();
            txtSym.Text = gridCurr.CurrentRow.Cells[3].Value.ToString();
            txtexch.Text = gridCurr.CurrentRow.Cells[5].Value.ToString();
            txtDec.Text = gridCurr.CurrentRow.Cells[6].Value.ToString();
            if (gridCurr.CurrentRow.Cells[4].Value.ToString() == "1")
            {
                rblocal.Checked = true;
            }else { 
             rbf.Checked = true;
            }


        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("هل تريد حذف هذا السجل", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)) == DialogResult.Yes)
            {



                int cno = Convert.ToInt32(gridCurr.CurrentRow.Cells[0].Value);
                SysFormat.CurrencyDelete(cno);
                Clears();
                Show();
                MessageBox.Show("تمت عملية الحذف بنجاح", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }
        }
    }
    

