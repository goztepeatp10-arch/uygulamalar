using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        private const string V = "İZMİR";
        private ComboBox comboBox2;
        private Button button2;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private Button button3;
        private Button button4;
        private TextBox textBox6;
        public Form1()
        {
            InitializeComponent();
            // textBox2'ye Enter ile kayıt eklemek için olay bağlanıyor
           
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Label'a "izmir" yazılır
            label1.Text = "izmir";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_KeyDown(object sender, KeyEventArgs e)
        {
          
        }

        private void AddToListBox()
        {
         
        }

        private void TextBox_MouseEnter(object sender, EventArgs e)
        {
            // Fare textbox içine geldiğinde groupBox3 içindeki label2'ye "merhaba" yaz
            label2.Text = "merhaba";
        }

        private void TextBox_MouseLeave(object sender, EventArgs e)
        {
            // Fare textbox'tan çıktığında label2'yi temizle
            label2.Text = string.Empty;
        }

        private void TextBox4_MouseLeave(object sender, EventArgs e)
        {
            // groupBox4 içindeki textbox'tan imleç çekilince label3'e "society" yaz
            label3.Text = "society";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
           
        }

        private void RadioButton1_Click(object sender, EventArgs e)
        {
            // radio butona tıklandığında label4'e "grief" yaz
            label4.Text = "grief";
        }

        private void RadioButton2_Click(object sender, EventArgs e)
        {
            // "Bekar" radio butonuna tıklandığında label5'e "bekar" yaz
            label5.Text = "bekar";
        }

        private void RadioButton3_Click(object sender, EventArgs e)
        {
            // "Evli" radio butonuna tıklandığında label5'e "evlisiniz" yaz
            label5.Text = "evlisiniz";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
           
        }

        private void Button4_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            label1.Text = "merhaba";
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.Text = "fare gitti";
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            label3.Text = textBox4.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox2.Text);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBox5.Text);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label4.Text = "grief";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label5.Text = "evlisiniz";

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label5.Text = "bekar";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5_Click = label2.Text = V;
        }
    }
}
