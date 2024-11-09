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
    public partial class FrmKurslar : Form
    {
        BtkKursDbContext context = new BtkKursDbContext();
        BindingList<DbKurs> blist;

        public FrmKurslar()
        {
            InitializeComponent();

            blist = new BindingList<DbKurs>(context.Kurslar.ToList());
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = blist;
        }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            foreach (DbKurs kurs in blist)//yeni eklenen kayıtları ef core' a ekle
            {
                if(kurs.Id == 0)
                    context.Kurslar.Add(kurs);
            }

            context.SaveChanges();
            Close();
        }
    }
}
