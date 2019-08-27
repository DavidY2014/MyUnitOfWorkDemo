using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using UnitOfWorkLibary.Entites;

namespace UnitOfWorkLibary
{
    public class MyDbContext : DbContext
    {
        public virtual DbSet<Student> Students { get; set; }

        public virtual DbSet<Techer> Techers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=10.10.4.201;User ID=sa;Password=colipu;database=transacionDB;Min Pool Size=10;Max Pool Size=500;");
        }
    }
}
