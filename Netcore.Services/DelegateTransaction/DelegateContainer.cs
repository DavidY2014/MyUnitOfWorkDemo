using System;
using System.Collections.Generic;
using System.Text;

namespace Netcore.Services.DelegateTransaction
{
    /// <summary>
    /// 定义业务方法的多个不同类型委托，也就是委托模板
    /// </summary>
    public  class DelegateContainer
    {
        public Action transaction { get; set; }

        

    }
}
