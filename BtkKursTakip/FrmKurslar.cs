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

            dataGridView1.DataSource = blist;
        }
    }
}
