using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace DistEkzamen_test
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void emloyees_Click(object sender, EventArgs e)
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
            using (var connection = new NpgsqlConnection(config.connection))
            {
                connection.Open();

                var command = new NpgsqlCommand();
                command.CommandText = "SELECT * FROM users";
                command.Connection = connection;

                var dt = new DataTable();
                dt.Load(command.ExecuteReader());
                dataGridView1.DataSource = dt;
                dataGridView1.Update();
                
                connection.Close();
            }
            label1.Text = "Сотрудники";
        }
        private void shifts_Click(object sender, EventArgs e)
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
            using (var connection = new NpgsqlConnection(config.connection))
            {
                connection.Open();

                var command = new NpgsqlCommand();
                command.CommandText = "SELECT * FROM shifts";
                command.Connection = connection;

                var dt = new DataTable();
                dt.Load(command.ExecuteReader());
                dataGridView1.DataSource = dt;
                dataGridView1.Update();

                connection.Close();
            }
            label1.Text = "Смены";
        }
        private void orders_Click(object sender, EventArgs e)
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
            using (var connection = new NpgsqlConnection(config.connection))
            {
                connection.Open();

                var command = new NpgsqlCommand();
                command.CommandText = "SELECT * FROM orders";
                command.Connection = connection;

                var dt = new DataTable();
                dt.Load(command.ExecuteReader());
                dataGridView1.DataSource = dt;
                dataGridView1.Update();

                connection.Close();
            }
            label1.Text = "Заказы";
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

                    command.CommandText =  "INSERT INTO users(id,login,password,name,job,job_status)" +
                                          $" VALUES({id},'{login}','{password}','{name}','{job}','{status}')" +
                                           " ON CONFLICT (id) DO UPDATE SET" +
                                          $" id = {id}, login = '{login}', password = '{password}', name = '{name}', job = '{job}', job_status = '{status}';";

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

                var dt = new DataTable();
                dt.Load(command.ExecuteReader());
                dataGridView1.DataSource = dt;
                dataGridView1.Update();

                connection.Close();
            }
        }
    }
}
