using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _630adet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int x = 0; int y = 0; int z = 0; int p = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            x = Convert.ToInt32(textBox1.Text);
            y = Convert.ToInt32(textBox2.Text);
            if (x>= 5 && x<10)
            {
                z=(y*5)/ 100;
                p = y - z;
                label3.Text = "fiyat: " + p.ToString();
            }
            else if (x >= 10)
            {
                z = (y * 10) / 100;
                p = y - z;
                label3.Text = "fiyat: " + p.ToString();
            }
        }
    }
}
