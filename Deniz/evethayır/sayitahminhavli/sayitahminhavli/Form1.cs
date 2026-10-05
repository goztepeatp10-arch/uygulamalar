using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayitahminhavli
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int rastgeleSayi = 0;
        int kalanHak = 4;
        Random rnd = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {
            rastgeleSayi = rnd.Next(0, 101);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int tahmin = Convert.ToInt32(textBox1.Text);

            
            kalanHak = kalanHak - 1;

            if (tahmin == rastgeleSayi)
            {
                label2.Text = "Bildiniz Yeni sayı seçildi";

                
                rastgeleSayi = rnd.Next(0, 101);
                kalanHak = 4;
            }
            else if (kalanHak == 0)
            {
                label2.Text = "Hakkınız bitti Sayı: " + rastgeleSayi + ". Yeni oyun başladı";

               
                rastgeleSayi = rnd.Next(0, 101);
                kalanHak = 4;
            }
            else if (tahmin < rastgeleSayi)
            {
                label2.Text = "Yukarı";
            }
            else if (tahmin > rastgeleSayi)
            {
                label2.Text = "Aşağı";
            }

           
            label1.Text = "Kalan Hak: " + kalanHak;
            textBox1.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
