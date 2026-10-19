using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADET_BİRİM_TUTAR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int adet = Convert.ToInt32(textBox1.Text);

           
            double fiyat = Convert.ToDouble(textBox2.Text);

           
            double sonuc = adet * fiyat;

           
            label1.Text = "Toplam Tutar: " + sonuc.ToString() + " TL";



        }
    }
 }

