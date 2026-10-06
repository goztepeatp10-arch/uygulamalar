using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayi = 0;
        Random random = new Random();
        int hak = 4;
        private void button1_Click(object sender, EventArgs e)
        {
            hak--;
            label1.Text = "Tahmin hakkınız: " + hak;
            if (hak > 0) ;


            int tahmin = Convert.ToInt32(textBox1.Text);
            if (tahmin < sayi)
            {
                label1.Text = "Daha büyük bir sayı girin.";
            }
            else if (tahmin > sayi)
            {
                label1.Text = "Daha küçük    bir sayı girin.";
            }
            else
            {
                label1.Text = "Tebrikler! Doğru tahmin ettiniz.";

            }
        }   
          
            

           
            
              
        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = "Tahmin hakkınız: " + hak ;
            sayi = random.Next(0, 100);
        }
    }
}
    

