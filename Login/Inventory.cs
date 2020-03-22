using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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

        private void btnProductAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["POS_SYSTEM"].ConnectionString))
                {
                    connection.Open();
                    string query = @"INSERT INTO tbl_products (product_name, product_srp, product_cost, product_item_code, product_stocks, date_creation, product_category, supplier_id) VALUES (@product_name, @product_srp, @product_cost, @product_item_code, @product_stocks, @date_creation, @product_category, @supplier_id);";
                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.Add("product_name", MySqlDbType.VarChar).Value = txtProductName.Text;
                        command.Parameters.Add("product_srp", MySqlDbType.Decimal).Value = txtProductSRP.Text;
                        command.Parameters.Add("product_cost", MySqlDbType.Decimal).Value = txtProductCost.Text;
                        command.Parameters.Add("product_item_code", MySqlDbType.VarChar).Value = txtProductItemCode.Text;
                        command.Parameters.Add("product_stocks", MySqlDbType.Int32).Value = txtProductStocks.Text;
                        command.Parameters.Add("date_creation", MySqlDbType.Date).Value = DateTime.Today;
                        command.Parameters.Add("product_category", MySqlDbType.VarChar).Value = cmbProductCategory.Text;
                        command.Parameters.Add("supplier_id", MySqlDbType.Int32).Value = cmbProductSupplier.SelectedValue;
                        command.ExecuteNonQuery();
                        MessageBox.Show("Successfully Saved!");
                        Classes.InventoryMethods.LoadGridViewProductCreation(dtgProducts);
                        Classes.GlobalMethods.ClearItems(pnlProductCreation);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            Classes.InventoryMethods.LoadComboBoxSupplier(cmbProductSupplier);
            Classes.InventoryMethods.LoadGridViewProductCreation(dtgProducts);
            Classes.InventoryMethods.LoadComboBoxProducts(cmbProductNameOut);
            Classes.InventoryMethods.LoadComboBoxProducts(cmbProductNameIn);
            Classes.InventoryMethods.LoadGridViewProductStocksIn(dtgStocksIn);
            cmbProductSupplier.SelectedIndex = -1;
            cmbProductNameOut.SelectedIndex = -1;
            cmbProductNameIn.SelectedIndex = -1;
        }

        private void tabProductCreation_Leave(object sender, EventArgs e)
        {
            Classes.GlobalMethods.ClearItems(pnlProductCreation);
        }

        private void tabStockOut_Leave(object sender, EventArgs e)
        {
            Classes.GlobalMethods.ClearItems(pnlStockOut);
        }

        private void cmbProductNameOut_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Classes.InventoryMethods.LoadProductInformation(cmbProductNameOut, txtItemNumberOut, txtStocksOut, dtpDateCreationOut, cmbCategoryOut);
        }

        private void cmbProductNameIn_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Classes.InventoryMethods.LoadProductInformation(cmbProductNameIn, txtItemNoIn, txtStocksIn, dtpDateCreationIn, cmbCategoryIn);
        }

        private void tabStockIn_Leave(object sender, EventArgs e)
        {
            Classes.GlobalMethods.ClearItems(pnlStockIn);
        }

        private void btnAddIn_Click(object sender, EventArgs e)
        {
            try
            {
                using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["POS_SYSTEM"].ConnectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO tbl_product_stockin (product_id, product_stock_added, date_creation) VALUES (@product_id, @product_stock_added, @date_creation);";
                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.Add("product_id", MySqlDbType.Int32).Value = cmbProductNameIn.SelectedValue;
                        command.Parameters.Add("product_stock_added", MySqlDbType.Int32).Value = txtStocksAddedIn.Text;
                        command.Parameters.Add("date_creation", MySqlDbType.Date).Value = dtpDateCreationIn.Value;
                        command.ExecuteNonQuery();
                        MessageBox.Show("Successfully Saved!");
                        Classes.InventoryMethods.LoadGridViewProductStocksIn(dtgStocksIn);
                        Classes.GlobalMethods.ClearItems(pnlStockIn);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
