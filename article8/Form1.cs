using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace article8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btncong_Click(object sender, EventArgs e)
        {
            int tong;
            Console.WriteLine(txtx.Text);
            Console.WriteLine(txty.Text);
            tong = int.Parse(txtx.Text) + int.Parse(txty.Text);
            lblKetQua.Text = txtx.Text + "+" + txty.Text + "=" + tong + "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int nhan;
            Console.WriteLine(txtx.Text);
            Console.WriteLine(txty.Text);
            nhan = int.Parse(txtx.Text) * int.Parse(txty.Text);
            lblKetQua.Text = txtx.Text + "+" + txty.Text + "=" + nhan + "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
