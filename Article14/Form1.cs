using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Article14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void ckDiscount_CheckedChanged(object sender, EventArgs e)
        {
            if (ckDiscount.Checked == true) tbDiscount.Enabled = true;
            else tbDiscount.Enabled = false;
            if (tbDiscount.Enabled == false)
            {
                tbDiscount.Text = "";
            }
        }
       

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bttinhtien_Click_1(object sender, EventArgs e)
        {
            string msg = null;
            string disc = "0";
            if (rbMale.Checked == true) msg += " Ông ";
            if (rbFemale.Checked == true) msg += " Bà ";
            if (ckDiscount.Checked == true)
            {
                disc = tbDiscount.Text;
            }
            tbResult.Text = msg + tbName.Text + " được giảm " + disc.ToString() + "%" + "\r\n";
        }
    }
}
