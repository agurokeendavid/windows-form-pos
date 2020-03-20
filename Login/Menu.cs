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
    public partial class Menu : Form
    {
        public static string pass;
        public static string diss;
        public Menu()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void houseWineToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void mocktailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            
        }

        private void bunifuMetroTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox5_OnValueChanged(object sender, EventArgs e)
        {
            
        }

        private void bunifuMetroTextbox4_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n = dataGridView1.Rows.Add();

            dataGridView1.Rows[n].Cells[0].Value = bunifuMetroTextbox1.Text;
            dataGridView1.Rows[n].Cells[1].Value = bunifuMetroTextbox2.Text;
            dataGridView1.Rows[n].Cells[2].Value = bunifuMetroTextbox4.Text;
            dataGridView1.Rows[n].Cells[3].Value = bunifuMetroTextbox5.Text;

            decimal Total = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                Total += Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value);
            }
            textBox1.Text = Total.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton9_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            pass = textBox1.Text;
            diss = bunifuMetroTextbox3.Text;
            payment p = new payment();
            p.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            bunifuMetroTextbox1.Text = "Ovum";
            bunifuMetroTextbox4.Text = "250.00";
            bunifuMetroTextbox2.Text=bunifuCustomTextbox1.Text;
            bunifuCustomTextbox1.Clear();
            try
            {
                bunifuMetroTextbox5.Text = (double.Parse(bunifuMetroTextbox4.Text) * double.Parse(bunifuMetroTextbox2.Text)).ToString();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                bunifuMetroTextbox2.Text = "1";
                bunifuMetroTextbox5.Text = (double.Parse(bunifuMetroTextbox4.Text) * double.Parse(bunifuMetroTextbox2.Text)).ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bunifuMetroTextbox1.Text = "Amalaya";
            bunifuMetroTextbox4.Text = "199.00";
            bunifuMetroTextbox2.Text=bunifuCustomTextbox2.Text;
            bunifuCustomTextbox2.Clear();
            try
            {
                bunifuMetroTextbox5.Text = (double.Parse(bunifuMetroTextbox4.Text) * double.Parse(bunifuMetroTextbox2.Text)).ToString();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                bunifuMetroTextbox2.Text = "1";
                bunifuMetroTextbox5.Text = (double.Parse(bunifuMetroTextbox4.Text) * double.Parse(bunifuMetroTextbox2.Text)).ToString();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            bunifuMetroTextbox1.Text = "Sangria";
            bunifuMetroTextbox4.Text = "490.00";
            bunifuMetroTextbox2.Text = bunifuCustomTextbox3.Text;
            bunifuCustomTextbox3.Clear();
            try
            {
                bunifuMetroTextbox5.Text = (double.Parse(bunifuMetroTextbox4.Text) * double.Parse(bunifuMetroTextbox2.Text)).ToString();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                bunifuMetroTextbox2.Text = "1";
                bunifuMetroTextbox5.Text = (double.Parse(bunifuMetroTextbox4.Text) * double.Parse(bunifuMetroTextbox2.Text)).ToString();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            bunifuMetroTextbox1.Text = "Glogg";
            bunifuMetroTextbox4.Text = "200.00";
            bunifuMetroTextbox2.Text = bunifuCustomTextbox4.Text;
            bunifuCustomTextbox4.Clear();
            try
            {
                bunifuMetroTextbox5.Text = (double.Parse(bunifuMetroTextbox4.Text) * double.Parse(bunifuMetroTextbox2.Text)).ToString();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                bunifuMetroTextbox2.Text = "1";
                bunifuMetroTextbox5.Text = (double.Parse(bunifuMetroTextbox4.Text) * double.Parse(bunifuMetroTextbox2.Text)).ToString();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            bunifuMetroTextbox1.Text = "Frose";
            bunifuMetroTextbox4.Text = "300.00";
            bunifuMetroTextbox2.Text = bunifuCustomTextbox8.Text;
            bunifuCustomTextbox8.Clear();
            try
            {
                bunifuMetroTextbox5.Text = (double.Parse(bunifuMetroTextbox4.Text) * double.Parse(bunifuMetroTextbox2.Text)).ToString();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                bunifuMetroTextbox2.Text = "1";
                bunifuMetroTextbox5.Text = (double.Parse(bunifuMetroTextbox4.Text) * double.Parse(bunifuMetroTextbox2.Text)).ToString();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            bunifuMetroTextbox1.Text = "Delamotte";
            bunifuMetroTextbox4.Text = "510.00";
            bunifuMetroTextbox2.Text = bunifuCustomTextbox7.Text;
            bunifuCustomTextbox7.Clear();
            try
            {
                bunifuMetroTextbox5.Text = (double.Parse(bunifuMetroTextbox4.Text) * double.Parse(bunifuMetroTextbox2.Text)).ToString();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                bunifuMetroTextbox2.Text = "1";
                bunifuMetroTextbox5.Text = (double.Parse(bunifuMetroTextbox4.Text) * double.Parse(bunifuMetroTextbox2.Text)).ToString();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            bunifuMetroTextbox1.Text = "Novellino";
            bunifuMetroTextbox4.Text = "255.00";
            bunifuMetroTextbox2.Text = bunifuCustomTextbox6.Text;
            bunifuCustomTextbox6.Clear();
            try
            {
                bunifuMetroTextbox5.Text = (double.Parse(bunifuMetroTextbox4.Text) * double.Parse(bunifuMetroTextbox2.Text)).ToString();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                bunifuMetroTextbox2.Text = "1";
                bunifuMetroTextbox5.Text = (double.Parse(bunifuMetroTextbox4.Text) * double.Parse(bunifuMetroTextbox2.Text)).ToString();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            bunifuMetroTextbox1.Text = "Black Tulip";
            bunifuMetroTextbox4.Text = "320.00";
            bunifuMetroTextbox2.Text = bunifuCustomTextbox5.Text;
            bunifuCustomTextbox5.Clear();
            try
            {
                bunifuMetroTextbox5.Text = (double.Parse(bunifuMetroTextbox4.Text) * double.Parse(bunifuMetroTextbox2.Text)).ToString();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                bunifuMetroTextbox2.Text = "1";
                bunifuMetroTextbox5.Text = (double.Parse(bunifuMetroTextbox4.Text) * double.Parse(bunifuMetroTextbox2.Text)).ToString();
            }
        }
        private void button12_Click(object sender, EventArgs e)
        {
            bunifuMetroTextbox1.Text = "Mai Tai";
            bunifuMetroTextbox4.Text = "80";
            bunifuMetroTextbox2.Text = bunifuCustomTextbox9.Text;
            bunifuCustomTextbox9.Clear();
            try
            {
                bunifuMetroTextbox5.Text = (double.Parse(bunifuMetroTextbox4.Text) * double.Parse(bunifuMetroTextbox2.Text)).ToString();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                bunifuMetroTextbox2.Text = "1";
                bunifuMetroTextbox5.Text = (double.Parse(bunifuMetroTextbox4.Text) * double.Parse(bunifuMetroTextbox2.Text)).ToString();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            bunifuMetroTextbox1.Text = "Blue Margarita";
            bunifuMetroTextbox4.Text = "75";
            bunifuMetroTextbox2.Text = bunifuCustomTextbox10.Text;
            bunifuCustomTextbox10.Clear();
            try
            {
                bunifuMetroTextbox5.Text = (double.Parse(bunifuMetroTextbox4.Text) * double.Parse(bunifuMetroTextbox2.Text)).ToString();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                bunifuMetroTextbox2.Text = "1";
                bunifuMetroTextbox5.Text = (double.Parse(bunifuMetroTextbox4.Text) * double.Parse(bunifuMetroTextbox2.Text)).ToString();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            bunifuMetroTextbox1.Text = "Long Island";
            bunifuMetroTextbox4.Text = "75";
            bunifuMetroTextbox2.Text = bunifuCustomTextbox11.Text;
            bunifuCustomTextbox11.Clear();
            try
            {
                bunifuMetroTextbox5.Text = (double.Parse(bunifuMetroTextbox4.Text) * double.Parse(bunifuMetroTextbox2.Text)).ToString();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                bunifuMetroTextbox2.Text = "1";
                bunifuMetroTextbox5.Text = (double.Parse(bunifuMetroTextbox4.Text) * double.Parse(bunifuMetroTextbox2.Text)).ToString();
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            bunifuMetroTextbox1.Text = "Boracay";
            bunifuMetroTextbox4.Text = "85";
            bunifuMetroTextbox2.Text = bunifuCustomTextbox12.Text;
            bunifuCustomTextbox12.Clear();
            try
            {
                bunifuMetroTextbox5.Text = (double.Parse(bunifuMetroTextbox4.Text) * double.Parse(bunifuMetroTextbox2.Text)).ToString();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                bunifuMetroTextbox2.Text = "1";
                bunifuMetroTextbox5.Text = (double.Parse(bunifuMetroTextbox4.Text) * double.Parse(bunifuMetroTextbox2.Text)).ToString();
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            bunifuMetroTextbox1.Text = "Tequila Sunrise";
            bunifuMetroTextbox4.Text = "75";
            bunifuMetroTextbox2.Text = bunifuCustomTextbox13.Text;
            bunifuCustomTextbox13.Clear();
            try
            {
                bunifuMetroTextbox5.Text = (double.Parse(bunifuMetroTextbox4.Text) * double.Parse(bunifuMetroTextbox2.Text)).ToString();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                bunifuMetroTextbox2.Text = "1";
                bunifuMetroTextbox5.Text = (double.Parse(bunifuMetroTextbox4.Text) * double.Parse(bunifuMetroTextbox2.Text)).ToString();
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            bunifuMetroTextbox1.Text = "Firefly";
            bunifuMetroTextbox4.Text = "80";
            bunifuMetroTextbox2.Text = bunifuCustomTextbox14.Text;
            bunifuCustomTextbox14.Clear();
            try
            {
                bunifuMetroTextbox5.Text = (double.Parse(bunifuMetroTextbox4.Text) * double.Parse(bunifuMetroTextbox2.Text)).ToString();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                bunifuMetroTextbox2.Text = "1";
                bunifuMetroTextbox5.Text = (double.Parse(bunifuMetroTextbox4.Text) * double.Parse(bunifuMetroTextbox2.Text)).ToString();
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            bunifuMetroTextbox1.Text = "Frosting Shots";
            bunifuMetroTextbox4.Text = "90";
            bunifuMetroTextbox2.Text = bunifuCustomTextbox15.Text;
            bunifuCustomTextbox15.Clear();
            try
            {
                bunifuMetroTextbox5.Text = (double.Parse(bunifuMetroTextbox4.Text) * double.Parse(bunifuMetroTextbox2.Text)).ToString();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                bunifuMetroTextbox2.Text = "1";
                bunifuMetroTextbox5.Text = (double.Parse(bunifuMetroTextbox4.Text) * double.Parse(bunifuMetroTextbox2.Text)).ToString();
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            bunifuMetroTextbox1.Text = "Jayer Bomb";
            bunifuMetroTextbox4.Text = "85";
            bunifuMetroTextbox2.Text = bunifuCustomTextbox16.Text;
            bunifuCustomTextbox16.Clear();
            try
            {
                bunifuMetroTextbox5.Text = (double.Parse(bunifuMetroTextbox4.Text) * double.Parse(bunifuMetroTextbox2.Text)).ToString();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                bunifuMetroTextbox2.Text = "1";
                bunifuMetroTextbox5.Text = (double.Parse(bunifuMetroTextbox4.Text) * double.Parse(bunifuMetroTextbox2.Text)).ToString();
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            bunifuMetroTextbox1.Text = "Mojito";
            bunifuMetroTextbox4.Text = "115";
            bunifuMetroTextbox2.Text = bunifuCustomTextbox17.Text;
            bunifuCustomTextbox17.Clear();
            try
            {
                bunifuMetroTextbox5.Text = (double.Parse(bunifuMetroTextbox4.Text) * double.Parse(bunifuMetroTextbox2.Text)).ToString();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                bunifuMetroTextbox2.Text = "1";
                bunifuMetroTextbox5.Text = (double.Parse(bunifuMetroTextbox4.Text) * double.Parse(bunifuMetroTextbox2.Text)).ToString();
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            bunifuMetroTextbox1.Text = "Fired Ice";
            bunifuMetroTextbox4.Text = "95";
            bunifuMetroTextbox2.Text = bunifuCustomTextbox18.Text;
            bunifuCustomTextbox18.Clear();
            try
            {
                bunifuMetroTextbox5.Text = (double.Parse(bunifuMetroTextbox4.Text) * double.Parse(bunifuMetroTextbox2.Text)).ToString();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                bunifuMetroTextbox2.Text = "1";
                bunifuMetroTextbox5.Text = (double.Parse(bunifuMetroTextbox4.Text) * double.Parse(bunifuMetroTextbox2.Text)).ToString();
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            bunifuMetroTextbox1.Text = "Deep Blue";
            bunifuMetroTextbox4.Text = "105";
            bunifuMetroTextbox2.Text = bunifuCustomTextbox19.Text;
            bunifuCustomTextbox19.Clear();
            try
            {
                bunifuMetroTextbox5.Text = (double.Parse(bunifuMetroTextbox4.Text) * double.Parse(bunifuMetroTextbox2.Text)).ToString();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                bunifuMetroTextbox2.Text = "1";
                bunifuMetroTextbox5.Text = (double.Parse(bunifuMetroTextbox4.Text) * double.Parse(bunifuMetroTextbox2.Text)).ToString();
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            bunifuMetroTextbox1.Text = "Shirley Temple";
            bunifuMetroTextbox4.Text = "115";
            bunifuMetroTextbox2.Text = bunifuCustomTextbox20.Text;
            bunifuCustomTextbox20.Clear();
            try
            {
                bunifuMetroTextbox5.Text = (double.Parse(bunifuMetroTextbox4.Text) * double.Parse(bunifuMetroTextbox2.Text)).ToString();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                bunifuMetroTextbox2.Text = "1";
                bunifuMetroTextbox5.Text = (double.Parse(bunifuMetroTextbox4.Text) * double.Parse(bunifuMetroTextbox2.Text)).ToString();
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            bunifuMetroTextbox1.Text = "Italian Cream Soda";
            bunifuMetroTextbox4.Text = "105";
            bunifuMetroTextbox2.Text = bunifuCustomTextbox21.Text;
            bunifuCustomTextbox21.Clear();
            try
            {
                bunifuMetroTextbox5.Text = (double.Parse(bunifuMetroTextbox4.Text) * double.Parse(bunifuMetroTextbox2.Text)).ToString();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                bunifuMetroTextbox2.Text = "1";
                bunifuMetroTextbox5.Text = (double.Parse(bunifuMetroTextbox4.Text) * double.Parse(bunifuMetroTextbox2.Text)).ToString();
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            bunifuMetroTextbox1.Text = "Sunrise";
            bunifuMetroTextbox4.Text = "95";
            bunifuMetroTextbox2.Text = bunifuCustomTextbox22.Text;
            bunifuCustomTextbox22.Clear();
            try
            {
                bunifuMetroTextbox5.Text = (double.Parse(bunifuMetroTextbox4.Text) * double.Parse(bunifuMetroTextbox2.Text)).ToString();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                bunifuMetroTextbox2.Text = "1";
                bunifuMetroTextbox5.Text = (double.Parse(bunifuMetroTextbox4.Text) * double.Parse(bunifuMetroTextbox2.Text)).ToString();
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            bunifuMetroTextbox1.Text = "Mid Summer Dream";
            bunifuMetroTextbox4.Text = "85";
            bunifuMetroTextbox2.Text = bunifuCustomTextbox23.Text;
            bunifuCustomTextbox23.Clear();
            try
            {
                bunifuMetroTextbox5.Text = (double.Parse(bunifuMetroTextbox4.Text) * double.Parse(bunifuMetroTextbox2.Text)).ToString();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                bunifuMetroTextbox2.Text = "1";
                bunifuMetroTextbox5.Text = (double.Parse(bunifuMetroTextbox4.Text) * double.Parse(bunifuMetroTextbox2.Text)).ToString();
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            bunifuMetroTextbox1.Text = "Queens Punch";
            bunifuMetroTextbox4.Text = "100";
            bunifuMetroTextbox2.Text = bunifuCustomTextbox24.Text;
            bunifuCustomTextbox24.Clear();
            try
            {
                bunifuMetroTextbox5.Text = (double.Parse(bunifuMetroTextbox4.Text) * double.Parse(bunifuMetroTextbox2.Text)).ToString();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                bunifuMetroTextbox2.Text = "1";
                bunifuMetroTextbox5.Text = (double.Parse(bunifuMetroTextbox4.Text) * double.Parse(bunifuMetroTextbox2.Text)).ToString();
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            bunifuMetroTextbox1.Text = "Emperador Original";
            bunifuMetroTextbox4.Text = "150";
            bunifuMetroTextbox2.Text = bunifuCustomTextbox25.Text;
            bunifuCustomTextbox25.Clear();
            try
            {
                bunifuMetroTextbox5.Text = (double.Parse(bunifuMetroTextbox4.Text) * double.Parse(bunifuMetroTextbox2.Text)).ToString();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                bunifuMetroTextbox2.Text = "1";
                bunifuMetroTextbox5.Text = (double.Parse(bunifuMetroTextbox4.Text) * double.Parse(bunifuMetroTextbox2.Text)).ToString();
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            bunifuMetroTextbox1.Text = "McDowell's";
            bunifuMetroTextbox4.Text = "250";
            bunifuMetroTextbox2.Text = bunifuCustomTextbox26.Text;
            bunifuCustomTextbox26.Clear();
            try
            {
                bunifuMetroTextbox5.Text = (double.Parse(bunifuMetroTextbox4.Text) * double.Parse(bunifuMetroTextbox2.Text)).ToString();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                bunifuMetroTextbox2.Text = "1";
                bunifuMetroTextbox5.Text = (double.Parse(bunifuMetroTextbox4.Text) * double.Parse(bunifuMetroTextbox2.Text)).ToString();
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            bunifuMetroTextbox1.Text = "Honey Bee";
            bunifuMetroTextbox4.Text = "155";
            bunifuMetroTextbox2.Text = bunifuCustomTextbox28.Text;
            bunifuCustomTextbox28.Clear();
            try
            {
                bunifuMetroTextbox5.Text = (double.Parse(bunifuMetroTextbox4.Text) * double.Parse(bunifuMetroTextbox2.Text)).ToString();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                bunifuMetroTextbox2.Text = "1";
                bunifuMetroTextbox5.Text = (double.Parse(bunifuMetroTextbox4.Text) * double.Parse(bunifuMetroTextbox2.Text)).ToString();
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            bunifuMetroTextbox1.Text = "Dreher";
            bunifuMetroTextbox4.Text = "150";
            bunifuMetroTextbox2.Text = bunifuCustomTextbox27.Text;
            bunifuCustomTextbox27.Clear();
            try
            {
                bunifuMetroTextbox5.Text = (double.Parse(bunifuMetroTextbox4.Text) * double.Parse(bunifuMetroTextbox2.Text)).ToString();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                bunifuMetroTextbox2.Text = "1";
                bunifuMetroTextbox5.Text = (double.Parse(bunifuMetroTextbox4.Text) * double.Parse(bunifuMetroTextbox2.Text)).ToString();
            }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            bunifuMetroTextbox1.Text = "Torres Master";
            bunifuMetroTextbox4.Text = "255";
            bunifuMetroTextbox2.Text = bunifuCustomTextbox29.Text;
            bunifuCustomTextbox29.Clear();
            try
            {
                bunifuMetroTextbox5.Text = (double.Parse(bunifuMetroTextbox4.Text) * double.Parse(bunifuMetroTextbox2.Text)).ToString();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                bunifuMetroTextbox2.Text = "1";
                bunifuMetroTextbox5.Text = (double.Parse(bunifuMetroTextbox4.Text) * double.Parse(bunifuMetroTextbox2.Text)).ToString();
            }
        }

        private void button34_Click(object sender, EventArgs e)
        {
            bunifuMetroTextbox1.Text = "Old Admiral";
            bunifuMetroTextbox4.Text = "300";
            bunifuMetroTextbox2.Text = bunifuCustomTextbox30.Text;
            bunifuCustomTextbox30.Clear();
            try
            {
                bunifuMetroTextbox5.Text = (double.Parse(bunifuMetroTextbox4.Text) * double.Parse(bunifuMetroTextbox2.Text)).ToString();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                bunifuMetroTextbox2.Text = "1";
                bunifuMetroTextbox5.Text = (double.Parse(bunifuMetroTextbox4.Text) * double.Parse(bunifuMetroTextbox2.Text)).ToString();
            }
        }

        private void button35_Click(object sender, EventArgs e)
        {
            bunifuMetroTextbox1.Text = "Men's Club";
            bunifuMetroTextbox4.Text = "190";
            bunifuMetroTextbox2.Text = bunifuCustomTextbox31.Text;
            bunifuCustomTextbox31.Clear();
            try
            {
                bunifuMetroTextbox5.Text = (double.Parse(bunifuMetroTextbox4.Text) * double.Parse(bunifuMetroTextbox2.Text)).ToString();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                bunifuMetroTextbox2.Text = "1";
                bunifuMetroTextbox5.Text = (double.Parse(bunifuMetroTextbox4.Text) * double.Parse(bunifuMetroTextbox2.Text)).ToString();
            }
        }

        private void button36_Click(object sender, EventArgs e)
        {
            bunifuMetroTextbox1.Text = "Old Kenigsberg";
            bunifuMetroTextbox4.Text = "195";
            bunifuMetroTextbox2.Text = bunifuCustomTextbox32.Text;
            bunifuCustomTextbox32.Clear();
            try
            {
                bunifuMetroTextbox5.Text = (double.Parse(bunifuMetroTextbox4.Text) * double.Parse(bunifuMetroTextbox2.Text)).ToString();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                bunifuMetroTextbox2.Text = "1";
                bunifuMetroTextbox5.Text = (double.Parse(bunifuMetroTextbox4.Text) * double.Parse(bunifuMetroTextbox2.Text)).ToString();
            }
        }

        private void button37_Click(object sender, EventArgs e)
        {
            bunifuMetroTextbox1.Text = "San Miguel Light";
            bunifuMetroTextbox4.Text = "50";
            bunifuMetroTextbox2.Text = bunifuCustomTextbox33.Text;
            bunifuCustomTextbox33.Clear();
            try
            {
                bunifuMetroTextbox5.Text = (double.Parse(bunifuMetroTextbox4.Text) * double.Parse(bunifuMetroTextbox2.Text)).ToString();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                bunifuMetroTextbox2.Text = "1";
                bunifuMetroTextbox5.Text = (double.Parse(bunifuMetroTextbox4.Text) * double.Parse(bunifuMetroTextbox2.Text)).ToString();
            }
        }

        private void button38_Click(object sender, EventArgs e)
        {
            bunifuMetroTextbox1.Text = "Pale Pilsen";
            bunifuMetroTextbox4.Text = "45";
            bunifuMetroTextbox2.Text = bunifuCustomTextbox34.Text;
            bunifuCustomTextbox34.Clear();
            try
            {
                bunifuMetroTextbox5.Text = (double.Parse(bunifuMetroTextbox4.Text) * double.Parse(bunifuMetroTextbox2.Text)).ToString();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                bunifuMetroTextbox2.Text = "1";
                bunifuMetroTextbox5.Text = (double.Parse(bunifuMetroTextbox4.Text) * double.Parse(bunifuMetroTextbox2.Text)).ToString();
            }
        }

        private void button40_Click(object sender, EventArgs e)
        {
            bunifuMetroTextbox1.Text = "Red Horse";
            bunifuMetroTextbox4.Text = "50";
            bunifuMetroTextbox2.Text = bunifuCustomTextbox36.Text;
            bunifuCustomTextbox36.Clear();
            try
            {
                bunifuMetroTextbox5.Text = (double.Parse(bunifuMetroTextbox4.Text) * double.Parse(bunifuMetroTextbox2.Text)).ToString();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                bunifuMetroTextbox2.Text = "1";
                bunifuMetroTextbox5.Text = (double.Parse(bunifuMetroTextbox4.Text) * double.Parse(bunifuMetroTextbox2.Text)).ToString();
            }
        }

        private void button39_Click(object sender, EventArgs e)
        {
            bunifuMetroTextbox1.Text = "Heineken";
            bunifuMetroTextbox4.Text = "55";
            bunifuMetroTextbox2.Text = bunifuCustomTextbox35.Text;
            bunifuCustomTextbox35.Clear();
            try
            {
                bunifuMetroTextbox5.Text = (double.Parse(bunifuMetroTextbox4.Text) * double.Parse(bunifuMetroTextbox2.Text)).ToString();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                bunifuMetroTextbox2.Text = "1";
                bunifuMetroTextbox5.Text = (double.Parse(bunifuMetroTextbox4.Text) * double.Parse(bunifuMetroTextbox2.Text)).ToString();
            }
        }

        private void button41_Click(object sender, EventArgs e)
        {
            bunifuMetroTextbox1.Text = "Guinnes";
            bunifuMetroTextbox4.Text = "50";
            bunifuMetroTextbox2.Text = bunifuCustomTextbox37.Text;
            bunifuCustomTextbox37.Clear();
            try
            {
                bunifuMetroTextbox5.Text = (double.Parse(bunifuMetroTextbox4.Text) * double.Parse(bunifuMetroTextbox2.Text)).ToString();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                bunifuMetroTextbox2.Text = "1";
                bunifuMetroTextbox5.Text = (double.Parse(bunifuMetroTextbox4.Text) * double.Parse(bunifuMetroTextbox2.Text)).ToString();
            }
        }

        private void button42_Click(object sender, EventArgs e)
        {
            bunifuMetroTextbox1.Text = "Corona";
            bunifuMetroTextbox4.Text = "85";
            bunifuMetroTextbox2.Text = bunifuCustomTextbox38.Text;
            bunifuCustomTextbox38.Clear();
            try
            {
                bunifuMetroTextbox5.Text = (double.Parse(bunifuMetroTextbox4.Text) * double.Parse(bunifuMetroTextbox2.Text)).ToString();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                bunifuMetroTextbox2.Text = "1";
                bunifuMetroTextbox5.Text = (double.Parse(bunifuMetroTextbox4.Text) * double.Parse(bunifuMetroTextbox2.Text)).ToString();
            }
        }

        private void button43_Click(object sender, EventArgs e)
        {
            bunifuMetroTextbox1.Text = "Miller";
            bunifuMetroTextbox4.Text = "95";
            bunifuMetroTextbox2.Text = bunifuCustomTextbox39.Text;
            bunifuCustomTextbox39.Clear();
            try
            {
                bunifuMetroTextbox5.Text = (double.Parse(bunifuMetroTextbox4.Text) * double.Parse(bunifuMetroTextbox2.Text)).ToString();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                bunifuMetroTextbox2.Text = "1";
                bunifuMetroTextbox5.Text = (double.Parse(bunifuMetroTextbox4.Text) * double.Parse(bunifuMetroTextbox2.Text)).ToString();
            }
        }

        private void button44_Click(object sender, EventArgs e)
        {
            bunifuMetroTextbox1.Text = "Beck's";
            bunifuMetroTextbox4.Text = "134";
            bunifuMetroTextbox2.Text = bunifuCustomTextbox40.Text;
            bunifuCustomTextbox40.Clear();
            try
            {
                bunifuMetroTextbox5.Text = (double.Parse(bunifuMetroTextbox4.Text) * double.Parse(bunifuMetroTextbox2.Text)).ToString();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                bunifuMetroTextbox2.Text = "1";
                bunifuMetroTextbox5.Text = (double.Parse(bunifuMetroTextbox4.Text) * double.Parse(bunifuMetroTextbox2.Text)).ToString();
            }
        }

        private void button45_Click(object sender, EventArgs e)
        {
            bunifuMetroTextbox1.Text = "Coca Cola glass";
            bunifuMetroTextbox4.Text = "50";
            bunifuMetroTextbox2.Text = bunifuCustomTextbox41.Text;
            bunifuCustomTextbox41.Clear();
            try
            {
                bunifuMetroTextbox5.Text = (double.Parse(bunifuMetroTextbox4.Text) * double.Parse(bunifuMetroTextbox2.Text)).ToString();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                bunifuMetroTextbox2.Text = "1";
                bunifuMetroTextbox5.Text = (double.Parse(bunifuMetroTextbox4.Text) * double.Parse(bunifuMetroTextbox2.Text)).ToString();
            }
        }

        private void button46_Click(object sender, EventArgs e)
        {
            bunifuMetroTextbox1.Text = "Sprite glass";
            bunifuMetroTextbox4.Text = "50";
            bunifuMetroTextbox2.Text = bunifuCustomTextbox42.Text;
            bunifuCustomTextbox42.Clear();
            try
            {
                bunifuMetroTextbox5.Text = (double.Parse(bunifuMetroTextbox4.Text) * double.Parse(bunifuMetroTextbox2.Text)).ToString();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                bunifuMetroTextbox2.Text = "1";
                bunifuMetroTextbox5.Text = (double.Parse(bunifuMetroTextbox4.Text) * double.Parse(bunifuMetroTextbox2.Text)).ToString();
            }
        }

        private void button48_Click(object sender, EventArgs e)
        {
            bunifuMetroTextbox1.Text = "Royal glass";
            bunifuMetroTextbox4.Text = "50";
            bunifuMetroTextbox2.Text = bunifuCustomTextbox44.Text;
            bunifuCustomTextbox44.Clear();
            try
            {
                bunifuMetroTextbox5.Text = (double.Parse(bunifuMetroTextbox4.Text) * double.Parse(bunifuMetroTextbox2.Text)).ToString();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                bunifuMetroTextbox2.Text = "1";
                bunifuMetroTextbox5.Text = (double.Parse(bunifuMetroTextbox4.Text) * double.Parse(bunifuMetroTextbox2.Text)).ToString();
            }
        }

        private void button47_Click(object sender, EventArgs e)
        {
            bunifuMetroTextbox1.Text = "Iced Tea glass";
            bunifuMetroTextbox4.Text = "25";
            bunifuMetroTextbox2.Text = bunifuCustomTextbox43.Text;
            bunifuCustomTextbox43.Clear();
            try
            {
                bunifuMetroTextbox5.Text = (double.Parse(bunifuMetroTextbox4.Text) * double.Parse(bunifuMetroTextbox2.Text)).ToString();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                bunifuMetroTextbox2.Text = "1";
                bunifuMetroTextbox5.Text = (double.Parse(bunifuMetroTextbox4.Text) * double.Parse(bunifuMetroTextbox2.Text)).ToString();
            }
        }

        private void button52_Click(object sender, EventArgs e)
        {
            bunifuMetroTextbox1.Text = "Yellow Lemonade glass";
            bunifuMetroTextbox4.Text = "25";
            bunifuMetroTextbox2.Text = bunifuCustomTextbox48.Text;
            bunifuCustomTextbox48.Clear();
            try
            {
                bunifuMetroTextbox5.Text = (double.Parse(bunifuMetroTextbox4.Text) * double.Parse(bunifuMetroTextbox2.Text)).ToString();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                bunifuMetroTextbox2.Text = "1";
                bunifuMetroTextbox5.Text = (double.Parse(bunifuMetroTextbox4.Text) * double.Parse(bunifuMetroTextbox2.Text)).ToString();
            }
        }

        private void button49_Click(object sender, EventArgs e)
        {
            bunifuMetroTextbox1.Text = "Bottled Water";
            bunifuMetroTextbox4.Text = "20";
            bunifuMetroTextbox2.Text = bunifuCustomTextbox45.Text;
            bunifuCustomTextbox45.Clear();
            try
            {
                bunifuMetroTextbox5.Text = (double.Parse(bunifuMetroTextbox4.Text) * double.Parse(bunifuMetroTextbox2.Text)).ToString();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                bunifuMetroTextbox2.Text = "1";
                bunifuMetroTextbox5.Text = (double.Parse(bunifuMetroTextbox4.Text) * double.Parse(bunifuMetroTextbox2.Text)).ToString();
            }
        }

        private void button50_Click(object sender, EventArgs e)
        {
            bunifuMetroTextbox1.Text = "Cucumber glass";
            bunifuMetroTextbox4.Text = "25";
            bunifuMetroTextbox2.Text = bunifuCustomTextbox46.Text;
            bunifuCustomTextbox46.Clear();
            try
            {
                bunifuMetroTextbox5.Text = (double.Parse(bunifuMetroTextbox4.Text) * double.Parse(bunifuMetroTextbox2.Text)).ToString();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                bunifuMetroTextbox2.Text = "1";
                bunifuMetroTextbox5.Text = (double.Parse(bunifuMetroTextbox4.Text) * double.Parse(bunifuMetroTextbox2.Text)).ToString();
            }
        }

        private void button51_Click(object sender, EventArgs e)
        {
            bunifuMetroTextbox1.Text = "Blue Lemonade";
            bunifuMetroTextbox4.Text = "25";
            bunifuMetroTextbox2.Text = bunifuCustomTextbox47.Text;
            bunifuCustomTextbox47.Clear();
            try
            {
                bunifuMetroTextbox5.Text = (double.Parse(bunifuMetroTextbox4.Text) * double.Parse(bunifuMetroTextbox2.Text)).ToString();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                bunifuMetroTextbox2.Text = "1";
                bunifuMetroTextbox5.Text = (double.Parse(bunifuMetroTextbox4.Text) * double.Parse(bunifuMetroTextbox2.Text)).ToString();
            }
        }

        private void button53_Click(object sender, EventArgs e)
        {
            bunifuMetroTextbox1.Text = "Pork bbq stick";
            bunifuMetroTextbox4.Text = "15";
            bunifuMetroTextbox2.Text = bunifuCustomTextbox49.Text;
            bunifuCustomTextbox49.Clear();
            try
            {
                bunifuMetroTextbox5.Text = (double.Parse(bunifuMetroTextbox4.Text) * double.Parse(bunifuMetroTextbox2.Text)).ToString();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                bunifuMetroTextbox2.Text = "1";
                bunifuMetroTextbox5.Text = (double.Parse(bunifuMetroTextbox4.Text) * double.Parse(bunifuMetroTextbox2.Text)).ToString();
            }
        }

        private void button54_Click(object sender, EventArgs e)
        {
            bunifuMetroTextbox1.Text = "Tempura";
            bunifuMetroTextbox4.Text = "180";
            bunifuMetroTextbox2.Text = bunifuCustomTextbox50.Text;
            bunifuCustomTextbox50.Clear();
            try
            {
                bunifuMetroTextbox5.Text = (double.Parse(bunifuMetroTextbox4.Text) * double.Parse(bunifuMetroTextbox2.Text)).ToString();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                bunifuMetroTextbox2.Text = "1";
                bunifuMetroTextbox5.Text = (double.Parse(bunifuMetroTextbox4.Text) * double.Parse(bunifuMetroTextbox2.Text)).ToString();
            }
        }

        private void button56_Click(object sender, EventArgs e)
        {
            bunifuMetroTextbox1.Text = "Cheese Stick";
            bunifuMetroTextbox4.Text = "85";
            bunifuMetroTextbox2.Text = bunifuCustomTextbox51.Text;
            bunifuCustomTextbox51.Clear();
            try
            {
                bunifuMetroTextbox5.Text = (double.Parse(bunifuMetroTextbox4.Text) * double.Parse(bunifuMetroTextbox2.Text)).ToString();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                bunifuMetroTextbox2.Text = "1";
                bunifuMetroTextbox5.Text = (double.Parse(bunifuMetroTextbox4.Text) * double.Parse(bunifuMetroTextbox2.Text)).ToString();
            }
        }

        private void button55_Click(object sender, EventArgs e)
        {
            bunifuMetroTextbox1.Text = "Chicken Wings Fried";
            bunifuMetroTextbox4.Text = "235";
            bunifuMetroTextbox2.Text = bunifuCustomTextbox52.Text;
            bunifuCustomTextbox52.Clear();
            try
            {
                bunifuMetroTextbox5.Text = (double.Parse(bunifuMetroTextbox4.Text) * double.Parse(bunifuMetroTextbox2.Text)).ToString();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                bunifuMetroTextbox2.Text = "1";
                bunifuMetroTextbox5.Text = (double.Parse(bunifuMetroTextbox4.Text) * double.Parse(bunifuMetroTextbox2.Text)).ToString();
            }
        }

        private void button57_Click(object sender, EventArgs e)
        {
            bunifuMetroTextbox1.Text = "Squid Rings";
            bunifuMetroTextbox4.Text = "190";
            bunifuMetroTextbox2.Text = bunifuCustomTextbox53.Text;
            bunifuCustomTextbox53.Clear();
            try
            {
                bunifuMetroTextbox5.Text = (double.Parse(bunifuMetroTextbox4.Text) * double.Parse(bunifuMetroTextbox2.Text)).ToString();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                bunifuMetroTextbox2.Text = "1";
                bunifuMetroTextbox5.Text = (double.Parse(bunifuMetroTextbox4.Text) * double.Parse(bunifuMetroTextbox2.Text)).ToString();
            }
        }

        private void button58_Click(object sender, EventArgs e)
        {
            bunifuMetroTextbox1.Text = "Hawaiian Pizza";
            bunifuMetroTextbox4.Text = "150";
            bunifuMetroTextbox2.Text = bunifuCustomTextbox54.Text;
            bunifuCustomTextbox54.Clear();
            try
            {
                bunifuMetroTextbox5.Text = (double.Parse(bunifuMetroTextbox4.Text) * double.Parse(bunifuMetroTextbox2.Text)).ToString();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                bunifuMetroTextbox2.Text = "1";
                bunifuMetroTextbox5.Text = (double.Parse(bunifuMetroTextbox4.Text) * double.Parse(bunifuMetroTextbox2.Text)).ToString();
            }
        }

        private void button59_Click(object sender, EventArgs e)
        {
            bunifuMetroTextbox1.Text = "Nachos";
            bunifuMetroTextbox4.Text = "55";
            bunifuMetroTextbox2.Text = bunifuCustomTextbox55.Text;
            bunifuCustomTextbox55.Clear();
            try
            {
                bunifuMetroTextbox5.Text = (double.Parse(bunifuMetroTextbox4.Text) * double.Parse(bunifuMetroTextbox2.Text)).ToString();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                bunifuMetroTextbox2.Text = "1";
                bunifuMetroTextbox5.Text = (double.Parse(bunifuMetroTextbox4.Text) * double.Parse(bunifuMetroTextbox2.Text)).ToString();
            }
        }

        private void button60_Click(object sender, EventArgs e)
        {
            bunifuMetroTextbox1.Text = "French Fries";
            bunifuMetroTextbox4.Text = "50";
            bunifuMetroTextbox2.Text = bunifuCustomTextbox56.Text;
            bunifuCustomTextbox56.Clear();
            try
            {
                bunifuMetroTextbox5.Text = (double.Parse(bunifuMetroTextbox4.Text) * double.Parse(bunifuMetroTextbox2.Text)).ToString();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                bunifuMetroTextbox2.Text = "1";
                bunifuMetroTextbox5.Text = (double.Parse(bunifuMetroTextbox4.Text) * double.Parse(bunifuMetroTextbox2.Text)).ToString();
            }
        }

        private void button61_Click(object sender, EventArgs e)
        {
            bunifuMetroTextbox1.Text = "Bucket of 6 (Beer)";
            bunifuMetroTextbox4.Text = "270";
            bunifuMetroTextbox2.Text = "1";
        }

        private void button62_Click(object sender, EventArgs e)
        {
            bunifuMetroTextbox1.Text = "Test Tube Shots (6)";
            bunifuMetroTextbox4.Text = "165";
            bunifuMetroTextbox2.Text = "1";
        }

        private void button63_Click(object sender, EventArgs e)
        {
            bunifuMetroTextbox1.Text = "KTV Rm";
            bunifuMetroTextbox4.Text = "560";
            bunifuMetroTextbox2.Text = "1";
        }

        private void button64_Click(object sender, EventArgs e)
        {
            bunifuMetroTextbox1.Text = "Beer Pong (12)";
            bunifuMetroTextbox4.Text = "860";
            bunifuMetroTextbox2.Text = "1";            
        }

        private void button65_Click(object sender, EventArgs e)
        {
            bunifuMetroTextbox1.Text = "Card Shot (12)";
            bunifuMetroTextbox4.Text = "300";
            bunifuMetroTextbox2.Text = "1";
        }

        private void bunifuMetroTextbox6_OnValueChanged(object sender, EventArgs e)
        {
           
        }

        private void button66_Click(object sender, EventArgs e)
        {
            double total = (Convert.ToInt32(textBox1.Text));
            if (string.IsNullOrEmpty(bunifuMetroTextbox3.Text))
            {
                bunifuMetroTextbox3.Text = "0";
            }
            else
            {
                double discount = (Convert.ToInt32(bunifuMetroTextbox3.Text));
                double cd = Convert.ToDouble(discount);
                double fd = cd / 100;
                double final_d = total * fd;
                double final_t = total - final_d;
                textBox1.Text = final_t.ToString();
            }
            richTextBox1.Clear();            
            int i = 0;
            int rw = dataGridView1.Rows.Count;
            richTextBox1.AppendText("---------------------------------------------" + Environment.NewLine);
            richTextBox1.AppendText("BOOZE Restobar" + Environment.NewLine);
            richTextBox1.AppendText("Roxas City Capiz" + Environment.NewLine);
            richTextBox1.AppendText("---------------------------------------------" + Environment.NewLine);
            richTextBox1.AppendText("PRODUCT" + "\t" + "PRICE" + "\t" + "QTY" + "\t" + "TOTAL" + "\t" + Environment.NewLine);
            richTextBox1.AppendText("---------------------------------------------" + Environment.NewLine);
            do
            {
                if (dataGridView1.Rows[i].Cells[0].Value == null)
                {
                    if (bunifuMetroTextbox3.Text == null)
                    {
                        richTextBox1.AppendText("---------------------------------------------" + Environment.NewLine);
                        richTextBox1.AppendText("\t\t\t" + "DISCOUNT: " + "0%" + Environment.NewLine);
                        richTextBox1.AppendText("\t\t\t" + "TOTAL: " + textBox1.Text + Environment.NewLine);
                        richTextBox1.AppendText("---------------------------------------------" + Environment.NewLine);
                        richTextBox1.AppendText("\t" + "THANK YOU FOR YOUR PATRONAGE!!!" + Environment.NewLine);
                        richTextBox1.AppendText("---------------------------------------------" + Environment.NewLine);
                        break;
                    }
                    else
                    {
                        richTextBox1.AppendText("---------------------------------------------" + Environment.NewLine);
                        richTextBox1.AppendText("\t\t\t" + "DISCOUNT: " + bunifuMetroTextbox3.Text + "%" +Environment.NewLine);
                        richTextBox1.AppendText("\t\t\t" + "TOTAL: " + textBox1.Text + Environment.NewLine);
                        richTextBox1.AppendText("---------------------------------------------" + Environment.NewLine);
                        richTextBox1.AppendText("\t" + "THANK YOU FOR YOUR PATRONAGE!!!" + Environment.NewLine);
                        richTextBox1.AppendText("---------------------------------------------" + Environment.NewLine);
                        break;
                    }
                }
                else
                {
                        richTextBox1.AppendText(
                        dataGridView1.Rows[i].Cells[0].Value.ToString().Substring(0,4) + 
                        "\t" + dataGridView1.Rows[i].Cells[2].Value.ToString() +
                        "\t" + dataGridView1.Rows[i].Cells[1].Value.ToString() + 
                        "\t" + dataGridView1.Rows[i].Cells[3].Value.ToString() + Environment.NewLine
                        );
                    
                    i++;
                }
            } while (i<rw);
            richTextBox1.SelectAll();
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }          
        private void gunaLabel4_Click(object sender, EventArgs e)
        {

        }
    }
}
