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
    public partial class FRMDoktorDetay : Form
    {
        public FRMDoktorDetay()
        {
            InitializeComponent();
        }
        public string TC;
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FRMDoktorDetay_Load(object sender, EventArgs e)
        {
            LblTC.Text = TC;
            SqlCommand komut = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktorlar where DoktorTC=@q1", bgl.baglanti());
            komut.Parameters.AddWithValue("@q1", LblTC.Text);//İsim Soyisim lbl ye doktorun tc ye göre adını soyadını yazdık.
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                lblAdSoyad.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevular where RandevuDoktor='" + lblAdSoyad.Text + "'", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void btnBilgiDuzenle_Click(object sender, EventArgs e)
        {
            FRMDoktorBİlgiDüzenle fr = new FRMDoktorBİlgiDüzenle();
            fr.TC = LblTC.Text;
            fr.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FRMDuyurular fr = new FRMDuyurular();
            fr.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            rchSikayet.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }
    }
}
