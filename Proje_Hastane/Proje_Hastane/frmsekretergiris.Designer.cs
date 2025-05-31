namespace Proje_Hastane
{
    partial class frmsekretergiris
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
            BtnGirisYap = new Button();
            TxtSifre = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            MskTC = new MaskedTextBox();
            SuspendLayout();
            // 
            // BtnGirisYap
            // 
            BtnGirisYap.BackColor = Color.SpringGreen;
            BtnGirisYap.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            BtnGirisYap.Location = new Point(241, 173);
            BtnGirisYap.Name = "BtnGirisYap";
            BtnGirisYap.Size = new Size(202, 35);
            BtnGirisYap.TabIndex = 18;
            BtnGirisYap.Text = "Giriş Yap";
            BtnGirisYap.UseVisualStyleBackColor = false;
            // 
            // TxtSifre
            // 
            TxtSifre.BackColor = SystemColors.ButtonHighlight;
            TxtSifre.BorderStyle = BorderStyle.FixedSingle;
            TxtSifre.Location = new Point(241, 144);
            TxtSifre.Name = "TxtSifre";
            TxtSifre.Size = new Size(202, 23);
            TxtSifre.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(167, 138);
            label3.Name = "label3";
            label3.Size = new Size(68, 30);
            label3.TabIndex = 15;
            label3.Text = "ŞİFRE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(84, 108);
            label2.Name = "label2";
            label2.Size = new Size(160, 30);
            label2.TabIndex = 14;
            label2.Text = "T.C KİMLİK NO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Teal;
            label1.Font = new Font("Segoe Script", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(31, 38);
            label1.Name = "label1";
            label1.Size = new Size(542, 61);
            label1.TabIndex = 13;
            label1.Text = "SEKRETER GİRİŞ PANELİ";
            // 
            // MskTC
            // 
            MskTC.Location = new Point(241, 115);
            MskTC.Mask = "00000000000";
            MskTC.Name = "MskTC";
            MskTC.Size = new Size(202, 23);
            MskTC.TabIndex = 19;
            MskTC.ValidatingType = typeof(int);
            // 
            // frmsekretergiris
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(613, 255);
            Controls.Add(MskTC);
            Controls.Add(BtnGirisYap);
            Controls.Add(TxtSifre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmsekretergiris";
            Text = "frmsekreter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnGirisYap;
        private TextBox TxtSifre;
        private Label label3;
        private Label label2;
        private Label label1;
        private MaskedTextBox MskTC;
    }
}