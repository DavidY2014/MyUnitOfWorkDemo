using System;
using System.Collections.Generic;
using System.Text;
using UnitOfWorkLibary.Resposities;
using UnitOfWorkLibary.TestDBModels;

namespace UnitOfWorkLibary.Units
{
    public interface IUnitOfWork:IDisposable
    {
        //这是通用仓储库
        IGenericRepository<Students> StudentsRepository { get; }
        IGenericRepository<UserLogin> UserLoginRepository { get; }

        void Commit();

        void RejectChanges();

        void Rollback();
    }
}
