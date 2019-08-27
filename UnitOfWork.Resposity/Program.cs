using Microsoft.EntityFrameworkCore;
using System;

namespace UnitOfWork.Resposity
{
    class Program
    {
        static void Main(string[] args)
        {
            DbContext dbContext = new UnitOfWorkLibary.CSSDBModels.CSSDBContext();
            var unitofWork1 = new UnitOfWorkLibary.UnitOfWork1(dbContext);
            //unitofWork1.StudentRepository.Add(new UnitOfWorkLibary.Entites.Student() { Id=DateTime.Now.Second,Name="Jack"});
            //unitofWork1.Commit();
            var efWorkOrders = unitofWork1.TworkOrderUserRepository.GetAll();
            foreach (var item in efWorkOrders)
            {
                Console.WriteLine(item.WorkOrderId);
            }
        }
    }
}
