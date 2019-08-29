using NetFramework.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace NetFramework.DataAccess
{
    public class DotnetFrameworkAirCraftContext:DbContext,IDisposable
    {
        public DotnetFrameworkAirCraftContext():base("name=ConnectionString")
        {

        }

        public DbSet<FrameworkAirCraft> Aircrafts { get; set; }

        public DbSet<FrameworkOrder> Orders { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<DotnetFrameworkAirCraftContext>());
            base.OnModelCreating(modelBuilder);
        }


        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("server=10.10.4.201;User ID=sa;Password=colipu;database=CodeFirstTestDB;Min Pool Size=10;Max Pool Size=500;");
        //}

    }
}
