using EfCoreModelFirst.Modeller;
using EfCoreModelFirst.Veritabani;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EfCoreModelFirst
{
    public partial class FrmSiniflar : Form
    {
        BtkOkulDbContext context = new BtkOkulDbContext();
        BindingList<Sinif> blist;

        public FrmSiniflar()
        {
            InitializeComponent();

            var liste = context.Siniflar.ToList();

            blist = new BindingList<Sinif>(liste);

            lbSiniflar.DataSource = blist;
            lbSiniflar.DisplayMember = "Ad";
            lbSiniflar.ValueMember = "Id";
        }

        private void btnEkleGuncelle_Click(object sender, EventArgs e)
        {
            Sinif snf = lbSiniflar.SelectedItem as Sinif;

            if (snf == null)
            {
                snf = new Sinif() { Ad = txtSinifAdi.Text };

                blist.Add(snf);
                txtSinifAdi.Text = "";
            }
            else
            {
                snf.Ad = txtSinifAdi.Text;

                blist.ResetItem(blist.IndexOf(snf));
            }
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            lbSiniflar.SelectedIndex = -1;
            txtSinifAdi.Text = "";
            txtSinifAdi.Focus();
        }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            foreach (Sinif snf in blist)
            {
                if (snf.Id <= 0)
                {
                    context.Siniflar.Add(snf);
                }
            }

            context.SaveChanges();

            Close();
        }

        private void lbSiniflar_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sinif snf = lbSiniflar.SelectedItem as Sinif;

            if (snf != null)
                txtSinifAdi.Text = snf.Ad;
        }
    }
}
