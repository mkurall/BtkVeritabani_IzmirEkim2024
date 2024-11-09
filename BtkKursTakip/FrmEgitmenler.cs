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
    public partial class FrmEgitmenler : Form
    {
        BtkKursDbContext context = new BtkKursDbContext();
        BindingList<DbEgitmen> blist;

        public FrmEgitmenler()
        {
            InitializeComponent();

            blist = new BindingList<DbEgitmen>(context.Egitmenler.ToList());
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = blist;
        }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            foreach (DbEgitmen egitmen in blist)//yeni eklenen kayıtları ef core' a ekle
            {
                if (egitmen.Id == 0)
                    context.Egitmenler.Add(egitmen);
            }

            context.SaveChanges();
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == colSil.Index)
            {
                DbEgitmen egitmen  = dataGridView1.Rows[e.RowIndex].DataBoundItem as DbEgitmen;

                if(egitmen != null)
                {
                    var cevap = MessageBox.Show(egitmen.AdSoyad + " isimli eğitmeni silmek" +
                        "istediğinize emin misiniz?", "Dikkat", 
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (cevap == DialogResult.Yes)
                    {
                        blist.Remove(egitmen);
                        context.Egitmenler.Remove(egitmen);
                    }
                }
            }
        }
    }
}
