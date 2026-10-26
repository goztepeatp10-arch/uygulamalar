using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _630furkanasalsayıadet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int adet = Convert.ToInt32(textBox1.Text);
            int sayac = 0;
            int sayi = 2;

            while (sayac < adet)
            {
                int bolenSayisi = 0;

                for (int i = 2; i < sayi; i++)
                {
                    if (sayi % i == 0)
                    {
                        bolenSayisi++;
                        break;
                    }
                }

                if (bolenSayisi == 0)
                {
                    listBox1.Items.Add(sayi);
                    sayac++;
                }

                sayi++;
            }
        }
    }
}
