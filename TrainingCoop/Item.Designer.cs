namespace TrainingCoop
{
    partial class Item
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
            label1 = new Label();
            label2 = new Label();
            itemCode = new TextBox();
            itemName = new TextBox();
            typeName = new ComboBox();
            label3 = new Label();
            Vat = new RadioButton();
            noVat = new RadioButton();
            label4 = new Label();
            price = new TextBox();
            label5 = new Label();
            qty = new TextBox();
            label6 = new Label();
            amount = new TextBox();
            label7 = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            bRemove = new Button();
            bEdit = new Button();
            bAdd = new Button();
            totalAmount = new TextBox();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // bClose
            // 
            bClose.Location = new Point(229, 348);
            bClose.Name = "bClose";
            bClose.Size = new Size(75, 23);
            bClose.TabIndex = 15;
            bClose.Text = "Close";
            bClose.UseVisualStyleBackColor = true;
            bClose.Click += bClose_Click;
            // 
            // bShow
            // 
            bShow.Location = new Point(133, 348);
            bShow.Name = "bShow";
            bShow.Size = new Size(75, 23);
            bShow.TabIndex = 14;
            bShow.Text = "Show";
            bShow.UseVisualStyleBackColor = true;
            bShow.Click += bShow_Click;
            // 
            // bNew
            // 
            bNew.Location = new Point(39, 348);
            bNew.Name = "bNew";
            bNew.Size = new Size(75, 23);
            bNew.TabIndex = 13;
            bNew.Text = "New";
            bNew.UseVisualStyleBackColor = true;
            bNew.Click += bNew_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 71);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 0;
            label1.Text = "รหัสสินค้า";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 100);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 1;
            label2.Text = "ชื่อสินค้า";
            // 
            // itemCode
            // 
            itemCode.Location = new Point(133, 68);
            itemCode.Name = "itemCode";
            itemCode.Size = new Size(171, 23);
            itemCode.TabIndex = 5;
            itemCode.KeyDown += itemCode_KeyDown;
            // 
            // itemName
            // 
            itemName.Location = new Point(133, 97);
            itemName.Name = "itemName";
            itemName.Size = new Size(171, 23);
            itemName.TabIndex = 6;
            itemName.KeyDown += itemName_KeyDown;
            // 
            // typeName
            // 
            typeName.FormattingEnabled = true;
            typeName.Items.AddRange(new object[] { "เครื่องใช้ไฟฟ้า", "อุปกรณ์คอมพิวเตอร์", "อุปกรณ์สำนักงาน", "อุปโภค-บริโภค" });
            typeName.Location = new Point(133, 126);
            typeName.Name = "typeName";
            typeName.Size = new Size(171, 23);
            typeName.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 129);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 1;
            label3.Text = "ประเภทสินค้า";
            // 
            // Vat
            // 
            Vat.AutoSize = true;
            Vat.Location = new Point(133, 155);
            Vat.Name = "Vat";
            Vat.Size = new Size(58, 19);
            Vat.TabIndex = 8;
            Vat.TabStop = true;
            Vat.Text = "คิด Vat";
            Vat.UseVisualStyleBackColor = true;
            Vat.CheckedChanged += Vat_CheckedChanged;
            // 
            // noVat
            // 
            noVat.AccessibleDescription = "";
            noVat.AutoSize = true;
            noVat.Location = new Point(133, 180);
            noVat.Name = "noVat";
            noVat.Size = new Size(70, 19);
            noVat.TabIndex = 9;
            noVat.TabStop = true;
            noVat.Text = "ไม่คิด Vat";
            noVat.UseVisualStyleBackColor = true;
            noVat.CheckedChanged += noVat_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 208);
            label4.Name = "label4";
            label4.Size = new Size(29, 15);
            label4.TabIndex = 2;
            label4.Text = "ราคา";
            // 
            // price
            // 
            price.Location = new Point(133, 205);
            price.Name = "price";
            price.Size = new Size(171, 23);
            price.TabIndex = 10;
            price.KeyDown += price_KeyDown;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 237);
            label5.Name = "label5";
            label5.Size = new Size(37, 15);
            label5.TabIndex = 3;
            label5.Text = "จำนวน";
            // 
            // qty
            // 
            qty.Location = new Point(133, 234);
            qty.Name = "qty";
            qty.Size = new Size(171, 23);
            qty.TabIndex = 11;
            qty.KeyDown += qty_KeyDown;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(39, 266);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 4;
            label6.Text = "เป็นเงิน";
            // 
            // amount
            // 
            amount.Enabled = false;
            amount.Location = new Point(133, 263);
            amount.Name = "amount";
            amount.Size = new Size(171, 23);
            amount.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(39, 159);
            label7.Name = "label7";
            label7.Size = new Size(23, 15);
            label7.TabIndex = 16;
            label7.Text = "Vat";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dataGridView1.Location = new Point(345, 68);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(660, 300);
            dataGridView1.TabIndex = 22;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Code";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 50;
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
            Column3.HeaderText = "Type";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Vat";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 70;
            // 
            // Column5
            // 
            Column5.HeaderText = "Price";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.HeaderText = "Qty";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 40;
            // 
            // Column7
            // 
            Column7.HeaderText = "Amount";
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // bRemove
            // 
            bRemove.BackColor = Color.Tomato;
            bRemove.Location = new Point(229, 306);
            bRemove.Name = "bRemove";
            bRemove.Size = new Size(75, 23);
            bRemove.TabIndex = 21;
            bRemove.Text = "Remove";
            bRemove.UseVisualStyleBackColor = false;
            bRemove.Click += bRemove_Click;
            // 
            // bEdit
            // 
            bEdit.BackColor = Color.Khaki;
            bEdit.Location = new Point(133, 306);
            bEdit.Name = "bEdit";
            bEdit.Size = new Size(75, 23);
            bEdit.TabIndex = 20;
            bEdit.Text = "Edit";
            bEdit.UseVisualStyleBackColor = false;
            bEdit.Click += bEdit_Click;
            // 
            // bAdd
            // 
            bAdd.BackColor = Color.YellowGreen;
            bAdd.Location = new Point(39, 306);
            bAdd.Name = "bAdd";
            bAdd.Size = new Size(75, 23);
            bAdd.TabIndex = 19;
            bAdd.Text = "Add";
            bAdd.UseVisualStyleBackColor = false;
            bAdd.Click += bAdd_Click;
            // 
            // totalAmount
            // 
            totalAmount.Enabled = false;
            totalAmount.Location = new Point(834, 383);
            totalAmount.Name = "totalAmount";
            totalAmount.Size = new Size(171, 23);
            totalAmount.TabIndex = 24;
            totalAmount.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(740, 386);
            label8.Name = "label8";
            label8.Size = new Size(79, 15);
            label8.TabIndex = 23;
            label8.Text = "ราคารวมทั้งหมด";
            // 
            // Item
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1049, 453);
            Controls.Add(totalAmount);
            Controls.Add(label8);
            Controls.Add(dataGridView1);
            Controls.Add(bRemove);
            Controls.Add(bEdit);
            Controls.Add(bAdd);
            Controls.Add(label7);
            Controls.Add(amount);
            Controls.Add(label6);
            Controls.Add(bClose);
            Controls.Add(qty);
            Controls.Add(bShow);
            Controls.Add(label5);
            Controls.Add(bNew);
            Controls.Add(price);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(noVat);
            Controls.Add(label2);
            Controls.Add(Vat);
            Controls.Add(itemCode);
            Controls.Add(label3);
            Controls.Add(itemName);
            Controls.Add(typeName);
            Name = "Item";
            Text = "Item";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bClose;
        private Button bShow;
        private Button bNew;
        private Label label1;
        private Label label2;
        private TextBox itemCode;
        private TextBox itemName;
        private ComboBox typeName;
        private Label label3;
        private RadioButton Vat;
        private RadioButton noVat;
        private Label label4;
        private TextBox price;
        private Label label5;
        private TextBox qty;
        private Label label6;
        private TextBox amount;
        private Label label7;
        private DataGridView dataGridView1;
        private Button bRemove;
        private Button bEdit;
        private Button bAdd;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private TextBox totalAmount;
        private Label label8;
    }
}