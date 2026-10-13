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

        private void button1_Click(object sender, EventArgs e)
        {
            double siparisTutari = Convert.ToDouble(textBox1.Text);
            string siparisTuru = (comboBox1.Text);

            if (siparisTutari > 500 && comboBox1.Text == "standart teslimat")
            {
                siparisTutari = 500;

            }
            else if(siparisTutari >500 &&  comboBox1.Text =="hızlı teslimat")
            {
                siparisTutari = siparisTutari + 50;
            }
            if (siparisTutari < 500 && comboBox1.Text == "standart teslimat") 
            {
                siparisTutari = siparisTutari + 30;
            }
            else if(siparisTutari < 500 && comboBox1.Text == "hızlı teslimat")
            {
                siparisTutari = siparisTutari + 70;
            }
            label3.Text=siparisTutari.ToString();

        }
    }
}


