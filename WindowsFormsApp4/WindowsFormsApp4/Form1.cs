using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int x = 0;
        private void button1_Click(object sender, EventArgs e)
        {
           int x = Convert.ToInt16(textBox1.Text);
           int sonuc = x * x;
           label2.Text = sonuc.ToString();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt16(textBox1.Text);
            int sonuc = x+x+x+x;
            label2.Text = sonuc.ToString();
        }
    }
}
