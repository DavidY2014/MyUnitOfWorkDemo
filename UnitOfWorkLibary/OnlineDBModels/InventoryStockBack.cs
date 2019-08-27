using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class InventoryStockBack
    {
        public int StockSysNo { get; set; }
        public int ProductSysNo { get; set; }
        public DateTime CreateTime { get; set; }
        public int AccountQty { get; set; }
        public int AvailableQty { get; set; }
        public int AllocatedQty { get; set; }
        public int OrderQty { get; set; }
        public int PurchaseQty { get; set; }
        public int ShiftInQty { get; set; }
        public int ShiftOutQty { get; set; }
        public int SafeQty { get; set; }
        public string Position1 { get; set; }
        public string Position2 { get; set; }
        public int? MaxSafeQty { get; set; }
        public int? MinSafeQty { get; set; }
        public decimal? UnitCost { get; set; }
    }
}
