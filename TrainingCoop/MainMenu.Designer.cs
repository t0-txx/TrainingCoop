namespace TrainingCoop
{
    partial class MainMenu
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
            menuStrip1 = new MenuStrip();
            เพมขอมลToolStripMenuItem = new ToolStripMenuItem();
            ขอมลสนคาToolStripMenuItem = new ToolStripMenuItem();
            ขอมลพนกงานToolStripMenuItem = new ToolStripMenuItem();
            ขอมลลกคาToolStripMenuItem = new ToolStripMenuItem();
            dataGridView1RowsrCells5ValueLabel6TextToolStripMenuItem = new ToolStripMenuItem();
            ขอมลประเภทสนคาToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { เพมขอมลToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(984, 29);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // เพมขอมลToolStripMenuItem
            // 
            เพมขอมลToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ขอมลสนคาToolStripMenuItem, ขอมลพนกงานToolStripMenuItem, ขอมลลกคาToolStripMenuItem, dataGridView1RowsrCells5ValueLabel6TextToolStripMenuItem, ขอมลประเภทสนคาToolStripMenuItem });
            เพมขอมลToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            เพมขอมลToolStripMenuItem.Name = "เพมขอมลToolStripMenuItem";
            เพมขอมลToolStripMenuItem.Size = new Size(82, 25);
            เพมขอมลToolStripMenuItem.Text = "เพิ่มข้อมูล";
            // 
            // ขอมลสนคาToolStripMenuItem
            // 
            ขอมลสนคาToolStripMenuItem.Name = "ขอมลสนคาToolStripMenuItem";
            ขอมลสนคาToolStripMenuItem.Size = new Size(195, 26);
            ขอมลสนคาToolStripMenuItem.Text = "ข้อมูลสินค้า";
            ขอมลสนคาToolStripMenuItem.Click += Item_Click;
            // 
            // ขอมลพนกงานToolStripMenuItem
            // 
            ขอมลพนกงานToolStripMenuItem.Name = "ขอมลพนกงานToolStripMenuItem";
            ขอมลพนกงานToolStripMenuItem.Size = new Size(195, 26);
            ขอมลพนกงานToolStripMenuItem.Text = "ข้อมูลพนักงาน";
            ขอมลพนกงานToolStripMenuItem.Click += Employee_Click;
            // 
            // ขอมลลกคาToolStripMenuItem
            // 
            ขอมลลกคาToolStripMenuItem.Name = "ขอมลลกคาToolStripMenuItem";
            ขอมลลกคาToolStripMenuItem.Size = new Size(195, 26);
            ขอมลลกคาToolStripMenuItem.Text = "ข้อมูลลูกค้า";
            ขอมลลกคาToolStripMenuItem.Click += Customer_Click;
            // 
            // dataGridView1RowsrCells5ValueLabel6TextToolStripMenuItem
            // 
            dataGridView1RowsrCells5ValueLabel6TextToolStripMenuItem.Name = "dataGridView1RowsrCells5ValueLabel6TextToolStripMenuItem";
            dataGridView1RowsrCells5ValueLabel6TextToolStripMenuItem.Size = new Size(195, 26);
            dataGridView1RowsrCells5ValueLabel6TextToolStripMenuItem.Text = "ข้อมูลแผนก";
            dataGridView1RowsrCells5ValueLabel6TextToolStripMenuItem.Click += Department_Click;
            // 
            // ขอมลประเภทสนคาToolStripMenuItem
            // 
            ขอมลประเภทสนคาToolStripMenuItem.Name = "ขอมลประเภทสนคาToolStripMenuItem";
            ขอมลประเภทสนคาToolStripMenuItem.Size = new Size(195, 26);
            ขอมลประเภทสนคาToolStripMenuItem.Text = "ข้อมูลประเภทสินค้า";
            ขอมลประเภทสนคาToolStripMenuItem.Click += ItemType_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 461);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainMenu";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem เพมขอมลToolStripMenuItem;
        private ToolStripMenuItem ขอมลสนคาToolStripMenuItem;
        private ToolStripMenuItem ขอมลพนกงานToolStripMenuItem;
        private ToolStripMenuItem ขอมลลกคาToolStripMenuItem;
        private ToolStripMenuItem dataGridView1RowsrCells5ValueLabel6TextToolStripMenuItem;
        private ToolStripMenuItem ขอมลประเภทสนคาToolStripMenuItem;
    }
}