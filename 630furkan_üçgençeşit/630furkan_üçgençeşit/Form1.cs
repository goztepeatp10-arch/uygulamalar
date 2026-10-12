using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _630furkan_üçgençeşit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       int kenar1 = 0; int kenar2 = 0; int kenar3 = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int kenar1 = Convert.ToInt32(textBox1.Text);
            int kenar2 = Convert.ToInt32(textBox2.Text);
            int kenar3 = Convert.ToInt32(textBox3.Text);
            if (kenar1 == kenar2 && kenar2 == kenar3)
            {
                label4.Text = "Eşkenar Üçgen";
            }
            else if (kenar1 == kenar2 || kenar2 == kenar3 || kenar1 == kenar3)
            {
                label4.Text = "İkizkenar Üçgen";
            }
            else
            {
                label4.Text = "Çeşitkenar Üçgen";
            }

        }
    }
}
