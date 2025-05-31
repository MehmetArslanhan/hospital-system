namespace Proje_Hastane
{
    partial class frmbrans
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
            label5 = new Label();
            dataGridView1 = new DataGridView();
            BtnSil = new Button();
            BtnEkle = new Button();
            BtnGuncelle = new Button();
            TxtBrans = new TextBox();
            label1 = new Label();
            LblTC = new Label();
            Txtid = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Teal;
            label5.Font = new Font("Segoe Script", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(125, 9);
            label5.Name = "label5";
            label5.Size = new Size(340, 61);
            label5.TabIndex = 47;
            label5.Text = "BRANŞ PANELİ";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(248, 86);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(316, 164);
            dataGridView1.TabIndex = 46;
            // 
            // BtnSil
            // 
            BtnSil.BackColor = Color.Pink;
            BtnSil.Location = new Point(178, 154);
            BtnSil.Name = "BtnSil";
            BtnSil.Size = new Size(64, 44);
            BtnSil.TabIndex = 45;
            BtnSil.Text = "Sil";
            BtnSil.UseVisualStyleBackColor = false;
            // 
            // BtnEkle
            // 
            BtnEkle.BackColor = Color.SpringGreen;
            BtnEkle.Location = new Point(106, 154);
            BtnEkle.Name = "BtnEkle";
            BtnEkle.Size = new Size(66, 44);
            BtnEkle.TabIndex = 44;
            BtnEkle.Text = "Ekle";
            BtnEkle.UseVisualStyleBackColor = false;
            // 
            // BtnGuncelle
            // 
            BtnGuncelle.BackColor = Color.DeepSkyBlue;
            BtnGuncelle.Location = new Point(106, 204);
            BtnGuncelle.Name = "BtnGuncelle";
            BtnGuncelle.Size = new Size(136, 46);
            BtnGuncelle.TabIndex = 43;
            BtnGuncelle.Text = "Güncelle";
            BtnGuncelle.UseVisualStyleBackColor = false;
            // 
            // TxtBrans
            // 
            TxtBrans.Location = new Point(106, 115);
            TxtBrans.Name = "TxtBrans";
            TxtBrans.Size = new Size(136, 23);
            TxtBrans.TabIndex = 40;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(7, 110);
            label1.Name = "label1";
            label1.Size = new Size(93, 26);
            label1.TabIndex = 36;
            label1.Text = "Branş Ad:";
            // 
            // LblTC
            // 
            LblTC.AutoSize = true;
            LblTC.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            LblTC.ForeColor = SystemColors.ControlText;
            LblTC.Location = new Point(14, 81);
            LblTC.Name = "LblTC";
            LblTC.Size = new Size(86, 26);
            LblTC.TabIndex = 33;
            LblTC.Text = "Branş id:";
            // 
            // Txtid
            // 
            Txtid.Location = new Point(106, 86);
            Txtid.Name = "Txtid";
            Txtid.Size = new Size(136, 23);
            Txtid.TabIndex = 34;
            // 
            // frmbrans
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(594, 272);
            Controls.Add(label5);
            Controls.Add(dataGridView1);
            Controls.Add(BtnSil);
            Controls.Add(BtnEkle);
            Controls.Add(BtnGuncelle);
            Controls.Add(TxtBrans);
            Controls.Add(label1);
            Controls.Add(LblTC);
            Controls.Add(Txtid);
            Name = "frmbrans";
            Text = "frmbrans";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private DataGridView dataGridView1;
        private Button BtnSil;
        private Button BtnEkle;
        private Button BtnGuncelle;
        private TextBox TxtBrans;
        private Label label1;
        private Label LblTC;
        private TextBox Txtid;
    }
}