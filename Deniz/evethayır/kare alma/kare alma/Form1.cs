using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kare_alma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayi = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            sayi = Convert.ToInt32(textBox1.Text);
            int alan = sayi * sayi;
            label2.Text = alan.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            sayi = Convert.ToInt32(textBox1.Text);
            int cevre = sayi * 4;
            label2.Text =cevre.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sayi = Convert.ToInt32(textBox2.Text);
            int alan = sayi * sayi;
            label3.Text = alan.ToString();
        }
    }
}
