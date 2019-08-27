using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class SoOutOrder
    {
        public int SysNo { get; set; }
        public int SosysNo { get; set; }
        public int? WarehouseSysNo { get; set; }
        public int ProductSysNo { get; set; }
        public int SaleQty { get; set; }
        public int OutQty { get; set; }
        public int LeftQty { get; set; }
        public int Status { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
