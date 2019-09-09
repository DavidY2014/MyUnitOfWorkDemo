using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using UnitOfWorkLibary.NewTMSDBModels;
using UnitOfWorkLibary.Resposities;
using UnitOfWorkLibary.Units;

namespace UnitOfWorkLibary
{
    public class UnitOfWork2 : UnitOfWorkBase
    {
        private readonly DbContext _dbContext;

        //public IRepository<Tcustomer> TworkOrderUserRepository => new BaseRepository<Tcustomer>(_dbContext);
        public UnitOfWork2(DbContext dbContext):base(dbContext)
        {
            _dbContext = dbContext;
        }

       
    }
}
