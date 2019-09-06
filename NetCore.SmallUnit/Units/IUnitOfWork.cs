using NetCore.SmallUnit.EFModels;
using NetCore.SmallUnit.Resposities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCore.SmallUnit.Units
{
    public interface IUnitOfWork: IDisposable
    {
        ISmallGenericRepository<Students> StudentsRepository { get; }
        ISmallGenericRepository<UserLogin> UserLoginRepository { get; }

        void Commit();

        void RejectChanges();

        void Rollback();
    }
}
