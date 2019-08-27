using System;
using System.Collections.Generic;
using System.Text;

namespace UnitOfWorkLibary.Units
{
    public interface IUnitOfWork
    {
        void Commit();

        void RejectChanges();

        void Dispose();

        void Rollback();
    }
}
