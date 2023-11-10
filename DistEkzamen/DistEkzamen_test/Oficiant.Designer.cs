namespace DistEkzamen_test
{
    partial class Oficiant
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
            this.принятыеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списоеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lable = new System.Windows.Forms.Label();
            this.create = new System.Windows.Forms.Button();
            this.state = new System.Windows.Forms.ComboBox();
            this.description = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.state_change = new System.Windows.Forms.ComboBox();
            this.row_change = new System.Windows.Forms.ComboBox();
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
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // заказыToolStripMenuItem
            // 
            this.заказыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.принятыеToolStripMenuItem,
            this.списоеToolStripMenuItem});
            this.заказыToolStripMenuItem.Name = "заказыToolStripMenuItem";
            this.заказыToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.заказыToolStripMenuItem.Text = "Заказы";
            // 
            // принятыеToolStripMenuItem
            // 
            this.принятыеToolStripMenuItem.Name = "принятыеToolStripMenuItem";
            this.принятыеToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.принятыеToolStripMenuItem.Text = "Создать";
            // 
            // списоеToolStripMenuItem
            // 
            this.списоеToolStripMenuItem.Name = "списоеToolStripMenuItem";
            this.списоеToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.списоеToolStripMenuItem.Text = "Список";
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 217);
            this.dataGridView1.TabIndex = 1;
            // 
            // lable
            // 
            this.lable.AutoSize = true;
            this.lable.Location = new System.Drawing.Point(12, 261);
            this.lable.Name = "lable";
            this.lable.Size = new System.Drawing.Size(72, 16);
            this.lable.TabIndex = 3;
            this.lable.Text = "Описание";
            // 
            // create
            // 
            this.create.Location = new System.Drawing.Point(531, 280);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(75, 23);
            this.create.TabIndex = 4;
            this.create.Text = "Создать";
            this.create.UseVisualStyleBackColor = true;
            // 
            // state
            // 
            this.state.FormattingEnabled = true;
            this.state.Location = new System.Drawing.Point(404, 280);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(121, 24);
            this.state.TabIndex = 5;
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(15, 280);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(383, 158);
            this.description.TabIndex = 6;
            this.description.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(415, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Состояние";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(667, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "изменить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // state_change
            // 
            this.state_change.FormattingEnabled = true;
            this.state_change.Location = new System.Drawing.Point(667, 310);
            this.state_change.Name = "state_change";
            this.state_change.Size = new System.Drawing.Size(121, 24);
            this.state_change.TabIndex = 9;
            // 
            // row_change
            // 
            this.row_change.FormattingEnabled = true;
            this.row_change.Location = new System.Drawing.Point(667, 341);
            this.row_change.Name = "row_change";
            this.row_change.Size = new System.Drawing.Size(121, 24);
            this.row_change.TabIndex = 10;
            // 
            // Oficiant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.row_change);
            this.Controls.Add(this.state_change);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.description);
            this.Controls.Add(this.state);
            this.Controls.Add(this.create);
            this.Controls.Add(this.lable);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Oficiant";
            this.Text = "Oficiant";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem заказыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem принятыеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списоеToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lable;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.ComboBox state;
        private System.Windows.Forms.RichTextBox description;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox state_change;
        private System.Windows.Forms.ComboBox row_change;
    }
}