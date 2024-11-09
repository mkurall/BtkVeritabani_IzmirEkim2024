using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace PersonelTakip.Modeller;

public partial class PersonelDbContext : DbContext
{
    public PersonelDbContext()
    {
    }

    public PersonelDbContext(DbContextOptions<PersonelDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Birimler> Birimlers { get; set; }

    public virtual DbSet<Personeller> Personellers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=PersonelDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Birimler>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Birimler__3214EC070512059D");

            entity.ToTable("Birimler");

            entity.Property(e => e.BirimAd).HasMaxLength(75);
        });

        modelBuilder.Entity<Personeller>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Personel__3214EC07B53F65CA");

            entity.ToTable("Personeller");

            entity.Property(e => e.Ad).HasMaxLength(30);
            entity.Property(e => e.Soyad).HasMaxLength(30);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
