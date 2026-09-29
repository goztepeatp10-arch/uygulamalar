using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Globalization;
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Boş bırakılabilir; giriş anlık kontrolü isterseniz buraya ekleyin.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // TextBox içeriğini güvenli şekilde sayıya çevir
            if (!decimal.TryParse(textBox1.Text, System.Globalization.NumberStyles.Number, System.Globalization.CultureInfo.CurrentCulture, out decimal value))
            {
                MessageBox.Show("Lütfen geçerli bir sayı girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // %18 hesabı
            decimal percent18 = value * 0.18m;

            // Sonucu label'a yaz
            label1.Text = percent18.ToString("N2", System.Globalization.CultureInfo.CurrentCulture);
        }
    }
}
