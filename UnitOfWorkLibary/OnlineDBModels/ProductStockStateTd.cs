using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class ProductStockStateTd
    {
        public int SysNo { get; set; }
        public int StockSysNo { get; set; }
        public int ProductSysNo { get; set; }
        public string Reason { get; set; }
        public DateTime? CreatedTime { get; set; }
        public int? CreateUserSysNo { get; set; }
        public int IsUnSaleable { get; set; }
        public DateTime? UpdateTime { get; set; }
        public int? UpdateUserSysNo { get; set; }
    }
}
