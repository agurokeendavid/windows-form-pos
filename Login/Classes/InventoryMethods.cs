using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
using Guna.UI.WinForms;
using Bunifu.Framework.UI;

namespace Login.Classes
{
    public static class InventoryMethods
    {

        public static void LoadProductInformation(MetroComboBox cmbProductName, GunaTextBox txtItemNumber, GunaTextBox txtStocks, BunifuDatepicker dtpDateCreation, MetroComboBox cmbCategory)
        {
            try
            {
                using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["POS_SYSTEM"].ConnectionString))
                {
                    connection.Open();
                    string query = "SELECT product_item_code, product_stocks, product_category FROM tbl_products WHERE product_id = @product_id;";
                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.Add("product_id", MySqlDbType.Int32).Value = cmbProductName.SelectedValue;
                        MySqlDataReader reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                txtItemNumber.Text = reader["product_item_code"].ToString();
                                txtStocks.Text = reader["product_stocks"].ToString();
                                dtpDateCreation.Value = DateTime.Today;
                                cmbCategory.Text = reader["product_category"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void LoadComboBoxProducts(ComboBox comboBox)
        {
            try
            {
                using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["POS_SYSTEM"].ConnectionString))
                {
                    connection.Open();
                    string query = "SELECT product_id, product_name FROM tbl_products ORDER BY product_name ASC;";
                    using (var command = new MySqlCommand(query, connection))
                    {
                        var da = new MySqlDataAdapter { SelectCommand = command };
                        var dt = new DataTable();

                        da.Fill(dt);
                        comboBox.DataSource = dt;
                        comboBox.DisplayMember = "product_name";
                        comboBox.ValueMember = "product_id";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void LoadComboBoxSupplier(ComboBox comboBox)
        {
            try
            {
                using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["POS_SYSTEM"].ConnectionString))
                {
                    connection.Open();
                    string query = "SELECT supplier_id, supplier_name FROM tbl_suppliers ORDER BY supplier_name ASC;";
                    using (var command = new MySqlCommand(query, connection))
                    {
                        var da = new MySqlDataAdapter { SelectCommand = command };
                        var dt = new DataTable();

                        da.Fill(dt);
                        
                        comboBox.DataSource = dt;
                        comboBox.DisplayMember = "supplier_name";
                        comboBox.ValueMember = "supplier_id";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void LoadGridViewProductStocksIn(DataGridView gridView)
        {
            try
            {
                using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["POS_SYSTEM"].ConnectionString))
                {
                    connection.Open();
                    string query = "SELECT prodin.stockin_id, prod.product_name, prod.product_srp, prod.product_cost, prod.product_item_code, prod.product_stocks, prod.date_creation, prod.product_category FROM tbl_product_stockin prodin INNER JOIN tbl_products prod ON prodin.product_id = prod.product_id ORDER BY prod.product_name ASC;";
                    using (var command = new MySqlCommand(query, connection))
                    {
                        var da = new MySqlDataAdapter { SelectCommand = command };
                        var dt = new DataTable();
                        da.Fill(dt);

                        gridView.AutoGenerateColumns = false;
                        gridView.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void LoadGridViewProductCreation(DataGridView gridView)
        {
            try
            {
                using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["POS_SYSTEM"].ConnectionString))
                {

                    connection.Open();
                    string query = @"SELECT prod.product_id, prod.product_name, CONCAT('₱',prod.product_srp) product_srp, CONCAT('₱', prod.product_cost) product_cost, prod.product_item_code, prod.product_stocks, date_format(prod.date_creation, '%M %d, %Y') AS date_creation, prod.product_category, supp.supplier_name FROM tbl_products prod INNER JOIN tbl_suppliers supp ON prod.supplier_id = supp.supplier_id ORDER BY prod.product_name ASC;";
                    using (var command = new MySqlCommand(query, connection))
                    {
                        var da = new MySqlDataAdapter { SelectCommand = command };
                        var dt = new DataTable();
                        da.Fill(dt);

                        gridView.AutoGenerateColumns = false;
                        gridView.DataSource = dt;
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
