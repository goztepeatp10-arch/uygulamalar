using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _630furkan_alan_cevree
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int boy = 0; int uzun = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            boy = Convert.ToInt32(textBox1.Text);
            uzun = Convert.ToInt32(textBox2.Text);
            if (radioButton2.Checked)
            {
                int alan = boy * uzun;
                label5.Text = "Alan: " + alan.ToString();
            }
            else if (radioButton1.Checked)
            {
                int cevre = 2 * (boy + uzun);
                label5.Text = "Çevre: " + cevre.ToString();
            }
        }
        int boy2 = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int boy2 = Convert.ToInt32(textBox3.Text);
            if (radioButton3.Checked)
            {
                int alan = boy2 * boy2;
                label3.Text = "Alan: " + alan.ToString();
            }
            else if (radioButton4.Checked)
            {
                int cevre = 4 * boy2;
                label3.Text = "Çevre: " + cevre.ToString();
            }
        }
    }
}
