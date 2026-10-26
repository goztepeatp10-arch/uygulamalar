using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _630furkanebob
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(textBox1.Text);
            int sayi2 = Convert.ToInt32(textBox2.Text);
            int ebob = 1;

            int kucukSayi = (sayi1 < sayi2) ? sayi1 : sayi2;

            for (int i = 1; i <= kucukSayi; i++)
            {
                if (sayi1 % i == 0 && sayi2 % i == 0)
                {
                    ebob = i;
                }
            }

            label1.Text = "EBOB(" + sayi1 + "," + sayi2 + ")=" + ebob;
        }
    }
}
