namespace DistEkzamen_test
{
    partial class Povar
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.заказыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.row = new System.Windows.Forms.ComboBox();
            this.state = new System.Windows.Forms.ComboBox();
            this.change_state_button = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.заказыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // заказыToolStripMenuItem
            // 
            this.заказыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.списокToolStripMenuItem});
            this.заказыToolStripMenuItem.Name = "заказыToolStripMenuItem";
            this.заказыToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.заказыToolStripMenuItem.Text = "Заказы";
            // 
            // списокToolStripMenuItem
            // 
            this.списокToolStripMenuItem.Name = "списокToolStripMenuItem";
            this.списокToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.списокToolStripMenuItem.Text = "Список";
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
            this.dataGridView1.Location = new System.Drawing.Point(16, 33);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(768, 367);
            this.dataGridView1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 407);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "Изменить статус";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // row
            // 
            this.row.FormattingEnabled = true;
            this.row.Location = new System.Drawing.Point(199, 407);
            this.row.Name = "row";
            this.row.Size = new System.Drawing.Size(121, 24);
            this.row.TabIndex = 3;
            // 
            // state
            // 
            this.state.FormattingEnabled = true;
            this.state.Location = new System.Drawing.Point(327, 407);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(121, 24);
            this.state.TabIndex = 4;
            // 
            // change_state_button
            // 
            this.change_state_button.Location = new System.Drawing.Point(455, 407);
            this.change_state_button.Name = "change_state_button";
            this.change_state_button.Size = new System.Drawing.Size(96, 23);
            this.change_state_button.TabIndex = 5;
            this.change_state_button.Text = "изменить";
            this.change_state_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.change_state_button.UseVisualStyleBackColor = true;
            this.change_state_button.Click += new System.EventHandler(this.change_state_button_Click);
            // 
            // Povar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.change_state_button);
            this.Controls.Add(this.state);
            this.Controls.Add(this.row);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Povar";
            this.Text = "Povar";
            this.Load += new System.EventHandler(this.Povar_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem заказыToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem списокToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox row;
        private System.Windows.Forms.ComboBox state;
        private System.Windows.Forms.Button change_state_button;
    }
}