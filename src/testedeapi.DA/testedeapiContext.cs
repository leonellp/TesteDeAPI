using Microsoft.EntityFrameworkCore;
using testedeapi.DA.Abstractions.Models;

#nullable disable

namespace testedeapi.DA {
    public partial class testedeapiContext : DbContext
    {
        public testedeapiContext()
        {
        }

        public testedeapiContext(DbContextOptions<testedeapiContext> options)
            : base(options)
        {
        }

        public virtual DbSet<paciente> paciente { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server = localhost,5434; Database = testedeapidb; User Id = sa; Password = Abcd@1234");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<paciente>(entity =>
            {
                entity.HasKey(e => e.Idpaciente);

                entity.Property(e => e.Idpaciente).ValueGeneratedNever();

                entity.Property(e => e.Celular)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.Inativo).HasColumnType("date");

                entity.Property(e => e.Nascimento).HasColumnType("date");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Sexo)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
