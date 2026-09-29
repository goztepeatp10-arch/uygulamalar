using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Şehirleri form yüklendiğinde listBoxCities'e ekle
            listBoxCities.Items.AddRange(new object[] { "İzmir", "Adana", "İstanbul" });
        }

        private void textBoxInput_TextChanged(object sender, EventArgs e)
        {
            var txt = textBoxInput.Text;
            // anlık olarak labela aktar
            labelMirror.Text = txt;

            // anlık olarak listboxa ekle (boş değilse ve son eklenenle aynı değilse)
            if (!string.IsNullOrEmpty(txt))
            {
                if (listBoxHistory.Items.Count == 0 ||
                    !string.Equals(listBoxHistory.Items[listBoxHistory.Items.Count - 1].ToString(), txt, StringComparison.Ordinal))
                {
                    listBoxHistory.Items.Add(txt);
                }
            }
        }

        private void textBoxInput_MouseEnter(object sender, EventArgs e)
        {
            // textboxun üzerine mouse geldiğinde başka grouptaki labela "Merhaba" yaz
            labelStatus.Text = "Merhaba";
        }

        private void textBoxInput_MouseLeave(object sender, EventArgs e)
        {
            // mouse ayrılınca labela "Güle güle" yaz
            labelStatus.Text = "Güle güle";
        }

        private void buttonAddToCombo_Click(object sender, EventArgs e)
        {
            var txt = textBoxInput.Text;
            if (!string.IsNullOrWhiteSpace(txt))
            {
                // aynı öğe varsa tekrar eklemeyelim
                bool exists = comboBoxItems.Items.Cast<object>().Any(i => string.Equals(i.ToString(), txt, StringComparison.Ordinal));
                if (!exists)
                {
                    comboBoxItems.Items.Add(txt);
                }
                // isteğe bağlı: eklenen öğeyi seç
                comboBoxItems.SelectedItem = txt;
            }
        }
        private void radioButtonTrigger_Click(object sender, EventArgs e)
        {
            // radio button'a tıklandığında groupBoxLabel içindeki labelInGroup metnini "Tıklandı" yap
            labelInGroup.Text = "Tıklandı";
            // radio button'u otomatik olarak unchecked yap
            var rb = sender as RadioButton;
            if (rb != null) rb.Checked = false;
        }

        private void radioButtonMarried_CheckedChanged(object sender, EventArgs e)
        {
            var rb = sender as RadioButton;
            if (rb != null && rb.Checked)
            {
                labelMaritalStatus.Text = "Evlisiniz";
            }
        }

        private void radioButtonSingle_CheckedChanged(object sender, EventArgs e)
        {
            var rb = sender as RadioButton;
            if (rb != null && rb.Checked)
            {
                labelMaritalStatus.Text = "Bekarsınız";
            }
        }

        private void buttonAddNew_Click(object sender, EventArgs e)
        {
            var txt = textBoxNewItem.Text;
            if (!string.IsNullOrWhiteSpace(txt))
            {
                if (!comboBoxSource.Items.Cast<object>().Any(i => string.Equals(i.ToString(), txt, StringComparison.Ordinal)))
                {
                    comboBoxSource.Items.Add(txt);
                }
                comboBoxSource.SelectedItem = txt;
            }
        }

        private void buttonTransfer_Click(object sender, EventArgs e)
        {
            var sel = comboBoxSource.SelectedItem;
            if (sel == null) return;
            var txt = sel.ToString();
            if (string.IsNullOrEmpty(txt)) return;
            // hedef combobox'a ekle (aynı yoksa)
            if (!comboBoxTarget.Items.Cast<object>().Any(i => string.Equals(i.ToString(), txt, StringComparison.Ordinal)))
            {
                comboBoxTarget.Items.Add(txt);
            }
            comboBoxTarget.SelectedItem = txt;
        }

        private void radioButtonEnable_CheckedChanged(object sender, EventArgs e)
        {
            var rb = sender as RadioButton;
            if (rb != null && rb.Checked)
            {
                textBoxInput.Enabled = true;
                textBoxInput.Focus();
            }
        }

        private void radioButtonDisable_CheckedChanged(object sender, EventArgs e)
        {
            var rb = sender as RadioButton;
            if (rb != null && rb.Checked)
            {
                textBoxInput.Enabled = false;
            }
        }

        private void radioButtonShow_CheckedChanged(object sender, EventArgs e)
        {
            var rb = sender as RadioButton;
            if (rb != null && rb.Checked)
            {
                buttonToToggle.Visible = true;
            }
        }

        private void radioButtonHide_CheckedChanged(object sender, EventArgs e)
        {
            var rb = sender as RadioButton;
            if (rb != null && rb.Checked)
            {
                buttonToToggle.Visible = false;
            }
        }

        private void buttonShowMessage_Click(object sender, EventArgs e)
        {
            var msg = textBoxMessageInput.Text;
            MessageBox.Show(this, msg, "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
