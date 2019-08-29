using CodeFirstLibrary.DataAccess;
using CodeFirstLibraryDataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using UnitOfWorkLibary.Units;

namespace UnitOfWork.Resposity
{
    class Program
    {
        static void Main(string[] args)
        {
            //DbContext cssDbContext = new UnitOfWorkLibary.CSSDBModels.CSSDBContext();
            //var unitofWork1 = new UnitOfWorkLibary.UnitOfWork1(cssDbContext);
            //unitofWork1.TworkOrderUserRepository.Add(new UnitOfWorkLibary.CSSDBModels.TworkOrderUser { CreateTime=DateTime.Now });
            //unitofWork1.Commit();
            //var efWorkOrders = unitofWork1.TworkOrderUserRepository.GetAll();
            //foreach (var item in efWorkOrders)
            //{
            //    Console.WriteLine(item.WorkOrderId);
            //}

            //DbContext newTMSDbContext = new UnitOfWorkLibary.NewTMSDBModels.NewTMSDBContext();
            //var unitofWork2 = new UnitOfWorkLibary.UnitOfWork2(newTMSDbContext);


            //DbContext financeDbContext = new UnitOfWorkLibary.FinanceDBModels.FinanceDBContext();

            //DbContext onlineDbContext = new UnitOfWorkLibary.OnlineDBModels.OnlineDBContext();
            //var doMasterUnit = new DoMasterUnitWork(onlineDbContext);
            //var efDoMasters = doMasterUnit.DoMasterRepository.GetAll();
            //foreach (var item in efDoMasters)
            //{
            //    Console.WriteLine(item.CreateTime);
            //}

            //DbContext wechatDbContext = new UnitOfWorkLibary.WeChatDBModels.WeChatDBContext();
            //var aritcleUnit = new dt_aritcleUnitofWork(wechatDbContext);
            //var efAritcles = aritcleUnit.dtArticleRepository.GetAll();
            //foreach (var item in efAritcles)
            //{
            //    Console.WriteLine(item.Content);
            //}

            
            InsertAircraft();

        }

        static void InsertAircraft()
        {
            var aircraft = new AirCraft
            {
                Name = "F-16",
                Winspan = 9.96m,
                Description = "The General Dynamics F-16 Fighting Falcon " +
                "is a single-engine multirole fighter aircraft"
            };
            using (var context = new AirCraftContext())
            {
                context.Aircrafts.Add(aircraft);
                context.SaveChanges();
            }
        }
    }
}
