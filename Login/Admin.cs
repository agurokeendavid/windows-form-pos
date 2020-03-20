using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Accounting ac = new Login.Accounting();
            ac.TopLevel = false;
            panel1.Controls.Add(ac);
            ac.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            ac.Dock = DockStyle.Fill;
            ac.Show();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Inventory it = new Login.Inventory();
            it.TopLevel = false;
            panel1.Controls.Add(it);
            it.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            it.Dock = DockStyle.Fill;
            it.Show();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            HR h = new Login.HR();
            h.TopLevel = false;
            panel1.Controls.Add(h);
            h.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            h.Dock = DockStyle.Fill;
            h.Show();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Monitoring mt = new Login.Monitoring();
            mt.TopLevel = false;
            panel1.Controls.Add(mt);
            mt.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            mt.Dock = DockStyle.Fill;
            mt.Show();
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Files f = new Login.Files();
            f.TopLevel = false;
            panel1.Controls.Add(f);
            f.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            f.Show();
        }

       
    }
}
