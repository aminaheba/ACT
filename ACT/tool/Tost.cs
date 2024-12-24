using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACT.tool
{
    public partial class Tost : Form
    {
        public Tost()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Caption_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
