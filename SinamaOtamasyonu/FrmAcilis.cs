using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace SinamaOtamasyonu
{
    public partial class FrmAcilis : Form
    {
        public 
            string connectionString = "Data Source=kisiler.db;Version=3;";

        public FrmAcilis()
        {
            InitializeComponent();
        }
        private void TabloyuOlustur()
        {
            string connectionString = "Data Source=kisiler.db;Version=3;Pooling=True;Max Pool Size=100;Connect Timeout=30;";

            try
            {
                // Eðer veritabaný zaten açýksa kapatma iþlemi
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    // Baðlantýyý açmadan önce kontrol et
                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                    }

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
            catch (SQLiteException ex)
            {
               
                    MessageBox.Show("Hata oluþtu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Beklenmeyen bir hata oluþtu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }



        private void btnGirisYap_Click_1(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text;
            string sifre = txtSifre.Text;

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string sql = "SELECT * FROM kullanicilar2 WHERE KullaniciAdi = @kullaniciadi AND Sifre = @sifre";

                    using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@kullaniciadi", kullaniciAdi);
                        command.Parameters.AddWithValue("@sifre", sifre);

                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                FrmAnaForm frmAnaForm = new FrmAnaForm(kullaniciAdi);
                                frmAnaForm.Show();
                                this.Hide(); // Giriþ formunu gizle
                            }
                            else
                            {
                                MessageBox.Show("Kullanýcý adý veya þifre hatalý!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluþtu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void FrmAcilis_load(object sender, EventArgs e)
        {
            TabloyuOlustur();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            KayýtOl Kyt = new KayýtOl();
            Kyt.Show();
            this.Hide();
        }

       
    }
}
