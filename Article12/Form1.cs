using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Article12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cb_faculty.SelectedIndex = 2;
        }

        private void cb_faculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cb_faculty.SelectedIndex;
            tbDisplay.Text = "Bạn đã chọn khoa thứ:" + index.ToString();
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            int index = cb_faculty.SelectedIndex;
            tbDisplay.Text = "Bạn đã chọn khoa thứ:" + index.ToString();
        }
    }
}
