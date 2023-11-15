//

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
        public Auth()
        {
            InitializeComponent();
        }

        public bool SuccessfullyAuth = false;

        private void Auth_Load(object sender, EventArgs e)
        {
            textBoxLogin.Text = "admin";
            textBoxPass.Text = "admin";
            labelInv.Visible = false;
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "" || textBoxPass.Text == "")
            {
                labelInv.Visible = true;
            }
            else
            {
                string AuthQUERY = "SELECT * FROM UserPass WHERE Login = @Login AND Password = @Password";
                SQLiteConnection AuthCONNECTION = new SQLiteConnection("Data Source=C:\\Users\\Alexander\\Desktop\\DemExam\\DSVDesigned\\DSVProgram\\DSVBD.db; Version=3;");
                AuthCONNECTION.Open();
                SQLiteCommand AuthCOMMAND = new SQLiteCommand(AuthQUERY, AuthCONNECTION);
                AuthCOMMAND.Parameters.AddWithValue("@Login", textBoxLogin.Text);
                AuthCOMMAND.Parameters.AddWithValue("@Password", textBoxPass.Text);
                SQLiteDataAdapter AuthADAPTER = new SQLiteDataAdapter(AuthCOMMAND);
                DataTable AuthDATATABLE = new DataTable();
                AuthADAPTER.Fill(AuthDATATABLE);

                if (AuthDATATABLE.Rows.Count > 0)
                {
                    SuccessfullyAuth = true;
                }
                else
                {
                    SuccessfullyAuth = false;
                    MessageBox.Show("Неизвестная ошибка", Text);
                    AuthCONNECTION.Close();
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