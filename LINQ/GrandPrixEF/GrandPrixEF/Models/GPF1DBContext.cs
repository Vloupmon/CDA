using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace GrandPrixEF.Models
{
    public partial class GPF1DBContext : DbContext
    {
        public GPF1DBContext()
        {
        }

        public GPF1DBContext(DbContextOptions<GPF1DBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Affecter> Affecter { get; set; }
        public virtual DbSet<Circuit> Circuit { get; set; }
        public virtual DbSet<Ecurie> Ecurie { get; set; }
        public virtual DbSet<Fournisseur> Fournisseur { get; set; }
        public virtual DbSet<GrandPrix> GrandPrix { get; set; }
        public virtual DbSet<HistoResultats> HistoResultats { get; set; }
        public virtual DbSet<Pays> Pays { get; set; }
        public virtual DbSet<Pilote> Pilote { get; set; }
        public virtual DbSet<PlanificationGp> PlanificationGp { get; set; }
        public virtual DbSet<ResultatCourse> ResultatCourse { get; set; }
        public virtual DbSet<SoutenirEcurie> SoutenirEcurie { get; set; }
        public virtual DbSet<SoutenirPilote> SoutenirPilote { get; set; }
        public virtual DbSet<Sponsor> Sponsor { get; set; }
        public virtual DbSet<Voiture> Voiture { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=localhost;Database=GrandPrixF1;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Affecter>(entity =>
            {
                entity.HasKey(e => new { e.CodePilote, e.NumVoiture });

                entity.HasOne(d => d.CodePiloteNavigation)
                    .WithMany(p => p.Affecter)
                    .HasForeignKey(d => d.CodePilote)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Affecter_Pilote");

                entity.HasOne(d => d.NumVoitureNavigation)
                    .WithMany(p => p.Affecter)
                    .HasForeignKey(d => d.NumVoiture)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Affecter_Voiture");
            });

            modelBuilder.Entity<Circuit>(entity =>
            {
                entity.HasKey(e => e.CodeCircuit);

                entity.Property(e => e.CodeCircuit)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Localisation)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NomCircuit)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.LocalisationNavigation)
                    .WithMany(p => p.Circuit)
                    .HasForeignKey(d => d.Localisation)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Circuit_Pays");
            });

            modelBuilder.Entity<Ecurie>(entity =>
            {
                entity.HasKey(e => e.CodeEcurie);

                entity.Property(e => e.CodeEcurie)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.CodeFournisseurPneumatiques)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.NomDirecteurEcurie)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NomEcurie)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.CodeFournisseurPneumatiquesNavigation)
                    .WithMany(p => p.Ecurie)
                    .HasForeignKey(d => d.CodeFournisseurPneumatiques)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ecurie_Fournisseur");
            });

            modelBuilder.Entity<Fournisseur>(entity =>
            {
                entity.HasKey(e => e.CodeFournisseurPneumatiques);

                entity.Property(e => e.CodeFournisseurPneumatiques)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.NumAgrementFia).HasColumnName("NumAgrementFIA");

                entity.Property(e => e.RaisonSocialeFournisseur)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<GrandPrix>(entity =>
            {
                entity.HasKey(e => e.CodeGp)
                    .HasName("PK_GrandPrix_1");

                entity.Property(e => e.CodeGp)
                    .HasColumnName("CodeGP")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.NomGrandPrix)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<HistoResultats>(entity =>
            {
                entity.HasKey(e => e.Idtransaction);

                entity.Property(e => e.Idtransaction).HasColumnName("IDTransaction");

                entity.Property(e => e.CodeOperation)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DateHeure).HasColumnType("datetime");

                entity.Property(e => e.LibelleOperation)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Utilisateur)
                    .IsRequired()
                    .HasMaxLength(128);
            });

            modelBuilder.Entity<Pays>(entity =>
            {
                entity.HasKey(e => e.IdPays2);

                entity.Property(e => e.IdPays2)
                    .HasColumnName("idPays2")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IdPays3)
                    .IsRequired()
                    .HasColumnName("idPays3")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IdPaysNum).HasColumnName("idPaysNum");

                entity.Property(e => e.LibellePays)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Pilote>(entity =>
            {
                entity.HasKey(e => e.CodePilote);

                entity.Property(e => e.CodeEcurie)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.NomPilote)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.PrenomPilote)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.CodeEcurieNavigation)
                    .WithMany(p => p.Pilote)
                    .HasForeignKey(d => d.CodeEcurie)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pilote_Ecurie");
            });

            modelBuilder.Entity<PlanificationGp>(entity =>
            {
                entity.HasKey(e => new { e.CodeCircuit, e.CodeGp });

                entity.ToTable("PlanificationGP");

                entity.Property(e => e.CodeCircuit)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.CodeGp)
                    .HasColumnName("CodeGP")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.DateGp)
                    .HasColumnName("DateGP")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.CodeCircuitNavigation)
                    .WithMany(p => p.PlanificationGp)
                    .HasForeignKey(d => d.CodeCircuit)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PlanificationGP_Circuit");

                entity.HasOne(d => d.CodeGpNavigation)
                    .WithMany(p => p.PlanificationGp)
                    .HasForeignKey(d => d.CodeGp)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PlanificationGP_GrandPrix");
            });

            modelBuilder.Entity<ResultatCourse>(entity =>
            {
                entity.HasKey(e => new { e.CodePilote, e.NumVoiture, e.CodeCircuit, e.CodeGp });

                entity.Property(e => e.CodeCircuit)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.CodeGp)
                    .HasColumnName("CodeGP")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.NombrePointsMarques).HasColumnType("decimal(3, 1)");

                entity.HasOne(d => d.CodePiloteNavigation)
                    .WithMany(p => p.ResultatCourse)
                    .HasForeignKey(d => d.CodePilote)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ResultatCourse_Pilote");

                entity.HasOne(d => d.NumVoitureNavigation)
                    .WithMany(p => p.ResultatCourse)
                    .HasForeignKey(d => d.NumVoiture)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ResultatCourse_Voiture");

                entity.HasOne(d => d.Code)
                    .WithMany(p => p.ResultatCourse)
                    .HasForeignKey(d => new { d.CodeCircuit, d.CodeGp })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ResultatCourse_PlanificationGP");
            });

            modelBuilder.Entity<SoutenirEcurie>(entity =>
            {
                entity.HasKey(e => new { e.CodeEcurie, e.CodeSponsor });

                entity.ToTable("Soutenir_Ecurie");

                entity.Property(e => e.CodeEcurie)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.CodeSponsor)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.MontantUsd)
                    .HasColumnName("MontantUSD")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.NumAgrementFia).HasColumnName("NumAgrementFIA");

                entity.HasOne(d => d.CodeEcurieNavigation)
                    .WithMany(p => p.SoutenirEcurie)
                    .HasForeignKey(d => d.CodeEcurie)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Soutenir_Ecurie_Ecurie");

                entity.HasOne(d => d.CodeSponsorNavigation)
                    .WithMany(p => p.SoutenirEcurie)
                    .HasForeignKey(d => d.CodeSponsor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Soutenir_Ecurie_Sponsor");
            });

            modelBuilder.Entity<SoutenirPilote>(entity =>
            {
                entity.HasKey(e => new { e.CodeSponsor, e.CodePilote });

                entity.ToTable("Soutenir_Pilote");

                entity.Property(e => e.CodeSponsor)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.MontantUsd)
                    .HasColumnName("MontantUSD")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.NumAgrementFia).HasColumnName("NumAgrementFIA");

                entity.HasOne(d => d.CodePiloteNavigation)
                    .WithMany(p => p.SoutenirPilote)
                    .HasForeignKey(d => d.CodePilote)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Soutenir_Pilote_Pilote");

                entity.HasOne(d => d.CodeSponsorNavigation)
                    .WithMany(p => p.SoutenirPilote)
                    .HasForeignKey(d => d.CodeSponsor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Soutenir_Pilote_Sponsor");
            });

            modelBuilder.Entity<Sponsor>(entity =>
            {
                entity.HasKey(e => e.CodeSponsor);

                entity.Property(e => e.CodeSponsor)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.NomSociete)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Voiture>(entity =>
            {
                entity.HasKey(e => e.NumVoiture);

                entity.Property(e => e.NumVoiture).ValueGeneratedNever();

                entity.Property(e => e.CodeEcurie)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.TypeVoiture)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.HasOne(d => d.CodeEcurieNavigation)
                    .WithMany(p => p.Voiture)
                    .HasForeignKey(d => d.CodeEcurie)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Voiture_Ecurie");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
