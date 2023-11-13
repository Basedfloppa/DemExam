namespace DistEkzamen_test
{
    partial class Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.emloyees = new System.Windows.Forms.Button();
            this.shifts = new System.Windows.Forms.Button();
            this.orders = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // emloyees
            // 
            this.emloyees.Location = new System.Drawing.Point(17, 2);
            this.emloyees.Name = "emloyees";
            this.emloyees.Size = new System.Drawing.Size(112, 23);
            this.emloyees.TabIndex = 5;
            this.emloyees.Text = "Сотрудники";
            this.emloyees.UseVisualStyleBackColor = true;
            this.emloyees.Click += new System.EventHandler(this.emloyees_Click);
            // 
            // shifts
            // 
            this.shifts.Location = new System.Drawing.Point(135, 2);
            this.shifts.Name = "shifts";
            this.shifts.Size = new System.Drawing.Size(133, 23);
            this.shifts.TabIndex = 6;
            this.shifts.Text = "Смены";
            this.shifts.UseVisualStyleBackColor = true;
            this.shifts.Click += new System.EventHandler(this.shifts_Click);
            // 
            // orders
            // 
            this.orders.Location = new System.Drawing.Point(274, 2);
            this.orders.Name = "orders";
            this.orders.Size = new System.Drawing.Size(108, 23);
            this.orders.TabIndex = 0;
            this.orders.Text = "Заказы";
            this.orders.UseVisualStyleBackColor = true;
            this.orders.Click += new System.EventHandler(this.orders_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(729, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Заказы";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(773, 407);
            this.dataGridView1.TabIndex = 8;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.orders);
            this.Controls.Add(this.shifts);
            this.Controls.Add(this.emloyees);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Admin";
            this.Text = "AdminMenu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Admin_FormClosing);
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button emloyees;
        private System.Windows.Forms.Button shifts;
        private System.Windows.Forms.Button orders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}