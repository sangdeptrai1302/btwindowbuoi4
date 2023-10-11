using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace levansang_2121110373_wd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            int tong;
            Console.WriteLine(txtA.Text);
            Console.WriteLine(txtB.Text);
            tong = int.Parse(txtA.Text) + int.Parse(txtB.Text);
            lblKetQua.Text =txtA.Text + "+"  + txtB.Text + "=" + tong + "";
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult cc = MessageBox.Show(
                "bạn có chắc chắn muốn thoát ?",
                "confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                );
            if (cc == DialogResult.Yes)
                Close();
            else if (cc == DialogResult.No)
                MessageBox.Show("OK Bạn ,mời bạn tiếp tục chương trình");
        }

        private void btnHieu_Click(object sender, EventArgs e)
        {
            int hieu;
            Console.WriteLine(txtA.Text);
            Console.WriteLine(txtB.Text);
            hieu = int.Parse(txtA.Text) - int.Parse(txtB.Text);
            lblKetQua.Text = txtA.Text + "-" + txtB.Text + "=" + hieu + "";
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
             
        }
    }
}
