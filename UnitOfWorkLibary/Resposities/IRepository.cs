using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitOfWorkLibary.Resposities
{
    public interface IRepository<T> where T:class
    {
        void Remove(T entity);

        void Add(T entity);

        IQueryable<T> GetAll();
    }
}
