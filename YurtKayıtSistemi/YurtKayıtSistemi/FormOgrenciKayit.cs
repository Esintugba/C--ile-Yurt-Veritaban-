using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace YurtKayıtSistemi
{
    public partial class FormOgrenciKayit : Form
    {
        public FormOgrenciKayit()
        {
            InitializeComponent();

        }
        Sqlbaglantim bgl = new Sqlbaglantim();

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void label11_Click(object sender, EventArgs e)
        {

        }
        private void label9_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Bölümlerin listelenme komutları
           
            SqlCommand komut = new SqlCommand("Select BolumAd From Bolumler", bgl.baglanti());
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                comboBoxOgrBolum.Items.Add(oku[0].ToString());
            }
            bgl.baglanti().Close();

            //Boş odaların listelenme komutları
           
            SqlCommand komut2 = new SqlCommand("Select OdaNo From Odalar where OdaKapasite!=OdaAktif", bgl.baglanti());
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                comboBoxOgrOdaNo.Items.Add(oku2[0].ToString());
            }
            bgl.baglanti().Close();
        }

        private void kayıt_Click(object sender, EventArgs e)
        {
            //Öğrenci Bilgilerinin Kayıt Edilme Komutu

            try
            {
               
                SqlCommand komutkaydet = new SqlCommand("insert into Ogrenci (Ograd,Ogrsoyad,OgrTC,OgrTelefon,OgrDogum,OgrBolum,OgrMail,OgrOdaNo,OgrVeliAdSoyad,OgrVeliTelefon,OgrVeliAdres) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)", bgl.baglanti());
                komutkaydet.Parameters.AddWithValue("@p1", textBoxOgrAd.Text);
                komutkaydet.Parameters.AddWithValue("@p2", textBoxOgrSoyad.Text);
                komutkaydet.Parameters.AddWithValue("@p3", maskedOgrTc.Text);
                komutkaydet.Parameters.AddWithValue("@p4", maskedOgrTelefon.Text);
                komutkaydet.Parameters.AddWithValue("@p5", maskedOgrDogum.Text);
                komutkaydet.Parameters.AddWithValue("@p6", comboBoxOgrBolum.Text);
                komutkaydet.Parameters.AddWithValue("@p7", textBoxOgrMail.Text);
                komutkaydet.Parameters.AddWithValue("@p8", comboBoxOgrOdaNo.Text);
                komutkaydet.Parameters.AddWithValue("@p9", textBoxVeliAd.Text);
                komutkaydet.Parameters.AddWithValue("@p10", maskedVeliTelefon.Text);
                komutkaydet.Parameters.AddWithValue("@p11", richVeliAdres.Text);
                komutkaydet.ExecuteNonQuery();

                bgl.baglanti().Close();
                MessageBox.Show("Kayıt Başarılı Bir Şekilde Eklendi.");

                //Öğrenci İdyi Labele Çekme

                SqlCommand komut = new SqlCommand("select Ogrid from Ogrenci", bgl.baglanti());
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    label1.Text=oku[0].ToString();
                }
                bgl.baglanti().Close();
            }
            catch (Exception)
            {
                MessageBox.Show("HATA! Lütfen Yeniden Deneyiniz..");
            }

            try
            {
                //Öğrenci Borç Alanı Oluşturma
                SqlCommand komutkaydet2 = new SqlCommand("insert into Borclar (Ogrid,Ograd,OgrSoyad) values (@b1,@b2,@b3)", bgl.baglanti());
                komutkaydet2.Parameters.AddWithValue("@b1", label1.Text);
                komutkaydet2.Parameters.AddWithValue("@b2", textBoxOgrAd.Text);
                komutkaydet2.Parameters.AddWithValue("@b3", textBoxOgrSoyad.Text);
                komutkaydet2.ExecuteNonQuery();
                bgl.baglanti().Close();
            }
            catch (Exception)
            {
                MessageBox.Show("HATA! Lütfen Yeniden Deneyiniz..");
            }

            //Öğrenci Oda Kontenjanı Azaltma

            SqlCommand komutoda = new SqlCommand("update Odalar set OdaAktif=OdaAktif+1 where OdaNo=@oda1", bgl.baglanti());
            komutoda.Parameters.AddWithValue("@oda1", comboBoxOgrOdaNo.Text);
            komutoda.ExecuteNonQuery();
            bgl.baglanti().Close();
            

        }
    }
}
// Data Source=DESKTOP-69VK961\SQLEXPRESS;Initial Catalog=YurtOtomasyonu;Integrated Security=True