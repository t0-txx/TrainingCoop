namespace TrainingCoop
{
    partial class Employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
            bClose = new Button();
            bShow = new Button();
            bNew = new Button();
            Salary = new TextBox();
            label4 = new Label();
            label1 = new Label();
            fSex = new RadioButton();
            label2 = new Label();
            mSex = new RadioButton();
            employeeCode = new TextBox();
            label3 = new Label();
            employeeName = new TextBox();
            departmentName = new ComboBox();
            label5 = new Label();
            noSex = new RadioButton();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewImageColumn();
            bRemove = new Button();
            bEdit = new Button();
            bAdd = new Button();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            bBrowse = new Button();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // bClose
            // 
            bClose.Location = new Point(225, 332);
            bClose.Name = "bClose";
            bClose.Size = new Size(75, 23);
            bClose.TabIndex = 14;
            bClose.Text = "Close";
            bClose.UseVisualStyleBackColor = true;
            bClose.Click += bClose_Click;
            // 
            // bShow
            // 
            bShow.Location = new Point(129, 332);
            bShow.Name = "bShow";
            bShow.Size = new Size(75, 23);
            bShow.TabIndex = 13;
            bShow.Text = "Show";
            bShow.UseVisualStyleBackColor = true;
            bShow.Click += bShow_Click;
            // 
            // bNew
            // 
            bNew.Location = new Point(35, 332);
            bNew.Name = "bNew";
            bNew.Size = new Size(75, 23);
            bNew.TabIndex = 12;
            bNew.Text = "New";
            bNew.UseVisualStyleBackColor = true;
            bNew.Click += bNew_Click;
            // 
            // Salary
            // 
            Salary.Location = new Point(129, 131);
            Salary.Name = "Salary";
            Salary.Size = new Size(171, 23);
            Salary.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 134);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 2;
            label4.Text = "เงินเดือน";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 76);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 0;
            label1.Text = "รหัสพนักงาน";
            // 
            // fSex
            // 
            fSex.AccessibleDescription = "";
            fSex.AutoSize = true;
            fSex.Location = new Point(129, 185);
            fSex.Name = "fSex";
            fSex.Size = new Size(47, 19);
            fSex.TabIndex = 9;
            fSex.TabStop = true;
            fSex.Text = "หญิง";
            fSex.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 105);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 1;
            label2.Text = "ชื่อพนักงาน";
            // 
            // mSex
            // 
            mSex.AutoSize = true;
            mSex.Location = new Point(129, 160);
            mSex.Name = "mSex";
            mSex.Size = new Size(43, 19);
            mSex.TabIndex = 8;
            mSex.TabStop = true;
            mSex.Text = "ชาย";
            mSex.UseVisualStyleBackColor = true;
            // 
            // employeeCode
            // 
            employeeCode.Location = new Point(129, 73);
            employeeCode.Name = "employeeCode";
            employeeCode.Size = new Size(171, 23);
            employeeCode.TabIndex = 5;
            employeeCode.KeyDown += employeeCode_KeyDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 238);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 4;
            label3.Text = "ตำแหน่ง";
            // 
            // employeeName
            // 
            employeeName.Location = new Point(129, 102);
            employeeName.Name = "employeeName";
            employeeName.Size = new Size(171, 23);
            employeeName.TabIndex = 6;
            employeeName.KeyDown += employeeName_KeyDown;
            // 
            // departmentName
            // 
            departmentName.FormattingEnabled = true;
            departmentName.Items.AddRange(new object[] { "บัญชี", "ตลาด", "ขาย", "บุคคล", "IT" });
            departmentName.Location = new Point(129, 235);
            departmentName.Name = "departmentName";
            departmentName.Size = new Size(171, 23);
            departmentName.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 164);
            label5.Name = "label5";
            label5.Size = new Size(25, 15);
            label5.TabIndex = 3;
            label5.Text = "เพศ";
            // 
            // noSex
            // 
            noSex.AccessibleDescription = "";
            noSex.AutoSize = true;
            noSex.Location = new Point(129, 210);
            noSex.Name = "noSex";
            noSex.Size = new Size(53, 19);
            noSex.TabIndex = 10;
            noSex.TabStop = true;
            noSex.Text = "ไม่ระบุ";
            noSex.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dataGridView1.Location = new Point(35, 373);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(715, 120);
            dataGridView1.TabIndex = 18;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // Column1
            // 
            Column1.Frozen = true;
            Column1.HeaderText = "Code";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 50;
            // 
            // Column2
            // 
            Column2.Frozen = true;
            Column2.HeaderText = "Name";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 150;
            // 
            // Column3
            // 
            Column3.Frozen = true;
            Column3.HeaderText = "Salary";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.Frozen = true;
            Column4.HeaderText = "Sex";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 50;
            // 
            // Column5
            // 
            Column5.Frozen = true;
            Column5.HeaderText = "Department";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.Frozen = true;
            Column6.HeaderText = "Browse";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Resizable = DataGridViewTriState.True;
            Column6.Width = 160;
            // 
            // Column7
            // 
            Column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Column7.HeaderText = "Image";
            Column7.ImageLayout = DataGridViewImageCellLayout.Stretch;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Resizable = DataGridViewTriState.True;
            Column7.Width = 46;
            // 
            // bRemove
            // 
            bRemove.BackColor = Color.Tomato;
            bRemove.Location = new Point(225, 285);
            bRemove.Name = "bRemove";
            bRemove.Size = new Size(75, 23);
            bRemove.TabIndex = 17;
            bRemove.Text = "Remove";
            bRemove.UseVisualStyleBackColor = false;
            bRemove.Click += bRemove_Click;
            // 
            // bEdit
            // 
            bEdit.BackColor = Color.Khaki;
            bEdit.Location = new Point(129, 285);
            bEdit.Name = "bEdit";
            bEdit.Size = new Size(75, 23);
            bEdit.TabIndex = 16;
            bEdit.Text = "Edit";
            bEdit.UseVisualStyleBackColor = false;
            bEdit.Click += bEdit_Click;
            // 
            // bAdd
            // 
            bAdd.BackColor = Color.YellowGreen;
            bAdd.Location = new Point(35, 285);
            bAdd.Name = "bAdd";
            bAdd.Size = new Size(75, 23);
            bAdd.TabIndex = 15;
            bAdd.Text = "Add";
            bAdd.UseVisualStyleBackColor = false;
            bAdd.Click += bAdd_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(325, 73);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(385, 217);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(325, 308);
            label6.Name = "label6";
            label6.Size = new Size(0, 15);
            label6.TabIndex = 20;
            // 
            // bBrowse
            // 
            bBrowse.Location = new Point(325, 332);
            bBrowse.Name = "bBrowse";
            bBrowse.Size = new Size(385, 23);
            bBrowse.TabIndex = 21;
            bBrowse.Text = "Browse";
            bBrowse.UseVisualStyleBackColor = true;
            bBrowse.Click += bBrowse_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Employee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 541);
            Controls.Add(bBrowse);
            Controls.Add(label6);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridView1);
            Controls.Add(bRemove);
            Controls.Add(bEdit);
            Controls.Add(bAdd);
            Controls.Add(noSex);
            Controls.Add(label5);
            Controls.Add(bClose);
            Controls.Add(bShow);
            Controls.Add(bNew);
            Controls.Add(Salary);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(fSex);
            Controls.Add(label2);
            Controls.Add(mSex);
            Controls.Add(employeeCode);
            Controls.Add(label3);
            Controls.Add(employeeName);
            Controls.Add(departmentName);
            Name = "Employee";
            Text = "Employee";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button bClose;
        private Button bShow;
        private Button bNew;
        private TextBox Salary;
        private Label label4;
        private Label label1;
        private RadioButton fSex;
        private Label label2;
        private RadioButton mSex;
        private TextBox employeeCode;
        private Label label3;
        private TextBox employeeName;
        private ComboBox departmentName;
        private Label label5;
        private RadioButton noSex;
        private DataGridView dataGridView1;
        private Button bRemove;
        private Button bEdit;
        private Button bAdd;
        private PictureBox pictureBox1;
        private Label label6;
        private Button bBrowse;
        private OpenFileDialog openFileDialog1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewImageColumn Column7;
    }
}