namespace Proje_Hastane
{
    partial class frmhastakayıt
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
            TxtSoyad = new TextBox();
            TxtAd = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            MskTC = new TextBox();
            MskTelefon = new TextBox();
            TxtSifre = new TextBox();
            CmbCinsiyet = new ComboBox();
            label7 = new Label();
            BtnKayitYap = new Button();
            SuspendLayout();
            // 
            // TxtSoyad
            // 
            TxtSoyad.BackColor = SystemColors.ButtonHighlight;
            TxtSoyad.BorderStyle = BorderStyle.FixedSingle;
            TxtSoyad.Location = new Point(206, 166);
            TxtSoyad.Name = "TxtSoyad";
            TxtSoyad.Size = new Size(202, 23);
            TxtSoyad.TabIndex = 8;
            // 
            // TxtAd
            // 
            TxtAd.BackColor = SystemColors.ButtonHighlight;
            TxtAd.BorderStyle = BorderStyle.FixedSingle;
            TxtAd.Location = new Point(206, 136);
            TxtAd.Name = "TxtAd";
            TxtAd.Size = new Size(202, 23);
            TxtAd.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(157, 129);
            label3.Name = "label3";
            label3.Size = new Size(43, 30);
            label3.TabIndex = 6;
            label3.Text = "AD";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(40, 189);
            label2.Name = "label2";
            label2.Size = new Size(160, 30);
            label2.TabIndex = 5;
            label2.Text = "T.C KİMLİK NO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(118, 159);
            label1.Name = "label1";
            label1.Size = new Size(82, 30);
            label1.TabIndex = 9;
            label1.Text = "SOYAD";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(95, 219);
            label4.Name = "label4";
            label4.Size = new Size(102, 30);
            label4.TabIndex = 10;
            label4.Text = "TELEFON";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlText;
            label5.Location = new Point(132, 252);
            label5.Name = "label5";
            label5.Size = new Size(68, 30);
            label5.TabIndex = 11;
            label5.Text = "ŞİFRE";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ControlText;
            label6.Location = new Point(95, 285);
            label6.Name = "label6";
            label6.Size = new Size(105, 30);
            label6.TabIndex = 12;
            label6.Text = "CİNSİYET";
            // 
            // MskTC
            // 
            MskTC.BackColor = SystemColors.ButtonHighlight;
            MskTC.BorderStyle = BorderStyle.FixedSingle;
            MskTC.Location = new Point(206, 196);
            MskTC.Name = "MskTC";
            MskTC.Size = new Size(202, 23);
            MskTC.TabIndex = 13;
            // 
            // MskTelefon
            // 
            MskTelefon.BackColor = SystemColors.ButtonHighlight;
            MskTelefon.BorderStyle = BorderStyle.FixedSingle;
            MskTelefon.Location = new Point(206, 226);
            MskTelefon.Name = "MskTelefon";
            MskTelefon.Size = new Size(202, 23);
            MskTelefon.TabIndex = 14;
            // 
            // TxtSifre
            // 
            TxtSifre.BackColor = SystemColors.ButtonHighlight;
            TxtSifre.BorderStyle = BorderStyle.FixedSingle;
            TxtSifre.Location = new Point(206, 259);
            TxtSifre.Name = "TxtSifre";
            TxtSifre.Size = new Size(202, 23);
            TxtSifre.TabIndex = 15;
            // 
            // CmbCinsiyet
            // 
            CmbCinsiyet.BackColor = SystemColors.ButtonHighlight;
            CmbCinsiyet.FormattingEnabled = true;
            CmbCinsiyet.Items.AddRange(new object[] { "Kadın", "Erkek" });
            CmbCinsiyet.Location = new Point(206, 292);
            CmbCinsiyet.Name = "CmbCinsiyet";
            CmbCinsiyet.Size = new Size(202, 23);
            CmbCinsiyet.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Teal;
            label7.Font = new Font("Segoe Script", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(40, 34);
            label7.Name = "label7";
            label7.Size = new Size(468, 61);
            label7.TabIndex = 17;
            label7.Text = "HASTA KAYIT PANELİ";
            // 
            // BtnKayitYap
            // 
            BtnKayitYap.BackColor = Color.SpringGreen;
            BtnKayitYap.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnKayitYap.Location = new Point(206, 321);
            BtnKayitYap.Name = "BtnKayitYap";
            BtnKayitYap.Size = new Size(203, 32);
            BtnKayitYap.TabIndex = 18;
            BtnKayitYap.Text = "Kayıt Yap";
            BtnKayitYap.UseVisualStyleBackColor = false;
            // 
            // frmhastakayıt
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(568, 398);
            Controls.Add(BtnKayitYap);
            Controls.Add(label7);
            Controls.Add(CmbCinsiyet);
            Controls.Add(TxtSifre);
            Controls.Add(MskTelefon);
            Controls.Add(MskTC);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(TxtSoyad);
            Controls.Add(TxtAd);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "frmhastakayıt";
            Text = "frmuyekayıt";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtSoyad;
        private TextBox TxtAd;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox MskTC;
        private TextBox MskTelefon;
        private TextBox TxtSifre;
        private ComboBox CmbCinsiyet;
        private Label label7;
        private Button BtnKayitYap;
    }
}