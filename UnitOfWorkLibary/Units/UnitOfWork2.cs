using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using UnitOfWorkLibary.Models;
using UnitOfWorkLibary.Resposities;

namespace UnitOfWorkLibary.Units
{
    public class UnitOfWork2 : UnitOfWorkBase
    {
        private readonly MyDbContext _dbContext;
        public IRepository<Student> StudentRepository => new BaseRepository<Student>(_dbContext);

        public IRepository<Room> RoomRepository => new BaseRepository<Room>(_dbContext);


        public UnitOfWork2(MyDbContext dbContext):base(dbContext)
        {
            _dbContext = dbContext;
        }

       
    }
}
