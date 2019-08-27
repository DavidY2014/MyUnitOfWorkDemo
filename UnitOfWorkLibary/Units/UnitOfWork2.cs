using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using UnitOfWorkLibary.Resposities;

namespace UnitOfWorkLibary.Units
{
    public class UnitOfWork2 : UnitOfWorkBase
    {
        private readonly DbContext _dbContext;


        public UnitOfWork2(DbContext dbContext):base(dbContext)
        {
            _dbContext = dbContext;
        }

       
    }
}
