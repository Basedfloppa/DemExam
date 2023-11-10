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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заказыToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.списокToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.сменыToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.списокToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem,
            this.заказыToolStripMenuItem1,
            this.сменыToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.списокToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.менюToolStripMenuItem.Text = "Сотрудники";
            // 
            // списокToolStripMenuItem
            // 
            this.списокToolStripMenuItem.Name = "списокToolStripMenuItem";
            this.списокToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.списокToolStripMenuItem.Text = "Список";
            this.списокToolStripMenuItem.Click += new System.EventHandler(this.списокToolStripMenuItem_Click);
            // 
            // заказыToolStripMenuItem1
            // 
            this.заказыToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.списокToolStripMenuItem1});
            this.заказыToolStripMenuItem1.Name = "заказыToolStripMenuItem1";
            this.заказыToolStripMenuItem1.Size = new System.Drawing.Size(72, 24);
            this.заказыToolStripMenuItem1.Text = "Заказы";
            // 
            // списокToolStripMenuItem1
            // 
            this.списокToolStripMenuItem1.Name = "списокToolStripMenuItem1";
            this.списокToolStripMenuItem1.Size = new System.Drawing.Size(142, 26);
            this.списокToolStripMenuItem1.Text = "Список";
            // 
            // сменыToolStripMenuItem1
            // 
            this.сменыToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.списокToolStripMenuItem2});
            this.сменыToolStripMenuItem1.Name = "сменыToolStripMenuItem1";
            this.сменыToolStripMenuItem1.Size = new System.Drawing.Size(71, 24);
            this.сменыToolStripMenuItem1.Text = "Смены";
            // 
            // списокToolStripMenuItem2
            // 
            this.списокToolStripMenuItem2.Name = "списокToolStripMenuItem2";
            this.списокToolStripMenuItem2.Size = new System.Drawing.Size(142, 26);
            this.списокToolStripMenuItem2.Text = "Список";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 32);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(768, 367);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(684, 407);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "Уволить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(17, 406);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 4;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Admin";
            this.Text = "AdminMenu";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заказыToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem сменыToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem списокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem списокToolStripMenuItem2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}