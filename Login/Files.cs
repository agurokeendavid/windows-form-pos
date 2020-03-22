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
        private string destination;
        private string sourceFilePath;
        private readonly BackgroundWorker documentsWorker = new BackgroundWorker();
        private readonly BackgroundWorker reportsWorker = new BackgroundWorker();
        private readonly BackgroundWorker permitsWorker = new BackgroundWorker();
        private readonly BackgroundWorker informationWorker = new BackgroundWorker();
        private const string UPLOADED_BY = "Administrator";

        public Files()
        {
            InitializeComponent();
            documentsWorker.WorkerSupportsCancellation = true;
            documentsWorker.WorkerReportsProgress = true;
            documentsWorker.ProgressChanged += documentsWorker_ProgressChanged;
            documentsWorker.DoWork += documentsWorker_DoWork;
            reportsWorker.WorkerSupportsCancellation = true;
            reportsWorker.WorkerReportsProgress = true;
            reportsWorker.ProgressChanged += reportsWorker_ProgressChanged;
            reportsWorker.DoWork += reportsWorker_DoWork;
            permitsWorker.WorkerSupportsCancellation = true;
            permitsWorker.WorkerReportsProgress = true;
            permitsWorker.ProgressChanged += permitsWorker_ProgressChanged;
            permitsWorker.DoWork += permitsWorker_DoWork;
            informationWorker.WorkerSupportsCancellation = true;
            informationWorker.WorkerReportsProgress = true;
            informationWorker.ProgressChanged += informationWorker_ProgressChanged;
            informationWorker.DoWork += informationWorker_DoWork;
        }

        private void informationWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Classes.FilesMethod.copyFile(sourceFilePath, destination, informationWorker);
        }

        private void informationWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pbInformation.Value = e.ProgressPercentage;
            lblInformationPercentage.Text = $"{pbInformation.Value}%";
        }

        private void permitsWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pbPermits.Value = e.ProgressPercentage;
            lblPermitPercentage.Text = $"{pbPermits.Value}%";
        }

        private void permitsWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Classes.FilesMethod.copyFile(sourceFilePath, destination, permitsWorker);
        }

        private void documentsWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Classes.FilesMethod.copyFile(sourceFilePath, destination, documentsWorker);
        }

        private void documentsWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pbDocumentsFile.Value = e.ProgressPercentage;
            lblDocumentsFilePercent.Text = $"{pbDocumentsFile.Value}%";
        }

        private void reportsWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pbReports.Value = e.ProgressPercentage;
            lblReportsPercentage.Text = $"{pbReports.Value}%";
        }

        private void reportsWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Classes.FilesMethod.copyFile(sourceFilePath, destination, reportsWorker);
        }

        private void btnSaveDocuments_Click(object sender, EventArgs e)
        {
            if (txtDocumentsFileName.Text != String.Empty && sourceFilePath != null && destination != null)
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
                            command.Parameters.Add("document_file", MySqlDbType.VarChar).Value = destination;
                            command.Parameters.Add("upload_date", MySqlDbType.Date).Value = DateTime.Today;
                            command.Parameters.Add("uploaded_by", MySqlDbType.VarChar).Value = UPLOADED_BY;
                            documentsWorker.RunWorkerAsync();
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
            Classes.FilesMethod.UploadPopUpDialog("Document Section", txtDocumentsFileName, ref sourceFilePath, ref destination);
        }

        private void pnlDocuments_Leave(object sender, EventArgs e)
        {
            Classes.GlobalMethods.ClearItems(pnlDocuments);
        }

        private void btnDocumentsViewFile_Click(object sender, EventArgs e)
        {
            Process.Start(dtgDocuments.CurrentRow.Cells[2].Value.ToString());
        }

        private void btnReportUpload_Click(object sender, EventArgs e)
        {
            Classes.FilesMethod.UploadPopUpDialog("Report Section", txtReportsFileName, ref sourceFilePath, ref destination);
        }

        private void btnReportSave_Click(object sender, EventArgs e)
        {
            if (txtReportsFileName.Text != String.Empty && sourceFilePath != null && destination != null)
            {
                try
                {
                    using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["POS_SYSTEM"].ConnectionString))
                    {
                        connection.Open();
                        string query = "INSERT INTO tbl_reports (report_name, report_file, upload_date, uploaded_by) VALUES (@report_name, @report_file, @upload_date, @uploaded_by);";
                        using (var command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.Add("report_name", MySqlDbType.VarChar).Value = txtReportsFileName.Text;
                            command.Parameters.Add("report_file", MySqlDbType.VarChar).Value = destination;
                            command.Parameters.Add("upload_date", MySqlDbType.Date).Value = DateTime.Today;
                            command.Parameters.Add("uploaded_by", MySqlDbType.VarChar).Value = UPLOADED_BY;
                            reportsWorker.RunWorkerAsync();
                            command.ExecuteNonQuery();
                            MessageBox.Show("Successfully Saved!");
                            Classes.FilesMethod.LoadGridViewReports(dtgReports);
                            Classes.GlobalMethods.ClearItems(pnlReports);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void tabReports_Leave(object sender, EventArgs e)
        {
            Classes.GlobalMethods.ClearItems(pnlReports);
        }

        private void Files_Load(object sender, EventArgs e)
        {
            Classes.FilesMethod.LoadGridViewDocuments(dtgDocuments);
            Classes.FilesMethod.LoadGridViewReports(dtgReports);
            Classes.FilesMethod.LoadGridViewPermits(dtgPermits);
            Classes.FilesMethod.LoadGridViewInformation(dtgInformation);
        }

        private void btnPermitUpload_Click(object sender, EventArgs e)
        {
            Classes.FilesMethod.UploadPopUpDialog("Permit Section", txtPermitFilename, ref sourceFilePath, ref destination);
        }

        private void btnPermitSave_Click(object sender, EventArgs e)
        {
            if (txtPermitFilename.Text != String.Empty && sourceFilePath != null && destination != null)
            {
                try
                {
                    using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["POS_SYSTEM"].ConnectionString))
                    {
                        connection.Open();
                        string query = "INSERT INTO tbl_permits (permit_name, permit_file, upload_date, uploaded_by) VALUES (@permit_name, @permit_file, @upload_date, @uploaded_by);";
                        using (var command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.Add("permit_name", MySqlDbType.VarChar).Value = txtPermitFilename.Text;
                            command.Parameters.Add("permit_file", MySqlDbType.VarChar).Value = destination;
                            command.Parameters.Add("upload_date", MySqlDbType.Date).Value = DateTime.Today;
                            command.Parameters.Add("uploaded_by", MySqlDbType.VarChar).Value = UPLOADED_BY;
                            permitsWorker.RunWorkerAsync();
                            command.ExecuteNonQuery();
                            MessageBox.Show("Successfully Saved!");
                            Classes.FilesMethod.LoadGridViewPermits(dtgPermits);
                            Classes.GlobalMethods.ClearItems(pnlPermits);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnPermitView_Click(object sender, EventArgs e)
        {
            Process.Start(dtgPermits.CurrentRow.Cells[2].Value.ToString());
        }

        private void btnReportView_Click(object sender, EventArgs e)
        {
            Process.Start(dtgReports.CurrentRow.Cells[2].Value.ToString());
        }

        private void btnInformationUpload_Click(object sender, EventArgs e)
        {
            Classes.FilesMethod.UploadPopUpDialog("Information Section", txtInformationFileName, ref sourceFilePath, ref destination);
        }

        private void btnInformationSave_Click(object sender, EventArgs e)
        {
            if (txtInformationFileName.Text != String.Empty && sourceFilePath != null && destination != null)
            {
                try
                {
                    using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["POS_SYSTEM"].ConnectionString))
                    {
                        connection.Open();
                        string query = "INSERT INTO tbl_informations (information_name, information_file, upload_date, uploaded_by) VALUES (@information_name, @information_file, @upload_date, @uploaded_by);";
                        using (var command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.Add("information_name", MySqlDbType.VarChar).Value = txtInformationFileName.Text;
                            command.Parameters.Add("information_file", MySqlDbType.VarChar).Value = destination;
                            command.Parameters.Add("upload_date", MySqlDbType.Date).Value = DateTime.Today;
                            command.Parameters.Add("uploaded_by", MySqlDbType.VarChar).Value = UPLOADED_BY;
                            informationWorker.RunWorkerAsync();
                            command.ExecuteNonQuery();
                            MessageBox.Show("Successfully Saved!");
                            Classes.FilesMethod.LoadGridViewInformation(dtgInformation);
                            Classes.GlobalMethods.ClearItems(pnlInformation);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnInformationView_Click(object sender, EventArgs e)
        {
            Process.Start(dtgInformation.CurrentRow.Cells[2].Value.ToString());
        }

        private void tabDocuments_Leave(object sender, EventArgs e)
        {
            Classes.GlobalMethods.ClearItems(pnlDocuments);
        }

        private void tabPermits_Leave(object sender, EventArgs e)
        {
            Classes.GlobalMethods.ClearItems(pnlPermits);
        }

        private void tabInformation_Leave(object sender, EventArgs e)
        {
            Classes.GlobalMethods.ClearItems(pnlInformation);
        }
    }
}
