using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hüso
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text.Trim();
            int number;

            if (!int.TryParse(text, out number))
            {
                label1.Text = "Lütfen bir tam sayı girin.";
                return;
            }

            if (number > 0)
            {
                label1.Text = "Girilen sayı pozitif.";
            }
            else if (number < 0)
            {
                label1.Text = "Girilen sayı negatif.";
            }
            else
            {
                label1.Text = "Girilen sayı sıfır.";
            }
        }
    }
}
