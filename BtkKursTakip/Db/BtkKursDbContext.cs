using BtkKursTakip.Modeller;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtkKursTakip.Db
{
    public class BtkKursDbContext : DbContext
    {
        public DbSet<DbKurs> Kurslar {  get; set; }
        public DbSet<DbEgitmen> Egitmenler { get; set; }
        public DbSet<DbKullanici> Kullanicilar { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;" +
                "Initial Catalog=BtkKurs_Db;Integrated Security=True;" +
                "Encrypt=False;Trust Server Certificate=False;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DbKurs>() //bir kursun
                .HasOne(e => e.Egitmen) //bir eğitmeni var
                .WithMany(e => e.Kurslar)//eğitmenin ise birçok kursu var 
                .HasForeignKey(e=>e.EgitmenId)//Kurslar tablosunda Yabancı anahtar
                .HasPrincipalKey(e=>e.Id);//Egitmenler tablosunda birincil anahtar 


            modelBuilder.Entity<DbKullanici>().HasData(
                new DbKullanici() { Id = 1, KullaniciAdi = "admin", 
                    Parola = "admin", Yetki = YetkiTuru.Yonetici }
                );
        }
    }
}
