using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
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
        public SQLiteConnection DATABASE_Connect;
        public SQLiteCommand DATABASE_Cmd;

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
            DATABASE_Connect = new SQLiteConnection();
            DATABASE_Cmd = new SQLiteCommand();
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
                try
                {
                    String SQLRequest = "SELECT * FROM Login_new WHERE username = '" + Login + "' AND password = '" + Password + "'";
                    SQLiteDataAdapter SQLAdapt = new SQLiteDataAdapter(SQLRequest, DATABASE_Connect);
                    
                    DataTable DTB = new DataTable();
                    SQLAdapt.Fill(DTB);

                    if (DTB.Rows.Count > 0)
                    {
                        Maintain addData = new Maintain();
                        addData.Show();
                        this.Hide();
                    }
                    else
                    {
                        labelInv.Visible = true;
                    }
                }
                catch
                {
                    MessageBox.Show("Неизвестная ошибка", Text);
                }
                finally
                { 
                    DATABASE_Connect.Close();
                }
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