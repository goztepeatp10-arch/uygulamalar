using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _630furkan_direnç
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int d1 = 0; int d2 = 0; int d3 = 0; float s1 = 0f;
        private void button1_Click(object sender, EventArgs e)
        {
            int d1 = Convert.ToInt32(textBox1.Text);
            int d2 = Convert.ToInt32(textBox2.Text);
            int d3 = Convert.ToInt32(textBox3.Text);
            if (checkBox1.Checked)
            {
                s1= d1 + d2 + d3;
                label6.Text = s1.ToString();
            }
            else if (checkBox2.Checked)
            {
                s1 = 1f / ((1f / d1) + (1f / d2) + (1f / d3));
                label7.Text = s1.ToString();
            }

        }
    }
}
