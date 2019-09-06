using Microsoft.EntityFrameworkCore;
using NetCore.SmallUnit.EFModels;
using NetCore.SmallUnit.Resposities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCore.SmallUnit.Units
{
    /// <summary>
    /// 自定义的工作单元，把需要操作的仓储塞进来就行了
    /// </summary>
    public class CustomUnitOfWork : TestDBContext, IUnitOfWork
    {
        public EFBaseRepository<Students> _studentsRepos;

        public EFBaseRepository<UserLogin> _userLoginRepos;

        public DbSet<Students> StudentsList { get; set; }
        public DbSet<UserLogin> UserLoginList { get; set; }

        public CustomUnitOfWork()
        {
            _studentsRepos = new EFBaseRepository<Students>(StudentsList);
            _userLoginRepos = new EFBaseRepository<UserLogin>(UserLoginList);
        }

        #region 接口方法
        public ISmallGenericRepository<Students> StudentsRepository { get { return _studentsRepos; } }

        public ISmallGenericRepository<UserLogin> UserLoginRepository { get { return _userLoginRepos; } }

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
