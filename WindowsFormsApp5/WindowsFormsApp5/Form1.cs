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

        private void button1_Click(object sender, EventArgs e)
        {
           
        {
            
            double sinav1 = Convert.ToDouble(textBox1.Text);
            double sinav2 = Convert.ToDouble(textBox2.Text);
            double proje = Convert.ToDouble(textBox3.Text);
            int devamsizlik = Convert.ToInt32(textBox4.Text);

           
            double ortalama = (sinav1 + sinav2 + proje) / 3;

            
            if (ortalama > 50 && devamsizlik < 20)
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
}
