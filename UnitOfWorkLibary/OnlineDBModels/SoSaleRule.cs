using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class SoSaleRule
    {
        public int SosysNo { get; set; }
        public int SaleRuleSysNo { get; set; }
        public string SaleRuleName { get; set; }
        public decimal Discount { get; set; }
        public int Times { get; set; }
        public string Note { get; set; }
        public DateTime CreateTime { get; set; }
        public int SysNo { get; set; }
        public int RefundTimes { get; set; }

        public virtual SoMaster SosysNoNavigation { get; set; }
    }
}
