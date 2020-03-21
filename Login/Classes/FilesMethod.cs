using MySql.Data.MySqlClient;
using System;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace Login.Classes
{
    public static class FilesMethod
    {
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

        public static void LoadGridViewDocuments(DataGridView gridView)
        {
            try
            {
                using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["POS_SYSTEM"].ConnectionString))
                {
                    string query = "SELECT * FROM tbl_documents ORDER BY document_name ASC;";
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
