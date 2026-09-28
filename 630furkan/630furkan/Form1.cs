using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _630furkan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayi1 = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1 , toplam;
            sayi1 = Convert.ToInt16(textBox1.Text);
            toplam = 2*sayi1+3;
            label3.Text = toplam.ToString();
        }
        int sayi2 = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            int sayi2;
            sayi2 = Convert.ToInt16(textBox2.Text);
            float toplam =(float)sayi2 * 1.8f + 32;
            label5.Text = toplam.ToString();
        }
        int sayi3 = 0;
        private void button3_Click(object sender, EventArgs e)
        {

            int sayi3;
            sayi3 = Convert.ToInt16(textBox3.Text);
            float toplam =sayi3*10 ;
            label9.Text = toplam.ToString();

        }
        int sayi5 = 0;
        int sayi4 = 0;
        private void button4_Click(object sender, EventArgs e)
        {

            int sayi4,sayi5;
            sayi4 = Convert.ToInt16(textBox4.Text);
            sayi5 = Convert.ToInt16(textBox5.Text);
            float toplam =sayi4 * sayi5;
            label12.Text = toplam.ToString();
        }
    }
}
