using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using UnitOfWorkLibary.CSSDBModels;
using UnitOfWorkLibary.Resposities;
using UnitOfWorkLibary.Units;

namespace UnitOfWorkLibary
{
    public class UnitOfWork1 : UnitOfWorkBase
    {
        private readonly DbContext _dbContext;
        //public IRepository<TworkOrderUser> TworkOrderUserRepository => new BaseRepository<TworkOrderUser>(_dbContext);

        public UnitOfWork1(DbContext dbContext):base(dbContext)
        {
            _dbContext = dbContext;
        }

       
    }

}
