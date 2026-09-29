using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        private void button1_Click(object sender, EventArgs e)
        {
            int etiketfiyati;
            double indirimfiyat;
            etiketfiyati = Convert.ToInt16(textBox1.Text);
            indirimfiyat = etiketfiyati - etiketfiyati * 0.10;
            label2.Text = indirimfiyat.ToString();  


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int etiketfiyati;
            double indirimfiyat;
            etiketfiyati = Convert.ToInt16(textBox1.Text);
            indirimfiyat = etiketfiyati - etiketfiyati * 0.25;
            label2.Text =indirimfiyat.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int etiketfiyati;
            double indirimfiyat;
            etiketfiyati = Convert.ToInt16(textBox1.Text);
            indirimfiyat = etiketfiyati - etiketfiyati * 0.50;
            label2.Text = indirimfiyat.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int etiketfiyati;
            double indirimfiyat;
            etiketfiyati = Convert.ToInt16(textBox1.Text);
            indirimfiyat = etiketfiyati - etiketfiyati * 0.75;
            label2.Text = indirimfiyat.ToString();
        }
    }
}
