using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabSheet05_PartB
{ 
    public partial class SignUp : Form

    {
        public static string name { get;  set; }
        public static string username { get;  set; }
        public static string email { get;  set; }

        public SignUp()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            string dob = dtpDOB.Value.ToString("dd/MM/yyyy");
            string name = txtName.Text;
            string password = txtPass.Text;
            string confirmPassword = txtConpass.Text;
            string email = txtEmail.Text;
            string username = txtUser.Text;

          


            if (txtUser.Text == "" || txtPass.Text == "" || txtConpass.Text == "" || txtEmail.Text == "")
            {
                MessageBox.Show("Please enter all the required fields");
            }
            else
            {
                if (txtUser.Text.All(char.IsLetter) == false && txtPass.Text.All(char.IsLetter) == false && txtConpass.Text.All(char.IsLetter) == false && txtEmail.Text.All(char.IsLetter) == false)
                {
                    MessageBox.Show("Please enter valid values");
                }

                if (txtPass.Text == txtConpass.Text)
                {
                   
                    txtUser.Text = "";
                    txtPass.Text = "";
                    txtConpass.Text = "";
                }
                else
                {
                    MessageBox.Show("Passwords do not match");
                }

                
              
               
            }
            Form2 f2 = new Form2(name,username,email);
            f2.Show();
            this.Hide();
           
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtUser.Text = "";
            txtPass.Text = "";
            txtConpass.Text = "";
            txtEmail.Text = "";
            txtName.Text = "";
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            
        }
    }
}
