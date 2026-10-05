using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _630oyun_furkan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayi = 0;
        Random random = new Random();
        int hakk = 4;
        private void button1_Click(object sender, EventArgs e)
        {
            hakk--;
            label3.Text = "Tahmin hakkınız: " + hakk;
            if (hakk > 0)
            {

                int tahmin = Convert.ToInt32(textBox1.Text);
                if (tahmin < sayi)
                {
                    label1.Text = "Daha büyük bir sayı girin.";
                }
                else if (tahmin > sayi)
                {
                    label1.Text = "Daha küçük    bir sayı girin.";
                }
                else
                {
                    label1.Text = "Tebrikler! Doğru tahmin ettiniz.";
                }
            }
            else
            {
                label1.Text = "Tahmin hakkınız kalmadı. Doğru sayı: " + sayi;
            }
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Text = "Tahmin hakkınız: " + hakk;
            sayi = random.Next(1, 101);
        }
    }
}