using EfCoreModelFirst.Modeller;
using EfCoreModelFirst.Veritabani;
using System.ComponentModel;

namespace EfCoreModelFirst
{
    public partial class Form1 : Form
    {
        BtkOkulDbContext context = new BtkOkulDbContext();
        BindingList<Ogrenci> blist;


        public Form1()
        {
            InitializeComponent();

            var liste = context.Ogrenci.ToList();
            blist = new BindingList<Ogrenci>(liste);

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = blist;

            var sinifListesi = context.Siniflar.ToList();
            colSinif.DataSource = sinifListesi;
            colSinif.DisplayMember = "Ad";
            colSinif.ValueMember = "Id";

            List<Cinsiyet> cList = new List<Cinsiyet>();

            cList.Add(new Cinsiyet() { Id = 0, Ad = "Erkek" });
            cList.Add(new Cinsiyet() { Id = 1, Ad = "Kadýn" });
            cList.Add(new Cinsiyet() { Id = 3, Ad = "Belirtmek Ýstemiyorum" });
            colCinsiyet.DataSource = cList;
            colCinsiyet.DisplayMember = "Ad";
            colCinsiyet.ValueMember = "Id";


        }

        private void btnSiniflar_Click(object sender, EventArgs e)
        {
            FrmSiniflar form = new FrmSiniflar();
            form.ShowDialog();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            foreach(Ogrenci o in blist)
            {
                if(o.Id<=0)
                {
                    context.Ogrenci.Add(o);
                }
            }

            context.SaveChanges();
            MessageBox.Show("Veriler kayýt edildi.");

        }
    }
}
