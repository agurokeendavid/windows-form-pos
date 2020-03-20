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
    public partial class Accounting : Form
    {
        public Accounting()
        {
            InitializeComponent();
        }

        private void Accounting_Load(object sender, EventArgs e)
        {

            this.fin_statement_viewer.RefreshReport();
            this.pro_loss_viewer.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = purchase_datagrid.Rows.Add();

            purchase_datagrid.Rows[n].Cells[0].Value = purchase_item.Text;
            purchase_datagrid.Rows[n].Cells[1].Value = purchase_no.Text;
            purchase_datagrid.Rows[n].Cells[2].Value = item_price.Text;
            purchase_datagrid.Rows[n].Cells[3].Value = quanti.Text;
            purchase_datagrid.Rows[n].Cells[4].Value = total_purchase.Text;
            try
            {
                purchase_datagrid.Rows[n].Cells[5].Value = comboBox2.Text;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("Date Needed!");
            }
            try
            {
                purchase_datagrid.Rows[n].Cells[6].Value = comboBox3.Text;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("Supplier Needed!");
            }
            try
            {
                purchase_datagrid.Rows[n].Cells[7].Value = comboBox1.Text;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("Assigned Personnel Needed!");
            }           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int rowindex = purchase_datagrid.CurrentCell.RowIndex;
                purchase_datagrid.Rows.RemoveAt(rowindex);
            }
            catch (Exception x)
            {
                Console.WriteLine(x);
                MessageBox.Show("Row is Empty!");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int n = supplier_datagrid.Rows.Add();

            supplier_datagrid.Rows[n].Cells[0].Value = supp_name.Text;
            supplier_datagrid.Rows[n].Cells[1].Value = supp_add .Text;
            supplier_datagrid.Rows[n].Cells[2].Value = comboBox4.Text;
            supplier_datagrid.Rows[n].Cells[3].Value = email.Text;
            supplier_datagrid.Rows[n].Cells[4].Value = supp_num.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int rowindex = supplier_datagrid.CurrentCell.RowIndex;
                supplier_datagrid.Rows.RemoveAt(rowindex);
            }
            catch (Exception x)
            {
                Console.WriteLine(x);
                MessageBox.Show("Row is Empty!");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int n = bacc_datagrid.Rows.Add();

            bacc_datagrid.Rows[n].Cells[0].Value = bacc.Text;
            bacc_datagrid.Rows[n].Cells[1].Value = acc_num.Text;
            bacc_datagrid.Rows[n].Cells[2].Value = acc_name.Text;
            bacc_datagrid.Rows[n].Cells[3].Value = bunifuDatepicker1.Text;
            bacc_datagrid.Rows[n].Cells[4].Value = card.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                int rowindex = bacc_datagrid.CurrentCell.RowIndex;
                bacc_datagrid.Rows.RemoveAt(rowindex);
            }
            catch (Exception x)
            {
                Console.WriteLine(x);
                MessageBox.Show("Row is Empty!");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int n = expenses_datagrid.Rows.Add();

            expenses_datagrid.Rows[n].Cells[0].Value = expense_desc.Text;
            expenses_datagrid.Rows[n].Cells[1].Value = amount.Text;
            expenses_datagrid.Rows[n].Cells[2].Value = assigned.Text;
            expenses_datagrid.Rows[n].Cells[3].Value = bunifuDatepicker2.Text;
            expenses_datagrid.Rows[n].Cells[4].Value = dept.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                int rowindex = expenses_datagrid.CurrentCell.RowIndex;
                expenses_datagrid.Rows.RemoveAt(rowindex);
            }
            catch (Exception x)
            {
                Console.WriteLine(x);
                MessageBox.Show("Row is Empty!");
            }
        }

        private void item_price_TextChanged(object sender, EventArgs e)
        {
            try
            {
                total_purchase.Text = (double.Parse(item_price.Text) * double.Parse(quanti.Text)).ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                total_purchase.Text = "0";
            }
        }

        private void quanti_TextChanged(object sender, EventArgs e)
        {
            try
            {
                total_purchase.Text = (double.Parse(item_price.Text) * double.Parse(quanti.Text)).ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                total_purchase.Text = "0";
            }
        }
    }
}
