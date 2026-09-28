using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4luguclu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = 0;
            sayi = Convert.ToInt32(textBox1.Text);
            int sonuc = (2 * sayi) + 3;
            label3.Text = sonuc.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double san = Convert.ToDouble(textBox2.Text);
            double fah = (san * 1.8) + 32;
            label6.Text = fah.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double san =Convert.ToDouble(textBox3.Text);
            double mil= san* 10;
            label8.Text= mil.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double akim = Convert.ToDouble(textBox4.Text);
            double direnc = Convert.ToDouble(textBox5.Text);
            double gerilim = akim*direnc;
            label11.Text=gerilim.ToString();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}
