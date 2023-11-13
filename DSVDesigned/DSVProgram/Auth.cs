using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DSVProgram
{
    public partial class Auth : Form
    {
        public String Login { get; set; }
        public String Password { get; set; }

        public Auth()
        {
            InitializeComponent();            
        }

        private void Auth_Load(object sender, EventArgs e)
        {
            Login = "Admin";
            Password = "Admin";
            textBoxLogin.Text = Login;
            textBoxPass.Text = Password;
            labelInv.Visible = false;
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            Login = textBoxLogin.Text;
            Password = textBoxPass.Text;

            if (Login == "" || Password == "")
            {
                labelInv.Visible = true;
            }
            else
            {
                Maintain addData = new Maintain();
                addData.Show();
                this.Hide();
            }
        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {
            labelInv.Visible = false;
        }

        private void textBoxPass_TextChanged(object sender, EventArgs e)
        {
            labelInv.Visible = false;
        }
    }
}