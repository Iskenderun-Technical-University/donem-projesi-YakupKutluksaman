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
    public partial class FRMBransPanel : Form
    {
        public FRMBransPanel()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        private void FRMBransPanel_Load(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * From Tbl_Branslar", bgl.baglanti());
            da.Fill(dt1);
            dataGridView1.DataSource = dt1;



        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            //Brans panelinden branş eklemesi yapıyoruz
            SqlCommand komut = new SqlCommand("insert into Tbl_Branslar (BransAd) values (@q1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@q1", TxtBransAd.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş Başarıyla Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Datagridin içinde seçilen değerleri textboxlara taşıyoruz.
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtBransID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtBransAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from Tbl_Branslar where BransID=@q1 ", bgl.baglanti());
            komut.Parameters.AddWithValue("@q1", txtBransID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş Silindi");
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Tbl_Branslar set BransAd=@q1 where bransID=@q2", bgl.baglanti());
            komut.Parameters.AddWithValue("@q1",TxtBransAd.Text);
            komut.Parameters.AddWithValue("@q2", txtBransID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş Güncellendi");

        }
    }
}
