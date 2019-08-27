using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using UnitOfWorkLibary;
using UnitOfWorkLibary.Units;

namespace Demo
{
    public class TestClass
    {
        /// <summary>
        /// 事务模拟 workorder
        /// </summary>
        public static void Transaction()
        {
            //创建一个context
            var dbContext = new MyDbContext();
            //创建一个对应context的工作单元
            var unitofWork1 = new UnitOfWorkLibary.UnitOfWork1(dbContext);

            //第一个单元操作
            unitofWork1.StudentRepository.Add(new UnitOfWorkLibary.Entites.Student() { id=DateTime.Now.Millisecond, name="Jack"});
            Thread.Sleep(1000);
            unitofWork1.StudentRepository.Add(new UnitOfWorkLibary.Entites.Student() { id= DateTime.Now.Millisecond, name = "Tom" });
            unitofWork1.Commit();

            //Room单元CRUD和提交分离操作
            var roomUnitOfWork = new UnitOfWorkLibary.Units.RoomUnitOfWork(dbContext);
            Thread.Sleep(1000);
            roomUnitOfWork.RoomRepository.Add(new UnitOfWorkLibary.Entites.Room() {RoomId= DateTime.Now.Millisecond, type="P" ,studentid=1});
            roomUnitOfWork.Commit();//何时提交可以自己控制


            //读取操作
            var efStudents = unitofWork1.StudentRepository.GetAll();
            foreach (var item in efStudents)
            {
                Console.WriteLine(item.name);
            }
        }

    }
}
