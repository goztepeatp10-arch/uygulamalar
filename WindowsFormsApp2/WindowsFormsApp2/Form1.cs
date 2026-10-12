using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int galibiyet = + Convert.ToInt32(textBox1.Text);
            int toplamPuan = 0;

            if (radioButton1.Checked) 
            {
                int beraberlik =  Convert.ToInt32(textBox2.Text);
                toplamPuan = (galibiyet * 3) + (beraberlik * 1);
            }
            else if (radioButton2.Checked) 
            {
                toplamPuan = galibiyet * 2;
            }

            label3.Text = toplamPuan.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                label2.Visible = true;    
                textBox2.Visible = true; 
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                label2.Visible = false;
                textBox2.Visible = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int kenar1 = Convert.ToInt32(textBox3.Text);
            int kenar2 = Convert.ToInt32(textBox4.Text);
            int kenar3 = Convert.ToInt32(textBox5.Text);

            
            if (kenar1 == kenar2 && kenar2 == kenar3)
            {
                
                label7.Text = "Eşkenar Üçgen";
            }
            else if (kenar1 == kenar2 || kenar1 == kenar3 || kenar2 == kenar3)
            {
                
                label7.Text = "İkizkenar Üçgen";
            }
            else
            {
                
                label7.Text = "Çeşitkenar Üçgen";
            }
        }
        int a = 0; int b = 0;
        private void button3_Click(object sender, EventArgs e)
        {

            a = Convert.ToInt32(textBox6.Text);
            b = Convert.ToInt32(textBox7.Text);
            if (radioButton3.Checked)
            {
                int alan = a * b;
                label12.Text = "Alan: " + alan.ToString();
            }
            else if (radioButton4.Checked)
            {
                int cevre = 2 * (a + b);
                label12.Text = "Çevre: " + cevre.ToString();
            }
        }
        int boy2 = 0;
        private void button4_Click(object sender, EventArgs e)
        {
            int boy2 = Convert.ToInt32(textBox9.Text);
            if (radioButton6.Checked)
            {
                int alan = boy2 * boy2;
                label13.Text = "Alan: " + alan.ToString();
            }
            else if (radioButton4.Checked)
            {
                int cevre = 4 * boy2;
                label13.Text = "Çevre: " + cevre.ToString();
            }
        }
        }
    }
    

