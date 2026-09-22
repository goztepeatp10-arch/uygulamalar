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
            MessageBox.Show("1.mesaj","mesaj başlığı");
            MessageBox.Show("2.mesaj","mesaj başlığı", MessageBoxButtons.YesNoCancel);
            MessageBox.Show("3.mesaj ","mesaj başlığı", MessageBoxButtons.OKCancel);
        }

        int a = 500;
        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show(a.ToString());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, toplam;
            sayi1 = Convert.ToInt16(textBox1.Text);
            sayi2 = Convert.ToInt16(textBox2.Text);
            toplam = sayi1 + sayi2;
            textBox3.Text = toplam.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, toplam;
            sayi1 = Convert.ToInt16(textBox1.Text);
            sayi2 = Convert.ToInt16(textBox2.Text);
            toplam = sayi1 - sayi2;
            textBox3.Text = toplam.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, toplam;
            sayi1 = Convert.ToInt16(textBox1.Text);
            sayi2 = Convert.ToInt16(textBox2.Text);
            toplam = sayi1 * sayi2;
            textBox3.Text = toplam.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, toplam;
            sayi1 = Convert.ToInt16(textBox1.Text);
            sayi2 = Convert.ToInt16(textBox2.Text);
            toplam = sayi1 / sayi2;
            textBox3.Text = toplam.ToString();
        }
    }
}
