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
    public partial class FrmBiletler : Form
    {
        private DataGridView dataGridViewBiletler;
        string username;

        public FrmBiletler(string username)
        {
            InitializeComponent();

            dataGridViewBiletler = new DataGridView();
            dataGridViewBiletler.Location = new Point(20, 20);
            dataGridViewBiletler.Size = new Size(600, 300);
            this.Controls.Add(dataGridViewBiletler);

            // DataGridView'i yapılandır
            dataGridViewBiletler.ColumnCount = 5;
            dataGridViewBiletler.Columns[0].Name = "Film Adı";
            dataGridViewBiletler.Columns[1].Name = "Seans";
            dataGridViewBiletler.Columns[2].Name = "Tarih";
            dataGridViewBiletler.Columns[3].Name = "Koltuk Bilgisi";
            dataGridViewBiletler.Columns[4].Name = "Kullanıcı Adı";
            this.username = username;
        }


        public void biletleriGoster()
        {
            string connectionString = "Data Source=kisiler.db;Version=3;";


            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    // Kullanıcıya ait biletleri çekmek için SQL sorgusu
                    string sql = "SELECT * FROM biletler WHERE KullaniciAdi = @KullaniciAdi";

                    using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@KullaniciAdi", username);

                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            // DataGridView'i temizle
                            dataGridViewBiletler.Rows.Clear();

                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    // Verileri al
                                    string filmAdi = reader["FilmAdi"].ToString();
                                    string seans = reader["Seans"].ToString();
                                    string tarih = reader["Tarih"].ToString();
                                    string koltukBilgisi = reader["KoltukBilgisi"].ToString();
                                    string kullaniciAdi = reader["KullaniciAdi"].ToString();

                                    // DataGridView'e satır ekle
                                    dataGridViewBiletler.Rows.Add(filmAdi, seans, tarih, koltukBilgisi, kullaniciAdi);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Bu kullanıcıya ait bilet bulunmamaktadır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmBiletler_Load(object sender, EventArgs e)
        {
            // DataGridView boyutunu uzun ve ince yapma
            dataGridViewBiletler.Width = 1000;  // Yatay genişlik
            dataGridViewBiletler.Height = 300;
            dataGridViewBiletler.BackgroundColor = SystemColors.Window;
        }

        
    }
}
