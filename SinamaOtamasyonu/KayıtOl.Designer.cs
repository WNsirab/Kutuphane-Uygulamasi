namespace SinamaOtamasyonu
{
    partial class KayıtOl
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
            panel1 = new Panel();
            button1 = new Button();
            label1 = new Label();
            label4 = new Label();
            btnGirisYap = new Button();
            txtSifre = new TextBox();
            label3 = new Label();
            txtKullaniciAdi = new TextBox();
            label2 = new Label();
            linkLabel1 = new LinkLabel();
            label5 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(774, 40);
            panel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Cursor = Cursors.Hand;
            button1.Dock = DockStyle.Right;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(734, 0);
            button1.Name = "button1";
            button1.Size = new Size(40, 40);
            button1.TabIndex = 1;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DimGray;
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(229, 31);
            label1.TabIndex = 1;
            label1.Text = "Sinema Otomasyonu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(383, 231);
            label4.Name = "label4";
            label4.Size = new Size(0, 31);
            label4.TabIndex = 14;
            // 
            // btnGirisYap
            // 
            btnGirisYap.BackColor = Color.DimGray;
            btnGirisYap.Cursor = Cursors.Hand;
            btnGirisYap.FlatAppearance.BorderSize = 0;
            btnGirisYap.FlatStyle = FlatStyle.Flat;
            btnGirisYap.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnGirisYap.ForeColor = Color.White;
            btnGirisYap.Location = new Point(484, 218);
            btnGirisYap.Name = "btnGirisYap";
            btnGirisYap.Size = new Size(116, 44);
            btnGirisYap.TabIndex = 13;
            btnGirisYap.Text = "Kaydol";
            btnGirisYap.UseVisualStyleBackColor = false;
            btnGirisYap.Click += btnGirisYap_Click;
            // 
            // txtSifre
            // 
            txtSifre.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtSifre.Location = new Point(322, 172);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(278, 30);
            txtSifre.TabIndex = 12;
            txtSifre.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(254, 172);
            label3.Name = "label3";
            label3.Size = new Size(62, 31);
            label3.TabIndex = 11;
            label3.Text = "Şifre";
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtKullaniciAdi.Location = new Point(322, 121);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(278, 30);
            txtKullaniciAdi.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(174, 121);
            label2.Name = "label2";
            label2.Size = new Size(142, 31);
            label2.TabIndex = 9;
            label2.Text = "Kullanıcı Adi";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            linkLabel1.Location = new Point(530, 265);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(75, 23);
            linkLabel1.TabIndex = 15;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Giriş Yap";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            linkLabel1.Click += linkLabel1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.Location = new Point(374, 265);
            label5.Name = "label5";
            label5.Size = new Size(150, 23);
            label5.TabIndex = 16;
            label5.Text = "Hesabınız var mı? ";
            label5.Click += label5_Click;
            // 
            // KayıtOl
            // 
            AcceptButton = btnGirisYap;
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(774, 382);
            Controls.Add(label5);
            Controls.Add(linkLabel1);
            Controls.Add(label4);
            Controls.Add(btnGirisYap);
            Controls.Add(txtSifre);
            Controls.Add(label3);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(label2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5);
            Name = "KayıtOl";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KayıtOl";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Label label1;
        private Label label4;
        private Button btnGirisYap;
        private TextBox txtSifre;
        private Label label3;
        private TextBox txtKullaniciAdi;
        private Label label2;
        private LinkLabel linkLabel1;
        private Label label5;
    }
}