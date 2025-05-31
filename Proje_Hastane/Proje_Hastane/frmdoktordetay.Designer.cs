namespace Proje_Hastane
{
    partial class frmdoktordetay
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
            LblTC = new Label();
            LblAdSoyad = new Label();
            groupBox3 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox2 = new GroupBox();
            BtnGuncelle = new Button();
            BtnDuyurular = new Button();
            BtnCikis = new Button();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(LblAdSoyad);
            groupBox1.Controls.Add(LblTC);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(234, 116);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Doktor Bilgi";
            // 
            // LblTC
            // 
            LblTC.AutoSize = true;
            LblTC.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            LblTC.ForeColor = SystemColors.ControlText;
            LblTC.Location = new Point(17, 29);
            LblTC.Name = "LblTC";
            LblTC.Size = new Size(133, 26);
            LblTC.TabIndex = 7;
            LblTC.Text = "00000000000";
            // 
            // LblAdSoyad
            // 
            LblAdSoyad.AutoSize = true;
            LblAdSoyad.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            LblAdSoyad.ForeColor = SystemColors.ControlText;
            LblAdSoyad.Location = new Point(17, 67);
            LblAdSoyad.Name = "LblAdSoyad";
            LblAdSoyad.Size = new Size(87, 26);
            LblAdSoyad.TabIndex = 8;
            LblAdSoyad.Text = "Null Null";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.Location = new Point(252, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(536, 337);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Randevu Listesi";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 25);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(530, 309);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(BtnCikis);
            groupBox2.Controls.Add(BtnDuyurular);
            groupBox2.Controls.Add(BtnGuncelle);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(12, 134);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(234, 215);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Hızlı Erişim";
            // 
            // BtnGuncelle
            // 
            BtnGuncelle.BackColor = Color.SpringGreen;
            BtnGuncelle.Location = new Point(14, 46);
            BtnGuncelle.Name = "BtnGuncelle";
            BtnGuncelle.Size = new Size(98, 60);
            BtnGuncelle.TabIndex = 0;
            BtnGuncelle.Text = "Bilgi Düzenle";
            BtnGuncelle.UseVisualStyleBackColor = false;
            // 
            // BtnDuyurular
            // 
            BtnDuyurular.BackColor = Color.SpringGreen;
            BtnDuyurular.Location = new Point(118, 46);
            BtnDuyurular.Name = "BtnDuyurular";
            BtnDuyurular.Size = new Size(101, 60);
            BtnDuyurular.TabIndex = 1;
            BtnDuyurular.Text = "Duyurular";
            BtnDuyurular.UseVisualStyleBackColor = false;
            // 
            // BtnCikis
            // 
            BtnCikis.BackColor = Color.Pink;
            BtnCikis.Location = new Point(14, 112);
            BtnCikis.Name = "BtnCikis";
            BtnCikis.Size = new Size(205, 65);
            BtnCikis.TabIndex = 2;
            BtnCikis.Text = "Çıkış";
            BtnCikis.UseVisualStyleBackColor = false;
            // 
            // frmdoktordetay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(800, 368);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmdoktordetay";
            Text = "frmdoktordetay";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label LblTC;
        private Label LblAdSoyad;
        private GroupBox groupBox3;
        private DataGridView dataGridView1;
        private GroupBox groupBox2;
        private Button BtnCikis;
        private Button BtnDuyurular;
        private Button BtnGuncelle;
    }
}