using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace TrainingCoop
{
    public partial class Employee : Form
    {
        string sex = "";
        public Employee()
        {
            InitializeComponent();
            isSex();
        }

        private void employeeCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    if (dataGridView1.Rows[i].Cells[1].Value + "" == employeeCode.Text)
                    {
                        dataGridView1.CurrentCell = dataGridView1.Rows[i].Cells[0];
                        employeeCode.Text = dataGridView1.Rows[i].Cells[1].Value + "";
                        employeeName.Text = dataGridView1.Rows[i].Cells[2].Value + "";
                        Salary.Text = dataGridView1.Rows[i].Cells[3].Value + "";
                        string dataSex = dataGridView1.Rows[i].Cells[4].Value + "";
                        if (dataSex == mSex.Text)
                            mSex.Checked = true;
                        else if (dataSex == fSex.Text)
                            fSex.Checked = true;
                        else
                            noSex.Checked = true;
                        departmentName.Text = dataGridView1.Rows[i].Cells[5].Value + "";
                        label6.Text = dataGridView1.Rows[i].Cells[6].Value + "";
                        pictureBox1.Image = (Image)dataGridView1.Rows[i].Cells[7].Value;
                    }
                }
                employeeName.Focus();
            }
        }

        private void employeeName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Salary.Focus();
            }
        }

        private void bNew_Click(object sender, EventArgs e)
        {
            employeeCode.Clear();
            employeeName.Clear();
            Salary.Clear();
            mSex.Checked = false;
            fSex.Checked = false;
            noSex.Checked = false;
            departmentName.Text = "";
            employeeCode.Focus();
        }

        private void bShow_Click(object sender, EventArgs e)
        {
            isSex();
            MessageBox.Show(label1.Text + " = " + employeeCode.Text + "\n" +
                            label2.Text + " = " + employeeName.Text + "\n" +
                            label4.Text + " = " + Salary.Text + "\n" +
                            label5.Text + " = " + sex + "\n" +
                            label3.Text + " = " + departmentName.Text + "\n", "ข้อมูลพนักงาน");
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("แน่ใจนะว่าจะปิด", "ยืนยัน", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }
        private void isSex()
        {
            if (mSex.Checked)
            {
                sex = mSex.Text;
            }
            else if (fSex.Checked)
            {
                sex = fSex.Text;
            }
            else
            {
                sex = noSex.Text;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                employeeCode.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value + "";
                employeeName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value + "";
                Salary.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value + "";
                string dataSex = dataGridView1.Rows[e.RowIndex].Cells[4].Value + "";
                if (dataSex == mSex.Text)
                    mSex.Checked = true;
                else if (dataSex == fSex.Text)
                    fSex.Checked = true;
                else
                    noSex.Checked = true;
                departmentName.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value + "";
                label6.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value + "";
                pictureBox1.Image = (Image)dataGridView1.Rows[e.RowIndex].Cells[7].Value;
                //pictureBox1.Image = System.Drawing.Image.FromFile("F:\\รูป\\" + label6.Text);
            }
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            isSex();
            dataGridView1.Rows.Add();
            int r = dataGridView1.Rows.Count - 1;
            dataGridView1.Rows[r].Cells[0].Value = r + 1;
            dataGridView1.Rows[r].Cells[1].Value = employeeCode.Text;
            dataGridView1.Rows[r].Cells[2].Value = employeeName.Text;
            dataGridView1.Rows[r].Cells[3].Value = Salary.Text;
            dataGridView1.Rows[r].Cells[4].Value = sex;
            dataGridView1.Rows[r].Cells[5].Value = departmentName.Text;
            dataGridView1.Rows[r].Cells[6].Value = label6.Text;
            dataGridView1.Rows[r].Cells[7].Value = pictureBox1.Image;
            bNew.PerformClick();
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                isSex();
                int r = dataGridView1.CurrentCell.RowIndex;
                dataGridView1.Rows[r].Cells[1].Value = employeeCode.Text;
                dataGridView1.Rows[r].Cells[2].Value = employeeName.Text;
                dataGridView1.Rows[r].Cells[3].Value = Salary.Text;
                dataGridView1.Rows[r].Cells[4].Value = sex;
                dataGridView1.Rows[r].Cells[5].Value = departmentName.Text;
                dataGridView1.Rows[r].Cells[6].Value = label6.Text;
                dataGridView1.Rows[r].Cells[7].Value = pictureBox1.Image;
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

        private void bBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "openFileDialog1")
            {
                FileInfo fileInfo = new FileInfo(openFileDialog1.FileName);
                pictureBox1.Image = System.Drawing.Image.FromFile("F:\\รูป\\" + fileInfo.Name);
                label6.Text = fileInfo.Name;
            }
            else
            {
                MessageBox.Show("ไม่ได้เลือกรูปภาพ");
            }
        }
    }
}
