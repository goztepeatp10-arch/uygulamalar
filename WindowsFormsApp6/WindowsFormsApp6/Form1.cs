using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        {
            
            double tuketim = Convert.ToDouble(textBox1.Text);
            double birimFiyat = Convert.ToDouble(textBox2.Text);
            double fatura = tuketim * (birimFiyat / 100);

            if (tuketim > 500) { fatura *= 1.30; }
            else if (tuketim > 350) { fatura *= 1.10; }

            label3.Text = fatura.ToString("0.0") + " TL";
        }




    }

}
    }

