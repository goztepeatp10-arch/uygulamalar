using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sdf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int adet = textBox1.Text.Length;
            int birim = textBox2.Text.Length;

            if (adet > 5)
            {
                birim = birim - birim * 100 / 5;
                label3.Text = "Tutar=" + birim * adet;
            }
            else if (adet > 10)
            {
                birim = birim - birim * 100 / 10;
                label3.Text = "Tutar=" + birim * adet;
            }
            else
            {
                label3.Text = "Tutar=" + birim * adet;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int adet = textBox3.Text.Length;
            int birim = textBox4.Text.Length;

            if (adet > 350)
            {
                birim = birim + birim * 100 / 5;
                label3.Text = "Tutar=" + birim * adet;
            }
            else if (adet > 500)
            {
                birim = birim + birim * 100 / 10;
                label3.Text = "Tutar=" + birim * adet;
            }
            else
            {
                label3.Text = "Tutar=" + birim * adet;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sinav1 = textBox5.Text.Length;
            int sinav2 = textBox6.Text.Length;
            int proje = textBox7.Text.Length;
            int devamsizlik = textBox8.Text.Length;

            int toplam = sinav1 + sinav2 + proje;

            if (devamsizlik > 10)
            {
                label13.Text = "Sonuç: Kaldınız";
            }
            else if (toplam / 3 < 50)
            {
                label13.Text = "Sonuç: Kaldınız";
            }
            else
            {
                label13.Text = "Sonuç: Geçtiniz";
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double dolar = Convert.ToDouble(textBox9.Text);
            double euro = Convert.ToDouble(textBox10.Text);
            double tl = Convert.ToDouble(textBox11.Text);
            double para = Convert.ToDouble(textBox12.Text);

            if (radioButton1.Checked == true)
            {
                double sonuc = para / dolar;
                label14.Text = "Sonuç: " + sonuc.ToString("0.00") + " Dolar";
            }
            if (radioButton2.Checked == true)
            {
                double sonuc = para / euro;
                label14.Text = "Sonuç: " + sonuc.ToString("0.00") + " Euro";
            }
            if (radioButton3.Checked == true)
            {
                double sonuc = para / tl;
                label14.Text = "Sonuç: " + sonuc.ToString("0.00") + " TL";
            }
            if (radioButton4.Checked == true)
            {
                double sonuc = para * dolar;
                label14.Text = "Sonuç: " + sonuc.ToString("0.00") + " Dolar";
            }
            if (radioButton5.Checked == true)
            {
                double sonuc = para * euro;
                label14.Text = "Sonuç: " + sonuc.ToString("0.00") + " Euro";
            }
            if (radioButton6.Checked == true)
            {
                double sonuc = para * tl;
                label14.Text = "Sonuç: " + sonuc.ToString("0.00") + " TL";
            }
        }
    }
}
