using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabSheet04_Q2
{
    public partial class Form1 : Form
    {
        int num1, num2, result;
        string operation;
        

        public Form1()
        {
          

            InitializeComponent();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            operation = "Add";
            result = num1 + num2;
            lblResult.Text = "Result: " + result.ToString();

        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            operation = "Sub";
            result = num1 - num2;
            lblResult.Text = "Result: " + result.ToString();
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            operation = "Mult";
            result = num1 * num2;
            lblResult.Text = "Result: " + result.ToString();

        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            operation = "Div";
            result = num1 / num2;
            lblResult.Text = "Result: " + result.ToString();
        }

        private void txtNum1_TextChanged(object sender, EventArgs e)
        {
          num1 = Convert.ToInt32(txtNum1.Text);
        }
        private void txtNum2_TextChanged(object sender, EventArgs e)
        {
            num2 = Convert.ToInt32(txtNum2.Text);
        }

        

    }
}
