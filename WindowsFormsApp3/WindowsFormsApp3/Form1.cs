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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt16(textBox1.Text);
            int b = Convert.ToInt16(textBox2.Text);
            int c = Convert.ToInt16(textBox3.Text);

            if (a > 0 && b > 0 && c > 0)
            {

                if (a + b > c && a + c > b && b + c > a)
                {
                    if (a == b || b == c || c == a)
                    {
                        label1.Text = "ikizkenar Üçgen";
                    }
                    if (b == c && a == b)
                    {
                        label1.Text = "Eş Kenar Üçgen";
                    }
                    if ((a != b && b != c && a != c))

                    {
                        label1.Text = "Çeşitkenar üçgen";
                    }

                }
                else
                {
                    label1.Text = "Üçgen oluşturulamaz";

                }
            }
            else
            {
                label1.Text = "degerler 0 dan büyük olmalıdır";


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double siparisTutari = Convert.ToDouble(textBox4.Text);
            string siparisTuru = (comboBox1.Text);

            {

                int adet = Convert.ToInt32(textBox4.Text);
                double birimfiyat = Convert.ToDouble(textBox5.Text);


                double toplamtutar = adet * birimfiyat;
                double indirimorani = 0;
                if (siparisTutari > 500 && comboBox1.Text == "standart teslimat")
                {
                    siparisTutari = 500;


                    if (adet >= 10) ;
            }
                else if (siparisTutari > 500 && comboBox1.Text == "hızlı teslimat")
                {
                    indirimorani = 0.10;
                    siparisTutari = siparisTutari + 50;
                }
                else if (adet >= 5)
                    if (siparisTutari < 500 && comboBox1.Text == "standart teslimat")
                    {
                        indirimorani = 0.05;
                        siparisTutari = siparisTutari + 30;
                    }
                    else if (siparisTutari < 500 && comboBox1.Text == "hızlı teslimat")
                    {
                        siparisTutari = siparisTutari + 70;
                    }
                label2.Text = siparisTutari.ToString();


                double nettutar = toplamtutar * (1 - indirimorani);


                label2.Text = nettutar.ToString("0.00") + " TL";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int yas = Convert.ToInt32(textBox6.Text);
            int gelir = Convert.ToInt32(textBox7.Text);
            int krediNotu = Convert.ToInt32(textBox8.Text);

            if (yas >= 18)
            {
                if (gelir >= 20000)
                {
                    if (krediNotu >= 1200)
                    {
                        label6.Text = "Kredi onaylandi";
                    }
                    else
                    {
                        label6.Text = "Kredi reddedildi";
                    }
                }
                else
                {
                    label6.Text = "Kredi reddedildi";
                }
            }
            else
            {
                label6.Text = "Kredi reddedildi";
            }
        }
    }
}






