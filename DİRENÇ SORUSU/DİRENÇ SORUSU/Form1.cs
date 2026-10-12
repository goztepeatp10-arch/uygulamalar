using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DİRENÇ_SORUSU
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int r1 = Convert.ToInt32(textBox1.Text);
            int r2 = Convert.ToInt32(textBox2.Text);
            int r3 = Convert.ToInt32(textBox3.Text);

            
            int seriSonuc = r1 + r2 + r3;
            label5.Text = seriSonuc.ToString();

            
            
            double paralelSonuc = 1 / ((1.0 / r1) + (1.0 / r2) + (1.0 / r3));
            label6.Text = paralelSonuc.ToString();
        }
    }
}
