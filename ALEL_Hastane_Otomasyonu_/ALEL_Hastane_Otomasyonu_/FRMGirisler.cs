using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALEL_Hastane_Otomasyonu_
{
    public partial class FRMGirisler : Form
    {
        public FRMGirisler()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void BtnHastaGiris_Click(object sender, EventArgs e)
        {
            FRMHastaGiris fr = new FRMHastaGiris();
            fr.Show();
            this.Hide();
        }

        private void btnDoktorGiris_Click(object sender, EventArgs e)
        {
            FRMDoktorGiris fr = new FRMDoktorGiris();
            fr.Show();
            this.Hide();
        }

        private void BtnSekreterGiris_Click(object sender, EventArgs e)
        {
            FRMSekreterGiris fr = new FRMSekreterGiris();
            fr.Show();
            this.Hide();
        }
    }
}
