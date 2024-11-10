using BtkKursTakip.Db;
using BtkKursTakip.Modeller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BtkKursTakip
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        private void btnOturumAc_Click(object sender, EventArgs e)
        {
            pbLoading.Visible = true;

            DbKullanici kullanici = null;

            BtkKursDbContext context = new BtkKursDbContext();

            kullanici = context.Kullanicilar.FirstOrDefault(
                e =>
                e.KullaniciAdi == txtKullaniciAdi.Text &&
                e.Parola == txtParola.Text);
            pbLoading.Visible = false;

            if (kullanici == null)//hatalı parola
            {
                lblBilgi.Visible = true;
            }
            else
            {
                AppData.Kullanici = kullanici;

                DialogResult = DialogResult.OK;//formu kapatıp deger döndürür
            }
        }
    }
}
