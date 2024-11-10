using BtkKursTakip.Modeller;

namespace BtkKursTakip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            tsbKullanici.Text = AppData.Kullanici.KullaniciAdi;

        }

        private void tsbKurslar_Click(object sender, EventArgs e)
        {
            FrmKurslar kurs = new FrmKurslar();
            kurs.ShowDialog();
        }

        private void tsbEgitmenler_Click(object sender, EventArgs e)
        {
            if (AppData.Kullanici.Yetki == YetkiTuru.Yonetici)
            {
                FrmEgitmenler form = new FrmEgitmenler();
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bu iþlem için yetkiniz yok",
                    "Uyarý", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        private void oturumuKapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGiris girisFormu = new FrmGiris();

            if(girisFormu.ShowDialog() != DialogResult.OK)
                Application.Exit();
        }
    }
}
