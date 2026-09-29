using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int fiyat = Convert.ToInt16(textBox1.Text);
            int indirim = fiyat - (fiyat * 10 / 100);
            fiyat -= indirim;
            label4.Text= fiyat.ToString();
            label3.Text= indirim.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int fiyat = Convert.ToInt16(textBox1.Text);
            int indirim = fiyat / 4;
            fiyat -= indirim;
            label4.Text = fiyat.ToString();
            label3.Text = indirim.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int fiyat = Convert.ToInt16(textBox1.Text);
            int indirim = fiyat/2;
            fiyat -= indirim;
            label4.Text = fiyat.ToString();
            label3.Text = indirim.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int fiyat = Convert.ToInt16(textBox1.Text);
            int indirim = fiyat - (fiyat * 3 / 4);
            fiyat -= indirim;
            label4.Text = fiyat.ToString();
            label3.Text = indirim.ToString();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            double x = Convert.ToInt16(textBox2.Text);
            double y = Convert.ToInt16(textBox3.Text);
            double sonuc = (x * x + y * y) / ((x+y)*3);
            label9.Text = sonuc.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double x = Convert.ToInt16(textBox4.Text);
            x = x * 18 / 100;
            label11.Text = x.ToString();
        }
    }
}
