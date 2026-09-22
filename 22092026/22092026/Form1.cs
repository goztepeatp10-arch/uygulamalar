using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22092026
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            MessageBox.Show("ilk mesaj","mesaj başlığı");
            MessageBox.Show("2.mesaj","mesaj başlığı", MessageBoxButtons.YesNoCancel);
            MessageBox.Show("3.mesaj","mesaj başlığı", MessageBoxButtons.OKCancel);
        }
        int a = 500;
        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(a.ToString());
            
        }
    }
}  