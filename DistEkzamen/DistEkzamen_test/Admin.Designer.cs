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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.emloyees = new System.Windows.Forms.Button();
            this.shifts = new System.Windows.Forms.Button();
            this.orders = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 32);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(768, 367);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.Visible = false;
            // 
            // emloyees
            // 
            this.emloyees.Location = new System.Drawing.Point(17, 2);
            this.emloyees.Name = "emloyees";
            this.emloyees.Size = new System.Drawing.Size(112, 23);
            this.emloyees.TabIndex = 5;
            this.emloyees.Text = "Сотрудники";
            this.emloyees.UseVisualStyleBackColor = true;
            // 
            // shifts
            // 
            this.shifts.Location = new System.Drawing.Point(135, 2);
            this.shifts.Name = "shifts";
            this.shifts.Size = new System.Drawing.Size(133, 23);
            this.shifts.TabIndex = 6;
            this.shifts.Text = "Смены";
            this.shifts.UseVisualStyleBackColor = true;
            // 
            // orders
            // 
            this.orders.Location = new System.Drawing.Point(274, 2);
            this.orders.Name = "orders";
            this.orders.Size = new System.Drawing.Size(108, 23);
            this.orders.TabIndex = 0;
            this.orders.Text = "Заказы";
            this.orders.UseVisualStyleBackColor = true;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.orders);
            this.Controls.Add(this.shifts);
            this.Controls.Add(this.emloyees);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Admin";
            this.Text = "AdminMenu";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button emloyees;
        private System.Windows.Forms.Button shifts;
        private System.Windows.Forms.Button orders;
    }
}