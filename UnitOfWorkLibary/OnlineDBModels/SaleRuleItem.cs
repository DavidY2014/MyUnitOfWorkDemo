using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class SaleRuleItem
    {
        public int SysNo { get; set; }
        public int SaleRuleSysNo { get; set; }
        public int ProductSysNo { get; set; }
        public int Quantity { get; set; }
        public decimal Discount { get; set; }
        public DateTime CreateTime { get; set; }
        public int? IsIconLoad { get; set; }
    }
}
