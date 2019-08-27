using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class ProductRelativeInfoTd
    {
        public int ProductSysNo { get; set; }
        public int? C3sysNo { get; set; }
        public decimal? Price { get; set; }
        public string Brand { get; set; }
        public int? SaleCount { get; set; }
        public string ShowType { get; set; }
    }
}
