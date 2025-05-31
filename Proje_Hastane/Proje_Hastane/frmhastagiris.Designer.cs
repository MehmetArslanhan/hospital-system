namespace Proje_Hastane
{
    partial class frmhastagiris
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
            label2 = new Label();
            label3 = new Label();
            MskTC = new TextBox();
            TxtSifre = new TextBox();
            BtnGirisYap = new Button();
            LnkUyeOl = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Teal;
            label1.Font = new Font("Segoe Script", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(55, 26);
            label1.Name = "label1";
            label1.Size = new Size(454, 61);
            label1.TabIndex = 0;
            label1.Text = "HASTA GİRİŞ PANELİ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(22, 109);
            label2.Name = "label2";
            label2.Size = new Size(160, 30);
            label2.TabIndex = 1;
            label2.Text = "T.C KİMLİK NO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(105, 139);
            label3.Name = "label3";
            label3.Size = new Size(68, 30);
            label3.TabIndex = 2;
            label3.Text = "ŞİFRE";
            // 
            // MskTC
            // 
            MskTC.BackColor = SystemColors.ButtonHighlight;
            MskTC.BorderStyle = BorderStyle.FixedSingle;
            MskTC.Location = new Point(179, 116);
            MskTC.Name = "MskTC";
            MskTC.Size = new Size(202, 23);
            MskTC.TabIndex = 3;
            // 
            // TxtSifre
            // 
            TxtSifre.BackColor = SystemColors.ButtonHighlight;
            TxtSifre.BorderStyle = BorderStyle.FixedSingle;
            TxtSifre.Location = new Point(179, 145);
            TxtSifre.Name = "TxtSifre";
            TxtSifre.Size = new Size(202, 23);
            TxtSifre.TabIndex = 4;
            TxtSifre.TextChanged += textBox2_TextChanged;
            // 
            // BtnGirisYap
            // 
            BtnGirisYap.BackColor = Color.SpringGreen;
            BtnGirisYap.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            BtnGirisYap.Location = new Point(179, 174);
            BtnGirisYap.Name = "BtnGirisYap";
            BtnGirisYap.Size = new Size(202, 35);
            BtnGirisYap.TabIndex = 5;
            BtnGirisYap.Text = "Giriş Yap";
            BtnGirisYap.UseVisualStyleBackColor = false;
            // 
            // LnkUyeOl
            // 
            LnkUyeOl.AutoSize = true;
            LnkUyeOl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LnkUyeOl.LinkColor = Color.Black;
            LnkUyeOl.Location = new Point(179, 212);
            LnkUyeOl.Name = "LnkUyeOl";
            LnkUyeOl.Size = new Size(57, 21);
            LnkUyeOl.TabIndex = 6;
            LnkUyeOl.TabStop = true;
            LnkUyeOl.Text = "Üye Ol";
            // 
            // frmhastagiris
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(551, 250);
            Controls.Add(LnkUyeOl);
            Controls.Add(BtnGirisYap);
            Controls.Add(TxtSifre);
            Controls.Add(MskTC);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmhastagiris";
            Text = "frmhastagiris";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox MskTC;
        private TextBox TxtSifre;
        private Button BtnGirisYap;
        private LinkLabel LnkUyeOl;
    }
}