using MySql.Data.MySqlClient;
using System;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.IO;
using System.Windows.Forms;
using Bunifu.Framework.UI;

namespace Login.Classes
{
    public static class FilesMethod
    {
        public static void UploadPopUpDialog(string folderName, BunifuMaterialTextbox txtFileName, ref string sourceFile, ref string destinationFile)
        {
            using (var openfiledialog = new OpenFileDialog())
            {
                string path = $@"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\Point Of Sales\{folderName}";
                openfiledialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                openfiledialog.Title = "Select a word document to be upload.";
                openfiledialog.Filter = "Word|*.docx|PDF|*.pdf";
                openfiledialog.Multiselect = false;
                openfiledialog.ValidateNames = true;
                if (openfiledialog.ShowDialog() == DialogResult.OK)
                {
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                    string fileName = openfiledialog.SafeFileName;
                    txtFileName.Text = $"{fileName}";
                    sourceFile = openfiledialog.FileName;
                    destinationFile = $@"{path}\{fileName}";

                    int count = 1;
                    while (File.Exists(destinationFile))
                    {
                        destinationFile = $@"{path}\{count} - {fileName}";
                        count++;
                    }

                }
            }
        }
        public static void copyFile(string source, string des, BackgroundWorker worker)
        {
            FileStream fsout = new FileStream(des, FileMode.Create);
            FileStream fsin = new FileStream(source, FileMode.Open);
            byte[] bt = new byte[1048756];

            int readByte;

            while ((readByte = fsin.Read(bt, 0, bt.Length)) > 0)
            {
                fsout.Write(bt, 0, readByte);
                worker.ReportProgress((int)(fsin.Position * 100 / fsin.Length));
            }

            fsin.Close();
            fsout.Close();
        }

        public static void LoadGridViewInformation(DataGridView gridView)
        {
            try
            {
                using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["POS_SYSTEM"].ConnectionString))
                {
                    string query = "SELECT information_id, information_name, information_file, date_format(upload_date, '%M %d, %Y') AS upload_date, uploaded_by FROM tbl_informations ORDER BY information_id ASC;";
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

        public static void LoadGridViewPermits(DataGridView gridView)
        {
            try
            {
                using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["POS_SYSTEM"].ConnectionString))
                {
                    string query = "SELECT permit_id, permit_name, permit_file, date_format(upload_date, '%M %d, %Y') AS upload_date, uploaded_by FROM tbl_permits ORDER BY permit_id ASC;";
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


        public static void LoadGridViewReports(DataGridView gridView)
        {
            try
            {
                using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["POS_SYSTEM"].ConnectionString))
                {
                    string query = "SELECT report_id, report_name, report_file, date_format(upload_date, '%M %d, %Y') AS upload_date, uploaded_by FROM tbl_reports ORDER BY report_id ASC;";
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

        public static void LoadGridViewDocuments(DataGridView gridView)
        {
            try
            {
                using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["POS_SYSTEM"].ConnectionString))
                {
                    string query = "SELECT document_id, document_name, document_file, date_format(upload_date, '%M %d, %Y') AS upload_date, uploaded_by FROM tbl_documents ORDER BY document_id ASC;";
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
