using MySqlX.XDevAPI.Relational;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace DistEkzamen_test
{
    public partial class Oficiant : Form
    {
        DataTable dt = new DataTable();
        public Oficiant()
        {
            InitializeComponent();
        }

        private void Oficiant_Load(object sender, System.EventArgs e)
        {
            using (var connection = new NpgsqlConnection(config.connection))
            {
                connection.Open();

                var command = new NpgsqlCommand();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM orders WHERE orders.status = 'Принят' OR orders.status = 'Оплачен'";
                                
                dt.Load(command.ExecuteReader());

                this.dataGridView1.DataSource = dt;

                connection.Close();
            }
        }

        private void Oficiant_FormClosing(object sender, FormClosingEventArgs e)
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
