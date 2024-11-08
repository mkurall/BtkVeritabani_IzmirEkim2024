using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelTakip
{
    public class TableProvider<T>
    {
        SqlConnection baglanti;
        public TableProvider(SqlConnection baglanti)
        {
            this.baglanti = baglanti;
        }
        public List<T> ListeGetir()
        {
            string tblAd = typeof(T).Name;

            SqlCommand cmd = new SqlCommand($"SELECT * FROM {tblAd}");

            return new();
        }
    }
}
