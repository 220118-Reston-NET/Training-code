using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PokeDL.Entities
{
    public partial class TestingDemoDBContext : DbContext
    {
        public TestingDemoDBContext()
        {
        }

        public TestingDemoDBContext(DbContextOptions<TestingDemoDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Ability> Abilities { get; set; } = null!;
        public virtual DbSet<Arsenal> Arsenals { get; set; } = null!;
        public virtual DbSet<Player> Players { get; set; } = null!;
        public virtual DbSet<Pokemon> Pokemons { get; set; } = null!;
        public virtual DbSet<Team> Teams { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=tcp:testpokedemodb.database.windows.net,1433;Initial Catalog=TestingDemoDB;Persist Security Info=False;User ID=pokeAdmin;Password=pokeSQL123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ability>(entity =>
            {
                entity.HasKey(e => e.AbId)
                    .HasName("PK__Ability__573A13BAD4198038");

                entity.ToTable("Ability");

                entity.Property(e => e.AbId).HasColumnName("abId");

                entity.Property(e => e.AbAccuracy).HasColumnName("abAccuracy");

                entity.Property(e => e.AbName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("abName");

                entity.Property(e => e.AbPower).HasColumnName("abPower");

                entity.Property(e => e.AbType)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("abType");

                entity.Property(e => e.Pp).HasColumnName("PP");
            });

            modelBuilder.Entity<Arsenal>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Arsenal");

                entity.Property(e => e.AbId).HasColumnName("abId");

                entity.Property(e => e.CurrentPp).HasColumnName("currentPP");

                entity.Property(e => e.TeamId).HasColumnName("teamId");

                entity.HasOne(d => d.Ab)
                    .WithMany()
                    .HasForeignKey(d => d.AbId)
                    .HasConstraintName("FK__Arsenal__abId__1EA48E88");

                entity.HasOne(d => d.Team)
                    .WithMany()
                    .HasForeignKey(d => d.TeamId)
                    .HasConstraintName("FK__Arsenal__teamId__236943A5");
            });

            modelBuilder.Entity<Player>(entity =>
            {
                entity.ToTable("Player");

                entity.Property(e => e.PlayerId).HasColumnName("playerId");

                entity.Property(e => e.PlayerGender).HasColumnName("playerGender");

                entity.Property(e => e.PlayerName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("playerName");
            });

            modelBuilder.Entity<Pokemon>(entity =>
            {
                entity.HasKey(e => e.PokeId)
                    .HasName("PK__Pokemon__86FB32280E26921B");

                entity.ToTable("Pokemon");

                entity.Property(e => e.PokeId).HasColumnName("pokeId");

                entity.Property(e => e.PokeAttack).HasColumnName("pokeAttack");

                entity.Property(e => e.PokeDefense).HasColumnName("pokeDefense");

                entity.Property(e => e.PokeHealth).HasColumnName("pokeHealth");

                entity.Property(e => e.PokeName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pokeName");

                entity.Property(e => e.PokeSpeed).HasColumnName("pokeSpeed");

                entity.Property(e => e.PokeType)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("pokeType");
            });

            modelBuilder.Entity<Team>(entity =>
            {
                entity.ToTable("Team");

                entity.Property(e => e.TeamId).HasColumnName("teamId");

                entity.Property(e => e.CurrentHealth).HasColumnName("currentHealth");

                entity.Property(e => e.PlayerId).HasColumnName("playerId");

                entity.Property(e => e.PokeId).HasColumnName("pokeId");

                entity.Property(e => e.PokeLevel).HasColumnName("pokeLevel");

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.Teams)
                    .HasForeignKey(d => d.PlayerId)
                    .HasConstraintName("FK__Team__playerId__151B244E");

                entity.HasOne(d => d.Poke)
                    .WithMany(p => p.Teams)
                    .HasForeignKey(d => d.PokeId)
                    .HasConstraintName("FK__Team__pokeId__18EBB532");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
