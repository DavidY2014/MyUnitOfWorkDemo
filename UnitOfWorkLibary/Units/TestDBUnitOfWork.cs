using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using UnitOfWorkLibary.Resposities;
using UnitOfWorkLibary.TestDBModels;

namespace UnitOfWorkLibary.Units
{
    public class TestDBUnitOfWork : TestDBContext,IUnitOfWork
    {
        public BaseRepository<Students> _studentsRepos;

        public BaseRepository<UserLogin> _userLoginRepos;

        public DbSet<Students> StudentsList { get; set; }
        public DbSet<UserLogin> UserLoginList { get; set; }

        public TestDBUnitOfWork()
        {
            _studentsRepos = new BaseRepository<Students>(StudentsList);
            _userLoginRepos = new BaseRepository<UserLogin>(UserLoginList);
        }


        //IGenericRepository<Students> IUnitOfWork.StudentsRepository
        //{
        //    get { return _studentsRepos; }
        //}

        //IGenericRepository<UserLogin> IUnitOfWork.UserLoginRepository
        //{
        //    get { return _userLoginRepos; }
        //}



        public void Commit()
        {
            this.SaveChanges();
        }

        public void RejectChanges()
        {
            throw new NotImplementedException();
        }

        public void Rollback()
        {
            throw new NotImplementedException();
        }

        void IUnitOfWork.RejectChanges()
        {
            throw new NotImplementedException();
        }

        void IUnitOfWork.Rollback()
        {
            throw new NotImplementedException();
        }
    }
}
