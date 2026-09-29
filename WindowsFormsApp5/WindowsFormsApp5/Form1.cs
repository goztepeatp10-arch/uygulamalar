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
        double x = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            x = Convert.ToInt16(textBox1.Text);
            double sonuc = x * 0.18;
            label1.Text = sonuc.ToString();



        }

        private void button1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            x = Convert.ToInt16(textBox1.Text);
            double sonuc = x * 0.18;
            label1.Text = sonuc.ToString();
        }
    }
}
