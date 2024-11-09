namespace BtkKursTakip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tsbKurslar_Click(object sender, EventArgs e)
        {
            FrmKurslar kurs = new FrmKurslar();
            kurs.ShowDialog();
        }
    }
}
