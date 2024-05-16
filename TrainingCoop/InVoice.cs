using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainingCoop
{
    public partial class Invoice : Form
    {
        public Invoice()
        {
            InitializeComponent();
            tNo.Text = "1";
        }

        private void customerCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                customerName.Focus();
            }
        }

        private void customerName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                customerProvince.Focus();
            }
        }

        private void customerProvince_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                itemCode.Focus();
            }
        }

        private void itemCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                itemName.Focus();
            }
        }

        private void itemName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                itemType.Focus();
            }
        }

        private void itemType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                itemPrice.Focus();
            }
        }

        private void itemPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                itemQty.Focus();
            }
        }

        private void itemQty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    double amt = double.Parse(itemPrice.Text) * double.Parse(itemQty.Text);
                    itemAmount.Text = amt.ToString("#,##0.00");
                }
                catch (Exception ex)
                {
                    itemAmount.Clear();
                    MessageBox.Show("ป้อนราคาหรือจำนวนไม่ถูกต้อง", "ข้อมูลผิดพลาด");
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                itemCode.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value + "";
                itemName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value + "";
                itemType.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value + "";
                itemPrice.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value + "";
                itemQty.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value + "";
                itemAmount.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value + "";
            }
        }
        private void bAdd_Click(object sender, EventArgs e)
        {
            
            try
            {
                double amt = double.Parse(itemAmount.Text);
                double totalAmt = double.Parse(totalAmount.Text);
                totalAmt = totalAmt + amt;
                totalAmount.Text = totalAmt.ToString("#,##0.00");
                dataGridView1.Rows.Add();
                int r = dataGridView1.Rows.Count - 1;
                
                dataGridView1.Rows[r].Cells[0].Value = r + 1;
                tNo.Text = r + 1 + "";
                dataGridView1.Rows[r].Cells[1].Value = itemCode.Text;
                dataGridView1.Rows[r].Cells[2].Value = itemName.Text;
                dataGridView1.Rows[r].Cells[3].Value = itemType.Text;
                dataGridView1.Rows[r].Cells[4].Value = itemPrice.Text;
                dataGridView1.Rows[r].Cells[5].Value = itemQty.Text;
                dataGridView1.Rows[r].Cells[6].Value = itemAmount.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ไม่ได้ รวม ราคา");
            }
        }
    }
}
