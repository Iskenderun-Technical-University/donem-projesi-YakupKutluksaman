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
    public partial class FRMRandevuListesi : Form
    {
        public FRMRandevuListesi()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl =new sqlbaglantisi();

        private void FRMRandevuListesi_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Randevular", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
       
    }
}
