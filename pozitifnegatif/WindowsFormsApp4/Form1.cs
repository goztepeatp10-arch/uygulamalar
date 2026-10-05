using System;
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
            int sayi;
            sayi = Convert.ToInt32(textBox1.Text);

            if (sayi % 2 == 0)
            {
                label1.Text = "Bu bir çift sayıdır.";
            }
            else
            {
                label1.Text = "Bu bir tek sayıdır.";
            }
        }
    }
}
