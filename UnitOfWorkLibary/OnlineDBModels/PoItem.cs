using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class PoItem
    {
        public int SysNo { get; set; }
        public int PosysNo { get; set; }
        public int ProductSysNo { get; set; }
        public int Quantity { get; set; }
        public decimal Weight { get; set; }
        public decimal OrderPrice { get; set; }
        public decimal ApportionAddOn { get; set; }
        public decimal UnitCost { get; set; }
        public int? OrderQty { get; set; }
        public int IsInStock { get; set; }
        public string C3url { get; set; }
        public int? ShelveQuantity { get; set; }
        public int? ShelveUserSysNo { get; set; }
        public DateTime? ShelveTime { get; set; }
        public string StockNo { get; set; }
        public int? WaitRecQty { get; set; }
        public int IsVisualStock { get; set; }
        public decimal? VendorOrderPrice { get; set; }
        public string Discount { get; set; }
        public decimal? DefaultOrderPrice { get; set; }
        public decimal? QtyGap { get; set; }
        public decimal DailySales { get; set; }
        public int SalableQty { get; set; }
        public int InventorySafeDays { get; set; }
        public int DefaultVendorSysNo { get; set; }
        public string ProductName { get; set; }
        public string SaleUnit { get; set; }

        public virtual PoMaster PosysNoNavigation { get; set; }
    }
}
