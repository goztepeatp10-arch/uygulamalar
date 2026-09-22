using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace evethayır
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Evet mi hayır mı iptal mi","havli başlik", MessageBoxButtons.OK);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Evet mi hayır mı iptal mi", "havli başlik", MessageBoxButtons.OKCancel);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Evet mi hayır mı iptal mi", "havli başlik", MessageBoxButtons.YesNo);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int deger = 500;
            MessageBox.Show(deger.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, toplam;
            sayi1 = Convert.ToInt16(textBox1.Text);
            sayi2 = Convert.ToInt16(textBox2.Text);
            toplam = sayi1 + sayi2;
            textBox3.Text = toplam.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, toplam;
            sayi1 = Convert.ToInt16(textBox1.Text);
            sayi2 = Convert.ToInt16(textBox2.Text);
            toplam = sayi1 - sayi2;
            textBox3.Text = toplam.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, toplam;
            sayi1 = Convert.ToInt16(textBox1.Text);
            sayi2 = Convert.ToInt16(textBox2.Text);
            toplam = sayi1 * sayi2;
            textBox3.Text = toplam.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Single sayi1, sayi2, toplam;
            sayi1 = Convert.ToSingle(textBox1.Text);
            sayi2 = Convert.ToSingle(textBox2.Text);
            toplam = sayi1 / sayi2;
            textBox3.Text = toplam.ToString();
        }
    }
}
