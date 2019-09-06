using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace NetCore.SmallUnit.Resposities
{
    public interface ISmallGenericRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);
        T Single(Expression<Func<T, bool>> predicate);
        T SingleOrDefault(Expression<Func<T, bool>> predicate);
        T First(Expression<Func<T, bool>> predicate);
        T GetById(int id);

        void Add(T entity);
        void Delete(T entity);
        void Attach(T entity);
    }
}
