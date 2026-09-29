namespace WindowsFormsApp11
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.labelMirror = new System.Windows.Forms.Label();
            this.listBoxHistory = new System.Windows.Forms.ListBox();
            this.listBoxCities = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBoxItems = new System.Windows.Forms.ComboBox();
            this.buttonAddToCombo = new System.Windows.Forms.Button();
            this.groupBoxLabel = new System.Windows.Forms.GroupBox();
            this.radioButtonTrigger = new System.Windows.Forms.RadioButton();
            this.labelInGroup = new System.Windows.Forms.Label();
            this.groupBoxMarital = new System.Windows.Forms.GroupBox();
            this.radioButtonMarried = new System.Windows.Forms.RadioButton();
            this.radioButtonSingle = new System.Windows.Forms.RadioButton();
            this.labelMaritalStatus = new System.Windows.Forms.Label();
            this.groupBoxEnable = new System.Windows.Forms.GroupBox();
            this.radioButtonEnable = new System.Windows.Forms.RadioButton();
            this.radioButtonDisable = new System.Windows.Forms.RadioButton();
            this.groupBoxTransfer = new System.Windows.Forms.GroupBox();
            this.textBoxNewItem = new System.Windows.Forms.TextBox();
            this.buttonAddNew = new System.Windows.Forms.Button();
            this.comboBoxSource = new System.Windows.Forms.ComboBox();
            this.buttonTransfer = new System.Windows.Forms.Button();
            this.comboBoxTarget = new System.Windows.Forms.ComboBox();
            this.groupBoxVisibility = new System.Windows.Forms.GroupBox();
            this.radioButtonShow = new System.Windows.Forms.RadioButton();
            this.radioButtonHide = new System.Windows.Forms.RadioButton();
            this.buttonToToggle = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBoxLabel.SuspendLayout();
            this.groupBoxMarital.SuspendLayout();
            this.groupBoxEnable.SuspendLayout();
            this.groupBoxTransfer.SuspendLayout();
            this.groupBoxVisibility.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(12, 12);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(300, 20);
            this.textBoxInput.TabIndex = 0;
            this.textBoxInput.TextChanged += new System.EventHandler(this.textBoxInput_TextChanged);
            this.textBoxInput.MouseEnter += new System.EventHandler(this.textBoxInput_MouseEnter);
            this.textBoxInput.MouseLeave += new System.EventHandler(this.textBoxInput_MouseLeave);
            // 
            // labelMirror
            // 
            this.labelMirror.AutoSize = true;
            this.labelMirror.Location = new System.Drawing.Point(12, 45);
            this.labelMirror.Name = "labelMirror";
            this.labelMirror.Size = new System.Drawing.Size(19, 13);
            this.labelMirror.TabIndex = 1;
            this.labelMirror.Text = "----";
            // 
            // listBoxHistory
            // 
            this.listBoxHistory.FormattingEnabled = true;
            this.listBoxHistory.Location = new System.Drawing.Point(12, 75);
            this.listBoxHistory.Name = "listBoxHistory";
            this.listBoxHistory.Size = new System.Drawing.Size(300, 147);
            this.listBoxHistory.TabIndex = 2;
            // 
            // listBoxCities
            // 
            this.listBoxCities.FormattingEnabled = true;
            this.listBoxCities.Location = new System.Drawing.Point(12, 420);
            this.listBoxCities.Name = "listBoxCities";
            this.listBoxCities.Size = new System.Drawing.Size(200, 95);
            this.listBoxCities.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelStatus);
            this.groupBox2.Location = new System.Drawing.Point(330, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Durum";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(6, 22);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(44, 13);
            this.labelStatus.TabIndex = 0;
            this.labelStatus.Text = "Bekliyor";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBoxItems);
            this.groupBox3.Controls.Add(this.buttonAddToCombo);
            this.groupBox3.Location = new System.Drawing.Point(546, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 150);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Combobox İşlemleri";
            // 
            // comboBoxItems
            // 
            this.comboBoxItems.FormattingEnabled = true;
            this.comboBoxItems.Location = new System.Drawing.Point(6, 22);
            this.comboBoxItems.Name = "comboBoxItems";
            this.comboBoxItems.Size = new System.Drawing.Size(188, 21);
            this.comboBoxItems.TabIndex = 0;
            // 
            // buttonAddToCombo
            // 
            this.buttonAddToCombo.Location = new System.Drawing.Point(6, 55);
            this.buttonAddToCombo.Name = "buttonAddToCombo";
            this.buttonAddToCombo.Size = new System.Drawing.Size(188, 23);
            this.buttonAddToCombo.TabIndex = 1;
            this.buttonAddToCombo.Text = "Combobox\'a Ekle";
            this.buttonAddToCombo.UseVisualStyleBackColor = true;
            this.buttonAddToCombo.Click += new System.EventHandler(this.buttonAddToCombo_Click);
            // 
            // groupBoxLabel
            // 
            this.groupBoxLabel.Controls.Add(this.radioButtonTrigger);
            this.groupBoxLabel.Controls.Add(this.labelInGroup);
            this.groupBoxLabel.Location = new System.Drawing.Point(12, 240);
            this.groupBoxLabel.Name = "groupBoxLabel";
            this.groupBoxLabel.Size = new System.Drawing.Size(200, 80);
            this.groupBoxLabel.TabIndex = 5;
            this.groupBoxLabel.TabStop = false;
            this.groupBoxLabel.Text = "Label Grubu";
            // 
            // radioButtonTrigger
            // 
            this.radioButtonTrigger.AutoSize = true;
            this.radioButtonTrigger.Location = new System.Drawing.Point(6, 22);
            this.radioButtonTrigger.Name = "radioButtonTrigger";
            this.radioButtonTrigger.Size = new System.Drawing.Size(118, 17);
            this.radioButtonTrigger.TabIndex = 0;
            this.radioButtonTrigger.TabStop = true;
            this.radioButtonTrigger.Text = "Tetikle (Label Tıkla)";
            this.radioButtonTrigger.UseVisualStyleBackColor = true;
            this.radioButtonTrigger.Click += new System.EventHandler(this.radioButtonTrigger_Click);
            // 
            // labelInGroup
            // 
            this.labelInGroup.AutoSize = true;
            this.labelInGroup.Location = new System.Drawing.Point(6, 48);
            this.labelInGroup.Name = "labelInGroup";
            this.labelInGroup.Size = new System.Drawing.Size(16, 13);
            this.labelInGroup.TabIndex = 1;
            this.labelInGroup.Text = "---";
            // 
            // groupBoxMarital
            // 
            this.groupBoxMarital.Controls.Add(this.radioButtonMarried);
            this.groupBoxMarital.Controls.Add(this.radioButtonSingle);
            this.groupBoxMarital.Controls.Add(this.labelMaritalStatus);
            this.groupBoxMarital.Location = new System.Drawing.Point(233, 240);
            this.groupBoxMarital.Name = "groupBoxMarital";
            this.groupBoxMarital.Size = new System.Drawing.Size(200, 80);
            this.groupBoxMarital.TabIndex = 6;
            this.groupBoxMarital.TabStop = false;
            this.groupBoxMarital.Text = "Medeni Durum";
            // 
            // radioButtonMarried
            // 
            this.radioButtonMarried.AutoSize = true;
            this.radioButtonMarried.Location = new System.Drawing.Point(6, 19);
            this.radioButtonMarried.Name = "radioButtonMarried";
            this.radioButtonMarried.Size = new System.Drawing.Size(57, 17);
            this.radioButtonMarried.TabIndex = 0;
            this.radioButtonMarried.TabStop = true;
            this.radioButtonMarried.Text = "Evli";
            this.radioButtonMarried.UseVisualStyleBackColor = true;
            this.radioButtonMarried.CheckedChanged += new System.EventHandler(this.radioButtonMarried_CheckedChanged);
            // 
            // radioButtonSingle
            // 
            this.radioButtonSingle.AutoSize = true;
            this.radioButtonSingle.Location = new System.Drawing.Point(70, 19);
            this.radioButtonSingle.Name = "radioButtonSingle";
            this.radioButtonSingle.Size = new System.Drawing.Size(63, 17);
            this.radioButtonSingle.TabIndex = 1;
            this.radioButtonSingle.TabStop = true;
            this.radioButtonSingle.Text = "Bekar";
            this.radioButtonSingle.UseVisualStyleBackColor = true;
            this.radioButtonSingle.CheckedChanged += new System.EventHandler(this.radioButtonSingle_CheckedChanged);
            // 
            // labelMaritalStatus
            // 
            this.labelMaritalStatus.AutoSize = true;
            this.labelMaritalStatus.Location = new System.Drawing.Point(6, 44);
            this.labelMaritalStatus.Name = "labelMaritalStatus";
            this.labelMaritalStatus.Size = new System.Drawing.Size(16, 13);
            this.labelMaritalStatus.TabIndex = 2;
            this.labelMaritalStatus.Text = "---";
            // 
            // groupBoxEnable
            // 
            this.groupBoxEnable.Controls.Add(this.radioButtonEnable);
            this.groupBoxEnable.Controls.Add(this.radioButtonDisable);
            this.groupBoxEnable.Location = new System.Drawing.Point(220, 240);
            this.groupBoxEnable.Name = "groupBoxEnable";
            this.groupBoxEnable.Size = new System.Drawing.Size(200, 80);
            this.groupBoxEnable.TabIndex = 6;
            this.groupBoxEnable.TabStop = false;
            this.groupBoxEnable.Text = "Textbox Durumu";
            // 
            // radioButtonEnable
            // 
            this.radioButtonEnable.AutoSize = true;
            this.radioButtonEnable.Location = new System.Drawing.Point(6, 22);
            this.radioButtonEnable.Name = "radioButtonEnable";
            this.radioButtonEnable.Size = new System.Drawing.Size(48, 17);
            this.radioButtonEnable.TabIndex = 0;
            this.radioButtonEnable.TabStop = true;
            this.radioButtonEnable.Text = "Aktif";
            this.radioButtonEnable.UseVisualStyleBackColor = true;
            this.radioButtonEnable.CheckedChanged += new System.EventHandler(this.radioButtonEnable_CheckedChanged);
            // 
            // radioButtonDisable
            // 
            this.radioButtonDisable.AutoSize = true;
            this.radioButtonDisable.Location = new System.Drawing.Point(70, 22);
            this.radioButtonDisable.Name = "radioButtonDisable";
            this.radioButtonDisable.Size = new System.Drawing.Size(52, 17);
            this.radioButtonDisable.TabIndex = 1;
            this.radioButtonDisable.TabStop = true;
            this.radioButtonDisable.Text = "Pasif";
            this.radioButtonDisable.UseVisualStyleBackColor = true;
            this.radioButtonDisable.CheckedChanged += new System.EventHandler(this.radioButtonDisable_CheckedChanged);
            // 
            // groupBoxTransfer
            // 
            this.groupBoxTransfer.Controls.Add(this.textBoxNewItem);
            this.groupBoxTransfer.Controls.Add(this.buttonAddNew);
            this.groupBoxTransfer.Controls.Add(this.comboBoxSource);
            this.groupBoxTransfer.Controls.Add(this.buttonTransfer);
            this.groupBoxTransfer.Controls.Add(this.comboBoxTarget);
            this.groupBoxTransfer.Location = new System.Drawing.Point(546, 180);
            this.groupBoxTransfer.Name = "groupBoxTransfer";
            this.groupBoxTransfer.Size = new System.Drawing.Size(200, 200);
            this.groupBoxTransfer.TabIndex = 7;
            this.groupBoxTransfer.TabStop = false;
            this.groupBoxTransfer.Text = "Transfer İşlemleri";
            // 
            // textBoxNewItem
            // 
            this.textBoxNewItem.Location = new System.Drawing.Point(6, 22);
            this.textBoxNewItem.Name = "textBoxNewItem";
            this.textBoxNewItem.Size = new System.Drawing.Size(188, 20);
            this.textBoxNewItem.TabIndex = 0;
            // 
            // buttonAddNew
            // 
            this.buttonAddNew.Location = new System.Drawing.Point(6, 48);
            this.buttonAddNew.Name = "buttonAddNew";
            this.buttonAddNew.Size = new System.Drawing.Size(188, 23);
            this.buttonAddNew.TabIndex = 1;
            this.buttonAddNew.Text = "Ekle";
            this.buttonAddNew.UseVisualStyleBackColor = true;
            this.buttonAddNew.Click += new System.EventHandler(this.buttonAddNew_Click);
            // 
            // comboBoxSource
            // 
            this.comboBoxSource.FormattingEnabled = true;
            this.comboBoxSource.Location = new System.Drawing.Point(6, 80);
            this.comboBoxSource.Name = "comboBoxSource";
            this.comboBoxSource.Size = new System.Drawing.Size(120, 21);
            this.comboBoxSource.TabIndex = 2;
            // 
            // buttonTransfer
            // 
            this.buttonTransfer.Location = new System.Drawing.Point(132, 78);
            this.buttonTransfer.Name = "buttonTransfer";
            this.buttonTransfer.Size = new System.Drawing.Size(38, 23);
            this.buttonTransfer.TabIndex = 3;
            this.buttonTransfer.Text = ">>";
            this.buttonTransfer.UseVisualStyleBackColor = true;
            this.buttonTransfer.Click += new System.EventHandler(this.buttonTransfer_Click);
            // 
            // comboBoxTarget
            // 
            this.comboBoxTarget.FormattingEnabled = true;
            this.comboBoxTarget.Location = new System.Drawing.Point(6, 110);
            this.comboBoxTarget.Name = "comboBoxTarget";
            this.comboBoxTarget.Size = new System.Drawing.Size(188, 21);
            this.comboBoxTarget.TabIndex = 4;
            // 
            // groupBoxMessage
            // 
            this.groupBoxMessage = new System.Windows.Forms.GroupBox();
            this.textBoxMessageInput = new System.Windows.Forms.TextBox();
            this.buttonShowMessage = new System.Windows.Forms.Button();
            this.groupBoxMessage.Controls.Add(this.textBoxMessageInput);
            this.groupBoxMessage.Controls.Add(this.buttonShowMessage);
            this.groupBoxMessage.Location = new System.Drawing.Point(220, 420);
            this.groupBoxMessage.Name = "groupBoxMessage";
            this.groupBoxMessage.Size = new System.Drawing.Size(300, 80);
            this.groupBoxMessage.TabIndex = 9;
            this.groupBoxMessage.TabStop = false;
            this.groupBoxMessage.Text = "Mesaj Göster";
            // 
            // textBoxMessageInput
            // 
            this.textBoxMessageInput.Location = new System.Drawing.Point(6, 22);
            this.textBoxMessageInput.Name = "textBoxMessageInput";
            this.textBoxMessageInput.Size = new System.Drawing.Size(288, 20);
            this.textBoxMessageInput.TabIndex = 0;
            // 
            // buttonShowMessage
            // 
            this.buttonShowMessage.Location = new System.Drawing.Point(6, 48);
            this.buttonShowMessage.Name = "buttonShowMessage";
            this.buttonShowMessage.Size = new System.Drawing.Size(288, 23);
            this.buttonShowMessage.TabIndex = 1;
            this.buttonShowMessage.Text = "Mesajı Göster";
            this.buttonShowMessage.UseVisualStyleBackColor = true;
            this.buttonShowMessage.Click += new System.EventHandler(this.buttonShowMessage_Click);
            // groupBoxVisibility
            // 
            this.groupBoxVisibility.Controls.Add(this.radioButtonShow);
            this.groupBoxVisibility.Controls.Add(this.radioButtonHide);
            this.groupBoxVisibility.Controls.Add(this.buttonToToggle);
            this.groupBoxVisibility.Location = new System.Drawing.Point(12, 330);
            this.groupBoxVisibility.Name = "groupBoxVisibility";
            this.groupBoxVisibility.Size = new System.Drawing.Size(200, 100);
            this.groupBoxVisibility.TabIndex = 8;
            this.groupBoxVisibility.TabStop = false;
            this.groupBoxVisibility.Text = "Buton Görünürlük";
            // 
            // radioButtonShow
            // 
            this.radioButtonShow.AutoSize = true;
            this.radioButtonShow.Location = new System.Drawing.Point(6, 22);
            this.radioButtonShow.Name = "radioButtonShow";
            this.radioButtonShow.Size = new System.Drawing.Size(49, 17);
            this.radioButtonShow.TabIndex = 0;
            this.radioButtonShow.TabStop = true;
            this.radioButtonShow.Text = "Göster";
            this.radioButtonShow.UseVisualStyleBackColor = true;
            this.radioButtonShow.CheckedChanged += new System.EventHandler(this.radioButtonShow_CheckedChanged);
            // 
            // radioButtonHide
            // 
            this.radioButtonHide.AutoSize = true;
            this.radioButtonHide.Location = new System.Drawing.Point(70, 22);
            this.radioButtonHide.Name = "radioButtonHide";
            this.radioButtonHide.Size = new System.Drawing.Size(47, 17);
            this.radioButtonHide.TabIndex = 1;
            this.radioButtonHide.TabStop = true;
            this.radioButtonHide.Text = "Gizle";
            this.radioButtonHide.UseVisualStyleBackColor = true;
            this.radioButtonHide.CheckedChanged += new System.EventHandler(this.radioButtonHide_CheckedChanged);
            // 
            // buttonToToggle
            // 
            this.buttonToToggle.Location = new System.Drawing.Point(6, 48);
            this.buttonToToggle.Name = "buttonToToggle";
            this.buttonToToggle.Size = new System.Drawing.Size(188, 23);
            this.buttonToToggle.TabIndex = 2;
            this.buttonToToggle.Text = "Hedef Buton";
            this.buttonToToggle.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 720);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBoxTransfer);
            this.Controls.Add(this.groupBoxVisibility);
            this.Controls.Add(this.groupBoxMessage);
            this.Controls.Add(this.groupBoxLabel);
            this.Controls.Add(this.groupBoxEnable);
            this.Controls.Add(this.groupBoxMarital);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.listBoxHistory);
            this.Controls.Add(this.listBoxCities);
            this.Controls.Add(this.labelMirror);
            this.Controls.Add(this.textBoxInput);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBoxLabel.ResumeLayout(false);
            this.groupBoxLabel.PerformLayout();
            this.groupBoxMarital.ResumeLayout(false);
            this.groupBoxMarital.PerformLayout();
            this.groupBoxEnable.ResumeLayout(false);
            this.groupBoxEnable.PerformLayout();
            this.groupBoxTransfer.ResumeLayout(false);
            this.groupBoxTransfer.PerformLayout();
            this.groupBoxVisibility.ResumeLayout(false);
            this.groupBoxVisibility.PerformLayout();
            this.groupBoxMessage.ResumeLayout(false);
            this.groupBoxMessage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Label labelMirror;
        private System.Windows.Forms.ListBox listBoxHistory;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBoxItems;
        private System.Windows.Forms.Button buttonAddToCombo;
        private System.Windows.Forms.GroupBox groupBoxLabel;
        private System.Windows.Forms.RadioButton radioButtonTrigger;
        private System.Windows.Forms.Label labelInGroup;
        private System.Windows.Forms.GroupBox groupBoxMarital;
        private System.Windows.Forms.RadioButton radioButtonMarried;
        private System.Windows.Forms.RadioButton radioButtonSingle;
        private System.Windows.Forms.Label labelMaritalStatus;
        private System.Windows.Forms.GroupBox groupBoxTransfer;
        private System.Windows.Forms.TextBox textBoxNewItem;
        private System.Windows.Forms.Button buttonAddNew;
        private System.Windows.Forms.ComboBox comboBoxSource;
        private System.Windows.Forms.Button buttonTransfer;
        private System.Windows.Forms.ComboBox comboBoxTarget;
        private System.Windows.Forms.GroupBox groupBoxEnable;
        private System.Windows.Forms.RadioButton radioButtonEnable;
        private System.Windows.Forms.RadioButton radioButtonDisable;
        private System.Windows.Forms.GroupBox groupBoxVisibility;
        private System.Windows.Forms.RadioButton radioButtonShow;
        private System.Windows.Forms.RadioButton radioButtonHide;
        private System.Windows.Forms.Button buttonToToggle;
        private System.Windows.Forms.GroupBox groupBoxMessage;
        private System.Windows.Forms.TextBox textBoxMessageInput;
        private System.Windows.Forms.Button buttonShowMessage;
        private System.Windows.Forms.ListBox listBoxCities;
    }
}

