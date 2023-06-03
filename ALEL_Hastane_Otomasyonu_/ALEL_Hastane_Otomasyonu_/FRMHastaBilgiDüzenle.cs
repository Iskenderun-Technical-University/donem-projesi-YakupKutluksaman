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
    public partial class FRMHastaBilgiDüzenle : Form
    {
        public FRMHastaBilgiDüzenle()
        {
            InitializeComponent();
        }
        public string TCno;

        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FRMHastaBilgiDüzenle_Load(object sender, EventArgs e)
        {
            MskTC.Text = TCno;
            SqlCommand komut = new SqlCommand("Select * From Tbl_Hastalar where HastaTC=@p1 ", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MskTC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                txtisim.Text = dr[1].ToString();
                txtsoyisim.Text = dr[2].ToString();
                mskTlf.Text = dr[3].ToString();
                txtSifre.Text = dr[4].ToString();
                cbmCinsiyet.Text = dr[5].ToString();
            }
            bgl.baglanti().Close();
            
        }
        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 =new SqlCommand("update Tbl_Hastalar set HastaAd=@p1,HastaSoyad=@p2,HastaTLF=@p3,HastaSifre=@p4,HastaCinsiyet=@p5 where HastaTC=@p6",bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", txtisim.Text);
            komut2.Parameters.AddWithValue("@p2", txtsoyisim.Text);
            komut2.Parameters.AddWithValue("@p3", mskTlf.Text);
            komut2.Parameters.AddWithValue("@p4", txtSifre.Text);
            komut2.Parameters.AddWithValue("@p5", cbmCinsiyet.Text);
            komut2.Parameters.AddWithValue("@p6", MskTC.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgileriniz Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);


        }
    }
}
