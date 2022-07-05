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
    public partial class FormYöneticiDuzenle : Form
    {
        public FormYöneticiDuzenle()
        {
            InitializeComponent();
        }

        Sqlbaglantim bgl = new Sqlbaglantim();

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtOtomasyonuDataSet7.Admin' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.adminTableAdapter.Fill(this.yurtOtomasyonuDataSet7.Admin);

        }

        private void buttonYöneticiKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komutkaydet = new SqlCommand("insert into Admin (YoneticiAd,YoneticiSifre) values (@p1,@p2)", bgl.baglanti());
            komutkaydet.Parameters.AddWithValue("@p1", textKullanıcıAd.Text);
            komutkaydet.Parameters.AddWithValue("@p2", textYöneticiSifre.Text);
            komutkaydet.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Yönetici Eklendi");
            this.adminTableAdapter.Fill(this.yurtOtomasyonuDataSet7.Admin);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            string ad, sifre, id;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            sifre = dataGridView1.Rows[secilen].Cells[2].Value.ToString();

            textKullanıcıAd.Text = ad;
            textYöneticiSifre.Text = sifre;
            textYoneticiİD.Text = id;
        }

        private void buttonYöneticiSil_Click(object sender, EventArgs e)
        {
            SqlCommand komutsil = new SqlCommand("delete from Admin where Yoneticiid=@p1",bgl.baglanti());
            komutsil.Parameters.AddWithValue("@p1", textYoneticiİD.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Silme İşlemi Gerçekleşti");
            this.adminTableAdapter.Fill(this.yurtOtomasyonuDataSet7.Admin);
          

        }

        private void buttonYöneticiGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komutguncelle = new SqlCommand("update Admin set YoneticiAd=@p1,YoneticiSifre=@p2 where Yoneticiid=@p3", bgl.baglanti());
            komutguncelle.Parameters.AddWithValue("@p1", textKullanıcıAd.Text);
            komutguncelle.Parameters.AddWithValue("@p2", textYöneticiSifre.Text);
            komutguncelle.Parameters.AddWithValue("@p3", textYoneticiİD.Text);
            komutguncelle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Güncellenme İşlemi Başarılı");
            this.adminTableAdapter.Fill(this.yurtOtomasyonuDataSet7.Admin);

        }
    }
}
