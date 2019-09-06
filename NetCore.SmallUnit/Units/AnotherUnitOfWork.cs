using Microsoft.EntityFrameworkCore;
using NetCore.SmallUnit.EFModels;
using NetCore.SmallUnit.Resposities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCore.SmallUnit.Units
{
    /// <summary>
    /// 无需注入context，继承需要用的context即可
    /// </summary>
    public class AnotherUnitOfWork : TestDBContext, IUnitOfWork
    {
        public EFBaseRepository<Students> _studentsRepos;


        public DbSet<Students> StudentsList { get; set; }

        public AnotherUnitOfWork()
        {
            _studentsRepos = new EFBaseRepository<Students>(StudentsList);
        }


        #region 接口方法

        public ISmallGenericRepository<Students> StudentsRepository { get { return _studentsRepos; } }

        public ISmallGenericRepository<UserLogin> UserLoginRepository => throw new NotImplementedException();

        public void Commit()
        {
            throw new NotImplementedException();
        }

        public void RejectChanges()
        {
            throw new NotImplementedException();
        }

        public void Rollback()
        {
            throw new NotImplementedException();
        }

        #endregion

    }
}
