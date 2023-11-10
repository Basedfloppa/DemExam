using Npgsql;
using System;
using System.Windows.Forms;

namespace DistEkzamen_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();   
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "Вход";
            label1.Text = "Логин";
            label2.Text = "Пароль";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            using (var connection = new NpgsqlConnection(config.connection))
            {
                connection.Open();

                var command = new NpgsqlCommand();
                
                command.CommandText = $"SELECT * FROM users WHERE login='{textBox1.Text}' AND password='{textBox2.Text}'";
                command.Connection = connection;
                var user = command.ExecuteReader();

                if (user.HasRows)
                {
                    user.Read();
                    switch (user[3])
                    {
                        case "admin":
                            Admin formAdmin = new Admin();
                            formAdmin.Show();
                            this.Hide();
                            break;
                        case "cook":
                            Povar formPovar = new Povar();
                            formPovar.Show();
                            this.Hide();
                            break;
                        case "waiter":
                            Oficiant formOficiant = new Oficiant();
                            formOficiant.Show();
                            this.Hide();
                            break;
                    }

                    user.Close();
                    connection.Close();
                }
            }
        }
    }
}
