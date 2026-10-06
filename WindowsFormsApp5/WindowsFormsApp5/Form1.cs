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

        private void button1_Click(object sender, EventArgs e)
        {
            int adet = Convert.ToInt32(textBox1.Text);
            double birimfiyat = Convert.ToDouble(textBox2.Text);


            double toplamtutar = adet * birimfiyat;
            double indirimorani = 0;


            if (adet >= 10)
            {
                indirimorani = 0.10;
            }
            else if (adet >= 5)
            {
                indirimorani = 0.05;
            }


            double nettutar = toplamtutar * (1 - indirimorani);


            label3.Text = nettutar.ToString("0.00") + " TL";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
