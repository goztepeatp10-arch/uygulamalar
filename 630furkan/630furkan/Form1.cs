using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _630furkan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int galibiyet = 0; int beraberlik = 0; int x = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int galibiyet = Convert.ToInt32(textBox1.Text);
            int beraberlik = Convert.ToInt32(textBox2.Text);
            if (radioButton1.Checked)
            {
                galibiyet=galibiyet*3;
                beraberlik=beraberlik*1;
                x = galibiyet+beraberlik;
                label3.Text = x.ToString();
            }
            else if (radioButton2.Checked)
            {
                galibiyet=galibiyet*2;
                beraberlik=beraberlik*1;
                x = galibiyet + beraberlik;
                label3.Text = x.ToString();
            }
        }
    }
}
