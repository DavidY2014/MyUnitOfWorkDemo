using Microsoft.EntityFrameworkCore;
using System;

namespace UnitOfWork.Resposity
{
    class Program
    {
        static void Main(string[] args)
        {
            DbContext cssDbContext = new UnitOfWorkLibary.CSSDBModels.CSSDBContext();
            var unitofWork1 = new UnitOfWorkLibary.UnitOfWork1(cssDbContext);
            unitofWork1.TworkOrderUserRepository.Add(new UnitOfWorkLibary.CSSDBModels.TworkOrderUser { CreateTime=DateTime.Now });
            unitofWork1.Commit();
            var efWorkOrders = unitofWork1.TworkOrderUserRepository.GetAll();
            foreach (var item in efWorkOrders)
            {
                Console.WriteLine(item.WorkOrderId);
            }

            DbContext newTMSDbContext = new UnitOfWorkLibary.NewTMSDBModels.NewTMSDBContext();
            var unitofWork2 = new UnitOfWorkLibary.UnitOfWork2(newTMSDbContext);

        }
    }
}
