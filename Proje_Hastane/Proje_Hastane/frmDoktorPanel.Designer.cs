namespace Proje_Hastane
{
    partial class frmDoktorPanel
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
            LblTC = new Label();
            TxtAd = new TextBox();
            CmbBrans = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            TxtSoyad = new TextBox();
            MskTC = new MaskedTextBox();
            TxtSifre = new TextBox();
            BtnGuncelle = new Button();
            BtnEkle = new Button();
            BtnSil = new Button();
            dataGridView1 = new DataGridView();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // LblTC
            // 
            LblTC.AutoSize = true;
            LblTC.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            LblTC.ForeColor = SystemColors.ControlText;
            LblTC.Location = new Point(107, 130);
            LblTC.Name = "LblTC";
            LblTC.Size = new Size(41, 26);
            LblTC.TabIndex = 18;
            LblTC.Text = "Ad:";
            // 
            // TxtAd
            // 
            TxtAd.Location = new Point(154, 135);
            TxtAd.Name = "TxtAd";
            TxtAd.Size = new Size(136, 23);
            TxtAd.TabIndex = 19;
            // 
            // CmbBrans
            // 
            CmbBrans.FormattingEnabled = true;
            CmbBrans.Location = new Point(154, 194);
            CmbBrans.Name = "CmbBrans";
            CmbBrans.Size = new Size(136, 23);
            CmbBrans.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(78, 159);
            label1.Name = "label1";
            label1.Size = new Size(70, 26);
            label1.TabIndex = 21;
            label1.Text = "Soyad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(83, 189);
            label2.Name = "label2";
            label2.Size = new Size(65, 26);
            label2.TabIndex = 22;
            label2.Text = "Branş:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(109, 218);
            label3.Name = "label3";
            label3.Size = new Size(39, 26);
            label3.TabIndex = 23;
            label3.Text = "TC:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(92, 252);
            label4.Name = "label4";
            label4.Size = new Size(56, 26);
            label4.TabIndex = 24;
            label4.Text = "Şifre:";
            // 
            // TxtSoyad
            // 
            TxtSoyad.Location = new Point(154, 164);
            TxtSoyad.Name = "TxtSoyad";
            TxtSoyad.Size = new Size(136, 23);
            TxtSoyad.TabIndex = 25;
            // 
            // MskTC
            // 
            MskTC.Location = new Point(154, 223);
            MskTC.Mask = "00000000000";
            MskTC.Name = "MskTC";
            MskTC.Size = new Size(136, 23);
            MskTC.TabIndex = 26;
            MskTC.ValidatingType = typeof(int);
            // 
            // TxtSifre
            // 
            TxtSifre.Location = new Point(154, 252);
            TxtSifre.Name = "TxtSifre";
            TxtSifre.Size = new Size(136, 23);
            TxtSifre.TabIndex = 27;
            // 
            // BtnGuncelle
            // 
            BtnGuncelle.BackColor = Color.DeepSkyBlue;
            BtnGuncelle.Location = new Point(154, 331);
            BtnGuncelle.Name = "BtnGuncelle";
            BtnGuncelle.Size = new Size(136, 46);
            BtnGuncelle.TabIndex = 28;
            BtnGuncelle.Text = "Güncelle";
            BtnGuncelle.UseVisualStyleBackColor = false;
            // 
            // BtnEkle
            // 
            BtnEkle.BackColor = Color.SpringGreen;
            BtnEkle.Location = new Point(154, 281);
            BtnEkle.Name = "BtnEkle";
            BtnEkle.Size = new Size(66, 44);
            BtnEkle.TabIndex = 29;
            BtnEkle.Text = "Ekle";
            BtnEkle.UseVisualStyleBackColor = false;
            // 
            // BtnSil
            // 
            BtnSil.BackColor = Color.Pink;
            BtnSil.Location = new Point(226, 281);
            BtnSil.Name = "BtnSil";
            BtnSil.Size = new Size(64, 44);
            BtnSil.TabIndex = 30;
            BtnSil.Text = "Sil";
            BtnSil.UseVisualStyleBackColor = false;
            BtnSil.Click += button3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(324, 135);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(419, 242);
            dataGridView1.TabIndex = 31;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Teal;
            label5.Font = new Font("Segoe Script", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(226, 48);
            label5.Name = "label5";
            label5.Size = new Size(372, 61);
            label5.TabIndex = 32;
            label5.Text = "DOKTOR PANELİ";
            // 
            // frmDoktorPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(dataGridView1);
            Controls.Add(BtnSil);
            Controls.Add(BtnEkle);
            Controls.Add(BtnGuncelle);
            Controls.Add(TxtSifre);
            Controls.Add(MskTC);
            Controls.Add(TxtSoyad);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(CmbBrans);
            Controls.Add(LblTC);
            Controls.Add(TxtAd);
            Name = "frmDoktorPanel";
            Text = "frmDoktorPanel";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblTC;
        private TextBox TxtAd;
        private ComboBox CmbBrans;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox TxtSoyad;
        private MaskedTextBox MskTC;
        private TextBox TxtSifre;
        private Button BtnGuncelle;
        private Button BtnEkle;
        private Button BtnSil;
        private DataGridView dataGridView1;
        private Label label5;
    }
}