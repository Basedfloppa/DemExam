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
            this.state.DataSource = new[] { "Принят", "Оплачен" };
            this.state_change.DataSource = new[] { "Принят", "Оплачен" };

            this.row_change.Visible = false;
            this.state_change.Visible = false;
            this.button_change_save.Visible = false;

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

        private void button_change_Click(object sender, System.EventArgs e)
        {
            this.row_change.Visible = true;
            this.state_change.Visible = true;
            this.button_change_save.Visible = true;

            var list = new List<string> { };
            var count = this.dataGridView1.Rows.Count - 1;
            while (count > 0)
            {
                list.Add(count.ToString());
                count--;
            }

            this.row_change.DataSource = list;
        }

        private void create_Click(object sender, System.EventArgs e)
        {
            using (var connection = new NpgsqlConnection(config.connection))
            {
                connection.Open();

                var command = new NpgsqlCommand();
                command.Connection = connection;
                command.CommandText = $"INSERT INTO orders(status,description) VALUES('{this.state.SelectedItem}','{this.description.Text}')";
                command.ExecuteNonQuery();

                this.description.Text = "";

                command.CommandText = "SELECT * FROM orders WHERE orders.status = 'Принят' OR orders.status = 'Оплачен'";

                dt.Load(command.ExecuteReader());

                this.dataGridView1.DataSource = dt;

                connection.Close();
            }
        }

        private void button_change_save_Click(object sender, System.EventArgs e)
        {
            this.state_change.Visible = false;
            this.row_change.Visible = false;
            this.button_change_save.Visible = false;

            dt.Rows[Convert.ToInt32(this.row_change.SelectedItem)-1][0] = state_change.Text;
            this.dataGridView1.DataSource = dt;
            this.dataGridView1.Update();
        }
    }
}
