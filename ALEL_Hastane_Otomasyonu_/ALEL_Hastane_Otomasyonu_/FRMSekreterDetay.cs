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


namespace ALEL_Hastane_Otomasyonu_
{
    public partial class FRMSekreterDetay : Form
    {
        public FRMSekreterDetay()
        {
            InitializeComponent();
        }
        public string TCNumara;
        sqlbaglantisi bgl = new sqlbaglantisi();

        private void FRMSekreterDetay_Load(object sender, EventArgs e)
        {
            lblTC.Text = TCNumara;

            SqlCommand komut1 = new SqlCommand("Select SekreterAd,SekreterSoyad From Tbl_Sekreterler Where SekreterTC=@q1",bgl.baglanti());
            komut1.Parameters.AddWithValue("@q1", lblTC.Text);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while(dr1.Read())
            {
                LblisimSoyisim.Text = dr1[0].ToString() + " " + dr1[1].ToString();//İsim Soyisimi Sekreter Bilgi paneline çekiyoruz
            }
            bgl.baglanti().Close();

            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select BransAD From Tbl_Branslar",bgl.baglanti()); //Branşları datagride alıyoruz.
            da.Fill(dt1);
            dataGridView1.DataSource = dt1;

            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select (DoktorAd + ' ' + DoktorSoyad) as 'Doktorlar',DoktorBrans From Tbl_Doktorlar",bgl.baglanti());//Doktorlar datagride Ad-Soyad ve Bransları çekiyoruz.
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;

            SqlCommand komut2 = new SqlCommand("Select BransAd From Tbl_Branslar",bgl.baglanti());// brans comboboxa branları çekiyoruz.
            SqlDataReader dr2 = komut2.ExecuteReader();
            while(dr2.Read())
            {
                cmbBrans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();



        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //Sekreter Bölümünde Randevu oluşturma işlemleri
            SqlCommand komut3 = new SqlCommand("insert into Tbl_Randevular (RandevuTarih,RandevuSaat,RandevuDoktor,RandevuBrans) values (@r1,@r2,@r3,@r4)",bgl.baglanti());
            komut3.Parameters.AddWithValue("@r1", mskTarih.Text);
            komut3.Parameters.AddWithValue("@r2", mskSaat.Text);
            komut3.Parameters.AddWithValue("@r3", cmbDoktor.Text);
            komut3.Parameters.AddWithValue("@r4", cmbBrans.Text);
            komut3.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu oluşturuldu");

        }

        private void cmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoktor.Items.Clear();
            SqlCommand komut = new SqlCommand("Select DoktorAd,DoktorSoyad from Tbl_Doktorlar Where DoktorBrans=@q1",bgl.baglanti());
            komut.Parameters.AddWithValue("@q1",cmbBrans.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                cmbDoktor.Items.Add(dr[0] + " " + dr[1]);
            }
            bgl.baglanti().Close();
        }

        private void BtnOlustur_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Duyurular (duyuru) values (@q1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@q1", rchDuyuru.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Duyuru Oluşturuldu!");
            bgl.baglanti().Close();
        }

        private void btnDoktorPaneli_Click(object sender, EventArgs e)
        {
            FrmDoktorPanel fr = new FrmDoktorPanel();
            fr.Show();
        }
    }
}
