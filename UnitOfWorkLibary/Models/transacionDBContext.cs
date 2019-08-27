using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace UnitOfWorkLibary.Models
{
    public partial class transacionDBContext : DbContext
    {
        public transacionDBContext()
        {
        }

        public transacionDBContext(DbContextOptions<transacionDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Room> Room { get; set; }
        public virtual DbSet<Student> Student { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("server=10.10.4.201;User ID=sa;Password=colipu;database=transacionDB;Min Pool Size=10;Max Pool Size=500;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Room>(entity =>
            {
                entity.Property(e => e.RoomId).ValueGeneratedNever();

                entity.Property(e => e.Studentid).HasColumnName("studentid");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });
        }
    }
}
