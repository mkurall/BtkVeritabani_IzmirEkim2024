using BtkKursTakip.Modeller;
using System.Runtime.InteropServices;

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

            if (girisFormu.ShowDialog() != DialogResult.OK)
                Application.Exit();
        }

        [DllImport("User32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int wMsg, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll")]
        public static extern Boolean ShowWindow(IntPtr hWnd, Int32 nCmdShow);

        const int SW_HIDE = 0;
        const int SW_SHOW = 5;

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            IntPtr hWndTray = FindWindow("Shell_TrayWnd", null);

            ShowWindow(hWndTray, SW_HIDE);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            IntPtr hWndTray = FindWindow("Shell_TrayWnd", null);

            ShowWindow(hWndTray, SW_SHOW);

        }
    }
}
