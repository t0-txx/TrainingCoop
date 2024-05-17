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
    public partial class Item : Form
    {
        public Item()
        {
            InitializeComponent();
            amount.Text = 0 + "";
        }

        private void itemCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int i = searchCode();
                if (i >= 0)
                {
                    dataGridView1.CurrentCell = dataGridView1.Rows[i].Cells[0];
                    itemName.Text = dataGridView1.Rows[i].Cells[2].Value + "";
                    typeName.Text = dataGridView1.Rows[i].Cells[3].Value + "";
                    if (dataGridView1.Rows[i].Cells[4].Value + "" == Vat.Text)
                    {
                        Vat.Checked = true;
                    }
                    else
                    {
                        noVat.Checked = true;
                    }
                    price.Text = dataGridView1.Rows[i].Cells[5].Value + "";
                    qty.Text = dataGridView1.Rows[i].Cells[6].Value + "";
                    amount.Text = dataGridView1.Rows[i].Cells[7].Value + "";
                }
                itemName.Focus();
            }
        }

        private void itemName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                typeName.Focus();
            }
        }

        private void price_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                qty.Focus();
            }
        }

        private void qty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    double vat = 0, amt = double.Parse(price.Text) * double.Parse(qty.Text);
                    if (Vat.Checked)
                        vat = 0.07;
                    amt = amt - (amt * vat);
                    amount.Text = amt.ToString("#,##0.00");
                }
                catch (Exception ex)
                {
                    amount.Clear();
                    MessageBox.Show("ป้อนราคาหรือจำนวนไม่ถูกต้อง", "ข้อมูลผิดพลาด");
                }
            }
        }

        string isVat = "";
        private void clearVat()
        {
            price.Clear();
            qty.Clear();
            amount.Clear();
            price.Focus();
        }

        private void Vat_CheckedChanged(object sender, EventArgs e)
        {
            clearVat();
            isVat = Vat.Text + "";
        }

        private void noVat_CheckedChanged(object sender, EventArgs e)
        {
            clearVat();
            isVat = noVat.Text + "";
        }

        private void bNew_Click(object sender, EventArgs e)
        {
            itemCode.Clear();
            itemName.Clear();
            typeName.Text = "";
            Vat.Checked = false;
            noVat.Checked = false;
            price.Clear();
            qty.Clear();
            amount.Clear();
            itemCode.Focus();
        }

        private void bShow_Click(object sender, EventArgs e)
        {
            MessageBox.Show(label1.Text + " = " + itemCode.Text + "\n" +
                            label2.Text + " = " + itemName.Text + "\n" +
                            label3.Text + " = " + typeName.Text + "\n" +
                            label7.Text + " = " + isVat + "\n" +
                            label4.Text + " = " + price.Text + "\n" +
                            label5.Text + " = " + qty.Text + "\n" +
                            label6.Text + " = " + amount.Text + "\n", "ข้อมูลสินค้า");
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("แน่ใจนะว่าจะปิด", "ยืนยัน", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void bTrue()
        {
            bEdit.Enabled = true;
            bRemove.Enabled = true;
        }

        private void bFalse()
        {
            bEdit.Enabled = false;
            bRemove.Enabled = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                itemCode.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value + "";
                itemName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value + "";
                typeName.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value + "";
                if (dataGridView1.Rows[e.RowIndex].Cells[4].Value + "" == Vat.Text)
                    Vat.Checked = true;
                else
                    noVat.Checked = true;
                price.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value + "";
                qty.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value + "";
                amount.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value + "";
                itemCode.Focus();
                bTrue();
            }
        }

        private int searchCode()
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (dataGridView1.Rows[i].Cells[1].Value + "" == itemCode.Text)
                {
                    return i;
                }
            }
            return -1;
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            int index = searchCode();
            if (index >= 0)
            {
                MessageBox.Show("รหัสซ้ำ");
                bNew.PerformClick();
                return;
            }

            dataGridView1.Rows.Add();
            int r = dataGridView1.Rows.Count - 1;
            dataGridView1.Rows[r].Cells[0].Value = r + 1;
            dataGridView1.Rows[r].Cells[1].Value = itemCode.Text;
            dataGridView1.Rows[r].Cells[2].Value = itemName.Text;
            dataGridView1.Rows[r].Cells[3].Value = typeName.Text;
            dataGridView1.Rows[r].Cells[4].Value = isVat;
            dataGridView1.Rows[r].Cells[5].Value = price.Text;
            dataGridView1.Rows[r].Cells[6].Value = qty.Text;
            dataGridView1.Rows[r].Cells[7].Value = amount.Text;

            try
            {
                double amt = double.Parse(amount.Text);
                double totalAmt = double.Parse(totalAmount.Text);
                totalAmt = totalAmt + amt;
                totalAmount.Text = totalAmt.ToString("#,##0.00");
            }
            catch (Exception ex)
            {
            }

            bNew.PerformClick();
            bFalse();
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                int r = dataGridView1.CurrentCell.RowIndex;
                dataGridView1.Rows[r].Cells[1].Value = itemCode.Text;
                dataGridView1.Rows[r].Cells[2].Value = itemName.Text;
                dataGridView1.Rows[r].Cells[3].Value = typeName.Text;
                dataGridView1.Rows[r].Cells[4].Value = isVat;
                dataGridView1.Rows[r].Cells[5].Value = price.Text;
                dataGridView1.Rows[r].Cells[6].Value = qty.Text;

                double amt = double.Parse(amount.Text);
                double totalAmt = double.Parse(totalAmount.Text);
                double editAmt = double.Parse(dataGridView1.Rows[r].Cells[7].Value + "");
                totalAmt = (totalAmt - editAmt) + amt;
                totalAmount.Text = totalAmt.ToString("#,##0.00");

                dataGridView1.Rows[r].Cells[7].Value = amount.Text;
                bNew.PerformClick();
                bFalse();
            }
        }

        private void bRemove_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count != 0)
            {
                int r = dataGridView1.CurrentCell.RowIndex;
                double amt = double.Parse(dataGridView1.Rows[r].Cells[7].Value + "");
                double totalAmt = double.Parse(totalAmount.Text);
                totalAmt = totalAmt - amt;
                totalAmount.Text = totalAmt.ToString("#,##0.00");
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
            bNew.PerformClick();
            bFalse();
        }
    }
}
