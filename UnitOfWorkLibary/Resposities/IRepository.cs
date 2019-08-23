using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitOfWorkLibary.Resposities
{
    public interface IRepository<T> where T:class
    {
        IQueryable<T> Entites { get; }

        void Remove(T entity);

        void Add(T entity);
    }

    public class BaseRepository<T> : IRepository<T> where T : class
    {
        public IQueryable<T> Entites => throw new NotImplementedException();

        public BaseRepository()
        {

        }
        public void Add(T entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
