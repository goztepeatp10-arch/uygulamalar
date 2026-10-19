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

namespace BANKA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int yas = Convert.ToInt32(textBox1.Text);
            int gelir = Convert.ToInt32(textBox2.Text);
            int krediNotu = Convert.ToInt32(textBox3.Text);

            if (yas >= 18)
            {
                if (gelir >= 20000)
                {
                    if (krediNotu >= 1200)
                    {
                        label4.Text = "Kredi onaylandi";
                    }
                    else
                    {
                        label4.Text = "Kredi reddedildi";
                    }
                }
                else
                {
                    label4.Text = "Kredi reddedildi";
                }
            }
            else
            {
                label4.Text = "Kredi reddedildi";


            }
        }
    }
}
