using NetCore.SmallUnit.EFModels;
using NetCore.SmallUnit.Resposities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCore.SmallUnit.Units
{
    /// <summary>
    /// https://mp.weixin.qq.com/s/ukLOyvQpoJYYWCTkOUJbog   事务嵌套的解决方法，通过active number来控制
    /// </summary>
    public interface IUnitOfWork: IDisposable
    {
        /// <summary>
        /// 引用次数，开启一次事务加+1,当次数为0时提交，主要是为了防止事务嵌套
        /// </summary>
        int ActiveNumber { get; set; }

        ISmallGenericRepository<Students> StudentsRepository { get; }
        ISmallGenericRepository<UserLogin> UserLoginRepository { get; }

        void Commit();

        void RejectChanges();

        void Rollback();

        void BeginTransaction();
    }
}
