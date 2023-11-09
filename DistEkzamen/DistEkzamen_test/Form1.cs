﻿using Npgsql;
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
                
                command.CommandText = $"SELECT * FROM restaurant.users WHERE login='{textBox1.Text}' AND password='{textBox2.Text}'";
                command.Connection = connection;
                var user = command.ExecuteReader();

                if (user.Depth == 1)
                {
                    command.CommandText = $"SELECT users.orders FROM restaurant.users WHERE login = '{textBox1.Text}' AND password = '{textBox2.Text}'";
                    if (command.ExecuteReader().Depth == 1)
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
                    connection.Close();
                }
            }
        }
    }
}
