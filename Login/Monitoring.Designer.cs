namespace Login
{
    partial class Monitoring
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.sales_rep = new System.Windows.Forms.TabPage();
            this.prod_rep = new System.Windows.Forms.TabPage();
            this.pro_loss = new System.Windows.Forms.TabPage();
            this.purch_rep = new System.Windows.Forms.TabPage();
            this.acc_ledge = new System.Windows.Forms.TabPage();
            this.emp_rep = new System.Windows.Forms.TabPage();
            this.sales_rep_viewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pro_rep_viewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.mon_proloss_viewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.purch_rep_viewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.acc_ledger = new Microsoft.Reporting.WinForms.ReportViewer();
            this.emp_rep_viewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabControl1.SuspendLayout();
            this.sales_rep.SuspendLayout();
            this.prod_rep.SuspendLayout();
            this.pro_loss.SuspendLayout();
            this.purch_rep.SuspendLayout();
            this.acc_ledge.SuspendLayout();
            this.emp_rep.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.sales_rep);
            this.tabControl1.Controls.Add(this.prod_rep);
            this.tabControl1.Controls.Add(this.pro_loss);
            this.tabControl1.Controls.Add(this.purch_rep);
            this.tabControl1.Controls.Add(this.acc_ledge);
            this.tabControl1.Controls.Add(this.emp_rep);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1316, 506);
            this.tabControl1.TabIndex = 0;
            // 
            // sales_rep
            // 
            this.sales_rep.BackColor = System.Drawing.Color.Transparent;
            this.sales_rep.Controls.Add(this.sales_rep_viewer);
            this.sales_rep.ForeColor = System.Drawing.Color.Black;
            this.sales_rep.Location = new System.Drawing.Point(4, 32);
            this.sales_rep.Name = "sales_rep";
            this.sales_rep.Padding = new System.Windows.Forms.Padding(3);
            this.sales_rep.Size = new System.Drawing.Size(1214, 642);
            this.sales_rep.TabIndex = 0;
            this.sales_rep.Text = "Sales Report";
            // 
            // prod_rep
            // 
            this.prod_rep.BackColor = System.Drawing.Color.Transparent;
            this.prod_rep.Controls.Add(this.pro_rep_viewer);
            this.prod_rep.ForeColor = System.Drawing.Color.Black;
            this.prod_rep.Location = new System.Drawing.Point(4, 32);
            this.prod_rep.Name = "prod_rep";
            this.prod_rep.Padding = new System.Windows.Forms.Padding(3);
            this.prod_rep.Size = new System.Drawing.Size(1214, 642);
            this.prod_rep.TabIndex = 1;
            this.prod_rep.Text = "Product Report";
            // 
            // pro_loss
            // 
            this.pro_loss.BackColor = System.Drawing.Color.Transparent;
            this.pro_loss.Controls.Add(this.mon_proloss_viewer);
            this.pro_loss.ForeColor = System.Drawing.Color.Black;
            this.pro_loss.Location = new System.Drawing.Point(4, 32);
            this.pro_loss.Name = "pro_loss";
            this.pro_loss.Size = new System.Drawing.Size(1214, 642);
            this.pro_loss.TabIndex = 2;
            this.pro_loss.Text = "Profit and Loss";
            // 
            // purch_rep
            // 
            this.purch_rep.BackColor = System.Drawing.Color.Transparent;
            this.purch_rep.Controls.Add(this.purch_rep_viewer);
            this.purch_rep.ForeColor = System.Drawing.Color.Black;
            this.purch_rep.Location = new System.Drawing.Point(4, 32);
            this.purch_rep.Name = "purch_rep";
            this.purch_rep.Size = new System.Drawing.Size(1214, 642);
            this.purch_rep.TabIndex = 3;
            this.purch_rep.Text = "Purchasing Report";
            // 
            // acc_ledge
            // 
            this.acc_ledge.BackColor = System.Drawing.Color.Transparent;
            this.acc_ledge.Controls.Add(this.acc_ledger);
            this.acc_ledge.ForeColor = System.Drawing.Color.Black;
            this.acc_ledge.Location = new System.Drawing.Point(4, 32);
            this.acc_ledge.Name = "acc_ledge";
            this.acc_ledge.Size = new System.Drawing.Size(1214, 642);
            this.acc_ledge.TabIndex = 4;
            this.acc_ledge.Text = "Account Ledger";
            // 
            // emp_rep
            // 
            this.emp_rep.BackColor = System.Drawing.Color.Transparent;
            this.emp_rep.Controls.Add(this.emp_rep_viewer);
            this.emp_rep.ForeColor = System.Drawing.Color.Black;
            this.emp_rep.Location = new System.Drawing.Point(4, 32);
            this.emp_rep.Name = "emp_rep";
            this.emp_rep.Size = new System.Drawing.Size(1308, 470);
            this.emp_rep.TabIndex = 5;
            this.emp_rep.Text = "Employee Report";
            // 
            // sales_rep_viewer
            // 
            this.sales_rep_viewer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sales_rep_viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sales_rep_viewer.Location = new System.Drawing.Point(3, 3);
            this.sales_rep_viewer.Name = "sales_rep_viewer";
            this.sales_rep_viewer.Size = new System.Drawing.Size(1208, 636);
            this.sales_rep_viewer.TabIndex = 0;
            // 
            // pro_rep_viewer
            // 
            this.pro_rep_viewer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pro_rep_viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pro_rep_viewer.DocumentMapWidth = 82;
            this.pro_rep_viewer.Location = new System.Drawing.Point(3, 3);
            this.pro_rep_viewer.Name = "pro_rep_viewer";
            this.pro_rep_viewer.Size = new System.Drawing.Size(1208, 636);
            this.pro_rep_viewer.TabIndex = 0;
            // 
            // mon_proloss_viewer
            // 
            this.mon_proloss_viewer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mon_proloss_viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mon_proloss_viewer.DocumentMapWidth = 84;
            this.mon_proloss_viewer.Location = new System.Drawing.Point(0, 0);
            this.mon_proloss_viewer.Name = "mon_proloss_viewer";
            this.mon_proloss_viewer.Size = new System.Drawing.Size(1214, 642);
            this.mon_proloss_viewer.TabIndex = 1;
            // 
            // purch_rep_viewer
            // 
            this.purch_rep_viewer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.purch_rep_viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.purch_rep_viewer.DocumentMapWidth = 84;
            this.purch_rep_viewer.Location = new System.Drawing.Point(0, 0);
            this.purch_rep_viewer.Name = "purch_rep_viewer";
            this.purch_rep_viewer.Size = new System.Drawing.Size(1214, 642);
            this.purch_rep_viewer.TabIndex = 1;
            // 
            // acc_ledger
            // 
            this.acc_ledger.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.acc_ledger.Dock = System.Windows.Forms.DockStyle.Fill;
            this.acc_ledger.DocumentMapWidth = 84;
            this.acc_ledger.Location = new System.Drawing.Point(0, 0);
            this.acc_ledger.Name = "acc_ledger";
            this.acc_ledger.Size = new System.Drawing.Size(1214, 642);
            this.acc_ledger.TabIndex = 1;
            // 
            // emp_rep_viewer
            // 
            this.emp_rep_viewer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.emp_rep_viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.emp_rep_viewer.DocumentMapWidth = 84;
            this.emp_rep_viewer.Location = new System.Drawing.Point(0, 0);
            this.emp_rep_viewer.Name = "emp_rep_viewer";
            this.emp_rep_viewer.Size = new System.Drawing.Size(1308, 470);
            this.emp_rep_viewer.TabIndex = 1;
            // 
            // Monitoring
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1316, 506);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Monitoring";
            this.Text = "Monitoring";
            this.Load += new System.EventHandler(this.Monitoring_Load);
            this.tabControl1.ResumeLayout(false);
            this.sales_rep.ResumeLayout(false);
            this.prod_rep.ResumeLayout(false);
            this.pro_loss.ResumeLayout(false);
            this.purch_rep.ResumeLayout(false);
            this.acc_ledge.ResumeLayout(false);
            this.emp_rep.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage sales_rep;
        private System.Windows.Forms.TabPage prod_rep;
        private System.Windows.Forms.TabPage pro_loss;
        private System.Windows.Forms.TabPage purch_rep;
        private System.Windows.Forms.TabPage acc_ledge;
        private System.Windows.Forms.TabPage emp_rep;
        private Microsoft.Reporting.WinForms.ReportViewer sales_rep_viewer;
        private Microsoft.Reporting.WinForms.ReportViewer pro_rep_viewer;
        private Microsoft.Reporting.WinForms.ReportViewer mon_proloss_viewer;
        private Microsoft.Reporting.WinForms.ReportViewer purch_rep_viewer;
        private Microsoft.Reporting.WinForms.ReportViewer acc_ledger;
        private Microsoft.Reporting.WinForms.ReportViewer emp_rep_viewer;
    }
}