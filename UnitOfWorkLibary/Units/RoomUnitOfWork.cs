using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using UnitOfWorkLibary.Resposities;

namespace UnitOfWorkLibary.Units
{
    public class RoomUnitOfWork : UnitOfWorkBase
    {
        private readonly DbContext _dbContext;

        //public IRepository<Room> RoomRepository => new BaseRepository<Room>(_dbContext);
        public RoomUnitOfWork(DbContext dbContext):base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
