using System;
using System.Collections.Generic;
using System.Text;
using UnitOfWorkLibary.Entites;
using UnitOfWorkLibary.Resposities;

namespace UnitOfWorkLibary.Units
{
    public class RoomUnitOfWork : UnitOfWorkBase
    {
        private readonly MyDbContext _dbContext;

        public IRepository<Room> RoomRepository => new BaseRepository<Room>(_dbContext);
        public RoomUnitOfWork(MyDbContext dbContext):base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
