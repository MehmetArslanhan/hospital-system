namespace Proje_Hastane
{
    partial class frmdoktorbilgiduzenle
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
            label1 = new Label();
            TxtSoyad = new TextBox();
            TxtAd = new TextBox();
            label3 = new Label();
            label2 = new Label();
            BtnBilgiGuncelle = new Button();
            CmbCinsiyet = new ComboBox();
            TxtSifre = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            CmbBrans = new ComboBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(114, 138);
            label1.Name = "label1";
            label1.Size = new Size(82, 30);
            label1.TabIndex = 32;
            label1.Text = "SOYAD";
            // 
            // TxtSoyad
            // 
            TxtSoyad.BackColor = SystemColors.ButtonHighlight;
            TxtSoyad.BorderStyle = BorderStyle.FixedSingle;
            TxtSoyad.Location = new Point(202, 145);
            TxtSoyad.Name = "TxtSoyad";
            TxtSoyad.Size = new Size(202, 23);
            TxtSoyad.TabIndex = 31;
            // 
            // TxtAd
            // 
            TxtAd.BackColor = SystemColors.ButtonHighlight;
            TxtAd.BorderStyle = BorderStyle.FixedSingle;
            TxtAd.Location = new Point(202, 115);
            TxtAd.Name = "TxtAd";
            TxtAd.Size = new Size(202, 23);
            TxtAd.TabIndex = 30;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(153, 108);
            label3.Name = "label3";
            label3.Size = new Size(43, 30);
            label3.TabIndex = 29;
            label3.Text = "AD";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(36, 168);
            label2.Name = "label2";
            label2.Size = new Size(160, 30);
            label2.TabIndex = 28;
            label2.Text = "T.C KİMLİK NO";
            // 
            // BtnBilgiGuncelle
            // 
            BtnBilgiGuncelle.BackColor = Color.SpringGreen;
            BtnBilgiGuncelle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnBilgiGuncelle.Location = new Point(202, 294);
            BtnBilgiGuncelle.Name = "BtnBilgiGuncelle";
            BtnBilgiGuncelle.Size = new Size(203, 32);
            BtnBilgiGuncelle.TabIndex = 38;
            BtnBilgiGuncelle.Text = "Güncelle";
            BtnBilgiGuncelle.UseVisualStyleBackColor = false;
            // 
            // CmbCinsiyet
            // 
            CmbCinsiyet.BackColor = SystemColors.ButtonHighlight;
            CmbCinsiyet.FormattingEnabled = true;
            CmbCinsiyet.Items.AddRange(new object[] { "Kadın", "Erkek" });
            CmbCinsiyet.Location = new Point(202, 265);
            CmbCinsiyet.Name = "CmbCinsiyet";
            CmbCinsiyet.Size = new Size(202, 23);
            CmbCinsiyet.TabIndex = 37;
            // 
            // TxtSifre
            // 
            TxtSifre.BackColor = SystemColors.ButtonHighlight;
            TxtSifre.BorderStyle = BorderStyle.FixedSingle;
            TxtSifre.Location = new Point(202, 204);
            TxtSifre.Name = "TxtSifre";
            TxtSifre.Size = new Size(202, 23);
            TxtSifre.TabIndex = 36;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ControlText;
            label6.Location = new Point(91, 258);
            label6.Name = "label6";
            label6.Size = new Size(105, 30);
            label6.TabIndex = 35;
            label6.Text = "CİNSİYET";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlText;
            label5.Location = new Point(128, 197);
            label5.Name = "label5";
            label5.Size = new Size(68, 30);
            label5.TabIndex = 34;
            label5.Text = "ŞİFRE";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(112, 227);
            label4.Name = "label4";
            label4.Size = new Size(84, 30);
            label4.TabIndex = 39;
            label4.Text = "BRANŞ";
            // 
            // CmbBrans
            // 
            CmbBrans.BackColor = SystemColors.ButtonHighlight;
            CmbBrans.FormattingEnabled = true;
            CmbBrans.Items.AddRange(new object[] { "Kadın", "Erkek" });
            CmbBrans.Location = new Point(202, 236);
            CmbBrans.Name = "CmbBrans";
            CmbBrans.Size = new Size(202, 23);
            CmbBrans.TabIndex = 40;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Teal;
            label7.Font = new Font("Segoe Script", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(36, 26);
            label7.Name = "label7";
            label7.Size = new Size(425, 48);
            label7.TabIndex = 41;
            label7.Text = "DOKTOR BİLGİ DÜZENLE";
            // 
            // MskTC
            // 
            
            // 
            // frmdoktorbilgiduzenle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(495, 368);
            Controls.Add(label7);
            Controls.Add(CmbBrans);
            Controls.Add(label4);
            Controls.Add(BtnBilgiGuncelle);
            Controls.Add(CmbCinsiyet);
            Controls.Add(TxtSifre);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(TxtSoyad);
            Controls.Add(TxtAd);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "frmdoktorbilgiduzenle";
            Text = "frmdoktorbilgiduzenle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox MskTC;
        private Label label1;
        private TextBox TxtSoyad;
        private TextBox TxtAd;
        private Label label3;
        private Label label2;
        private Button BtnBilgiGuncelle;
        private ComboBox CmbCinsiyet;
        private TextBox TxtSifre;
        private Label label6;
        private Label label5;
        private Label label4;
        private ComboBox CmbBrans;
        private Label label7;
    }
}