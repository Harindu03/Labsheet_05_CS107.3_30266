using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabSheet_04_Q1
{
   
    public partial class Form1 : Form
    {
        int num1, num2, sum;
        public Form1()
        {
            InitializeComponent();
        }

        private void txtNum2_TextChanged(object sender, EventArgs e)
        {
            num2 = Convert.ToInt32(txtNum2.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sum = num1 + num2;
            lblSum.Text = "Sum: " + sum.ToString();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNum1_TextChanged(object sender, EventArgs e)
        {
            num1 = Convert.ToInt32(txtNum1.Text);
        }
        
    }
}
