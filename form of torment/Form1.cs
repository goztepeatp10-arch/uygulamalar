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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
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

        private void textBox3_MouseHover(object sender, EventArgs e)
        {
            label2.Text = "hello :3";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_MouseHover(object sender, EventArgs e)
        {
            label2.Text = "wawa";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBox4.Text);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label3.Text = "STATUS: 8 BILLION PEOPLE KILLED";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label4.Text = "Liar";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label4.Text = "Arent we all";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox2.Items.Add(textBox5.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox3.Items.Add(comboBox2.Text);
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            textBox6.Enabled = true;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            textBox6.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            button4.Enabled = true;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            button4.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox7.Text);
        }
    }
    }
