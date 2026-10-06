using System;
using System.Windows.Forms;

namespace alp_para
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            {
                double dolar = Convert.ToDouble(textBox1.Text);
                double euro = Convert.ToDouble(textBox2.Text);
                double para = Convert.ToDouble(textBox3.Text);
                double sonuc = 0;

                if (radioButton1.Checked)
                {
                    sonuc = para / dolar;
                }
                else if (radioButton2.Checked)
                {
                    sonuc = para * dolar;
                }
                else if (radioButton3.Checked)
                {
                    sonuc = para / euro;
                }
                else if (radioButton4.Checked)
                {
                    sonuc = para * euro;
                }
                else if (radioButton5.Checked)
                {
                    sonuc = para * dolar / euro;
                }
                else if (radioButton6.Checked)
                {
                    sonuc = para * euro / dolar;
                }

                label4.Text = "Sonuç: " + sonuc.ToString("0.00");
            }

        }
    }
}
