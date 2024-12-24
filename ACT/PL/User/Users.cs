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
using System.Xml.Linq;

namespace ACT.PL.User
{
    public partial class Form1 : Form
    {
        BL.User.User use=new BL.User.User();
        public Form1()
        {
            InitializeComponent();
            showData();

        }
        void Active(bool t)
        {
            txtFullName.Enabled = t;
            txtUserName.Enabled = t;
            txtPass.Enabled = t;
            txtPhone.Enabled = t;
            txtEmail.Enabled = t;
            chkBlok.Enabled = t;
            rbtnAdmin.Enabled = t;
            rbtnLevel.Enabled = t;
        }
        public void showData()
        {
            gridDataUser.DataSource = use.GetAll();
            gridDataUser.Columns[0].HeaderText = "رقم المستخدم";
            gridDataUser.Columns[1].Visible = false;
            gridDataUser.Columns[2].HeaderText = "المستخدم";
            gridDataUser.Columns[3].Visible = false;
            gridDataUser.Columns[4].HeaderText = "التلفون";
            gridDataUser.Columns[5].HeaderText = "البريد الالكتروني";
            gridDataUser.Columns[6].Visible = false;
            gridDataUser.Columns[7].Visible = false;
            gridDataUser.Columns[8].Visible = false;

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            

            foreach (var c in this.groupBox1.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = string.Empty;
                }
            }
            Active(true);
            picUser.Image = null;
            btnSave.Enabled = true;
            txtNum.Text = use.GenerateUID().Rows[0][0].ToString();
            txtFullName.Focus();
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }



        private void txtEmail_Validated_1(object sender, EventArgs e)
        {
            BL.Helper help = new BL.Helper();
            if (!(help.checkEmail(txtEmail.Text)))
            {
                txtEmail.Focus();
            }

        }

        private void btnBrose_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.FileName = "All File |.gif;jpg;png;bmp";
            // openFileDialog.Filter = "All File |.gif;jpg;png;bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                picUser.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            picUser.Image = null;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            pnlUser.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] bimg;
                int ustate=0;
                int utype=0;
                if(chkBlok.Checked==true){
                    ustate=0;
                } else {
                    ustate = 1;
                }
                if (rbtnAdmin.Checked == true) {
                    utype = 1;
                }else {
                    utype = 0;
                }
                MemoryStream ms=new MemoryStream();
                picUser.Image.Save(ms, picUser.Image.RawFormat);
                bimg= ms.ToArray();
                use.AddUser(Convert.ToInt32(txtNum.Text),txtFullName.Text,txtUserName.Text,txtPass.Text,txtPhone.Text,txtEmail.Text,ustate,utype,bimg);
                MessageBox.Show("تمت عملية الحفظ بنجاح","تنبيه",MessageBoxButtons.OK,MessageBoxIcon.Information);
                showData();
                foreach (var c in this.groupBox1.Controls)
                {
                    if (c is TextBox)
                    {
                        ((TextBox)c).Text = string.Empty;
                    }
                }
                picUser.Image = null;
            }
            catch(Exception ex) 
            {
                MessageBox.Show("" + ex.Message);
            }
        }

        private void gridDataUser_DoubleClick(object sender, EventArgs e)
        {
           

            txtNum.Text = gridDataUser.CurrentRow.Cells[0].Value.ToString();
            txtFullName.Text = gridDataUser.CurrentRow.Cells[1].Value.ToString();
            txtUserName.Text = gridDataUser.CurrentRow.Cells[2].Value.ToString();
            txtPass.Text = gridDataUser.CurrentRow.Cells[3].Value.ToString();
            txtPhone.Text = gridDataUser.CurrentRow.Cells[4].Value.ToString();
            txtEmail.Text = gridDataUser.CurrentRow.Cells[5].Value.ToString();
            if(Convert.ToInt32(gridDataUser.CurrentRow.Cells[6].Value) == 1)
            {
                chkBlok.Checked = true;
            }
            else
            {
                chkBlok.Checked = false;
            }
            if (Convert.ToInt32(gridDataUser.CurrentRow.Cells[7].Value) == 1)
            {
                rbtnAdmin.Checked = true;
            }
            else
            {
                rbtnLevel.Checked = true;
            }
            if (gridDataUser.CurrentRow.Cells[8].Value != DBNull.Value)
            {
                byte[] Bimg = (byte[])gridDataUser.CurrentRow.Cells[8].Value;
                MemoryStream ms = new MemoryStream(Bimg);
                picUser.Image = Image.FromStream(ms);
            }
            else { picUser.Image = null; }
           Active(true);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] bimg;
                int ustate = 0;
                int utype = 0;
                if (chkBlok.Checked == true)
                {
                    ustate = 0;
                }
                else
                {
                    ustate = 1;
                }
                if (rbtnAdmin.Checked == true)
                {
                    utype = 1;
                }
                else
                {
                    utype = 0;
                }
                MemoryStream ms = new MemoryStream();
                if (picUser.Image != null)
                {
                    picUser.Image.Save(ms, picUser.Image.RawFormat);
                    bimg = ms.ToArray();
                }
                else { bimg = null; }
                use.UpdateUser(Convert.ToInt32(txtNum.Text), txtFullName.Text, txtUserName.Text, txtPass.Text, txtPhone.Text, txtEmail.Text, ustate, utype, bimg);
                showData();
               /* foreach (var c in this.groupBox1.Controls)
                {
                    if (c is TextBox)
                    {
                        ((TextBox)c).Text = string.Empty;
                    }
                }
                picUser.Image = null;*/
                MessageBox.Show("تمت عملية التعديل بنجاح", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
            }

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("هل تريد حذف هذا السجل", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)) == DialogResult.Yes)
            {



                int cno = Convert.ToInt32(gridDataUser.CurrentRow.Cells[0].Value);
                use.DelUser(cno);
                showData();
                foreach (var c in this.groupBox1.Controls)
                {
                    if (c is TextBox)
                    {
                        ((TextBox)c).Text = string.Empty;
                    }
                }
                picUser.Image = null;
                MessageBox.Show("تمت عملية الحذف بنجاح", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);

                foreach (var c in this.Controls)
                {
                    if (c is TextBox)
                    {
                        ((TextBox)c).Text = string.Empty;

                    }
                    picUser.Image = null;
                    txtFullName.Focus();
                }
            }
        }

        private void txtNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            foreach (var c in this.groupBox1.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = string.Empty;
                    ((TextBox)c).Enabled = false;
                }
            }
            Active(false);
            picUser.Image = null;
            btnSave.Enabled = false;
           
           
        }
    }
}
