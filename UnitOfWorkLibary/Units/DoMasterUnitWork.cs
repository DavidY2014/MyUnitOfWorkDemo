using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using UnitOfWorkLibary.OnlineDBModels;
using UnitOfWorkLibary.Resposities;

namespace UnitOfWorkLibary.Units
{
    public class DoMasterUnitWork:UnitOfWorkBase
    {
        private readonly DbContext _dbContext;
        //public IRepository<DoMaster> DoMasterRepository => new BaseRepository<DoMaster>(_dbContext);
        public DoMasterUnitWork(DbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
