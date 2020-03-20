using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int n = prod_create_datagrid.Rows.Add();

            prod_create_datagrid.Rows[n].Cells[0].Value = prod_name.Text;
            prod_create_datagrid.Rows[n].Cells[1].Value = code.Text;
            prod_create_datagrid.Rows[n].Cells[2].Value = category.Text;
            prod_create_datagrid.Rows[n].Cells[3].Value = srp.Text;
            prod_create_datagrid.Rows[n].Cells[4].Value = prod_cost.Text;
            prod_create_datagrid.Rows[n].Cells[5].Value = stonks.Text;
            prod_create_datagrid.Rows[n].Cells[6].Value = date.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int rowindex = prod_create_datagrid.CurrentCell.RowIndex;
                prod_create_datagrid.Rows.RemoveAt(rowindex);
            }
            catch (Exception x)
            {
                Console.WriteLine(x);
                MessageBox.Show("Row is Empty!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
