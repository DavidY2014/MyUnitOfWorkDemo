using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
//using UnitOfWorkLibary.Models;

namespace UnitOfWorkLibary
{
    /// <summary>
    /// database first 
    /// Scaffold-DbContext "server=10.10.4.201;User ID=sa;Password=colipu;database=transacionDB;Min Pool Size=10;Max Pool Size=500;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models
    /// </summary>
    public class MyDbContext : DbContext
    {
        //public virtual DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=10.10.4.201;User ID=sa;Password=colipu;database=transacionDB;Min Pool Size=10;Max Pool Size=500;");
        }
    }
}
