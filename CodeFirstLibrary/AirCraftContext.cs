using CodeFirstLibraryDataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFirstLibrary.DataAccess
{
    public class AirCraftContext:DbContext
    {
        public DbSet<AirCraft> Aircrafts { get; set; }

        public DbSet<Order> Orders { get; set; }

        public AirCraftContext(DbContextOptions options):base(options)
        {
        }


        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("server=10.10.4.201;User ID=sa;Password=colipu;database=NetCoreCodeFirstTestDB;Min Pool Size=10;Max Pool Size=500;");
        //}

    }
}
