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
    public partial class KayıtOl : Form
    {
        public KayıtOl()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }



        private void linkLabel1_Click(object sender, EventArgs e)
        {
            FrmAcilis frmAcilis = new FrmAcilis();
            frmAcilis.Show();
            this.Close();


        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection("Data Source=kisiler.db;Version=3;"))
                {
                    connection.Open();

                    string insertSql = "INSERT INTO kullanicilar2 (KullaniciAdi, Sifre) VALUES (@kullaniciadi, @sifre);";

                    using (SQLiteCommand command = new SQLiteCommand(insertSql, connection))
                    {
                        command.Parameters.AddWithValue("@kullaniciadi", txtKullaniciAdi.Text);
                        command.Parameters.AddWithValue("@sifre", txtSifre.Text);

                        int rowsAffected = command.ExecuteNonQuery();

                        // İşlem başarıyla tamamlandıysa
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Kullanıcı başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Bir hata oluştu. Kullanıcı eklenemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Hata mesajını göster
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
     
