using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _630furkanasalsayı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox1.Text);
            int sayac = 0;

            if (sayi <= 1)
            {
                label1.Text = "Lütfen 1'den büyük bir sayı giriniz.";
                return;
            }

            for (int i = 2; i < sayi; i++)
            {
                if (sayi % i == 0)
                {
                    sayac++;
                    break;
                }
            }

            if (sayac == 0)
            {
                label1.Text = "Sayı Asal";
            }
            else
            {
                label1.Text = "Sayı Asal Değil";
            }


        }
    }
}
