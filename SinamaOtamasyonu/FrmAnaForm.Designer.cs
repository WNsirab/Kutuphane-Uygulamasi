namespace SinamaOtamasyonu
{
    partial class FrmAnaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnaForm));
            panel1 = new Panel();
            button1 = new Button();
            label1 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            sqliteCommand1 = new Microsoft.Data.Sqlite.SqliteCommand();
            biletalBtn = new Button();
            biletlerimBtn = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            odRadioBtn = new RadioButton();
            lotrRadioBtn = new RadioButton();
            arogRadioBtn = new RadioButton();
            seansCb = new ComboBox();
            seansLbl = new Label();
            blokLbl = new Label();
            blokCb = new ComboBox();
            koltukCb = new ComboBox();
            tarihLbl = new Label();
            dateTimePicker1 = new DateTimePicker();
            filmsecLbl = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
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
            panel1.Size = new Size(1222, 40);
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
            button1.Location = new Point(1182, 0);
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
            // panel2
            // 
            panel2.BackColor = Color.DimGray;
            panel2.Cursor = Cursors.SizeNESW;
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 40);
            panel2.Name = "panel2";
            panel2.Size = new Size(47, 489);
            panel2.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DimGray;
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(47, 489);
            panel3.Name = "panel3";
            panel3.Size = new Size(1175, 40);
            panel3.TabIndex = 3;
            // 
            // sqliteCommand1
            // 
            sqliteCommand1.CommandTimeout = 30;
            sqliteCommand1.Connection = null;
            sqliteCommand1.Transaction = null;
            sqliteCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // biletalBtn
            // 
            biletalBtn.BackColor = Color.DimGray;
            biletalBtn.Cursor = Cursors.Hand;
            biletalBtn.FlatAppearance.BorderSize = 3;
            biletalBtn.FlatStyle = FlatStyle.Popup;
            biletalBtn.ForeColor = Color.White;
            biletalBtn.Location = new Point(1014, 388);
            biletalBtn.Name = "biletalBtn";
            biletalBtn.Size = new Size(131, 48);
            biletalBtn.TabIndex = 4;
            biletalBtn.Text = "Bilet Al";
            biletalBtn.UseVisualStyleBackColor = false;
            biletalBtn.Click += biletalBtn_Click;
            // 
            // biletlerimBtn
            // 
            biletlerimBtn.BackColor = Color.DimGray;
            biletlerimBtn.Cursor = Cursors.Hand;
            biletlerimBtn.FlatAppearance.BorderSize = 3;
            biletlerimBtn.FlatStyle = FlatStyle.Popup;
            biletlerimBtn.ForeColor = Color.White;
            biletlerimBtn.Location = new Point(867, 388);
            biletlerimBtn.Name = "biletlerimBtn";
            biletlerimBtn.Size = new Size(131, 48);
            biletlerimBtn.TabIndex = 5;
            biletlerimBtn.Text = "Biletlerim";
            biletlerimBtn.UseVisualStyleBackColor = false;
            biletlerimBtn.Click += biletlerimBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(62, 98);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(192, 272);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = Properties.Resources.yüzüklerin_efendisi;
            pictureBox2.Location = new Point(304, 98);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(188, 268);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BorderStyle = BorderStyle.Fixed3D;
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = Properties.Resources.arog;
            pictureBox3.Location = new Point(552, 98);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(188, 268);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // odRadioBtn
            // 
            odRadioBtn.AutoSize = true;
            odRadioBtn.Location = new Point(62, 383);
            odRadioBtn.Name = "odRadioBtn";
            odRadioBtn.Size = new Size(183, 35);
            odRadioBtn.TabIndex = 9;
            odRadioBtn.TabStop = true;
            odRadioBtn.Text = "Ölümlü Dünya";
            odRadioBtn.UseVisualStyleBackColor = true;
            // 
            // lotrRadioBtn
            // 
            lotrRadioBtn.AutoSize = true;
            lotrRadioBtn.Location = new Point(341, 383);
            lotrRadioBtn.Name = "lotrRadioBtn";
            lotrRadioBtn.Size = new Size(111, 35);
            lotrRadioBtn.TabIndex = 10;
            lotrRadioBtn.TabStop = true;
            lotrRadioBtn.Text = "L.O.T.R.";
            lotrRadioBtn.UseVisualStyleBackColor = true;
            // 
            // arogRadioBtn
            // 
            arogRadioBtn.AutoSize = true;
            arogRadioBtn.Location = new Point(582, 383);
            arogRadioBtn.Name = "arogRadioBtn";
            arogRadioBtn.Size = new Size(120, 35);
            arogRadioBtn.TabIndex = 11;
            arogRadioBtn.TabStop = true;
            arogRadioBtn.Text = "A.R.O.G.";
            arogRadioBtn.UseVisualStyleBackColor = true;
            // 
            // seansCb
            // 
            seansCb.FormattingEnabled = true;
            seansCb.Items.AddRange(new object[] { "09.00", "12.00", "15.00", "18.00", "21.00" });
            seansCb.Location = new Point(1022, 98);
            seansCb.Name = "seansCb";
            seansCb.Size = new Size(151, 39);
            seansCb.TabIndex = 12;
            // 
            // seansLbl
            // 
            seansLbl.AutoSize = true;
            seansLbl.Location = new Point(768, 101);
            seansLbl.Name = "seansLbl";
            seansLbl.Size = new Size(158, 31);
            seansLbl.TabIndex = 13;
            seansLbl.Text = "Seans Seçiniz:";
            // 
            // blokLbl
            // 
            blokLbl.AutoSize = true;
            blokLbl.Location = new Point(768, 222);
            blokLbl.Name = "blokLbl";
            blokLbl.Size = new Size(243, 31);
            blokLbl.TabIndex = 15;
            blokLbl.Text = "Blok/Koltuk Numarası";
            // 
            // blokCb
            // 
            blokCb.FormattingEnabled = true;
            blokCb.Items.AddRange(new object[] { "A", "B", "C", "D", "E", "F", "G" });
            blokCb.Location = new Point(1042, 222);
            blokCb.Name = "blokCb";
            blokCb.Size = new Size(60, 39);
            blokCb.TabIndex = 14;
            // 
            // koltukCb
            // 
            koltukCb.FormattingEnabled = true;
            koltukCb.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25" });
            koltukCb.Location = new Point(1110, 222);
            koltukCb.Name = "koltukCb";
            koltukCb.Size = new Size(60, 39);
            koltukCb.TabIndex = 16;
            // 
            // tarihLbl
            // 
            tarihLbl.AutoSize = true;
            tarihLbl.Location = new Point(768, 162);
            tarihLbl.Name = "tarihLbl";
            tarihLbl.Size = new Size(149, 31);
            tarihLbl.TabIndex = 18;
            tarihLbl.Text = "Tarih Seçiniz:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(923, 162);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 38);
            dateTimePicker1.TabIndex = 19;
            // 
            // filmsecLbl
            // 
            filmsecLbl.AutoSize = true;
            filmsecLbl.BackColor = Color.DimGray;
            filmsecLbl.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 162);
            filmsecLbl.ForeColor = Color.White;
            filmsecLbl.Location = new Point(326, 53);
            filmsecLbl.Name = "filmsecLbl";
            filmsecLbl.Size = new Size(146, 32);
            filmsecLbl.TabIndex = 20;
            filmsecLbl.Text = "Film Seçiniz:";
            // 
            // FrmAnaForm
            // 
            AccessibleRole = AccessibleRole.None;
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1222, 529);
            Controls.Add(filmsecLbl);
            Controls.Add(dateTimePicker1);
            Controls.Add(tarihLbl);
            Controls.Add(koltukCb);
            Controls.Add(blokLbl);
            Controls.Add(blokCb);
            Controls.Add(seansLbl);
            Controls.Add(seansCb);
            Controls.Add(arogRadioBtn);
            Controls.Add(lotrRadioBtn);
            Controls.Add(odRadioBtn);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(biletlerimBtn);
            Controls.Add(biletalBtn);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5);
            Name = "FrmAnaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmAnaForm";
            Load += FrmAnaForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private Microsoft.Data.Sqlite.SqliteCommand sqliteCommand1;
        private Button biletalBtn;
        private Button biletlerimBtn;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private RadioButton odRadioBtn;
        private RadioButton lotrRadioBtn;
        private RadioButton arogRadioBtn;
        private ComboBox seansCb;
        private Label seansLbl;
        private Label blokLbl;
        private ComboBox blokCb;
        private ComboBox koltukCb;
        private Label tarihLbl;
        private DateTimePicker dateTimePicker1;
        private Label filmsecLbl;
    }
}