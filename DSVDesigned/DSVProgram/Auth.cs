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
            tbAuthor.Text = Login;
            tbBook.Text = Password;
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            Login = tbAuthor.Text;
            Password = tbBook.Text;

            Maintain addData = new Maintain();
            addData.Show();
            this.Hide();
        }
    }
}