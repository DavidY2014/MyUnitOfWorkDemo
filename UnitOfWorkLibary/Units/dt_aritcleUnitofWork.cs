using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using UnitOfWorkLibary.Resposities;
using UnitOfWorkLibary.WeChatDBModels;

namespace UnitOfWorkLibary.Units
{
    public class dt_aritcleUnitofWork: UnitOfWorkBase
    {
        private readonly DbContext _dbContext;
        public IRepository<DtArticle> dtArticleRepository => new BaseRepository<DtArticle>(_dbContext);

        public dt_aritcleUnitofWork(DbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

    }
}
