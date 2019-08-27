using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class ProductAttribute2Summary
    {
        public int SysNo { get; set; }
        public int ProductSysNo { get; set; }
        public string Summary { get; set; }
        public string SummaryMain { get; set; }

        public virtual Product ProductSysNoNavigation { get; set; }
    }
}
