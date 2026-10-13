using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt16(textBox1.Text);
            int b = Convert.ToInt16(textBox2.Text);
            int c = Convert.ToInt16(textBox3.Text);

            if (a > 0 && b > 0 && c > 0)
            {

                if (a + b > c && a + c > b && b + c > a)
                {
                    if (a == b || b == c || c == a)
                    {
                        label4.Text = "ikizkenar Üçgen";
                    }
                    if (b == c && a == b)
                    {
                        label4.Text = "Eş Kenar Üçgen";
                    }
                    if ((a != b && b != c && a != c))

                    {
                        label4.Text = "Çeşitkenar üçgen";
                    }
                   
                } else
                    {
                        label4.Text = "Üçgen oluşturulamaz";

                    }
            }
            else
            {
                label4.Text = "degerler 0 dan büyük olmalıdır";


            }
        }
    }
}
