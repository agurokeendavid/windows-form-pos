using MySql.Data.MySqlClient;
using System;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Login
{
    public partial class Files : Form
    {
        private string destionationFilePath;
        private string sourceFilePath;
        private readonly BackgroundWorker worker = new BackgroundWorker();

        public Files()
        {
            InitializeComponent();
            worker.WorkerSupportsCancellation = true;
            worker.WorkerReportsProgress = true;
            worker.ProgressChanged += worker_ProgressChanged;
            worker.DoWork += Worker_DoWork;
            Classes.FilesMethod.LoadGridViewDocuments(dtgDocuments);
        }

        private void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pbDocumentsFile.Value = e.ProgressPercentage;
            lblDocumentsFilePercent.Text = $"{pbDocumentsFile.Value}%";
        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            Classes.FilesMethod.copyFile(sourceFilePath, destionationFilePath, worker);
        }

        private void btnSaveDocuments_Click(object sender, EventArgs e)
        {
            const string UPLOADED_BY = "Administrator";
            if (txtDocumentsFileName.Text != String.Empty && sourceFilePath != null && destionationFilePath != null)
            {
                try
                {
                    using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["POS_SYSTEM"].ConnectionString))
                    {
                        connection.Open();
                        string query = "INSERT INTO tbl_documents (document_name, document_file, upload_date, uploaded_by) VALUES (@document_name, @document_file, @upload_date, @uploaded_by);";
                        using (var command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.Add("document_name", MySqlDbType.VarChar).Value = txtDocumentsFileName.Text;
                            command.Parameters.Add("document_file", MySqlDbType.VarChar).Value = destionationFilePath;
                            command.Parameters.Add("upload_date", MySqlDbType.Date).Value = DateTime.Today;
                            command.Parameters.Add("uploaded_by", MySqlDbType.VarChar).Value = UPLOADED_BY;
                            worker.RunWorkerAsync();
                            command.ExecuteNonQuery();
                            MessageBox.Show("Successfully Saved!");
                            Classes.FilesMethod.LoadGridViewDocuments(dtgDocuments);
                            Classes.GlobalMethods.ClearItems(pnlDocuments);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnDocumentsUploadFile_Click(object sender, EventArgs e)
        {
            using (var openfiledialog = new OpenFileDialog())
            {
                string path = $@"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\PointOfSales";
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
                    txtDocumentsFileName.Text = $"{fileName}";
                    sourceFilePath = openfiledialog.FileName;
                    destionationFilePath = $@"{path}\{fileName}";

                    int count = 1;
                    while(File.Exists(destionationFilePath))
                    {
                        destionationFilePath = $@"{path}\{count} - {fileName}";
                        count++;
                    }
                        
                }
            }
        }

        private void pnlDocuments_Leave(object sender, EventArgs e)
        {
            Classes.GlobalMethods.ClearItems(pnlDocuments);
        }

        private void btnDocumentsViewFile_Click(object sender, EventArgs e)
        {
            Process.Start(dtgDocuments.CurrentRow.Cells[2].Value.ToString());
        }
    }
}
