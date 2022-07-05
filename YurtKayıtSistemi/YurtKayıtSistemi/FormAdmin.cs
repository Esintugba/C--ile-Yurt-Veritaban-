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
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        Sqlbaglantim bgl = new Sqlbaglantim();
        private void textBolumid_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from admin where Yoneticiad=@p1 and YoneticiSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textAdminAd.Text);
            komut.Parameters.AddWithValue("@p2", textAdminSifre.Text);
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                AnaForm fr = new AnaForm();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı ya da şifre");
                textAdminAd.Clear();
                textAdminSifre.Clear();
                textAdminAd.Focus();
                
                    
            }
            bgl.baglanti().Close();
        }
    }
}
