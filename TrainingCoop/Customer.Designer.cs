namespace TrainingCoop
{
    partial class Customer
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
            bClose = new Button();
            bShow = new Button();
            bNew = new Button();
            customerName = new TextBox();
            customerCode = new TextBox();
            label2 = new Label();
            label1 = new Label();
            province = new ComboBox();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            bRemove = new Button();
            bEdit = new Button();
            bAdd = new Button();
            Column4 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // bClose
            // 
            bClose.Location = new Point(283, 271);
            bClose.Name = "bClose";
            bClose.Size = new Size(75, 23);
            bClose.TabIndex = 8;
            bClose.Text = "Close";
            bClose.UseVisualStyleBackColor = true;
            bClose.Click += bClose_Click;
            // 
            // bShow
            // 
            bShow.Location = new Point(187, 271);
            bShow.Name = "bShow";
            bShow.Size = new Size(75, 23);
            bShow.TabIndex = 7;
            bShow.Text = "Show";
            bShow.UseVisualStyleBackColor = true;
            bShow.Click += bShow_Click;
            // 
            // bNew
            // 
            bNew.Location = new Point(93, 271);
            bNew.Name = "bNew";
            bNew.Size = new Size(75, 23);
            bNew.TabIndex = 6;
            bNew.Text = "New";
            bNew.UseVisualStyleBackColor = true;
            bNew.Click += bNew_Click;
            // 
            // customerName
            // 
            customerName.Location = new Point(188, 144);
            customerName.Name = "customerName";
            customerName.Size = new Size(171, 23);
            customerName.TabIndex = 4;
            // 
            // customerCode
            // 
            customerCode.Location = new Point(188, 115);
            customerCode.Name = "customerCode";
            customerCode.Size = new Size(171, 23);
            customerCode.TabIndex = 3;
            customerCode.KeyDown += customerCode_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(94, 147);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 1;
            label2.Text = "ชื่อลูกค้า";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(94, 118);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 0;
            label1.Text = "รหัสลูกค้า";
            // 
            // province
            // 
            province.FormattingEnabled = true;
            province.Items.AddRange(new object[] { "เชียงราย", "พะเยา", "แพร่", "น่าน", "ลำปาง", "เชียงใหม่", "ลำพูน", "แม่ฮ่องสอน" });
            province.Location = new Point(188, 173);
            province.Name = "province";
            province.Size = new Size(171, 23);
            province.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(94, 176);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 2;
            label3.Text = "จังหวัด";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column4, Column1, Column2, Column3 });
            dataGridView1.Location = new Point(405, 115);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(459, 179);
            dataGridView1.TabIndex = 15;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // bRemove
            // 
            bRemove.BackColor = Color.Tomato;
            bRemove.Location = new Point(284, 224);
            bRemove.Name = "bRemove";
            bRemove.Size = new Size(75, 23);
            bRemove.TabIndex = 14;
            bRemove.Text = "Remove";
            bRemove.UseVisualStyleBackColor = false;
            bRemove.Click += bRemove_Click;
            // 
            // bEdit
            // 
            bEdit.BackColor = Color.Khaki;
            bEdit.Location = new Point(188, 224);
            bEdit.Name = "bEdit";
            bEdit.Size = new Size(75, 23);
            bEdit.TabIndex = 13;
            bEdit.Text = "Edit";
            bEdit.UseVisualStyleBackColor = false;
            bEdit.Click += bEdit_Click;
            // 
            // bAdd
            // 
            bAdd.BackColor = Color.YellowGreen;
            bAdd.Location = new Point(94, 224);
            bAdd.Name = "bAdd";
            bAdd.Size = new Size(75, 23);
            bAdd.TabIndex = 12;
            bAdd.Text = "Add";
            bAdd.UseVisualStyleBackColor = false;
            bAdd.Click += bAdd_Click;
            // 
            // Column4
            // 
            Column4.HeaderText = "No.";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 50;
            // 
            // Column1
            // 
            Column1.HeaderText = "Code";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Name";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 150;
            // 
            // Column3
            // 
            Column3.HeaderText = "Province";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Customer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(956, 450);
            Controls.Add(dataGridView1);
            Controls.Add(bRemove);
            Controls.Add(bEdit);
            Controls.Add(bAdd);
            Controls.Add(label3);
            Controls.Add(province);
            Controls.Add(bClose);
            Controls.Add(bShow);
            Controls.Add(bNew);
            Controls.Add(customerName);
            Controls.Add(customerCode);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Customer";
            Text = "Customer";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bClose;
        private Button bShow;
        private Button bNew;
        private TextBox customerName;
        private TextBox customerCode;
        private Label label2;
        private Label label1;
        private ComboBox province;
        private Label label3;
        private DataGridView dataGridView1;
        private Button bRemove;
        private Button bEdit;
        private Button bAdd;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
    }
}