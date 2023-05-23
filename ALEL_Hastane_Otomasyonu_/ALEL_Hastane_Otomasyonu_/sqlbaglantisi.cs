using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ALEL_Hastane_Otomasyonu_
{
    class sqlbaglantisi
    {
        public SqlConnection baglanti() // Sınıf içinde sql bağlantısı oluşturduk.Formlar da tek tek oluşturmak yerine sınıftan faydalanacağız.
        {
            SqlConnection baglan = new SqlConnection("Data Source=YKS;Initial Catalog=ALEL_Hastane_Otomasyonu;Integrated Security=True");
            baglan.Open();
            return baglan;
        }


    }
}
