using ACT.BL.SysFormat;
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
    public partial class Setting : Form
    {
        BL.SysFormat.SysFormat SysFormat = new BL.SysFormat.SysFormat();
        public   static double SYSExch = 0;
        public Setting()
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
                //   txtExchange.Text = dt.Rows[0][2].ToString();
                SYSExch = Convert.ToDouble(dt.Rows[0][2]);
            }
        }

        private void Setting_Load(object sender, EventArgs e)
        {
            show();
        }
    }
}
