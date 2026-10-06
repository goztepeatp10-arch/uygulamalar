using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sinav1 = Convert.ToInt32(textBox1.Text);
            int sinav2 = Convert.ToInt32(textBox2.Text);
            int proje = Convert.ToInt32(textBox3.Text);
            int devamsizlik = Convert.ToInt32(textBox4.Text);

            double ortalama = (sinav1 + sinav2 + proje) / 3.0;

            if (ortalama >= 50 && devamsizlik < 10)
            {
                label5.Text = "Öğrenci geçti. Ortalama: " + ortalama.ToString("0.00");
            }
            else
            {
                label5.Text = "Öğrenci kaldı. Ortalama: " + ortalama.ToString("0.00");
            }
        }

    }
}





