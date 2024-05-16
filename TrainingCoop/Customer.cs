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
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void customerCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                customerName.Focus();
            }
        }

        private void bNew_Click(object sender, EventArgs e)
        {
            customerCode.Clear();
            customerName.Clear();
            province.Text = "";
            customerCode.Focus();
        }

        private void bShow_Click(object sender, EventArgs e)
        {
            MessageBox.Show(label1.Text + " = " + customerCode.Text + "\n" +
                            label2.Text + " = " + customerName.Text + "\n" +
                            label3.Text + " = " + province.Text, "ข้อมูลประเภทสินค้า");
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
                customerCode.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value + "";
                customerName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value + "";
                province.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value + "";
            }
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add();
            int r = dataGridView1.Rows.Count - 1;
            dataGridView1.Rows[r].Cells[0].Value = r + 1;
            dataGridView1.Rows[r].Cells[1].Value = customerCode.Text;
            dataGridView1.Rows[r].Cells[2].Value = customerName.Text;
            dataGridView1.Rows[r].Cells[3].Value = province.Text;
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                int r = dataGridView1.CurrentCell.RowIndex;
                dataGridView1.Rows[r].Cells[1].Value = customerCode.Text;
                dataGridView1.Rows[r].Cells[2].Value = customerName.Text;
                dataGridView1.Rows[r].Cells[3].Value = province.Text;
            }
        }

        private void bRemove_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count != 0)
            {
                int r = dataGridView1.CurrentCell.RowIndex;
                dataGridView1.Rows.RemoveAt(r);
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    dataGridView1.Rows[i].Cells[0].Value = i + 1;
                }
            }
            else
            {
                MessageBox.Show("ไม่มีข้อมูล");
            }
        }
    }
}
