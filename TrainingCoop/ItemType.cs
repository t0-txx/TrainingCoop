using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainingCoop
{
    public partial class ItemType : Form
    {
        public ItemType()
        {
            InitializeComponent();
        }
        private void typeCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                typeName.Focus();
            }
        }
        private void bNew_Click(object sender, EventArgs e)
        {
            typeCode.Clear();
            typeName.Clear();
            typeCode.Focus();
        }
        private void bShow_Click(object sender, EventArgs e)
        {
            MessageBox.Show(label1.Text + " = " + typeCode.Text + "\n" +
                            label2.Text + " = " + typeName.Text, "ข้อมูลประเภทสินค้า");
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("แน่ใจนะว่าจะปิด", "ยืนยัน", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1) 
            { 
                typeCode.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value + "";
                typeName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value + "";
            }
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add();
            int r = dataGridView1.Rows.Count - 1;
            dataGridView1.Rows[r].Cells[0].Value = typeCode.Text;
            dataGridView1.Rows[r].Cells[1].Value = typeName.Text;
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                int r = dataGridView1.CurrentCell.RowIndex;
                dataGridView1.Rows[r].Cells[0].Value = typeCode.Text;
                dataGridView1.Rows[r].Cells[1].Value = typeName.Text;
            }
        }

        private void bRemove_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count != 0)
            {
                int r = dataGridView1.CurrentCell.RowIndex;
                dataGridView1.Rows.RemoveAt(r);
            }
            else
            { 
                MessageBox.Show("ไม่มีข้อมูล");
            }
        }
    }
}
