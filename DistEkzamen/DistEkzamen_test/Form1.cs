using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace DistEkzamen_test
{
    public partial class Form1 : Form
    {
        DB_class dB_class = new DB_class();
        public Form1()
        {
            InitializeComponent();   
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "Вход";
            label1.Text = "Логин";
            label2.Text = "Пароль";
            label3.Text = "Должность";

            comboBox1.SelectedIndex = 0;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MySqlCommand command = DB_class.connection.CreateCommand();
            dB_class.openConnection();

            command.CommandText = $"SELECT * FROM restaurant.users WHERE login='{textBox1.Text}' AND password='{textBox2.Text}'";

            MySqlDataReader user = command.ExecuteReader();

            if (user.Depth == 1)
            {
                command.CommandText = $"SELECT users.orders FROM restaurant.users WHERE login = '{textBox1.Text}' AND password = '{textBox2.Text}'";
                if(command.ExecuteReader().Depth == 1)
                {
                    switch (user[3])
                    {
                        case 1:
                            Admin formAdmin = new Admin();
                            formAdmin.ShowDialog();
                            break;
                        case 2:
                            Povar formPovar = new Povar();
                            formPovar.ShowDialog();
                            break;
                        case 3:
                            Oficiant formOficiant = new Oficiant();
                            formOficiant.ShowDialog();
                            break;

                    }
                }
            }
            dB_class.closeConnection();
        }
    }
}
