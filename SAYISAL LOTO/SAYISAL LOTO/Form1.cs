using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAYISAL_LOTO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random();

           
            int sayi1 = rastgele.Next(1, 50);
            int sayi2 = rastgele.Next(1, 50);
            int sayi3 = rastgele.Next(1, 50);
            int sayi4 = rastgele.Next(1, 50);
            int sayi5 = rastgele.Next(1, 50);
            int sayi6 = rastgele.Next(1, 50);

         
            textBox1.Text = sayi1.ToString();
            textBox2.Text = sayi2.ToString();
            textBox3.Text = sayi3.ToString();
            textBox4.Text = sayi4.ToString();
            textBox5.Text = sayi5.ToString();
            textBox6.Text = sayi6.ToString();
        }
    }
}
