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
    public partial class Monitoring : Form
    {
        public Monitoring()
        {
            InitializeComponent();
        }

        private void Monitoring_Load(object sender, EventArgs e)
        {

            this.sales_rep_viewer.RefreshReport();
            this.pro_rep_viewer.RefreshReport();
        }
    }
}
