using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1. Kutulardan sınav, proje ve devamsızlık bilgilerini alıyoruz
            double sinav1 = Convert.ToDouble(textBox1.Text);
            double sinav2 = Convert.ToDouble(textBox2.Text);
            double proje = Convert.ToDouble(textBox3.Text);
            double devamsizlik = Convert.ToDouble(textBox4.Text);

            // 2. Ortalamayı hesaplıyoruz (2 sınav + 1 proje notunun aritmetik ortalaması alıyoruz basittttt)
            double ortalama = (sinav1 + sinav2 + proje) / 3;

            if (ortalama > 50 && devamsizlik < 10)
            {
                label5.Text = "Geçtiniz";
            }
            else
            {
                label5.Text = "Kaldınız";
            }
    }
}
}
