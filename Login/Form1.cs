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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Cashier")
            {
                Menu m = new Menu();
                m.Show();
            }
            else if (comboBox1.Text == "Manager")
            {
                Manager mng = new Manager();
                mng.Show();
            }
            else if (comboBox1.Text == "Administrator")
            {
                Admin a = new Admin();
                a.Show();
            }
            else
            {
                MessageBox.Show("INVALID INPUT");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Name = "Cashier";
            comboBox1.Name = "Manager";
            comboBox1.Name = "Administrator";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
