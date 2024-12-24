using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACT.PL.Account
{
    public partial class Search : Form
    {
        public bool isok = false;
        public Search()
        {
            InitializeComponent();
            BL.SysFormat.SysFormat sys = new BL.SysFormat.SysFormat();
            gridSearchResult.DataSource = sys.searchinAcc(txtSearch.Text);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            BL.SysFormat.SysFormat sys = new BL.SysFormat.SysFormat();
            gridSearchResult.DataSource = sys.searchinAcc(txtSearch.Text);
            gridSearchResult.Columns[0].HeaderText = "";
            gridSearchResult.Columns[1].Visible = false;
            gridSearchResult.Columns[2].HeaderText = "";
            gridSearchResult.Columns[3].HeaderText = "";
            gridSearchResult.Columns[4].Visible = false;
            gridSearchResult.Columns[5].Visible = false;
            gridSearchResult.Columns[6].Visible = false;
            gridSearchResult.Columns[7].Visible = false;
            gridSearchResult.Columns[8].Visible = false;
            gridSearchResult.Columns[9].Visible = false;

        }

        private void gridSearchResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            


        }

        private void gridSearchResult_DoubleClick(object sender, EventArgs e)
        {
            
           
            
        }

        private void gridSearchResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            isok = true;
            Close();
        }
    }
}
