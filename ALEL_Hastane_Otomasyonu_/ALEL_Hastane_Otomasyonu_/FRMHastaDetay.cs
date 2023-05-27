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
    public partial class FRMHastaDetay : Form
    {
        public FRMHastaDetay()
        {
            InitializeComponent();
        }
        public string tc; //public tc oluşturup hasta girişteki tc yi aldık.

        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FRMHastaDetay_Load(object sender, EventArgs e)
        {
            lblTC.Text = tc;

            SqlCommand komut = new SqlCommand("Select HastaAd,HastaSoyad From Tbl_Hastalar where HastaTC=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lblTC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                lblisimSoy.Text = dr[0] +" " + dr[1]; //Kişi Bilgilerine Sql den tc numarasına göre isim ve soyisimi çekiyoruz.
            }
            bgl.baglanti().Close();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevular where HastaTC= " +tc,bgl.baglanti()); //Hasta Tc numarasına göre datagridviewe randevuları çekiyoruz.
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            SqlCommand komut2 = new SqlCommand("select BransAd from Tbl_Branslar", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while(dr2.Read())
            {
                cmbBrans.Items.Add(dr2[0]); // comboboxa Branşları çekiyoruz.
            }
        }

        private void cmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoktor.Items.Clear(); // Her Branş seçiminde doktorların combobox temizliyoruz.

            SqlCommand komut3 = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktorlar where DoktorBrans=@p1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", cmbBrans.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read()) 
            {
                cmbDoktor.Items.Add(dr3[0] + " " + dr3[1]); // Branşlara göre sorgu yapıp doktorları çekiyoruz.
            }
            bgl.baglanti().Close();
        }
        private void cmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevular where RandevuBrans ='"+cmbBrans.Text+"'",bgl.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }
        private void lnkBilgiDuzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FRMHastaBilgiDüzenle fr = new FRMHastaBilgiDüzenle();
            fr.TCno = lblTC.Text; //Hasta detay formundaki tc numarasını hasta bilgi düzenle formunda tc numarasına taşıdık.
            fr.Show();
        }
    }
}
