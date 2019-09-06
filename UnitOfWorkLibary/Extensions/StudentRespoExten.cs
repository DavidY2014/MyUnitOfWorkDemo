using System;
using System.Collections.Generic;
using System.Text;
using UnitOfWorkLibary.Resposities;
using UnitOfWorkLibary.TestDBModels;

namespace UnitOfWorkLibary.Extensions
{
    public static class StudentRespoExten
    {
        public static List<Students> GetAllExtension(this IGenericRepository<Students> unit,int para1,string para2  )
        {
            return new List<Students>();
        }
    }
}
