using Npgsql;
using System;
using System.Data;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DistEkzamen_test
{
    public partial class Povar : Form
    {
        public DataTable dt = new DataTable();
        public string[] states = new string[] { "Готовится", "Готово" };
        public Povar()
        {
            InitializeComponent();
        }

        private void Povar_Load(object sender, EventArgs e)
        {
            using (var connection = new NpgsqlConnection(config.connection))
            {
                connection.Open();

                var command = new NpgsqlCommand();
                command.CommandText = "SELECT * FROM orders WHERE orders.status = 'Оплачен' OR orders.status = 'Готовится' OR orders.status = 'Готов'";
                command.Connection = connection;

                dt.Load(command.ExecuteReader());

                this.dataGridView1.DataSource = dt;

                connection.Close();
            }
        }
        private void Povar_FormClosing(object sender, FormClosingEventArgs e)
        {
            using (var connection = new NpgsqlConnection(config.connection))
            {
                connection.Open();

                string status = "";
                string description = "";
                string id = "";

                var command = new NpgsqlCommand();
                command.Connection = connection;

                foreach (DataGridViewRow row in this.dataGridView1.Rows)
                {
                    if (row.Cells[0].Value == null) break;
                    
                    status = row.Cells[0].Value.ToString();
                    description = row.Cells[1].Value.ToString();
                    id = row.Cells[2].Value.ToString();

                    command.CommandText = $"INSERT INTO orders(id,status,description) VALUES({id},'{status}','{description}') ON CONFLICT (id) DO UPDATE SET id = {id}, status = '{status}', description = '{description}';";

                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
            Environment.Exit(0);
        }
    }
}