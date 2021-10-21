using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Bibliotheque.BOL;

namespace Bibliotheque.DALEF
{
    public partial class BibliothequeEF : DbContext
    {
        public BibliothequeEF()
        {
        }

        public BibliothequeEF(DbContextOptions<BibliothequeEF> options)
            : base(options)
        {
        }

        public virtual DbSet<Adherent> Adherent { get; set; }
        public virtual DbSet<Categorie> Categorie { get; set; }
        public virtual DbSet<Exemplaire> Exemplaire { get; set; }
        public virtual DbSet<Livre> Livre { get; set; }
        public virtual DbSet<Pret> Pret { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                if (DBEF.DbProviderName == "System.Data.SqlClient")
                {
                    optionsBuilder.UseSqlServer(DBEF.DbConnectionString);
                }
                if (DBEF.DbProviderName == "MySql.Data.MySqlClient")
                {
                    optionsBuilder.UseMySql(DBEF.DbConnectionString);
                }
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Adherent>(entity =>
            {
                entity.HasKey(e => e.IdAdherent);

                entity.Property(e => e.IdAdherent)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.NomAdherent)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PrenomAdherent).HasMaxLength(50);
            });

            modelBuilder.Entity<Categorie>(entity =>
            {
                entity.HasKey(e => e.IdCategorie);

                entity.Property(e => e.LibelleCategorie)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Exemplaire>(entity =>
            {
                entity.HasKey(e => e.IdExemplaire);

                entity.Property(e => e.Isbn)
                    .IsRequired()
                    .HasColumnName("ISBN")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.HasOne(d => d.IsbnNavigation)
                    .WithMany(p => p.Exemplaire)
                    .HasForeignKey(d => d.Isbn)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Exemplaire_Livre");
            });

            modelBuilder.Entity<Livre>(entity =>
            {
                entity.HasKey(e => e.Isbn);

                entity.Property(e => e.Isbn)
                    .HasColumnName("ISBN")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Titre)
                    .IsRequired()
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<Pret>(entity =>
            {
                entity.HasKey(e => new { e.IdAdherent, e.IdExemplaire, e.DateEmprunt });

                entity.Property(e => e.IdAdherent)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.DateEmprunt).HasColumnType("date");

                entity.Property(e => e.DateRetour).HasColumnType("date");

                entity.HasOne(d => d.IdAdherentNavigation)
                    .WithMany(p => p.Prets)
                    .HasForeignKey(d => d.IdAdherent)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pret_Adherent");

                entity.HasOne(d => d.IdExemplaireNavigation)
                    .WithMany(p => p.Pret)
                    .HasForeignKey(d => d.IdExemplaire)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pret_Exemplaire");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
