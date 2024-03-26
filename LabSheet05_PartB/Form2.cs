using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LabSheet05_PartB
{
    public partial class Form2 : Form
    {
        string name = SignUp.name;
        string username = SignUp.username;
        string email = SignUp.email;

        public Form2(string name, string username, string email)
        {
            InitializeComponent();
            this.name = name;
            this.username = username;
            this.email = email;


        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lblName.Text = "Name: " +name.ToString();
            lblUsername.Text = "Username: " +username.ToString();
            lblEmail.Text = "Email: " +email.ToString();
        }

        public void lblName_Click(object sender, EventArgs e)
        {
           
           

        }

            public void lblUsername_Click(object sender, EventArgs e)
        {
            
        }

        public void lblEmail_Click(object sender, EventArgs e)
        {
         
        }
    }
}
