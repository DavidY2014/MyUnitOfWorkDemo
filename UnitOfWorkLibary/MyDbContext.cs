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

        public MyDbContext(string connectionString)
        {

        }
    }
}
