using PersonelTakip.Modeller;
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

                List<TblPersoneller> liste = new();

                while (okuyucu.Read())
                {
                    TblPersoneller personel = new TblPersoneller();

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



        private void btnBirimleriGetir_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new
                SqlConnection("Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=PersonelDb;");

            TableProvider<TblBirimler> provider = new TableProvider<TblBirimler>(baglanti);

            var blistesi = provider.ListeGetir();

            comboBox1.DataSource = blistesi;
            comboBox1.DisplayMember = "BirimAd";
            comboBox1.ValueMember = "Id";

            TableProvider<TblPersoneller> personelProvider = new(baglanti);
            var plistesi = personelProvider.ListeGetir();

            lbPersoneller.DataSource = plistesi;
            lbPersoneller.DisplayMember = "AdSoyad";
            lbPersoneller.ValueMember = "Id";

        }

        private void btnEfCoreKullan_Click(object sender, EventArgs e)
        {
            PersonelDbContext ctx = new PersonelDbContext();

            var plistesi = ctx.Personellers.ToList();

            var blistesi = ctx.Birimlers.ToList();

            lbPersoneller.DataSource = plistesi;
            lbPersoneller.DisplayMember = "Ad";
            lbPersoneller.ValueMember = "Id";

            comboBox1.DataSource = blistesi;
            comboBox1.DisplayMember = "BirimAd";
            comboBox1.ValueMember = "Id";

        }

        private void btnBirimEkle_Click(object sender, EventArgs e)
        {
            PersonelDbContext context = new PersonelDbContext(); 
            
            Birimler birim = new Birimler();
            birim.BirimAd = txtYeniBirim.Text;

            context.Birimlers.Add(birim);

            context.SaveChanges();
        }
    }
}
