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
    public partial class Department : Form
    {
        public Department()
        {
            InitializeComponent();
        }

        private void departmentCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    if (dataGridView1.Rows[i].Cells[1].Value + "" == departmentCode.Text)
                    {
                        dataGridView1.CurrentCell = dataGridView1.Rows[i].Cells[0];
                        departmentName.Text = dataGridView1.Rows[i].Cells[2].Value + "";
                        break;
                    }
                }
                departmentName.Focus();
            }
        }

        private void bNew_Click(object sender, EventArgs e)
        {
            departmentCode.Clear();
            departmentName.Clear();
            departmentCode.Focus();
        }

        private void bShow_Click(object sender, EventArgs e)
        {
            MessageBox.Show(label1.Text + " = " + departmentCode.Text + "\n" +
                            label2.Text + " = " + departmentName.Text, "ข้อมูลแผนก");
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
                departmentCode.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value + "";
                departmentName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value + "";
                bTrue();
            }
        }

        private void detect()
        {
            dataGridView1.Rows.Add();
            int r = dataGridView1.Rows.Count - 1;
            dataGridView1.Rows[r].Cells[0].Value = r + 1;
            dataGridView1.Rows[r].Cells[1].Value = departmentCode.Text;
            dataGridView1.Rows[r].Cells[2].Value = departmentName.Text;
            bNew.PerformClick();
            bFalse();
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                detect();
            }
            else
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    if (dataGridView1.Rows[i].Cells[1].Value + "" != departmentCode.Text)
                    {
                        detect();
                        break;
                    }
                    else
                    {
                        MessageBox.Show("ข้อมูลซ้ำ");
                        bNew.PerformClick();
                        bFalse();
                        break;
                    }
                }
            }
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                int r = dataGridView1.CurrentCell.RowIndex;
                dataGridView1.Rows[r].Cells[1].Value = departmentCode.Text;
                dataGridView1.Rows[r].Cells[2].Value = departmentName.Text;
                bNew.PerformClick();
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
