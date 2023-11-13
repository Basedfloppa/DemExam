using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DistEkzamen_test
{
    public partial class Admin : Form
    {
        public DataTable dt = new DataTable();
        public Admin()
        {
            InitializeComponent();
        }

        private void emloyees_Click(object sender, EventArgs e)
        {
            using (var connection = new NpgsqlConnection(config.connection))
            {
                connection.Open();

                var command = new NpgsqlCommand();
                command.CommandText = "SELECT * FROM users";
                command.Connection = connection;

                dt.Clear();
                dataGridView1.Update();

                dt.Load(command.ExecuteReader());
                this.dataGridView1.DataSource = dt;

                connection.Close();
            }
        }

        private void shifts_Click(object sender, EventArgs e)
        {
            using (var connection = new NpgsqlConnection(config.connection))
            {
                connection.Open();

                var command = new NpgsqlCommand();
                command.CommandText = "SELECT * FROM shifts";
                command.Connection = connection;

                dt.Clear();
                dataGridView1.Update();

                dt.Load(command.ExecuteReader());
                this.dataGridView1.DataSource = dt;

                connection.Close();
            }
        }

        private void orders_Click(object sender, EventArgs e)
        {
            using (var connection = new NpgsqlConnection(config.connection))
            {
                connection.Open();

                var command = new NpgsqlCommand();
                command.CommandText = "SELECT * FROM orders";
                command.Connection = connection;

                dt.Clear();
                dataGridView1.Update();

                dt.Load(command.ExecuteReader());
                this.dataGridView1.DataSource = dt;

                connection.Close();
            }
        }

        private void Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (this.label1.Text) 
            {
                case "Заказы":
                    orders_flush();
                    break;
                case "Сотрудники":
                    empolyees_flush();
                    break;
                case "Смены":
                    shifts_flush();
                    break;
            }

            Environment.Exit(0);
        }

        private void empolyees_flush()
        {
            string password;
            string login;
            string name;
            string job;
            string id;
            string status;

            using (var connection = new NpgsqlConnection(config.connection))
            {
                connection.Open();

                var command = new NpgsqlCommand();
                command.Connection = connection;

                foreach (DataGridViewRow row in this.dataGridView1.Rows)
                {
                    if (row.Cells[0].Value == null) break;

                    password = row.Cells[0].Value.ToString();
                    login = row.Cells[1].Value.ToString();
                    name = row.Cells[2].Value.ToString();
                    job = row.Cells[3].Value.ToString();
                    id = row.Cells[4].Value.ToString();
                    status = row.Cells[5].Value.ToString();

                    command.CommandText =  "INSERT INTO orders(id,password,login,name,job,status)" +
                                          $" VALUES({id},'{password}','{login}','{name}','{job}','{status}')" +
                                           " ON CONFLICT (id) DO UPDATE SET" +
                                          $" id = {id}, time_start = '{password}', time_end = '{login}', employees = '{name}', job = '{job}', status = '{status}';";

                    command.ExecuteNonQuery();
                }
            }
        }
        private void shifts_flush()
        {
            string time_start;
            string time_end;
            string id;
            string employees;

            using (var connection = new NpgsqlConnection(config.connection))
            {
                connection.Open();

                var command = new NpgsqlCommand();
                command.Connection = connection;

                foreach (DataGridViewRow row in this.dataGridView1.Rows)
                {
                    if (row.Cells[0].Value == null) break;

                    id = row.Cells[0].Value.ToString();
                    time_start = row.Cells[1].Value.ToString();
                    time_end = row.Cells[2].Value.ToString();
                    employees = row.Cells[3].Value.ToString();

                    command.CommandText = $"INSERT INTO orders(id,time_start,time_end,employees)" +
                                           " VALUES({id},'{time_end}','{time_start}','{employees}')" + 
                                           " ON CONFLICT (id) DO UPDATE SET" + 
                                           " id = {id}, time_start = '{time_start}', time_end = '{time_end}', employees = '{employees}';";

                    command.ExecuteNonQuery();
                }
            }
        }
        private void orders_flush()
        {
            string status;
            string description;
            string id;

            using (var connection = new NpgsqlConnection(config.connection))
            {
                connection.Open();

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
            }
        }
        private void Admin_Load(object sender, EventArgs e)
        {
            using (var connection = new NpgsqlConnection(config.connection))
            {
                connection.Open();

                var command = new NpgsqlCommand();
                command.CommandText = "SELECT * FROM orders";
                command.Connection = connection;

                dt.Clear();
                this.dataGridView1.DataSource = dt;

                dt.Load(command.ExecuteReader());
                this.dataGridView1.DataSource = dt;

                connection.Close();
            }
        }
    }
}
