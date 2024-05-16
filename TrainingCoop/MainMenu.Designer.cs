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
            Item = new ToolStripMenuItem();
            Employee = new ToolStripMenuItem();
            Customer = new ToolStripMenuItem();
            Department = new ToolStripMenuItem();
            ItemType = new ToolStripMenuItem();
            Invoice = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { เพมขอมลToolStripMenuItem, Invoice });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(984, 29);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // เพมขอมลToolStripMenuItem
            // 
            เพมขอมลToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { Item, Employee, Customer, Department, ItemType });
            เพมขอมลToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            เพมขอมลToolStripMenuItem.Name = "เพมขอมลToolStripMenuItem";
            เพมขอมลToolStripMenuItem.Size = new Size(82, 25);
            เพมขอมลToolStripMenuItem.Text = "เพิ่มข้อมูล";
            // 
            // Item
            // 
            Item.Name = "Item";
            Item.Size = new Size(195, 26);
            Item.Text = "ข้อมูลสินค้า";
            Item.Click += Item_Click;
            // 
            // Employee
            // 
            Employee.Name = "Employee";
            Employee.Size = new Size(195, 26);
            Employee.Text = "ข้อมูลพนักงาน";
            Employee.Click += Employee_Click;
            // 
            // Customer
            // 
            Customer.Name = "Customer";
            Customer.Size = new Size(195, 26);
            Customer.Text = "ข้อมูลลูกค้า";
            Customer.Click += Customer_Click;
            // 
            // Department
            // 
            Department.Name = "Department";
            Department.Size = new Size(195, 26);
            Department.Text = "ข้อมูลแผนก";
            Department.Click += Department_Click;
            // 
            // ItemType
            // 
            ItemType.Name = "ItemType";
            ItemType.Size = new Size(195, 26);
            ItemType.Text = "ข้อมูลประเภทสินค้า";
            ItemType.Click += ItemType_Click;
            // 
            // Invoice
            // 
            Invoice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Invoice.Name = "Invoice";
            Invoice.Size = new Size(47, 25);
            Invoice.Text = "ขาย";
            Invoice.Click += Invoice_Click;
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
        private ToolStripMenuItem Item;
        private ToolStripMenuItem Employee;
        private ToolStripMenuItem Customer;
        private ToolStripMenuItem Department;
        private ToolStripMenuItem ItemType;
        private ToolStripMenuItem Invoice;
    }
}