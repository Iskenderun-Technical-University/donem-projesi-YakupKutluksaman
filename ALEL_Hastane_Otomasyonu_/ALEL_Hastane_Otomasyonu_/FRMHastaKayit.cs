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
    public partial class FRMHastaKayit : Form
    {
        public FRMHastaKayit()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        private void BtnKayıt_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Hastalar (HastaAd,HastaSoyad,HastaTLF,HastaSifre,HastaCinsiyet,HastaTC) values (@p1,@p2,@p3,@p4,@p5,@p6)",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtisim.Text);
            komut.Parameters.AddWithValue("@p2", txtsoyisim.Text);
            komut.Parameters.AddWithValue("@p3", mskTlf.Text);
            komut.Parameters.AddWithValue("@p4", txtSifre.Text);
            komut.Parameters.AddWithValue("@p5", cbmCinsiyet.Text);
            komut.Parameters.AddWithValue("@p6", MskTC.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kaydınız Oluşturuldu.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
