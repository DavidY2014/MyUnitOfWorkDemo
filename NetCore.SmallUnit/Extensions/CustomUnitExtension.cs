using NetCore.SmallUnit.Units;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCore.SmallUnit.Extensions
{
    public static class CustomUnitExtension
    {
        /// <summary>
        /// 这个里面放重用的工作单元方法
        /// </summary>
        /// <param name=""></param>
        /// <param name="para1"></param>
        /// <param name="para2"></param>
        public static void  CustomUnifExtensionMethod(this CustomUnitOfWork unit, int para1, string para2)
        {
            //reusable code  重用业务代码
        }


    }
}
