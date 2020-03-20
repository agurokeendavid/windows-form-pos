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
    public partial class Accounting : Form
    {
        public Accounting()
        {
            InitializeComponent();
        }

        private void LoadAllMethods()
        {
            LoadGridViewPurchases();
            LoadComboBoxEmployees();
            LoadComboBoxSupplier();
            LoadGridViewSupplier();
        }
        private void LoadComboBoxSupplier()
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

                        cmbPurchasesSupplier.DataSource = dt;
                        cmbPurchasesSupplier.DisplayMember = "supplier_name";
                        cmbPurchasesSupplier.ValueMember = "supplier_id";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadComboBoxEmployees()
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

                        cmbPurchasesPersonAssign.DataSource = dt;
                        cmbPurchasesPersonAssign.DisplayMember = "fullname";
                        cmbPurchasesPersonAssign.ValueMember = "employee_id";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadGridViewPurchases()
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

                        dtgPurchases.AutoGenerateColumns = false;
                        dtgPurchases.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadGridViewSupplier()
        {
            try
            {
                using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["POS_SYSTEM"].ConnectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM tbl_suppliers;";
                    using (var command = new MySqlCommand(query, connection))
                    {
                        var da = new MySqlDataAdapter { SelectCommand = command };
                        var dt = new DataTable();
                        da.Fill(dt);

                        dtgSupplier.AutoGenerateColumns = false;
                        dtgSupplier.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Accounting_Load(object sender, EventArgs e)
        {
            this.fin_statement_viewer.RefreshReport();
            this.pro_loss_viewer.RefreshReport();
            LoadAllMethods();
            
        }


        private void dtgSupplier_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSupplierName.Text = dtgSupplier.CurrentRow.Cells[1].Value.ToString();
            txtSupplierAddress.Text = dtgSupplier.CurrentRow.Cells[2].Value.ToString();
            txtSupplierContactNo.Text = dtgSupplier.CurrentRow.Cells[4].Value.ToString();
            txtSupplierEmail.Text = dtgSupplier.CurrentRow.Cells[3].Value.ToString();
        }


        private void tabSupplier_Leave(object sender, EventArgs e)
        {
            Classes.Methods.ClearItems(pnlSupplier);
        }

        private void btnSupplierAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["POS_SYSTEM"].ConnectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO tbl_suppliers (supplier_name, supplier_address, supplier_email, supplier_contact) VALUES (@supplier_name, @supplier_address, @supplier_email, @supplier_contact);";
                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.Add("supplier_name", MySqlDbType.VarChar).Value = txtSupplierName.Text;
                        command.Parameters.Add("supplier_address", MySqlDbType.VarChar).Value = txtSupplierAddress.Text;
                        command.Parameters.Add("supplier_email", MySqlDbType.VarChar).Value = txtSupplierEmail.Text;
                        command.Parameters.Add("supplier_contact", MySqlDbType.VarChar).Value = txtSupplierContactNo.Text;
                        command.ExecuteNonQuery();
                        MessageBox.Show("Successfully Saved!");
                        Classes.Methods.ClearItems(pnlSupplier);
                        LoadAllMethods();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPurchasesAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["POS_SYSTEM"].ConnectionString))
                {
                    connection.Open();
                    string query = @"INSERT INTO tbl_purchases (purchase_item, purchase_number, description, quantity, price, total_amount, employee_id, purchase_date, supplier_id) VALUES (@purchase_item, @purchase_number, @description, @quantity, @price, @total_amount, @employee_id, @purchase_date, @supplier_id);";
                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.Add("purchase_item", MySqlDbType.VarChar).Value = txtPurchasesItem.Text;
                        command.Parameters.Add("purchase_number", MySqlDbType.VarChar).Value = txtPurchasesNo.Text;
                        command.Parameters.Add("description", MySqlDbType.VarChar).Value = txtPurchasesDesc.Text;
                        command.Parameters.Add("quantity", MySqlDbType.Int32).Value = txtPurchasesQuanity.Text;
                        command.Parameters.Add("price", MySqlDbType.Decimal).Value = txtPurchasesPrice.Text;
                        command.Parameters.Add("total_amount", MySqlDbType.Decimal).Value = txtPurchasesTotal.Text;
                        command.Parameters.Add("employee_id", MySqlDbType.Int32).Value = cmbPurchasesPersonAssign.SelectedValue;
                        command.Parameters.Add("purchase_date", MySqlDbType.Date).Value = dtpPurchasesDate.Value;
                        command.Parameters.Add("supplier_id", MySqlDbType.Int32).Value = cmbPurchasesSupplier.SelectedValue;
                        command.ExecuteNonQuery();
                        MessageBox.Show("Successfully Saved!");
                        Classes.Methods.ClearItems(pnlPurchases);
                        LoadAllMethods();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tabPurchases_Leave(object sender, EventArgs e)
        {
            Classes.Methods.ClearItems(pnlPurchases);
        }

        private void dtgPurchases_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            cmbPurchasesPersonAssign.Text = dtgPurchases.CurrentRow.Cells[8].Value.ToString();
            cmbPurchasesSupplier.Text = dtgPurchases.CurrentRow.Cells[7].Value.ToString();
        }
    }
}
