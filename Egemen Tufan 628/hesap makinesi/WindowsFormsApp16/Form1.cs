using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
            
        private void Form1_Load(object sender, EventArgs e)
        {
                    }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
        int sayi1 = 0;
        int sayi2 = 0;
        int sayi3 = 0;
        public void textBox1_TextChanged(object sender, EventArgs e)
        {
           
           

        }

        public void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        public void button2_Click(object sender, EventArgs e)
        {  sayi1 = Convert.ToInt32(textBox1.Text); 
            sayi2 = Convert.ToInt32(textBox2.Text);
            sayi3 = sayi1 + sayi2;
                MessageBox.Show(sayi3.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox2.Text);
            sayi3 = sayi1 - sayi2;
            MessageBox.Show(sayi3.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox2.Text);
            sayi3 = sayi1 / sayi2;
            MessageBox.Show(sayi3.ToString());
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox2.Text);
            sayi3 = sayi1 * sayi2;
            MessageBox.Show(sayi3.ToString());
        }
    }
}
