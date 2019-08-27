using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class ProductCost
    {
        public int ProductSysNo { get; set; }
        public decimal Cost { get; set; }
        public int Quantity { get; set; }
        public decimal Amt { get; set; }
    }
}
