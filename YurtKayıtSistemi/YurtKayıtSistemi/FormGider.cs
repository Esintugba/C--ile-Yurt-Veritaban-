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
    public partial class FormGider : Form
    {
        public FormGider()
        {
            InitializeComponent();
        }
        Sqlbaglantim bgl = new Sqlbaglantim();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttongider_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("insert into Giderler (Elektrik,Su,Dogalgaz,internet,Gıda,Personel,Diger) Values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", textElektrik.Text);
                komut.Parameters.AddWithValue("@p2", textSu.Text);
                komut.Parameters.AddWithValue("@p3", textDogalgaz.Text);
                komut.Parameters.AddWithValue("@p4", textİnternet.Text);
                komut.Parameters.AddWithValue("@p5", textGıda.Text);
                komut.Parameters.AddWithValue("@p6", textPersonel.Text);
                komut.Parameters.AddWithValue("@p7", textDiger.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Giderler eklendi");
            }
            catch (Exception)
            {
                MessageBox.Show("HATA! Lütfen Tekrar Deneyiniz");

            }


        }

        private void FormGider_Load(object sender, EventArgs e)
        {

        }
    }
}
