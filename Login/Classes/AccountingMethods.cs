using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace Login.Classes
{
    public static class AccountingMethods
    {
        #region Methods
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
        public static void LoadComboBoxEmployees(ComboBox comboBox)
        {
            try
            {
                using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["POS_SYSTEM"].ConnectionString))
                {
                    connection.Open();
                    string query = "SELECT employee_id, CONCAT(firstname, ' ', middlename, ' ', lastname) fullname FROM tbl_employees ORDER BY lastname ASC;";
                    using (var command = new MySqlCommand(query, connection))
                    {
                        var da = new MySqlDataAdapter { SelectCommand = command };
                        var dt = new DataTable();

                        da.Fill(dt);

                        comboBox.DataSource = dt;
                        comboBox.DisplayMember = "fullname";
                        comboBox.ValueMember = "employee_id";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void LoadGridViewBankAccounts(DataGridView gridView)
        {
            try
            {
                using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["POS_SYSTEM"].ConnectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM tbl_bankaccounts ORDER BY bankaccount ASC;";
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
        public static void LoadGridViewPurchases(DataGridView gridView)
        {
            try
            {
                using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["POS_SYSTEM"].ConnectionString))
                {

                    connection.Open();
                    string query = @"SELECT purch.purchase_id, purch.purchase_item, purch.purchase_number, purch.description, purch.quantity, purch.price, purch.total_amount, CONCAT(emp.firstname, ' ', emp.middlename, ' ', emp.lastname) fullname, date_format(purch.purchase_date, '%M %d, %Y') AS purchase_date, supp.supplier_name FROM tbl_purchases purch INNER JOIN tbl_employees emp ON purch.employee_id = emp.employee_id INNER JOIN tbl_suppliers supp ON purch.supplier_id = supp.supplier_id ORDER BY purch.purchase_item ASC;";
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

        public static void LoadGridViewSupplier(DataGridView gridView)
        {
            try
            {
                using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["POS_SYSTEM"].ConnectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM tbl_suppliers ORDER BY supplier_name ASC;";
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

        public static void LoadGridViewExpenses(DataGridView gridView)
        {
            try
            {
                using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["POS_SYSTEM"].ConnectionString))
                {
                    connection.Open();
                    string query = "SELECT exp.expenses_id, exp.expenses_desc, exp.expenses_amount, CONCAT(emp.firstname, ' ', emp.middlename, ' ', emp.lastname) as fullname, exp.expenses_department, exp.expenses_date FROM tbl_expenses exp INNER JOIN tbl_employees emp ON exp.employee_id = emp.employee_id ORDER BY exp.expenses_amount DESC;";
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
        #endregion
    }
}
