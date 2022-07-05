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
    public partial class Bolumler : Form
    {
        public Bolumler()
        {
            InitializeComponent();
        }

        Sqlbaglantim bgl = new Sqlbaglantim();

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Bolumler_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtOtomasyonuDataSet.Bolumler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.bolumlerTableAdapter.Fill(this.yurtOtomasyonuDataSet.Bolumler);

        }

        private void pictureEkle_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komutekle = new SqlCommand("insert into Bolumler (BolumAd) values (@p1)", bgl.baglanti());
                komutekle.Parameters.AddWithValue("@p1",textBolumad.Text);
                komutekle.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Bölüm Başarıyla Eklendi");
                this.bolumlerTableAdapter.Fill(this.yurtOtomasyonuDataSet.Bolumler);
            }
            catch
            {
                MessageBox.Show("HATA! Lütfen Tekrar Deneyiniz");
            }
        }

        private void pictureSil_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komutsil = new SqlCommand("delete from Bolumler where Bolumid=@p1", bgl.baglanti());
                komutsil.Parameters.AddWithValue("@p1", textBolumid.Text);
                komutsil.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Silme İşlemi Başarılı");
                this.bolumlerTableAdapter.Fill(this.yurtOtomasyonuDataSet.Bolumler);
            }
            catch
            {
                MessageBox.Show("HATA! Lütfen Tekrar Deneyiniz");
            }
           

        }

        int secilen;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string id, bolumad;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            bolumad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();

            textBolumid.Text = id;
            1textBolumad.Text = bolumad;

        }

        private void pictureDüzenle_Click(object sender, EventArgs e)
        {
            try
            {
                
                SqlCommand komutsil = new SqlCommand("update Bolumler Set Bolumad=@p1 where Bolumid=@p2", bgl.baglanti());
                komutsil.Parameters.AddWithValue("@p2", textBolumid.Text);
                komutsil.Parameters.AddWithValue("@p1", textBolumad.Text);
                komutsil.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Başarıyla Düzenlendi");
                this.bolumlerTableAdapter.Fill(this.yurtOtomasyonuDataSet.Bolumler);

            }
            catch
            {
                MessageBox.Show("HATA! Lütfen Tekrar Deneyiniz");
            }
          
        }
    }
}
