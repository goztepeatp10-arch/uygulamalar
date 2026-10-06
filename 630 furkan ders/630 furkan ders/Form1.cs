using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _630_furkan_ders
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int x = 0; int y = 0; int z = 0; int w = 0; int t = 0;int u = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            int y = Convert.ToInt32(textBox2.Text);
            int z = Convert.ToInt32(textBox3.Text);
            int w = Convert.ToInt32(textBox4.Text);
            t = x + y + z;
            u = t/3;
            if (u >= 50 &&  w<=10)
            {
                label5.Text = "Geçtiniz";
            }
            else if ( w > 10)
            {
                label5.Text = "Kaldınız";
            }
            else
            {
                label5.Text = "Kaldınız";
            }

        }
    }
}
