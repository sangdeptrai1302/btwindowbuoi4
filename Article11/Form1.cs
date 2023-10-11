using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Article11
{
    public partial class Form1 : Form
    {
        decimal memory = 0;
        decimal workingMemory = 0;
        string opr = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            if ((char.IsDigit(bt.Text, 0) & bt.Text.Length == 1) || bt.Text == ".")
            {
                tbDisplay.Text += bt.Text;
            }
            else if (bt.Text == "*" || bt.Text == "/" || bt.Text == "+" || bt.Text == "-")
            {
                opr = bt.Text;
                workingMemory = decimal.Parse(tbDisplay.Text);
                tbDisplay.Clear();
            }
            else if (bt.Text == "=")
            {
                decimal secondValue = decimal.Parse(tbDisplay.Text);
                switch (opr)
                {
                    case "+":
                        {
                            tbDisplay.Text = (workingMemory + secondValue).ToString();
                            break;
                        }
                    case "-":
                        {
                            tbDisplay.Text = (workingMemory - secondValue).ToString();
                            break;
                        }
                    case "*":
                        {
                            tbDisplay.Text = (workingMemory * secondValue).ToString();
                            break;
                        }
                    case "/":
                        {
                            tbDisplay.Text = (workingMemory / secondValue).ToString();
                            break;
                        }
                }
            }
            else if (bt.Text == "±")
            {
                decimal currVal = decimal.Parse(tbDisplay.Text);
                currVal = -currVal;
                tbDisplay.Text = currVal.ToString();
            }

            else if (bt.Text == "√")
            {
                decimal currVal = decimal.Parse(tbDisplay.Text);
                currVal = (decimal)Math.Sqrt((double)currVal);
                tbDisplay.Text = currVal.ToString();
            }
            else if (bt.Text == "%")
            {
                decimal currVal = decimal.Parse(tbDisplay.Text);
                currVal = currVal / 100;
                tbDisplay.Text = currVal.ToString();
            }
            else if (bt.Text == "1/x")
            {
                decimal currVal = decimal.Parse(tbDisplay.Text);
                currVal = 1 / currVal;
                tbDisplay.Text = currVal.ToString();
            }
            else if (bt.Text == "<-")
            {
                if (tbDisplay.TextLength != 0)
                {
                    tbDisplay.Text = tbDisplay.Text.Remove(tbDisplay.TextLength - 1);
                }
            }
            else if (bt.Text == "MC")
            {
                memory = 0;
            }
            else if (bt.Text == "MR")
            {
                tbDisplay.Text = memory.ToString();
            }
            else if (bt.Text == "MS")
            {
                memory = decimal.Parse(tbDisplay.Text);
                tbDisplay.Clear();
            }
            else if (bt.Text == "M+")
            {
                memory = memory + decimal.Parse(tbDisplay.Text);

            }
            else if (bt.Text == "M-")
            {
                memory = memory - decimal.Parse(tbDisplay.Text);
            }
            else if (bt.Text == "C")
            {
                workingMemory = 0;
                opr = "";
                tbDisplay.Clear();
            }
            else if (bt.Text == "CE")
            {
                tbDisplay.Clear();
            }
        }

        private void tbDisplay_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
