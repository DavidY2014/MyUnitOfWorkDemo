using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class SpecialPriceItem
    {
        public int SysNo { get; set; }
        public int MasterSysNo { get; set; }
        public int Type { get; set; }
        public int? ProductSysNo { get; set; }
        public int? C1sysNo { get; set; }
        public int? C2sysNo { get; set; }
        public int? C3sysNo { get; set; }
        public int? ManufactorySysNo { get; set; }
        public decimal? Price { get; set; }
        public int? Discount { get; set; }
        public int CreateSysNo { get; set; }
        public DateTime CreateTime { get; set; }
        public int? UpdateSysNo { get; set; }
        public DateTime? UpdateTime { get; set; }
        public int? DesignationQuantity { get; set; }
        public int SentQuantity { get; set; }
        public int? IsIconLoad { get; set; }
    }
}
