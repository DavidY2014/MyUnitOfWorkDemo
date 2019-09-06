using System;
using System.Collections.Generic;
using System.Text;
using UnitOfWorkLibary.Units;

namespace UnitOfWorkLibary.Extensions
{
    public static class TestDBUnitExtension
    {
        public static void ReUsableMethod(this TestDBUnitOfWork unit , int para1,string para2)
        {
            //doing share operations 

        }

    }
}
