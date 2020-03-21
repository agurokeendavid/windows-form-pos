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
        

        private void Accounting_Load(object sender, EventArgs e)
        {
            this.fin_statement_viewer.RefreshReport();
            this.pro_loss_viewer.RefreshReport();
            Classes.AccountingMethods.LoadGridViewPurchases(dtgPurchases);
            Classes.AccountingMethods.LoadComboBoxEmployees(cmbPurchasesPersonAssign);
            Classes.AccountingMethods.LoadComboBoxSupplier(cmbPurchasesSupplier);
            Classes.AccountingMethods.LoadGridViewSupplier(dtgSupplier);
            Classes.AccountingMethods.LoadGridViewBankAccounts(dtgBankAccounts);
            Classes.AccountingMethods.LoadComboBoxEmployees(cmbExpensesPersonAssigned);
            Classes.AccountingMethods.LoadGridViewExpenses(dtgExpenses);
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
            Classes.GlobalMethods.ClearItems(pnlSupplier);
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
                        Classes.AccountingMethods.LoadGridViewSupplier(dtgSupplier);
                        Classes.GlobalMethods.ClearItems(pnlSupplier);
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
                        Classes.AccountingMethods.LoadGridViewPurchases(dtgPurchases);
                        Classes.GlobalMethods.ClearItems(pnlPurchases);
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
            Classes.GlobalMethods.ClearItems(pnlPurchases);
        }

        private void dtgPurchases_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            cmbPurchasesPersonAssign.Text = dtgPurchases.CurrentRow.Cells[8].Value.ToString();
            cmbPurchasesSupplier.Text = dtgPurchases.CurrentRow.Cells[7].Value.ToString();
        }

        private void btbnBankAccountAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["POS_SYSTEM"].ConnectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO tbl_bankaccounts (bankaccount, account_number, account_name, card_type, expiration) VALUES (@bankaccount, @account_number, @account_name, @card_type, @expiration);";
                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.Add("bankaccount", MySqlDbType.VarChar).Value = txtBankAccount.Text;
                        command.Parameters.Add("account_number", MySqlDbType.VarChar).Value = txtAccountNumber.Text;
                        command.Parameters.Add("account_name", MySqlDbType.VarChar).Value = txtAccountName.Text;
                        command.Parameters.Add("card_type", MySqlDbType.VarChar).Value = cmbCardType.Text;
                        command.Parameters.Add("expiration", MySqlDbType.Date).Value = dtpBankAccountExpiration.Value;
                        command.ExecuteNonQuery();
                        MessageBox.Show("Successfully Saved!");
                        Classes.AccountingMethods.LoadGridViewBankAccounts(dtgBankAccounts);
                        Classes.GlobalMethods.ClearItems(pnlBankAccounts);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tabBankAccounts_Leave(object sender, EventArgs e)
        {
            Classes.GlobalMethods.ClearItems(pnlBankAccounts);
        }

        private void dtgBankAccounts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBankAccount.Text = dtgBankAccounts.CurrentRow.Cells[1].Value.ToString();
            txtAccountNumber.Text = dtgBankAccounts.CurrentRow.Cells[2].Value.ToString();
            txtAccountName.Text = dtgBankAccounts.CurrentRow.Cells[3].Value.ToString();
            cmbCardType.Text = dtgBankAccounts.CurrentRow.Cells[5].Value.ToString();
            dtpBankAccountExpiration.Value = (DateTime)dtgBankAccounts.CurrentRow.Cells[4].Value;
        }

        private void btnExpensesAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["POS_SYSTEM"].ConnectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO tbl_expenses (expenses_desc, expenses_amount, employee_id, expenses_department, expenses_date) VALUES (@expenses_desc, @expenses_amount, @employee_id, @expenses_department, @expenses_date);";
                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.Add("expenses_desc", MySqlDbType.VarChar).Value = txtExpensesDesc.Text;
                        command.Parameters.Add("expenses_amount", MySqlDbType.Decimal).Value = txtExpensesAmount.Text;
                        command.Parameters.Add("employee_id", MySqlDbType.Int32).Value = cmbExpensesPersonAssigned.SelectedValue;
                        command.Parameters.Add("expenses_department", MySqlDbType.VarChar).Value = cmbExpensesDepartment.Text;
                        command.Parameters.Add("expenses_date", MySqlDbType.Date).Value = dtpExpensesDate.Value;
                        command.ExecuteNonQuery();
                        MessageBox.Show("Successfully Saved!");
                        Classes.AccountingMethods.LoadGridViewExpenses(dtgExpenses);
                        Classes.GlobalMethods.ClearItems(pnlExpenses);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tabExpenses_Leave(object sender, EventArgs e)
        {
            Classes.GlobalMethods.ClearItems(pnlExpenses);
        }

        private void dtgExpenses_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtExpensesDesc.Text = dtgExpenses.CurrentRow.Cells[1].Value.ToString();
            txtExpensesAmount.Text = dtgExpenses.CurrentRow.Cells[2].Value.ToString();
            cmbExpensesPersonAssigned.Text = dtgExpenses.CurrentRow.Cells[3].Value.ToString();
            cmbExpensesDepartment.Text = dtgExpenses.CurrentRow.Cells[5].Value.ToString();
            dtpExpensesDate.Value = (DateTime)dtgExpenses.CurrentRow.Cells[4].Value;
        }
    }
}
