using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YurtKayıtSistemi
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void öğrenciSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOgrListe fr = new FormOgrListe();
            fr.Show();
                
        }
        private void AnaForm_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtOtomasyonuDataSet1.Ogrenci' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ogrenciTableAdapter.Fill(this.yurtOtomasyonuDataSet1.Ogrenci);
            timer1.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();


        }

        private void hesapMakinesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }

        private void paintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("MsPaint.Exe");
        }

        private void öğrenciEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOgrenciKayit fr = new FormOgrenciKayit();
            fr.Show();
        }

        private void öğrenciDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOgrListe fr = new FormOgrListe();
            fr.Show();

        }

        private void bölümEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bolumler frm = new Bolumler();
            frm.Show();

                
        }

        private void bölümSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bolumler frm = new Bolumler();
            frm.Show();
        }

        private void ödemeAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Odemeler odm = new Odemeler();
            odm.Show();
                
        }

        private void giderEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGider gdr = new FormGider();
            gdr.Show();
        }

        private void giderİstatistikleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGiderListe gdr = new FormGiderListe();
            gdr.Show();
        }

        private void giderİstatisikleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGiderListe lst = new FormGiderListe();
            lst.Show();
        }

        private void gelirİstatistikleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGiderİstatistik ist = new FormGiderİstatistik();
            ist.Show();
        }

        private void şifreİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormYöneticiDuzenle ynt = new FormYöneticiDuzenle();
            ynt.Show();
        }

        private void personelDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPersonel prs = new FormPersonel();
            prs.Show();
        }

        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yurdumuz öğrencilerimizin kendilerini evlerindeymiş gibi hissetmesini sağlamaktadır","2009 yılından beri hizmet vermekteyiz.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
