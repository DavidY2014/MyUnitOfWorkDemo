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

        public int ActiveNumber { get; set; } = 0;

        public void Commit()
        {
            this.ActiveNumber--;
            if (this.ActiveNumber == 0)
            {

                Console.WriteLine("提交事务");
            }
        }

        public void RejectChanges()
        {
            throw new NotImplementedException();
        }

        public void Rollback()
        {
            if (this.ActiveNumber > 0 )
            {
                try
                {
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }
            Console.WriteLine("回滚事务");
        }

        public void BeginTransaction()
        {
            if (this.ActiveNumber == 0)
            {
                Console.WriteLine("开启事务");
            }
            this.ActiveNumber++;
        }
        #endregion

    }
}
