﻿using BtkKursTakip.Db;
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

            colEgitmen.DataSource = context.Egitmenler.ToList();
            colEgitmen.DisplayMember = "AdSoyad";
            colEgitmen.ValueMember = "Id";

            SehirleriGetir();
            
        }

        private async void SehirleriGetir()
        {
            List<Sehir> sehirler = await TurkiyeAPI.SehirleriGetir();
            colSehir.DataSource = sehirler;
            colSehir.DisplayMember = "name";
            colSehir.ValueMember = "id";


            TurkiyeAPI.IlceleriGetir(35);

        }


        private void btnTamam_Click(object sender, EventArgs e)
        {
            foreach (DbKurs kurs in blist)//yeni eklenen kayıtları ef core' a ekle
            {
                if (kurs.Id == 0)//yeni kayıtların id si 0 olur
                    context.Kurslar.Add(kurs);
            }

            context.SaveChanges();
            Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {

            int index = dataGridView1.CurrentRow.Index;

            DbKurs kurs = dataGridView1.Rows[index].DataBoundItem as DbKurs;

            if (kurs != null)
            {
                var cevap = MessageBox.Show(kurs.Ad + " isimli kursu silmek" +
                    "istediğinize emin misiniz?", "Dikkat",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (cevap == DialogResult.Yes)
                {
                    blist.Remove(kurs);
                    context.Kurslar.Remove(kurs);
                }
            }

        }
    }
}
