using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace PersonelTakip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPersonelleriGetir_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new 
                SqlConnection("Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=PersonelDb;");

            baglanti.Open();

            if(baglanti.State == System.Data.ConnectionState.Open)
            {
                MessageBox.Show("Baþlantý baþarýlý.");

                SqlCommand cmd = new SqlCommand("select * from Personeller", baglanti);

                var okuyucu = cmd.ExecuteReader();

                List<TblPersonel> liste = new();

                while(okuyucu.Read())
                {
                    TblPersonel personel = new TblPersonel();

                    personel.Id = okuyucu.GetInt32("Id");
                    personel.Ad = okuyucu.GetString("Ad");
                    personel.Soyad = okuyucu.GetString("Soyad");
                    personel.Kidem = okuyucu.GetByte("Kidem");
                    personel.BirimId = okuyucu.GetInt32("BirimId");
                    liste.Add(personel);
                }


                lbPersoneller.DataSource = liste;
                lbPersoneller.DisplayMember = "AdSoyad";
                lbPersoneller.ValueMember = "Id";
            }
            else
            {
                MessageBox.Show("Baþlantý baþarýsýz. Lütfen baðlantý cümlenizi kontrol edin!");
            }

            
        }

        class TblPersonel
        {
            public int Id { get; set; }
            public string Ad { get; set; }
            public string Soyad { get; set; }
            public byte Kidem { get; set; }
            public int BirimId { get; set; }

            public string AdSoyad { get { return Ad + " " + Soyad; } }
        }
    }
}
