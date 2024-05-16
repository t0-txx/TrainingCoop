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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Item_Click(object sender, EventArgs e)
        {
            Item form = new Item();
            form.Show();
        }

        private void Employee_Click(object sender, EventArgs e)
        {
            Employee form = new Employee();
            form.Show();
        }

        private void Customer_Click(object sender, EventArgs e)
        {
            Customer form = new Customer();
            form.Show();
        }

        private void Department_Click(object sender, EventArgs e)
        {
            Department form = new Department();
            form.Show();
        }

        private void ItemType_Click(object sender, EventArgs e)
        {
            ItemType form = new ItemType();
            form.Show();
        }
    }
}
