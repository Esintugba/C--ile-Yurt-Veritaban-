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
    public partial class FormOgrDuzenle : Form
    {
        public FormOgrDuzenle()
        {
            InitializeComponent();
        }
        public string id,ad,soyad,TC,telefon,dogum,bolum;

        

        public string mail, odano, veliad, velitel, adres;

        Sqlbaglantim bgl = new Sqlbaglantim();

        private void guncelle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("update Ogrenci set Ograd=@p2,Ogrsoyad=@p3,OgrTC=@p4,OgrTelefon=@p5,OgrDogum=@p6,OgrBolum=@p7,OgrMail=@p8,OgrOdaNo=@p9,OgrVeliAdSoyad=@p10,OgrVeliTelefon=@p11,OgrVeliAdres=@p12 where Ogrid=@p1",bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", textOgrid.Text);
                komut.Parameters.AddWithValue("@p2", textBoxOgrAd.Text);
                komut.Parameters.AddWithValue("@p3", textBoxOgrSoyad.Text);
                komut.Parameters.AddWithValue("@p4", maskedOgrTc.Text);
                komut.Parameters.AddWithValue("@p5", maskedOgrTelefon.Text);
                komut.Parameters.AddWithValue("@p6", maskedOgrDogum.Text);
                komut.Parameters.AddWithValue("@p7", comboBoxOgrBolum.Text);
                komut.Parameters.AddWithValue("@p8", textBoxOgrMail.Text);
                komut.Parameters.AddWithValue("@p9", comboBoxOgrOdaNo.Text);
                komut.Parameters.AddWithValue("@p10", textBoxVeliAd.Text);
                komut.Parameters.AddWithValue("@p11", maskedOgrTelefon.Text);
                komut.Parameters.AddWithValue("@p12", richVeliAdres.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Kayıt Güncellendi");

            }
            catch (Exception)
            {
                MessageBox.Show("HATA! Lütfen Tekrar Deneyiniz");
            }
              
        }

    
        private void FormOgrDuzenle_Load(object sender, EventArgs e)
        {
            textOgrid.Text = id;
            textBoxOgrAd.Text = ad;
            textBoxOgrSoyad.Text = soyad;
            maskedOgrTc.Text = TC;
            maskedOgrTelefon.Text = telefon;
            maskedOgrDogum.Text = dogum;
            comboBoxOgrBolum.Text = bolum;
            textBoxOgrMail.Text = mail;
            comboBoxOgrOdaNo.Text = odano;
            textBoxVeliAd.Text = veliad;
            maskedVeliTelefon.Text = velitel;
            richVeliAdres.Text = adres;
           


        }

        private void FormOgrDuzenle_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void buttonSil_Click(object sender, EventArgs e)
        {
            //Öğrenci Silme
            SqlCommand komutsil = new SqlCommand("delete from Ogrenci where Ogrid=@k1", bgl.baglanti());
            komutsil.Parameters.AddWithValue("@k1", textOgrid.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Silindi");

            //Oda Kontenjanı Arttırma

            SqlCommand komutoda = new SqlCommand("update Odalar set OdaAktif=OdaAktif-1 where OdaNo=@oda", bgl.baglanti());
            komutoda.Parameters.AddWithValue("@oda", comboBoxOgrOdaNo.Text);
            komutoda.ExecuteNonQuery();
            bgl.baglanti().Close();

        }


    }
}
