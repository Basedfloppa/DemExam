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
            this.state.DataSource = states;
            this.state.Visible = false;
            this.row.Visible = false;
            this.change_state_button.Visible = false;

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
        private void button1_Click(object sender, EventArgs e)
        {
            var list = new List<string> { };
            var count = this.dataGridView1.Rows.Count - 1;
            while (count > 0)
            {
                list.Add(count.ToString());
                count--;
            }

            row.DataSource = list;

            this.state.Visible = true;
            this.row.Visible = true;
            this.change_state_button.Visible = true;
        }
        private void change_state_button_Click(object sender, EventArgs e)
        {
            this.state.Visible = false;
            this.row.Visible = false;
            this.change_state_button.Visible = false;

            dt.Rows[Convert.ToInt32(row.SelectedItem) - 1][1] = state.Text;
            this.dataGridView1.DataSource = dt;
            this.dataGridView1.Update();
        }
    }
}