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
    public partial class FRMSekreterGiris : Form
    {
        public FRMSekreterGiris()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void BtnGiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Tbl_Sekreterler Where SekreterTC=@q1 and SekreterSifre=@q2", bgl.baglanti());
            komut.Parameters.AddWithValue("@q1", MskTC.Text);
            komut.Parameters.AddWithValue("@q2", TxtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if(dr.Read())
            {
                FRMSekreterDetay fr = new FRMSekreterDetay();
                fr.TCNumara = MskTC.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı TC & Şifre");
            }
            bgl.baglanti().Close();
        }
    }
}
