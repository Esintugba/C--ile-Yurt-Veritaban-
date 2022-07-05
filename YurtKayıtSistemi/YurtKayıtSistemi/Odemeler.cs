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
    public partial class Odemeler : Form
    {
        public Odemeler()
        {
            InitializeComponent();
        }
        Sqlbaglantim bgl = new Sqlbaglantim();

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Odemeler_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtOtomasyonuDataSet3.Borclar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.borclarTableAdapter1.Fill(this.yurtOtomasyonuDataSet3.Borclar);
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            string id, ad, soyad, kalan;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            soyad = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            kalan = dataGridView1.Rows[secilen].Cells[3].Value.ToString();

            textAD.Text = ad;
            textSoyad.Text = soyad;
            textborc.Text = kalan;
            textOgrid.Text = id;

        }

        private void buttonÖdeme_Click(object sender, EventArgs e)
        {
            //ödenen tutardan kalan tutarı çıkarma
            int odenen, kalan,yeniborc;
            odenen = Convert.ToInt16(textOdenen.Text);
            kalan = Convert.ToInt16(textborc.Text);
            yeniborc = kalan - odenen;
            textborc.Text = yeniborc.ToString();

            //Yeni tutarı veritabanına kaydetme
            SqlCommand komut = new SqlCommand("update Borclar set OgrKalanBorc=@p1 where Ogrid=@p2",bgl.baglanti());
            komut.Parameters.AddWithValue("@p2", textOgrid.Text);
            komut.Parameters.AddWithValue("@p1", textborc.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Borç Ödemesi Alındı");
            this.borclarTableAdapter1.Fill(this.yurtOtomasyonuDataSet3.Borclar);

            //Kasa Tablosuna Ekleme

            SqlCommand komut2 = new SqlCommand("insert into Kasa (OdemeAy,OdemeMiktar) values (@k1,@k2)", bgl.baglanti());
            komut2.Parameters.AddWithValue("@k1", textOdenenAy.Text);
            komut2.Parameters.AddWithValue("@k2", textOdenen.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
