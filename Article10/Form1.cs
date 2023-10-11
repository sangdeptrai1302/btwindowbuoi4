﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Article10
{
    public partial class Form1 : Form
    {
        decimal workingMemory = 0;
        string opr = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void bt0_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += bt0.Text;
        }


        private void bt1_Click_1(object sender, EventArgs e)
        {
            tbDisplay.Text += bt1.Text;
        }

        private void bt2_Click_1(object sender, EventArgs e)
        {
            tbDisplay.Text += bt2.Text;
        }

        private void bt3_Click_1(object sender, EventArgs e)
        {
            tbDisplay.Text += bt3.Text;
        }

        private void btPlus_Click_1(object sender, EventArgs e)
        {
            opr = btPlus.Text;
            workingMemory = decimal.Parse(tbDisplay.Text);
            tbDisplay.Clear();
        }

        private void btMul_Click_1(object sender, EventArgs e)
        {
            opr = btMul.Text;
            workingMemory = decimal.Parse(tbDisplay.Text);
            tbDisplay.Clear();
        }
        private void btcham_Click_1(object sender, EventArgs e)
        {
            tbDisplay.Text += btcham.Text;
        }

        
        private void btEquals_Click_1(object sender, EventArgs e)
        {
            decimal seconValue = decimal.Parse(tbDisplay.Text);
            if (opr == "+")
                tbDisplay.Text = (workingMemory + seconValue).ToString();
            if (opr == "*")
                tbDisplay.Text = (workingMemory * seconValue).ToString();
        }
    }
}
