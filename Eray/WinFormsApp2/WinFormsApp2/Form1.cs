namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayi1, sayi2, sonuc;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToInt16(textBox1.Text);
            sayi2 = Convert.ToInt16(textBox2.Text);
            sonuc = sayi1 + sayi2;
            textBox3.Text = sonuc.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToInt16(textBox1.Text);
            sayi2 = Convert.ToInt16(textBox2.Text);
            sonuc = sayi1 - sayi2;
            textBox3.Text = sonuc.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToInt16(textBox1.Text);
            sayi2 = Convert.ToInt16(textBox2.Text);
            sonuc = sayi1 / sayi2;
            textBox3.Text = sonuc.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToInt16(textBox1.Text);
            sayi2 = Convert.ToInt16(textBox2.Text);
            sonuc = sayi1 * sayi2;
            textBox3.Text = sonuc.ToString();

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
