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
    public partial class FrmDoktorPanel : Form
    {
        public FrmDoktorPanel()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        private void FrmDoktorPanel_Load(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select * From Tbl_Doktorlar", bgl.baglanti());//Doktorlar datagride Ad-Soyad ve Bransları çekiyoruz.
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;

            SqlCommand komut2 = new SqlCommand("Select BransAd From Tbl_Branslar", bgl.baglanti());// brans comboboxa branları çekiyoruz.
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cbmBrans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            //Doktor Ekleme işlemi yapıyoruz doktor panelinde
            SqlCommand komut = new SqlCommand("insert into Tbl_Doktorlar (DoktorAd,DoktorSoyad,DoktorBrans,DoktorTC,DoktorSifre) values (@q1,@q2,@q3,@q4,@q5)", bgl.baglanti());
            komut.Parameters.AddWithValue("@q1", txtisim.Text);
            komut.Parameters.AddWithValue("@q2", txtsoyisim.Text);
            komut.Parameters.AddWithValue("@q3", cbmBrans.Text);
            komut.Parameters.AddWithValue("@q4", MskTC.Text);
            komut.Parameters.AddWithValue("@q5", txtSifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor başarıyla eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Doktor panelinde Seçilen satır veya sutuna göre bilgileri textbox ve cmbboxlara getiriyoruz.
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtisim.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtsoyisim.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cbmBrans.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            MskTC.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtSifre.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();

        }

        private void BtnSil_Click(object sender, EventArgs e)
        { 
            //Doktor panelinde Doktor silme işlemini gerçekleştirdik.
            SqlCommand komut = new SqlCommand("Delete from Tbl_Doktorlar where DoktorTC=@q1", bgl.baglanti());
            komut.Parameters.AddWithValue("@q1", MskTC.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tbl_Doktorlar set DoktorAd=@q1,DoktorSoyad=@q2,DoktorBrans=@q3,DoktorSifre=@q5 where DoktorTC=@q4 ",bgl.baglanti());
            komut.Parameters.AddWithValue("@q1", txtisim.Text);
            komut.Parameters.AddWithValue("@q2", txtsoyisim.Text);
            komut.Parameters.AddWithValue("@q3", cbmBrans.Text);
            komut.Parameters.AddWithValue("@q4", MskTC.Text);
            komut.Parameters.AddWithValue("@q5", txtSifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor başarıyla eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
