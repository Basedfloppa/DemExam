﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DistEkzamen_test
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void всеЗаказыToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void списокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            button1.Visible = true;
            button2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddStaff formAdd = new AddStaff();
            formAdd.Show();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }
    }
}
