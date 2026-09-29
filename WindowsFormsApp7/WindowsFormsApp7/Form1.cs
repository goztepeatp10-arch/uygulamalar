using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox2.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox3_MouseEnter(object sender, EventArgs e)
        {
            label2.Text = "merhaba";
        }

        private void textBox4_MouseLeave(object sender, EventArgs e)
        {
            label3.Text = "Güle Güle";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBox5.Text);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label4.Text = "TIKLANDI";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label5.Text = "Bekarsınız";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label5.Text = "Evlisiniz";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox2.Items.Add(textBox6.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox3.Items.Add(comboBox2.SelectedItem);
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            textBox7.Enabled = true;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            textBox7.Enabled= false;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            button4.Visible = true;
            
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            button4.Visible= false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox8.Text);
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox2.Items.Add("Trabzon");
            listBox2.Items.Add("Aydın");
            listBox2.Items.Add("Manisa");
            listBox2.Items.Add("Rize");
        }
    }
}
