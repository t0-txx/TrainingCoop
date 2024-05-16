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
            itemAmount.Text = "0.00";
            totalAmount.Text = "0.00";
            tVat.Text = "0.00";
            tTotal.Text = "0.00";
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                tNo.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value + "";
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
                double Vat = 0.07, total = 0;
                totalAmt = totalAmt + amt;
                Vat = totalAmt * Vat;
                total = totalAmt - Vat;
                totalAmount.Text = totalAmt.ToString("#,##0.00");
                tVat.Text = Vat.ToString("#,##0.00");
                tTotal.Text = total.ToString("#,##0.00");

                dataGridView1.Rows.Add();
                int r = dataGridView1.Rows.Count - 1;
                dataGridView1.Rows[r].Cells[0].Value = r + 1;
                tNo.Text = int.Parse(dataGridView1.Rows[r].Cells[0].Value + "") + 1 + "";
                dataGridView1.Rows[r].Cells[1].Value = itemCode.Text;
                dataGridView1.Rows[r].Cells[2].Value = itemName.Text;
                dataGridView1.Rows[r].Cells[3].Value = itemType.Text;
                dataGridView1.Rows[r].Cells[4].Value = itemPrice.Text;
                dataGridView1.Rows[r].Cells[5].Value = itemQty.Text;
                dataGridView1.Rows[r].Cells[6].Value = itemAmount.Text;

                bNew.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ไม่ได้ รวม ราคา");
            }
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                int r = dataGridView1.CurrentCell.RowIndex;
                dataGridView1.Rows[r].Cells[1].Value = itemCode.Text;
                dataGridView1.Rows[r].Cells[2].Value = itemName.Text;
                dataGridView1.Rows[r].Cells[3].Value = itemType.Text;
                dataGridView1.Rows[r].Cells[4].Value = itemPrice.Text;
                dataGridView1.Rows[r].Cells[5].Value = itemQty.Text;

                double amt = double.Parse(itemAmount.Text);
                double totalAmt = double.Parse(totalAmount.Text);
                double editAmt = double.Parse(dataGridView1.Rows[r].Cells[6].Value + "");
                double Vat = 0.07, total = 0;
                totalAmt = (totalAmt - editAmt) + amt;
                Vat = totalAmt * Vat;
                total = totalAmt - Vat;
                totalAmount.Text = totalAmt.ToString("#,##0.00");
                tVat.Text = Vat.ToString("#,##0.00");
                tTotal.Text = total.ToString("#,##0.00");

                dataGridView1.Rows[r].Cells[6].Value = itemAmount.Text;

                bNew.PerformClick();
            }
        }

        private void bRemove_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count != 0)
            {
                int r = dataGridView1.CurrentCell.RowIndex;

                double amt = double.Parse(dataGridView1.Rows[r].Cells[6].Value + "");
                double totalAmt = double.Parse(totalAmount.Text);
                double Vat = 0.07, total = 0;
                totalAmt = totalAmt - amt;
                Vat = totalAmt * Vat;
                total = totalAmt - Vat;
                totalAmount.Text = totalAmt.ToString("#,##0.00");
                tVat.Text = Vat.ToString("#,##0.00");
                tTotal.Text = total.ToString("#,##0.00");

                dataGridView1.Rows.RemoveAt(r);
                tNo.Text = dataGridView1.Rows.Count + 1 + "";
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    dataGridView1.Rows[i].Cells[0].Value = i + 1;
                }

                bNew.PerformClick();
            }
            else
            {
                MessageBox.Show("ไม่มีข้อมูล");
            }
        }

        private void employeeCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                employeeName.Focus();
            }
        }

        private void bNew_Click(object sender, EventArgs e)
        {
            itemCode.Clear();
            itemName.Clear();
            itemType.Clear();
            itemPrice.Clear();
            itemQty.Clear();
            itemAmount.Clear();
            itemCode.Focus();
        }

        private void bShow_Click(object sender, EventArgs e)
        {
            MessageBox.Show(label16.Text + "\t" + dateTimePicker1.Text + "\n\n" +
                           groupBox1.Text + "\n" +
                           label2.Text + "\t\t" + customerCode.Text + "\n" +
                           label3.Text + "\t\t" + customerName.Text + "\n" +
                           label4.Text + "\t\t" + customerProvince.Text + "\n\n" +
                           groupBox2.Text + "\n" +
                           label13.Text + "\t" + totalAmount.Text + "\n" +
                           label14.Text + "\t\t" + tVat.Text + "\n" +
                           label15.Text + "\t\t" + tTotal.Text + "\n\n" +
                           groupBox3.Text + "\n" +
                           label11.Text + "\t\t" + employeeCode.Text + "\n" +
                           label12.Text + "\t\t" + employeeName.Text + "\n", "Invoice");
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("แน่ใจนะว่าจะปิด", "ยืนยัน", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
