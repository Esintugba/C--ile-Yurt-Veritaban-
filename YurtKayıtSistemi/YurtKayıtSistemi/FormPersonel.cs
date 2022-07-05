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
    public partial class FormPersonel : Form
    {
        public FormPersonel()
        {
            InitializeComponent();
        }
        Sqlbaglantim bgl = new Sqlbaglantim();
        private void FormPersonel_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtOtomasyonuDataSet8.Personel' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.personelTableAdapter.Fill(this.yurtOtomasyonuDataSet8.Personel);

        }

        private void buttonPersonelKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komutkaydet = new SqlCommand("insert into Personel (PersonelAdSoyad,PersonelDepartman) values (@p1,@p2)",bgl.baglanti());
            komutkaydet.Parameters.AddWithValue("@p1", textPersonelAd.Text);
            komutkaydet.Parameters.AddWithValue("@p2", textPersonelGorev.Text);
            komutkaydet.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Eklendi");
            this.personelTableAdapter.Fill(this.yurtOtomasyonuDataSet8.Personel);
        }

        private void buttonPersonelSil_Click(object sender, EventArgs e)
        {
            SqlCommand komutsil = new SqlCommand("delete from Personel where Personelid=@p1",bgl.baglanti());
            komutsil.Parameters.AddWithValue("@p1", textPersonelİD.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Silme İşlemi Gerçekleşti");
            this.personelTableAdapter.Fill(this.yurtOtomasyonuDataSet8.Personel);
        }

        private void buttonPersonelGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komutguncelle = new SqlCommand("update Personel set PersonelAdSoyad=@p1,PersonelDepartman=@p2 where Personelid=@p3", bgl.baglanti());
            komutguncelle.Parameters.AddWithValue("@p1", textPersonelAd.Text);
            komutguncelle.Parameters.AddWithValue("@p2", textPersonelGorev.Text);
            komutguncelle.Parameters.AddWithValue("@p3", textPersonelİD.Text);
            komutguncelle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Güncelleme Başarılı");
            this.personelTableAdapter.Fill(this.yurtOtomasyonuDataSet8.Personel);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            string ad, gorev, id;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            gorev = dataGridView1.Rows[secilen].Cells[2].Value.ToString();

            textPersonelAd.Text = ad;
            textPersonelGorev.Text = gorev;
            textPersonelİD.Text = id;
        }
    }
}
