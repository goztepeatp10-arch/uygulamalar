using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20102026
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox1.Text);
            int toplam = 1;

            for (int i = 1; i <= sayi; i++)
            {
                toplam = toplam * i;
            }

            label1.Text = "Faktöriyel: " + toplam.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox2.Text);
            int sayi2 = Convert.ToInt32(textBox3.Text);
            int toplam = 0;

            for (int i = sayi2; i <= sayi; i++)
            {
                toplam = toplam + i;

            }

            label2.Text = "Toplam: " + toplam.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            int ilkdeger = Convert.ToInt32(textBox4.Text);
            int sondeger = Convert.ToInt32(textBox5.Text);


            listBox1.Items.Clear();

            for (int x = ilkdeger; x <= sondeger; x++)
            {
                int sonuc = 0;

                if (x < 0)
                {
                    sonuc = 0;
                }
                else if (x == 0)
                {
                    sonuc = 1;
                }
                else if (x > 0)
                {
                    sonuc = (x * x) + 5; 
                }

                listBox1.Items.Add("x=" + x.ToString() + " için; " + sonuc.ToString());
            }
        }
    }
}
