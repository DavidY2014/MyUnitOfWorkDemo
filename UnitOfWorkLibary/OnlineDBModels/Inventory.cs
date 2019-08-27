using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class Inventory
    {
        public int SysNo { get; set; }
        public int ProductSysNo { get; set; }
        public int AccountQty { get; set; }
        public int AvailableQty { get; set; }
        public int AllocatedQty { get; set; }
        public int OrderQty { get; set; }
        public int PurchaseQty { get; set; }
        public int VirtualQty { get; set; }
        public int? SalableQty { get; set; }
    }
}
