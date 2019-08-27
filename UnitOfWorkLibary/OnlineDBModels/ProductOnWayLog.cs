using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class ProductOnWayLog
    {
        public int SysNo { get; set; }
        public int ProductSysNo { get; set; }
        public string Remark { get; set; }
        public int IsDelete { get; set; }
        public int CreateUserSysNo { get; set; }
        public DateTime CreatedTime { get; set; }
        public int? UpdateUserSysNo { get; set; }
        public DateTime? UpdateTime { get; set; }
        public int StockSysNo { get; set; }
        public DateTime DeliveryTime { get; set; }
        public string StockoutCause { get; set; }
        public int IsUpdateDeliveryTime { get; set; }
    }
}
