using System;
using System.Windows.Forms;

namespace _630furkanelekririk_faturası
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int x = 0; int y = 0; int z = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            if (x>=350 && x<500)
            {
                y=(x*30)/ 100;
                z= (x*96)+y;
                label3.Text = "Faturanız: " + z.ToString() + " TL";
            }
            else if (x >= 500)
            {
                y = (x * 40) / 100;
                z = (x*96) + y;
                label3.Text = "Faturanız: " + z.ToString() + " TL";
            }
            else
            {
                x = (x * 96);
                label3.Text = "Faturanız: " + x.ToString() + " TL";
            }
        }
    }
}
