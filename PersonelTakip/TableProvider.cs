using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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

            var okuyucu = cmd.ExecuteReader();

            var props = typeof(T).GetProperties();

            List<T> liste = new();

            while(okuyucu.Read())
            {
                foreach(var prop in props)
                {

                }
            }


            return new();
        }
    }
}
