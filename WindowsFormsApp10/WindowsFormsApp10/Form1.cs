using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double tuketim = Convert.ToDouble(textBox1.Text);
            double fiyat = Convert.ToDouble(textBox2.Text);

            // 2. Kuruşu TL'ye çevirerek faturayı hesapla
            double fatura = tuketim * (fiyat / 100);

            // 3. Şartlara göre zam uygula
            if (tuketim > 500)
            {
                fatura = fatura * 1.30; // %30 zam
            }
            else if (tuketim > 350)
            {
                fatura = fatura * 1.10; // %10 zam
            }
            label3.Text = fatura.ToString() + " TL";
        }
    }
}





