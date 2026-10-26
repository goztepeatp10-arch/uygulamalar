using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İLHAN_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    int sonuc = i * j;
                    listBox1.Items.Add(i + "x" + j + " = " + sonuc);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
            int m = Convert.ToInt32(textBox2.Text);


            for (int x = 1; x <= n; x++)
            {

                for (int y = 1; y <= m; y++)
                {

                    int sonuc = (3 * x) + (y * y) + 3;


                    string satir = "x=" + x + ", y=" + y + " için; 3 * " + x + " + " + y + " ^ 2 + 3 = " + sonuc;


                    listBox2.Items.Add(satir);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            {

                int bitisSayisi = Convert.ToInt32(textBox3.Text);


                int tekToplam = 0;
                int ciftToplam = 0;


                for (int i = 1; i <= bitisSayisi; i++)
                {

                    if (i % 2 == 0)
                    {
                        ciftToplam = ciftToplam + i;
                    }

                    else
                    {
                        tekToplam = tekToplam + i;
                    }
                }


                label2.Text = tekToplam.ToString();
                label1.Text = ciftToplam.ToString();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox4.Text);
            bool asalMi = true;

            if (sayi < 2)
            {
                asalMi = false;
            }
            else
            {
                for (int i = 2; i < sayi; i++)
                {
                    if (sayi % i == 0)
                    {
                        asalMi = false;
                        break;
                    }
                }
            }

            if (asalMi == true)
            {
                label3.Text = "Sayı Asal";
            }
            else
            {
                label3.Text = "Sayı Asal Değil";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox5.Text);


            int toplam = 0;


            for (int i = 1; i < sayi; i++)
            {

                if (sayi % i == 0)
                {
                    toplam = toplam + i;
                }
            }


            if (toplam == sayi)
            {
                label4.Text = "Sayı Mükemmeldir";
            }
            else
            {
                label4.Text = "Sayı Mükemmel Değildir";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox6.Text);
            for(int sayi = 2; sayi <= n; sayi++)
            {
                bool asalMi = true;
                for (int i = 2; i < sayi; i++)
                {
                    if (sayi % i == 0)
                    {
                        asalMi = false;
                        break;
                    }
                }
                if (asalMi)
                {
                    listBox3.Items.Add(sayi);
                }
            }







        }

        private void button7_Click(object sender, EventArgs e)
        {
            int istenenadet = Convert.ToInt32(textBox7.Text);
            int bulunanadet = 0;
            int testedilen = 2;
            while (bulunanadet < istenenadet)
            {
                bool asalMi = true;
                for (int i = 2; i < testedilen; i++)
                {
                    if (testedilen % i == 0)
                    {
                        asalMi = false;
                        break;
                    }
                }
                if (asalMi)
                {
                    listBox4.Items.Add(testedilen);
                    bulunanadet++;
                }
                testedilen++;
            }


        }

        private void button8_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(textBox8.Text);
            int sayi2 = Convert.ToInt32(textBox9.Text);

            int ebob = 1;
            int kucukSayi;

            if (sayi1 < sayi2)
            {
                kucukSayi = sayi1;
            }
            else
            {
                kucukSayi = sayi2;
            }

            for (int i = kucukSayi; i >= 1; i--)
            {
                if (sayi1 % i == 0 && sayi2 % i == 0)
                {
                    ebob = i;
                    break;
                }
            }

            label6.Text = "EBOB(" + sayi1 + "," + sayi2 + ")=" + ebob;
        }
        }
    }


