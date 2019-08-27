using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitOfWorkLibary.Units
{
    public class UnitOfWorkBase : IUnitOfWork
    {
        private readonly DbContext _dbContext;
        public UnitOfWorkBase(DbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Commit()
        {
            _dbContext.SaveChanges();
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }

        public void RejectChanges()
        {
            foreach (var entry in _dbContext.ChangeTracker.Entries())
            {
                if (entry.State != EntityState.Unchanged)
                {
                    switch (entry.State)
                    {
                        case EntityState.Added:
                            entry.State = EntityState.Detached;
                            break;
                        case EntityState.Modified:
                        case EntityState.Deleted:
                            entry.Reload();
                            break;
                    }
                }
            }
        }

        public void Rollback()
        {
            _dbContext.Database.RollbackTransaction();
        }
    }
}
