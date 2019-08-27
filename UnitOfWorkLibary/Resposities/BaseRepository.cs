﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitOfWorkLibary.Resposities
{
    public class BaseRepository<T>  : IRepository<T> where T : class
    {
        private readonly MyDbContext _dbContext;

        public BaseRepository(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Add(T entity)
        {
            _dbContext.Add(entity);
        }

        public void Remove(T entity)
        {
            _dbContext.Remove(entity);
        }

        public IQueryable<T> GetAll()
        {
            return _dbContext.Set<T>();
        }

    }
}