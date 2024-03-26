using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabSheet04_Q3_Q4_Q5
{
    public partial class Form1 : Form
    {
        int num1, num2, result;
        string operation;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtResult.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtResult.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtResult.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtResult.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtResult.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtResult.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtResult.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtResult.Text += "8";
        }

        

        private void btn9_Click(object sender, EventArgs e)
        {
            txtResult.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtResult.Text += "0";
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            operation = "+";
            num1 = int.Parse(txtResult.Text);
            txtResult.Clear();
        }
      

        private void btnSub_Click_1(object sender, EventArgs e)
        {
            operation = "-";
            num1 = int.Parse(txtResult.Text);
            txtResult.Clear();

        }

        private void btnMult_Click_1(object sender, EventArgs e)
        {
            operation = "*";
            num1 = int.Parse(txtResult.Text);
            txtResult.Clear();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {

            num2 = int.Parse(txtResult.Text);

            if (operation == ("+"))
            {
                result = num1 + num2;

            }
            else if (operation == ("-"))
            {
                result = num1 - num2;

            }
            else if (operation == ("*"))
            {
                result = num1 * num2;
            }
            else if (operation == ("/"))
            {

                if (num2 == 0)
                {
                    MessageBox.Show("Cannot divide by zero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    result = num1 / num2;
                }

            }

            

            txtResult.Text = result + "";
        }

        private void btnDiv_Click_1(object sender, EventArgs e)
        {
            operation = "/";
            num1 = int.Parse(txtResult.Text);
            txtResult.Clear();
        }

       
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.Clear();
            result = 0;
            num1 = 0;
            num2 = 0;
        }




    }
}
