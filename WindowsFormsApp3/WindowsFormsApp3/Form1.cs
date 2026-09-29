using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           double x = 0;
           double y = 0;
           x = Convert.ToInt16(textBox1.Text);
           y = Convert.ToInt16(textBox2.Text);
            double sonuc = ((x * x) + (y * y)) /( (x + y) * 3);
            label3.Text = sonuc.ToString();
           
        }
    }
}
