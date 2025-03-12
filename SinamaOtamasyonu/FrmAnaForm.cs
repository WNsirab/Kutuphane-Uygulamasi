using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace SinamaOtamasyonu
{
    public partial class FrmAnaForm : Form
    {
        string kullaniciAdi;
        public string connectionString = "Data Source=kisiler.db;Version=3;";
        public FrmAnaForm(string kullaniciAdi)
        {
            InitializeComponent();
            this.kullaniciAdi = kullaniciAdi;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmAnaForm_Load(object sender, EventArgs e)
        {
            TabloyuOlustur();
            seansCb.SelectedIndex = 0;
            blokCb.SelectedIndex = 0;
            koltukCb.SelectedIndex = 0;
        }
        private void TabloyuOlustur()
        {


            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string sql = @"
                CREATE TABLE IF NOT EXISTS biletler (
                    KullaniciAdi TEXT NOT NULL,
                    FilmAdi TEXT NOT NULL,
                    Seans TEXT NOT NULL,
                    Tarih TEXT NOT NULL,
                    KoltukBilgisi TEXT NOT NULL
                );";

                    using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void biletalBtn_Click(object sender, EventArgs e)
        {


            // Formdaki seçimler
            string seans = seansCb.Text;
            DateTime tarih1 = dateTimePicker1.Value;
            string tarih = tarih1.ToString("yyyy-MM-dd");
            string blok = blokCb.Text;
            string koltuk = koltukCb.Text;
            string koltukbilgisi = $"({blok},{koltuk})";
            string filmAdi = ""; // Radiobutton ile seçilecek
                                 // Giriş yapan kullanıcı bilgisi, bunu oturumdan alabilirsiniz.

            // Radiobutton seçimi
            if (odRadioBtn.Checked)
            {
                filmAdi = "Ölümlü Dünya";
            }
            else if (lotrRadioBtn.Checked)
            {
                filmAdi = "Yüzüklerin Efendisi";
            }
            else if (arogRadioBtn.Checked)
            {
                filmAdi = "A.R.O.G.";
            }
            else
            {
                MessageBox.Show("Lütfen bir film seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    // Veritabanına veri ekleme
                    string sql = "INSERT INTO biletler (KullaniciAdi, FilmAdi, Seans, Tarih, KoltukBilgisi) VALUES (@KullaniciAdi, @FilmAdi, @Seans, @Tarih, @KoltukBilgisi)";
                    using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi);
                        command.Parameters.AddWithValue("@FilmAdi", filmAdi);
                        command.Parameters.AddWithValue("@Seans", seans);
                        command.Parameters.AddWithValue("@Tarih", tarih);
                        command.Parameters.AddWithValue("@KoltukBilgisi", koltukbilgisi);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Bilet başarıyla alındı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void biletlerimBtn_Click(object sender, EventArgs e)
        {
            FrmBiletler frmBiletler = new FrmBiletler(kullaniciAdi);
            frmBiletler.Show();
            frmBiletler.biletleriGoster(); // Biletleri göster
        }

        
    }
}
