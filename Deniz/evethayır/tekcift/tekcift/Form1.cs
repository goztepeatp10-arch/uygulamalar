using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tekcift
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("lütfen sayı girin", "zenci2", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (int.TryParse(textBox1.Text, out int sayi))
            {
               
                if (sayi % 2 == 0)
                {
                    label1.Text = $"Sonuç: {sayi} sayısı çifttir";
                }
                else
                {
                    label1.Text = $"Sonuç: {sayi} sayısı tektir";
                }
            }
            else
            {
                MessageBox.Show("sadece tam sayı", "Zenci", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
