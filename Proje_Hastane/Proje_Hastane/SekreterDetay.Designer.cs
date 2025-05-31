namespace Proje_Hastane
{
    partial class SekreterDetay
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
            groupBox1 = new GroupBox();
            LblAdSoyad = new Label();
            LblTC = new Label();
            groupBox2 = new GroupBox();
            RchDuyuru = new RichTextBox();
            BtnDuyuruOlustur = new Button();
            groupBox3 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            MskTarih = new MaskedTextBox();
            Txtid = new TextBox();
            MskSaat = new MaskedTextBox();
            CmbBrans = new ComboBox();
            CmbDoktor = new ComboBox();
            MskTC = new MaskedTextBox();
            BtnKaydet = new Button();
            ChkDurum = new CheckBox();
            BtnGuncelle = new Button();
            groupBox4 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox5 = new GroupBox();
            dataGridView2 = new DataGridView();
            groupBox6 = new GroupBox();
            BtnDoktorPanel = new Button();
            BtnBransPanel = new Button();
            BtnListe = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(LblAdSoyad);
            groupBox1.Controls.Add(LblTC);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(253, 124);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sekreter Bilgi";
            // 
            // LblAdSoyad
            // 
            LblAdSoyad.AutoSize = true;
            LblAdSoyad.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            LblAdSoyad.ForeColor = SystemColors.ControlText;
            LblAdSoyad.Location = new Point(18, 73);
            LblAdSoyad.Name = "LblAdSoyad";
            LblAdSoyad.Size = new Size(87, 26);
            LblAdSoyad.TabIndex = 10;
            LblAdSoyad.Text = "Null Null";
            // 
            // LblTC
            // 
            LblTC.AutoSize = true;
            LblTC.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            LblTC.ForeColor = SystemColors.ControlText;
            LblTC.Location = new Point(18, 35);
            LblTC.Name = "LblTC";
            LblTC.Size = new Size(133, 26);
            LblTC.TabIndex = 9;
            LblTC.Text = "00000000000";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(BtnDuyuruOlustur);
            groupBox2.Controls.Add(RchDuyuru);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(12, 151);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(253, 287);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Duyuru Oluştur";
            // 
            // RchDuyuru
            // 
            RchDuyuru.Location = new Point(6, 22);
            RchDuyuru.Name = "RchDuyuru";
            RchDuyuru.Size = new Size(241, 219);
            RchDuyuru.TabIndex = 0;
            RchDuyuru.Text = "";
            // 
            // BtnDuyuruOlustur
            // 
            BtnDuyuruOlustur.BackColor = Color.SpringGreen;
            BtnDuyuruOlustur.Location = new Point(6, 247);
            BtnDuyuruOlustur.Name = "BtnDuyuruOlustur";
            BtnDuyuruOlustur.Size = new Size(241, 34);
            BtnDuyuruOlustur.TabIndex = 1;
            BtnDuyuruOlustur.Text = "Duyuru Oluştur";
            BtnDuyuruOlustur.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(BtnGuncelle);
            groupBox3.Controls.Add(ChkDurum);
            groupBox3.Controls.Add(BtnKaydet);
            groupBox3.Controls.Add(MskTC);
            groupBox3.Controls.Add(CmbDoktor);
            groupBox3.Controls.Add(CmbBrans);
            groupBox3.Controls.Add(Txtid);
            groupBox3.Controls.Add(MskSaat);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(MskTarih);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label1);
            groupBox3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.Location = new Point(271, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(282, 426);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Randevular";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(64, 70);
            label1.Name = "label1";
            label1.Size = new Size(34, 26);
            label1.TabIndex = 10;
            label1.Text = "id:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(39, 107);
            label2.Name = "label2";
            label2.Size = new Size(59, 26);
            label2.TabIndex = 11;
            label2.Text = "Tarih:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(43, 139);
            label3.Name = "label3";
            label3.Size = new Size(55, 26);
            label3.TabIndex = 12;
            label3.Text = "Saat:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(21, 212);
            label4.Name = "label4";
            label4.Size = new Size(77, 26);
            label4.TabIndex = 13;
            label4.Text = "Doktor:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlText;
            label5.Location = new Point(33, 174);
            label5.Name = "label5";
            label5.Size = new Size(65, 26);
            label5.TabIndex = 14;
            label5.Text = "Branş:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ControlText;
            label7.Location = new Point(6, 38);
            label7.Name = "label7";
            label7.Size = new Size(92, 26);
            label7.TabIndex = 16;
            label7.Text = "Hasta TC:";
            // 
            // MskTarih
            // 
            MskTarih.Location = new Point(104, 104);
            MskTarih.Mask = "00/00/0000";
            MskTarih.Name = "MskTarih";
            MskTarih.Size = new Size(136, 29);
            MskTarih.TabIndex = 17;
            MskTarih.ValidatingType = typeof(DateTime);
            // 
            // Txtid
            // 
            Txtid.Location = new Point(104, 70);
            Txtid.Name = "Txtid";
            Txtid.Size = new Size(136, 29);
            Txtid.TabIndex = 17;
            // 
            // MskSaat
            // 
            MskSaat.Location = new Point(104, 139);
            MskSaat.Mask = "00:00";
            MskSaat.Name = "MskSaat";
            MskSaat.Size = new Size(136, 29);
            MskSaat.TabIndex = 18;
            MskSaat.ValidatingType = typeof(DateTime);
            // 
            // CmbBrans
            // 
            CmbBrans.FormattingEnabled = true;
            CmbBrans.Location = new Point(104, 174);
            CmbBrans.Name = "CmbBrans";
            CmbBrans.Size = new Size(136, 29);
            CmbBrans.TabIndex = 19;
            // 
            // CmbDoktor
            // 
            CmbDoktor.FormattingEnabled = true;
            CmbDoktor.Location = new Point(104, 209);
            CmbDoktor.Name = "CmbDoktor";
            CmbDoktor.Size = new Size(136, 29);
            CmbDoktor.TabIndex = 20;
            // 
            // MskTC
            // 
            MskTC.Location = new Point(104, 35);
            MskTC.Mask = "00000000000";
            MskTC.Name = "MskTC";
            MskTC.Size = new Size(136, 29);
            MskTC.TabIndex = 21;
            MskTC.ValidatingType = typeof(int);
            // 
            // BtnKaydet
            // 
            BtnKaydet.BackColor = Color.SpringGreen;
            BtnKaydet.Location = new Point(21, 291);
            BtnKaydet.Name = "BtnKaydet";
            BtnKaydet.Size = new Size(241, 57);
            BtnKaydet.TabIndex = 22;
            BtnKaydet.Text = "Kaydet";
            BtnKaydet.UseVisualStyleBackColor = false;
            // 
            // ChkDurum
            // 
            ChkDurum.AutoSize = true;
            ChkDurum.Location = new Point(21, 260);
            ChkDurum.Name = "ChkDurum";
            ChkDurum.Size = new Size(153, 25);
            ChkDurum.TabIndex = 24;
            ChkDurum.Text = "Randevu Durum";
            ChkDurum.UseVisualStyleBackColor = true;
            // 
            // BtnGuncelle
            // 
            BtnGuncelle.BackColor = Color.SpringGreen;
            BtnGuncelle.Location = new Point(21, 354);
            BtnGuncelle.Name = "BtnGuncelle";
            BtnGuncelle.Size = new Size(241, 57);
            BtnGuncelle.TabIndex = 25;
            BtnGuncelle.Text = "Güncelle";
            BtnGuncelle.UseVisualStyleBackColor = false;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dataGridView1);
            groupBox4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox4.Location = new Point(559, 12);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(397, 254);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Doktorlar";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 25);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(391, 226);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(dataGridView2);
            groupBox5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox5.Location = new Point(562, 272);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(394, 256);
            groupBox5.TabIndex = 4;
            groupBox5.TabStop = false;
            groupBox5.Text = "Branşlar";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(3, 25);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(388, 228);
            dataGridView2.TabIndex = 0;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(BtnListe);
            groupBox6.Controls.Add(BtnBransPanel);
            groupBox6.Controls.Add(BtnDoktorPanel);
            groupBox6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox6.Location = new Point(12, 444);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(541, 84);
            groupBox6.TabIndex = 5;
            groupBox6.TabStop = false;
            groupBox6.Text = "Erişim";
            // 
            // BtnDoktorPanel
            // 
            BtnDoktorPanel.BackColor = SystemColors.MenuHighlight;
            BtnDoktorPanel.ForeColor = SystemColors.ControlText;
            BtnDoktorPanel.Location = new Point(18, 28);
            BtnDoktorPanel.Name = "BtnDoktorPanel";
            BtnDoktorPanel.Size = new Size(158, 40);
            BtnDoktorPanel.TabIndex = 0;
            BtnDoktorPanel.Text = "Doktor Paneli";
            BtnDoktorPanel.UseVisualStyleBackColor = false;
            // 
            // BtnBransPanel
            // 
            BtnBransPanel.BackColor = SystemColors.MenuHighlight;
            BtnBransPanel.Location = new Point(196, 28);
            BtnBransPanel.Name = "BtnBransPanel";
            BtnBransPanel.Size = new Size(146, 40);
            BtnBransPanel.TabIndex = 1;
            BtnBransPanel.Text = "Branş Paneli";
            BtnBransPanel.UseVisualStyleBackColor = false;
            // 
            // BtnListe
            // 
            BtnListe.BackColor = SystemColors.MenuHighlight;
            BtnListe.Location = new Point(363, 28);
            BtnListe.Name = "BtnListe";
            BtnListe.Size = new Size(158, 40);
            BtnListe.TabIndex = 2;
            BtnListe.Text = "Randevu Liste";
            BtnListe.UseVisualStyleBackColor = false;
            // 
            // SekreterDetay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(968, 540);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "SekreterDetay";
            Text = "SekreterDetay";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label LblAdSoyad;
        private Label LblTC;
        private GroupBox groupBox2;
        private Button BtnDuyuruOlustur;
        private RichTextBox RchDuyuru;
        private GroupBox groupBox3;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label7;
        private Label label5;
        private Label label4;
        private MaskedTextBox MskTarih;
        private TextBox Txtid;
        private MaskedTextBox MskTC;
        private ComboBox CmbDoktor;
        private ComboBox CmbBrans;
        private MaskedTextBox MskSaat;
        private Button BtnGuncelle;
        private CheckBox ChkDurum;
        private Button BtnKaydet;
        private GroupBox groupBox4;
        private DataGridView dataGridView1;
        private GroupBox groupBox5;
        private DataGridView dataGridView2;
        private GroupBox groupBox6;
        private Button BtnDoktorPanel;
        private Button BtnListe;
        private Button BtnBransPanel;
    }
}