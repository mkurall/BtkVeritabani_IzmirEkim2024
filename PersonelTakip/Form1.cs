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

            if (baglanti.State == System.Data.ConnectionState.Open)
            {
                MessageBox.Show("Baþlantý baþarýlý.");

                SqlCommand cmd = new SqlCommand("select * from Personeller", baglanti);

                var okuyucu = cmd.ExecuteReader();

                List<Personeller> liste = new();

                while (okuyucu.Read())
                {
                    Personeller personel = new Personeller();

                    personel.Id = okuyucu.GetInt32("Id");
                    personel.Ad = okuyucu.GetString("Ad");
                    personel.Soyad = okuyucu.GetString("Soyad");
                    personel.Kidem = okuyucu.GetByte("Kidem");

                    var x = okuyucu.GetValue("BirimId");

                    personel.BirimId = (x == DBNull.Value ? null : (int)x);

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

        class Personeller
        {
            public int Id { get; set; }
            public string Ad { get; set; }
            public string Soyad { get; set; }
            public byte Kidem { get; set; }
            public int? BirimId { get; set; }

            public string AdSoyad { get { return Ad + " " + Soyad; } }
        }

        private void btnBirimleriGetir_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new
                SqlConnection("Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=PersonelDb;");

            TableProvider<Birimler> provider = new TableProvider<Birimler>(baglanti);

            var blistesi = provider.ListeGetir();

            comboBox1.DataSource = blistesi;
            comboBox1.DisplayMember = "BirimAd";
            comboBox1.ValueMember = "Id";

            TableProvider<Personeller> personelProvider = new(baglanti);
            var plistesi = personelProvider.ListeGetir(); 
            
            lbPersoneller.DataSource = plistesi;
            lbPersoneller.DisplayMember = "AdSoyad";
            lbPersoneller.ValueMember = "Id";

        }
    }
}
