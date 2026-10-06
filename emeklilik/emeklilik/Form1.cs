using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace emeklilik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            button1.Click += Button1_Click;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
          
            if (!int.TryParse(textBox1.Text, out int yas)) { label4.Text = "Yaş sayı olmalı"; label4.ForeColor = Color.Red; return; }
            if (!int.TryParse(textBox2.Text, out int gun)) { label4.Text = "Gün sayı olmalı"; label4.ForeColor = Color.Red; return; }
            if (!int.TryParse(textBox3.Text, out int yil)) { label4.Text = "Yıl sayı olmalı"; label4.ForeColor = Color.Red; return; }

            bool kadin = radioButton1.Checked;
            bool erkek = radioButton2.Checked;

            if (!kadin && !erkek)
            {
                label4.Text = "Cinsiyet seçiniz.";
                label4.ForeColor = Color.Red;
                return;
            }

            var eksikler = new List<string>();

            if (erkek)
            {
                if (gun < 6500) eksikler.Add($"Gün: {gun}/6500");
                if (yas < 50) eksikler.Add($"Yaş: {yas}/50");
                if (yil < 40) eksikler.Add($"Çalışma yılı: {yil}/40");
            }
            else // kadın
            {
                if (gun < 4500) eksikler.Add("Gün: {gun}/4500");
                if (yas < 45) eksikler.Add("Yaş: {yas}/45");
                if (yil < 35) eksikler.Add("Çalışma yılı: {yil}/35");
            }

            if (eksikler.Count == 0)
            {
                label4.Text = "Emekli olabilirsiniz.";
                label4.ForeColor = Color.Green;
            }
            else
            {
                label4.Text = "Emekli değilsiniz. Eksikler:\n- " + string.Join("\n- ", eksikler);
                label4.ForeColor = Color.Red;
            }
        }
    }
}
