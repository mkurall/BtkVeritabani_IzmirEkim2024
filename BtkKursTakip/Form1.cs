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
            FrmEgitmenler form = new FrmEgitmenler();
            form.ShowDialog();
        }
    }
}
