using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARTIseverim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);

            if (a > 0 && a <= 45)
            {
                MessageBox.Show("notun 1");
            }

            if (a > 45 && a <= 55) 
            {
                MessageBox.Show("notun 2");
            }

            if (a > 55 && a <= 70) 
            {
                MessageBox.Show("notun 3");
            }

            if (a > 70 && a <= 85) 
            {
                MessageBox.Show("notun 4");
            }

            if (a > 85 && a <= 101)
            {
                MessageBox.Show("notun 5");
            }

            else
            {
                MessageBox.Show("Hatalı giriş vro");
            }    

        }
    }
}
