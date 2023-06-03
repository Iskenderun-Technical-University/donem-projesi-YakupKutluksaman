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
    public partial class FRMDoktorBİlgiDüzenle : Form
    {
        public FRMDoktorBİlgiDüzenle()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        public string TC;
        private void FRMDoktorBİlgiDüzenle_Load(object sender, EventArgs e)
        {
            MskTC.Text = TC;
            SqlCommand komut = new SqlCommand("Select * from Tbl_Doktorlar where DoktorTC=@q1", bgl.baglanti());
            komut.Parameters.AddWithValue("@q1", MskTC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                txtisim.Text = dr[1].ToString();
                txtsoyisim.Text = dr[2].ToString();
                cmbBrans.Text = dr[3].ToString();
                txtSifre.Text = dr[5].ToString();
            }
            bgl.baglanti().Close();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tbl_Doktorlar set DoktorAd=@q1,DoktorSoyad=@q2,DoktorBrans=@q3,DoktorSifre=@q4 where DoktorTC=@5", bgl.baglanti());
            komut.Parameters.AddWithValue("@q1", txtisim.Text);
            komut.Parameters.AddWithValue("@q2", txtsoyisim.Text);
            komut.Parameters.AddWithValue("@q3", cmbBrans.Text);
            komut.Parameters.AddWithValue("@q4", txtSifre.Text);
            komut.Parameters.AddWithValue("@5", MskTC.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Güncellendi");
        }
    }
}
