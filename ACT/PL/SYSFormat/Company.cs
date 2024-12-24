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
using System.Globalization;
using System.Text.RegularExpressions;

namespace ACT.PL.SYSFormat
{
    public partial class Company : Form
    {
        BL.SysFormat.SysFormat sf = new BL.SysFormat.SysFormat();

        public Company()
        {
            InitializeComponent();
            gridComp();
        }
        void gridComp()
        {
            gridcompdata.DataSource = sf.GetAllDataC();
            gridcompdata.Columns[0].HeaderText = "الرقم";
            gridcompdata.Columns[0].Visible = false;
            gridcompdata.Columns[1].HeaderText = "الاسم";
            gridcompdata.Columns[2].HeaderText = "الاسم الاجنبي";
            gridcompdata.Columns[3].HeaderText = "العنوان";
            gridcompdata.Columns[4].HeaderText = "العنوان الاجنبي";
            gridcompdata.Columns[5].HeaderText = "تليفون";
            gridcompdata.Columns[6].HeaderText = "فاكس";
            gridcompdata.Columns[7].HeaderText = "البريد الالكتروني";
            gridcompdata.Columns[8].HeaderText = "الموقع الالكتروني";
            //  gridcompdata.Columns[8].Visible = false;
            gridcompdata.Columns[9].HeaderText = "الشعار ";
            gridcompdata.Columns[9].Visible = false;

        }
        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnBrose_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.FileName = "All File |.gif;jpg;png;bmp";
           // openFileDialog.Filter = "All File |.gif;jpg;png;bmp";
            if(openFileDialog.ShowDialog() == DialogResult.OK ) { 
                piclogo.Image=Image.FromFile(openFileDialog.FileName);  
                    }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            piclogo.Image = null;  
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            foreach(var c in this.pnlCompany. Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c ).Text = string.Empty;
                    ((TextBox)c).Enabled = true;
                }
            }
            piclogo.Image = null;
            btnBrose.Enabled = true;
            btnSave.Enabled = true;
            txtname.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try {
                byte[] Bimg;
                if (piclogo.Image == null)
                {
                    MessageBox.Show("يجب ادخال شعار الشركة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    MemoryStream ms = new MemoryStream();
                    piclogo.Image.Save(ms, piclogo.Image.RawFormat);
                    Bimg = ms.ToArray();
                    sf.AddCompany(txtname.Text, txtfname.Text, txtaddress.Text, txtfadress.Text, txtphone.Text, txtfax.Text, txtemail.Text, txtwebsite.Text, Bimg);
                    gridComp();
                    MessageBox.Show("تمت عملية الحفظ بنجاح", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }catch(Exception ex)
            {
                MessageBox.Show("" + ex.Message);

            }
            

        }

        private void txtname_Enter(object sender, EventArgs e)
        {
            Application.CurrentInputLanguage = InputLanguage.FromCulture( new CultureInfo("ar-SY"));
        }

        private void txtfname_Enter(object sender, EventArgs e)
        {
            Application.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("en-us"));
        }

        private void txtaddress_Enter(object sender, EventArgs e)
        {
            Application.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("ar-SY"));

        }

        private void txtfadress_Enter(object sender, EventArgs e)
        {
            Application.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("en-us"));

        }

        private void gridcompdata_DoubleClick(object sender, EventArgs e)
        {

            foreach (var k in this.pnlCompany.Controls)
            {
                if (k is TextBox)
                {
                    ((TextBox)k).Enabled = true;
                }
            }

            txtname.Text = gridcompdata.CurrentRow.Cells[1].Value.ToString();
            txtfname.Text = gridcompdata.CurrentRow.Cells[2].Value.ToString();
            txtaddress.Text = gridcompdata.CurrentRow.Cells[3].Value.ToString();
            txtfadress.Text = gridcompdata.CurrentRow.Cells[4].Value.ToString();
            txtphone.Text = gridcompdata.CurrentRow.Cells[5].Value.ToString();
            txtfax.Text = gridcompdata.CurrentRow.Cells[6].Value.ToString();
            txtemail.Text = gridcompdata.CurrentRow.Cells[7].Value.ToString();
            txtwebsite.Text = gridcompdata.CurrentRow.Cells[8].Value.ToString();
            byte[]Bimg = (byte[])gridcompdata.CurrentRow.Cells[9].Value;
            MemoryStream ms = new MemoryStream(Bimg);
            piclogo.Image=Image.FromStream(ms);
          
            btnBrose.Enabled = true;
            btnSave.Enabled = true;
        }

        private void gridcompdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try {
                byte[] Bimg;


                MemoryStream ms = new MemoryStream();
                piclogo.Image.Save(ms, piclogo.Image.RawFormat);
                Bimg = ms.ToArray();
                int cno = Convert.ToInt32(gridcompdata.CurrentRow.Cells[0].Value);
                sf.EditCompany(cno, txtname.Text, txtfname.Text, txtaddress.Text, txtfadress.Text, txtphone.Text, txtfax.Text, txtemail.Text, txtwebsite.Text, Bimg);
                gridComp();
                MessageBox.Show("تمت عملية التعديل بنجاح", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);

            }


        }
        

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                if ((MessageBox.Show("هل تريد حذف هذا السجل", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)) == DialogResult.Yes)
                {



                    int cno = Convert.ToInt32(gridcompdata.CurrentRow.Cells[0].Value);
                    sf.DeletCompany(cno);
                    gridComp();
                    MessageBox.Show("تمت عملية الحذف بنجاح", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    foreach (var c in this.pnlCompany.Controls)
                    {
                        if (c is TextBox)
                        {
                            ((TextBox)c).Text = string.Empty;

                        }
                        piclogo.Image = null;
                        txtname.Focus();
                    }
                  
                }
            }

            catch(Exception ex)
            {
                MessageBox.Show("" + ex.Message);

            }
        }

        

        private void btnexit_Click(object sender, EventArgs e)
        {
            foreach (var c in this.pnlCompany.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = string.Empty;
                    ((TextBox)c).Enabled = false;
                }
            }
            piclogo.Image = null;
            btnBrose.Enabled = false;
            btnSave.Enabled = false;
            txtname.Focus();
        }

      

        private void txtemail_Validated(object sender, EventArgs e)
        {
            Regex reg = new Regex(@"^\w+([-_.]\w+)*@\w+([-.]\w+)*\.\w+$");
            if (!reg.IsMatch(txtemail.Text))
            {
                MessageBox.Show("الصيغة التي ادخلتها غير صحبجة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtemail.Focus();
            }

        }

        private void txtwebsite_Validated(object sender, EventArgs e)
        {
            Regex reg = new Regex(@"^(\w\.)*\w+([-.]\w+)*\.\w+$");
            if (!reg.IsMatch(txtwebsite.Text))
            {
                MessageBox.Show("الصيغة التي ادخلتها غير صحبجة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtwebsite.Focus();
            }

        }
    }
}
