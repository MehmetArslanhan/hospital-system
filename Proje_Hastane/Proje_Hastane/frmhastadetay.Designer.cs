namespace Proje_Hastane
{
    partial class frmhastadetay
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
            groupBox2 = new GroupBox();
            LblTC = new Label();
            LblAdSoyad = new Label();
            BtnRandeduAl = new Button();
            CmbBrans = new ComboBox();
            CmbDoktor = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            LnkBilgiDuzenle = new LinkLabel();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(LblAdSoyad);
            groupBox1.Controls.Add(LblTC);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(267, 117);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hasta Bilgileri";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(LnkBilgiDuzenle);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(CmbDoktor);
            groupBox2.Controls.Add(BtnRandeduAl);
            groupBox2.Controls.Add(CmbBrans);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(12, 135);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(267, 193);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Randevu Al";
            // 
            // LblTC
            // 
            LblTC.AutoSize = true;
            LblTC.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            LblTC.ForeColor = SystemColors.ControlText;
            LblTC.Location = new Point(6, 29);
            LblTC.Name = "LblTC";
            LblTC.Size = new Size(133, 26);
            LblTC.TabIndex = 6;
            LblTC.Text = "00000000000";
            // 
            // LblAdSoyad
            // 
            LblAdSoyad.AutoSize = true;
            LblAdSoyad.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            LblAdSoyad.ForeColor = SystemColors.ControlText;
            LblAdSoyad.Location = new Point(6, 66);
            LblAdSoyad.Name = "LblAdSoyad";
            LblAdSoyad.Size = new Size(87, 26);
            LblAdSoyad.TabIndex = 7;
            LblAdSoyad.Text = "Null Null";
            // 
            // BtnRandeduAl
            // 
            BtnRandeduAl.BackColor = Color.SpringGreen;
            BtnRandeduAl.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            BtnRandeduAl.Location = new Point(81, 127);
            BtnRandeduAl.Name = "BtnRandeduAl";
            BtnRandeduAl.Size = new Size(121, 32);
            BtnRandeduAl.TabIndex = 0;
            BtnRandeduAl.Text = "Randevu Al";
            BtnRandeduAl.UseVisualStyleBackColor = false;
            // 
            // CmbBrans
            // 
            CmbBrans.FormattingEnabled = true;
            CmbBrans.Location = new Point(81, 47);
            CmbBrans.Name = "CmbBrans";
            CmbBrans.Size = new Size(121, 29);
            CmbBrans.TabIndex = 2;
            // 
            // CmbDoktor
            // 
            CmbDoktor.FormattingEnabled = true;
            CmbDoktor.Location = new Point(81, 88);
            CmbDoktor.Name = "CmbDoktor";
            CmbDoktor.Size = new Size(121, 29);
            CmbDoktor.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(15, 44);
            label3.Name = "label3";
            label3.Size = new Size(60, 26);
            label3.TabIndex = 8;
            label3.Text = "Branş";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(4, 85);
            label4.Name = "label4";
            label4.Size = new Size(71, 26);
            label4.TabIndex = 9;
            label4.Text = "Doktor";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.Location = new Point(285, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(489, 117);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Randevu Geçmişi";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dataGridView2);
            groupBox4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox4.Location = new Point(285, 135);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(489, 193);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Aktif Randevular";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 25);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(483, 89);
            dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(3, 25);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(483, 165);
            dataGridView2.TabIndex = 1;
            // 
            // LnkBilgiDuzenle
            // 
            LnkBilgiDuzenle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LnkBilgiDuzenle.LinkColor = Color.Lime;
            LnkBilgiDuzenle.Location = new Point(15, 165);
            LnkBilgiDuzenle.Name = "LnkBilgiDuzenle";
            LnkBilgiDuzenle.Size = new Size(155, 25);
            LnkBilgiDuzenle.TabIndex = 10;
            LnkBilgiDuzenle.TabStop = true;
            LnkBilgiDuzenle.Text = "Bilgilerimi Düzenle";
            // 
            // frmhastadetay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(800, 352);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmhastadetay";
            Text = "Hasta Detay";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label LblAdSoyad;
        private Label LblTC;
        private Label label4;
        private Label label3;
        private ComboBox CmbDoktor;
        private Button BtnRandeduAl;
        private ComboBox CmbBrans;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private LinkLabel LnkBilgiDuzenle;
    }
}