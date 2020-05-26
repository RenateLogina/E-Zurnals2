using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EZurnals.Logic.EZurnalsDB
{
    public partial class EZurnalsContext : DbContext
    {
        public EZurnalsContext()
        {
        }

        public EZurnalsContext(DbContextOptions<EZurnalsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<GradesDb> GradesDb { get; set; }
        public virtual DbSet<StudentsDb> StudentsDb { get; set; }
        public virtual DbSet<SubjectsDb> SubjectsDb { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\User\\Desktop\\Accenture-projekti\\E-Zurnals2\\EZurnalsDB.mdf;Integrated Security=True;Connect Timeout=30");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GradesDb>(entity =>
            {
                entity.ToTable("GradesDB");

                entity.Property(e => e.Grade).HasColumnType("decimal(2, 0)")
                    .IsRequired();

                entity.Property(e => e.StudentId).HasColumnType("int")
                    .IsRequired();

                entity.Property(e => e.SubjectId).HasColumnType("int")
                    .IsRequired();


            });

            modelBuilder.Entity<StudentsDb>(entity =>
            {
                entity.ToTable("StudentsDB");

                entity.Property(e => e.BirthYear)
                    .IsRequired()
                    .HasMaxLength(4);

                entity.Property(e => e.Klase)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<SubjectsDb>(entity =>
            {
                entity.ToTable("SubjectsDB");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(150);
            });
        }
    }
}
