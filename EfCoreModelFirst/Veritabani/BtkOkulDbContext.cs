using EfCoreModelFirst.Modeller;
using Microsoft.EntityFrameworkCore;


namespace EfCoreModelFirst.Veritabani
{
    public class BtkOkulDbContext : DbContext
    {
        public DbSet<Sinif> Siniflar { get; set; }
        public DbSet<Ogrenci> Ogrenci { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=(localdb)\\mssqllocaldb;database=" +
                "btk_okul_db;trusted_connection=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sinif>()
                .HasMany(e => e.Ogrenciler)
                .WithOne(e => e.Sinifi)
                .HasForeignKey(e => e.SinifId)
                .HasPrincipalKey(e => e.Id);

        }
    }
}
