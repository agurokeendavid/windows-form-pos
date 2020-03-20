using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HashAlgorithm sha1 = new SHA1CryptoServiceProvider();
            var password = Encoding.Default.GetBytes(txtPassword.Text);
            var convertedPassword = BitConverter.ToString(sha1.ComputeHash(password)).ToLower().Replace("-", "");
            try
            {
                using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["POS_SYSTEM"].ConnectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM tbl_users WHERE username = @username AND password = @password AND user_type = @user_type;";
                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.Add("username", MySqlDbType.VarChar).Value = txtUsername.Text;
                        command.Parameters.Add("password", MySqlDbType.VarChar).Value = convertedPassword;
                        command.Parameters.Add("user_type", MySqlDbType.VarChar).Value = cmbAccountType.Text;
                        MySqlDataReader reader = command.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                switch (reader["user_type"].ToString())
                                {
                                    case "Cashier":
                                        var menu = new Menu();
                                        menu.ShowDialog();
                                        break;

                                    case "Manager":
                                        var manager = new Manager();
                                        manager.ShowDialog();
                                        break;

                                    case "Administrator":
                                        var admin = new Admin();
                                        admin.ShowDialog();
                                        break;

                                    default:
                                        break;
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("No account found!");
                        }
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
