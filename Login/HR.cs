using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace Login
{
    public partial class HR : Form
    {
        public HR()
        {
            InitializeComponent();
        }

        #region Functions
        private bool IsRequiredFieldsFillIn()
        {
            if (txtFirstName.Text != String.Empty && txtLastName.Text != String.Empty && cmbCivilStatus.Text != String.Empty && cmbGender.Text != String.Empty && txtAddress.Text != String.Empty && txtPIN.Text != String.Empty && cmbDepartment.Text != String.Empty && cmbPosition.Text != String.Empty && cmbStatus.Text != String.Empty && txtDailyRate.Text != String.Empty)
            {
                return true;
            }
            return false;
        }

        private byte[] ConvertImageToBinary(Image image)
        {
            using (var ms = new MemoryStream())
            {
                image.Save(ms, ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }
        #endregion

        private void HR_Load(object sender, EventArgs e)
        {
            reportViewer1.RefreshReport();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsRequiredFieldsFillIn())
            {
                try
                {
                    using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["POS_SYSTEM"].ConnectionString))
                    {
                        connection.Open();
                        string query = @"INSERT INTO tbl_employees (firstname, middlename, lastname, dob, civil_status, gender, address, father_name, mother_name, spouse, department, position, date_hired, status, daily_rate, sss, philhealth, tin, pagibig, picture, pin) VALUES (@firstname, @middlename, @lastname, @dob, @civil_status, @gender, @address, @father_name, @mother_name, @spouse, @department, @position, @date_hired, @status, @daily_rate, @sss, @philhealth, @tin, @pagibig, @picture, SHA1(@pin));";
                        using (var command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.Add("firstname", MySqlDbType.VarChar).Value = txtFirstName.Text;
                            command.Parameters.Add("middlename", MySqlDbType.VarChar).Value = txtMiddleName.Text;
                            command.Parameters.Add("lastname", MySqlDbType.VarChar).Value = txtLastName.Text;
                            command.Parameters.Add("dob", MySqlDbType.Date).Value = dtpDOB.Value;
                            command.Parameters.Add("civil_status", MySqlDbType.VarChar).Value = cmbCivilStatus.Text;
                            command.Parameters.Add("gender", MySqlDbType.VarChar).Value = cmbGender.Text;
                            command.Parameters.Add("address", MySqlDbType.VarChar).Value = txtAddress.Text;
                            command.Parameters.Add("father_name", MySqlDbType.VarChar).Value = txtFatherName.Text;
                            command.Parameters.Add("mother_name", MySqlDbType.VarChar).Value = txtMotherName.Text;
                            command.Parameters.Add("spouse", MySqlDbType.VarChar).Value = txtSpouse.Text;
                            command.Parameters.Add("department", MySqlDbType.VarChar).Value = cmbDepartment.Text;
                            command.Parameters.Add("position", MySqlDbType.VarChar).Value = cmbPosition.Text;
                            command.Parameters.Add("date_hired", MySqlDbType.Date).Value = dtpDateHired.Value;
                            command.Parameters.Add("status", MySqlDbType.VarChar).Value = cmbStatus.Text;
                            command.Parameters.Add("daily_rate", MySqlDbType.Decimal).Value = txtDailyRate.Text;
                            command.Parameters.Add("sss", MySqlDbType.VarChar).Value = txtSSS.Text;
                            command.Parameters.Add("philhealth", MySqlDbType.VarChar).Value = txtPhilhealth.Text;
                            command.Parameters.Add("tin", MySqlDbType.VarChar).Value = txtTIN.Text;
                            command.Parameters.Add("pagibig", MySqlDbType.VarChar).Value = txtPAGIBIG.Text;
                            command.Parameters.Add("picture", MySqlDbType.Blob).Value = ConvertImageToBinary(pbPhoto.Image);
                            command.Parameters.Add("pin", MySqlDbType.VarChar).Value = txtPIN.Text;
                            command.ExecuteNonQuery();
                            MessageBox.Show("Successfully Save!");
                            Classes.GlobalMethods.ClearItems(pnlBasicInfo);
                            Classes.GlobalMethods.ClearItems(pnlEmployeeInfo);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("One of your fields are required to fill in.");
            }
        }



        
        private void btnClear_Click(object sender, EventArgs e)
        {
            Classes.GlobalMethods.ClearItems(pnlBasicInfo);
            Classes.GlobalMethods.ClearItems(pnlEmployeeInfo);
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (var openfiledialog = new OpenFileDialog())
            {
                openfiledialog.Filter = "JPEG|*.jpg|PNG|*.png";
                openfiledialog.Multiselect = false;
                openfiledialog.ValidateNames = true;
                if (openfiledialog.ShowDialog() == DialogResult.OK)
                {
                    txtFileName.Text = $"{openfiledialog.FileName}";
                    pbPhoto.Image = Image.FromFile(openfiledialog.FileName);
                }
            }
        }
    }
}
