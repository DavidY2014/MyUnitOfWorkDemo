using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using UnitOfWorkLibary.Entites;
using UnitOfWorkLibary.Resposities;
using UnitOfWorkLibary.Units;

namespace UnitOfWorkLibary
{
    public class UnitOfWork1 : UnitOfWorkBase
    {
        private readonly MyDbContext _dbContext;
        public IRepository<Student> StudentRepository => new BaseRepository<Student>(_dbContext);

        public IRepository<WorkOrderUser> WorkOrderUserRepository => new BaseRepository<WorkOrderUser>(_dbContext);


        public UnitOfWork1(MyDbContext dbContext):base(dbContext)
        {
            _dbContext = dbContext;
        }

       
    }

}
