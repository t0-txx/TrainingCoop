namespace TrainingCoop
{
    partial class ItemType
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
            label1 = new Label();
            label2 = new Label();
            typeCode = new TextBox();
            typeName = new TextBox();
            bNew = new Button();
            bShow = new Button();
            bClose = new Button();
            bAdd = new Button();
            bEdit = new Button();
            bRemove = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 142);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 0;
            label1.Text = "รหัสประเภทสินค้า";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(78, 171);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 1;
            label2.Text = "ชื่อประเภทสินค้า";
            // 
            // typeCode
            // 
            typeCode.Location = new Point(172, 139);
            typeCode.Name = "typeCode";
            typeCode.Size = new Size(171, 23);
            typeCode.TabIndex = 2;
            typeCode.KeyDown += typeCode_KeyDown;
            // 
            // typeName
            // 
            typeName.Location = new Point(172, 168);
            typeName.Name = "typeName";
            typeName.Size = new Size(171, 23);
            typeName.TabIndex = 3;
            // 
            // bNew
            // 
            bNew.Location = new Point(78, 266);
            bNew.Name = "bNew";
            bNew.Size = new Size(75, 23);
            bNew.TabIndex = 4;
            bNew.Text = "New";
            bNew.UseVisualStyleBackColor = true;
            bNew.Click += bNew_Click;
            // 
            // bShow
            // 
            bShow.Location = new Point(172, 266);
            bShow.Name = "bShow";
            bShow.Size = new Size(75, 23);
            bShow.TabIndex = 5;
            bShow.Text = "Show";
            bShow.UseVisualStyleBackColor = true;
            bShow.Click += bShow_Click;
            // 
            // bClose
            // 
            bClose.Location = new Point(268, 266);
            bClose.Name = "bClose";
            bClose.Size = new Size(75, 23);
            bClose.TabIndex = 6;
            bClose.Text = "Close";
            bClose.UseVisualStyleBackColor = true;
            bClose.Click += bClose_Click;
            // 
            // bAdd
            // 
            bAdd.BackColor = Color.YellowGreen;
            bAdd.Location = new Point(78, 219);
            bAdd.Name = "bAdd";
            bAdd.Size = new Size(75, 23);
            bAdd.TabIndex = 8;
            bAdd.Text = "Add";
            bAdd.UseVisualStyleBackColor = false;
            bAdd.Click += bAdd_Click;
            // 
            // bEdit
            // 
            bEdit.BackColor = Color.Khaki;
            bEdit.Location = new Point(172, 219);
            bEdit.Name = "bEdit";
            bEdit.Size = new Size(75, 23);
            bEdit.TabIndex = 9;
            bEdit.Text = "Edit";
            bEdit.UseVisualStyleBackColor = false;
            bEdit.Click += bEdit_Click;
            // 
            // bRemove
            // 
            bRemove.BackColor = Color.Tomato;
            bRemove.Location = new Point(268, 219);
            bRemove.Name = "bRemove";
            bRemove.Size = new Size(75, 23);
            bRemove.TabIndex = 10;
            bRemove.Text = "Remove";
            bRemove.UseVisualStyleBackColor = false;
            bRemove.Click += bRemove_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dataGridView1.Location = new Point(379, 139);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(348, 150);
            dataGridView1.TabIndex = 11;
            dataGridView1.CellClick += dataGridView1_CellClick;
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
            Column2.Width = 200;
            // 
            // ItemType
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(bRemove);
            Controls.Add(bEdit);
            Controls.Add(bAdd);
            Controls.Add(bClose);
            Controls.Add(bShow);
            Controls.Add(bNew);
            Controls.Add(typeName);
            Controls.Add(typeCode);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ItemType";
            Text = "ItemType";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox typeCode;
        private TextBox typeName;
        private Button bNew;
        private Button bShow;
        private Button bClose;
        private Button bAdd;
        private Button bEdit;
        private Button bRemove;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
    }
}