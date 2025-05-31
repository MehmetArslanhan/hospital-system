namespace Proje_Hastane
{
    partial class frmbilgiduzenle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BtnBilgiGuncelle = new Button();
            label7 = new Label();
            CmbCinsiyet = new ComboBox();
            TxtSifre = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            TxtSoyad = new TextBox();
            TxtAd = new TextBox();
            label3 = new Label();
            label2 = new Label();
            MskTC = new MaskedTextBox();
            MskTelefon = new MaskedTextBox();
            SuspendLayout();
            // 
            // BtnBilgiGuncelle
            // 
            BtnBilgiGuncelle.BackColor = Color.SpringGreen;
            BtnBilgiGuncelle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnBilgiGuncelle.Location = new Point(193, 284);
            BtnBilgiGuncelle.Name = "BtnBilgiGuncelle";
            BtnBilgiGuncelle.Size = new Size(203, 32);
            BtnBilgiGuncelle.TabIndex = 32;
            BtnBilgiGuncelle.Text = "Güncelle";
            BtnBilgiGuncelle.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Teal;
            label7.Font = new Font("Segoe Script", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(12, 23);
            label7.Name = "label7";
            label7.Size = new Size(468, 61);
            label7.TabIndex = 31;
            label7.Text = "HASTA KAYIT PANELİ";
            // 
            // CmbCinsiyet
            // 
            CmbCinsiyet.BackColor = SystemColors.ButtonHighlight;
            CmbCinsiyet.FormattingEnabled = true;
            CmbCinsiyet.Items.AddRange(new object[] { "Kadın", "Erkek" });
            CmbCinsiyet.Location = new Point(193, 255);
            CmbCinsiyet.Name = "CmbCinsiyet";
            CmbCinsiyet.Size = new Size(202, 23);
            CmbCinsiyet.TabIndex = 30;
            // 
            // TxtSifre
            // 
            TxtSifre.BackColor = SystemColors.ButtonHighlight;
            TxtSifre.BorderStyle = BorderStyle.FixedSingle;
            TxtSifre.Location = new Point(193, 222);
            TxtSifre.Name = "TxtSifre";
            TxtSifre.Size = new Size(202, 23);
            TxtSifre.TabIndex = 29;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ControlText;
            label6.Location = new Point(82, 248);
            label6.Name = "label6";
            label6.Size = new Size(105, 30);
            label6.TabIndex = 26;
            label6.Text = "CİNSİYET";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlText;
            label5.Location = new Point(119, 215);
            label5.Name = "label5";
            label5.Size = new Size(68, 30);
            label5.TabIndex = 25;
            label5.Text = "ŞİFRE";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(82, 182);
            label4.Name = "label4";
            label4.Size = new Size(102, 30);
            label4.TabIndex = 24;
            label4.Text = "TELEFON";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(105, 122);
            label1.Name = "label1";
            label1.Size = new Size(82, 30);
            label1.TabIndex = 23;
            label1.Text = "SOYAD";
            // 
            // TxtSoyad
            // 
            TxtSoyad.BackColor = SystemColors.ButtonHighlight;
            TxtSoyad.BorderStyle = BorderStyle.FixedSingle;
            TxtSoyad.Location = new Point(193, 129);
            TxtSoyad.Name = "TxtSoyad";
            TxtSoyad.Size = new Size(202, 23);
            TxtSoyad.TabIndex = 22;
            // 
            // TxtAd
            // 
            TxtAd.BackColor = SystemColors.ButtonHighlight;
            TxtAd.BorderStyle = BorderStyle.FixedSingle;
            TxtAd.Location = new Point(193, 99);
            TxtAd.Name = "TxtAd";
            TxtAd.Size = new Size(202, 23);
            TxtAd.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(144, 92);
            label3.Name = "label3";
            label3.Size = new Size(43, 30);
            label3.TabIndex = 20;
            label3.Text = "AD";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(27, 152);
            label2.Name = "label2";
            label2.Size = new Size(160, 30);
            label2.TabIndex = 19;
            label2.Text = "T.C KİMLİK NO";
            // 
            // MskTC
            // 
            MskTC.Location = new Point(193, 158);
            MskTC.Mask = "00000000000";
            MskTC.Name = "MskTC";
            MskTC.Size = new Size(202, 23);
            MskTC.TabIndex = 43;
            MskTC.ValidatingType = typeof(int);
            // 
            // MskTelefon
            // 
            MskTelefon.Location = new Point(193, 189);
            MskTelefon.Mask = "(999) 000-0000";
            MskTelefon.Name = "MskTelefon";
            MskTelefon.Size = new Size(202, 23);
            MskTelefon.TabIndex = 44;
            // 
            // frmbilgiduzenle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(500, 332);
            Controls.Add(MskTelefon);
            Controls.Add(MskTC);
            Controls.Add(BtnBilgiGuncelle);
            Controls.Add(label7);
            Controls.Add(CmbCinsiyet);
            Controls.Add(TxtSifre);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(TxtSoyad);
            Controls.Add(TxtAd);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "frmbilgiduzenle";
            Text = "frmbilgiduzenle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnBilgiGuncelle;
        private Label label7;
        private ComboBox CmbCinsiyet;
        private TextBox TxtSifre;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label1;
        private TextBox TxtSoyad;
        private TextBox TxtAd;
        private Label label3;
        private Label label2;
        private MaskedTextBox MskTC;
        private MaskedTextBox MskTelefon;
    }
}