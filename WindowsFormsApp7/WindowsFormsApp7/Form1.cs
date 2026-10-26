using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        {
            listBox1.Items.Clear();

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    int sonuc = i * j;

                    listBox1.Items.Add(i + " x " + j + " = " + sonuc);
                }

            }
        }

    }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                listBox2.Items.Clear();

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
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox3.Text);
            int tekToplam = 0;                         
            int ciftToplam = 0;                       

            for (int i = 1; i <= sayi; i++)
            {
                if (i % 2 == 0)
                {
                    ciftToplam += i; 
                }
                else
                {
                    tekToplam += i;  
                }
            }

            label7.Text = tekToplam.ToString();
            label8.Text = ciftToplam.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            {
                int sayi = Convert.ToInt32(textBox4.Text);

                bool asalMi = true;

                if (sayi <= 1)
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
                    label11.Text = "Sayı Asal";
                }
                else
                {
                    label11.Text = "Sayı Asal Değil";
                }
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
                    toplam += i; 
                }
            }

            if (toplam == sayi)
            {
                label13.Text = "Sayı Mükemmeldir";
            }
            else
            {
                label13.Text = "Sayı Mükemmel Değildir";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();

            int n = Convert.ToInt32(textBox6.Text);

            for (int sayi = 2; sayi <= n; sayi++)
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

                if (asalMi == true)
                {
                    listBox3.Items.Add(sayi);
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            int istenenAdet = Convert.ToInt32(textBox7.Text);

            int bulunanAsalAdedi = 0; 
            int testEdilenSayi = 2;   

            while (bulunanAsalAdedi < istenenAdet)
            {
                bool asalMi = true; 


                for (int i = 2; i < testEdilenSayi; i++)
                {
                    if (testEdilenSayi % i == 0)
                    {
                        asalMi = false; 
                        break;          
                    }
                }

                if (asalMi == true)
                {
                    listBox4.Items.Add(testEdilenSayi);
                    bulunanAsalAdedi++; 
                }

                testEdilenSayi++;
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

            label20.Text = "EBOB(" + sayi1 + "," + sayi2 + ")=" + ebob;
        }
    }
    }
    
    
    

