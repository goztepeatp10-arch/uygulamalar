using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
   
           
        {
            int sayi = Convert.ToInt32(textBox1.Text);

            if (sayi >= 0 && sayi < 45)
                label1.Text = "1";
            else if (sayi >= 45 && sayi < 55)
                label1.Text = "2";
            else if (sayi >= 55 && sayi < 70)
                label1.Text = "3";
            else if (sayi >= 70 && sayi < 85)
                label1.Text = "4";
            else if (sayi >= 85 && sayi <= 100)
                label1.Text = "5";
            else
                label1.Text = "Geçersiz sayı";
        }

    }
}



    