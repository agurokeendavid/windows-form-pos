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
    public partial class payment : Form
    {
        public payment()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void payment_Load(object sender, EventArgs e)
        {
            bunifuMetroTextbox3.Text = Login.Menu.pass;
            bunifuMetroTextbox5.Text = Login.Menu.diss;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double tots = (Convert.ToInt32(bunifuMetroTextbox3.Text));
                double amnt = (Convert.ToInt32(bunifuMetroTextbox2.Text));
                double change = amnt - tots;
                bunifuMetroTextbox4.Text = change.ToString();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("ENTER VALID PAYMENT!");
            }
        }
    }
}
