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
    public partial class FormGiderGuncelle : Form
    {
        public FormGiderGuncelle()
        {
            InitializeComponent();
        }

        public string elektrik, su, dogalgaz, internet, gida, personel, diger,id;

       

        Sqlbaglantim bgl = new Sqlbaglantim();

        private void FormGiderGuncelle_Load(object sender, EventArgs e)
        {
            textgiderİD.Text = id;
            textElektrik.Text = elektrik;
            textSu.Text = su;
            textDogalgaz.Text = dogalgaz;
            textİnternet.Text = internet;
            textGıda.Text = gida;
            textPersonel.Text = personel;
            textDiger.Text = diger;

        }

        private void buttongiderguncelle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("update Giderler set Elektrik=@p1,Su=@p2,Dogalgaz=@p3,internet=@p4,Gıda=@p5,Personel=@p6,Diger=@p7 where Odemeid=@p8", bgl.baglanti());
                komut.Parameters.AddWithValue("@p8", textgiderİD.Text);
                komut.Parameters.AddWithValue("@p1", textElektrik.Text);
                komut.Parameters.AddWithValue("@p2", textSu.Text);
                komut.Parameters.AddWithValue("@p3", textDogalgaz.Text);
                komut.Parameters.AddWithValue("@p4", textİnternet.Text);
                komut.Parameters.AddWithValue("@p5", textGıda.Text);
                komut.Parameters.AddWithValue("@p6", textPersonel.Text);
                komut.Parameters.AddWithValue("@p7", textDiger.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Güncelleme Başarılı");
            }
            catch (Exception)
            {
                MessageBox.Show("HATA! Lütfen Tekrar Deneyiniz");
            }
        }

    }
}
