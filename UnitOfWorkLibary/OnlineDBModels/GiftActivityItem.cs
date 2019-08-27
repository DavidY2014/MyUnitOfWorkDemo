using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class GiftActivityItem
    {
        public int SysNo { get; set; }
        public int MasterSysNo { get; set; }
        public int ProductSysNo { get; set; }
        public int ProductQty { get; set; }
        public int Type { get; set; }
        public int? TotalQty { get; set; }
        public int? SendQty { get; set; }
        public int? IsIconLoad { get; set; }
    }
}
