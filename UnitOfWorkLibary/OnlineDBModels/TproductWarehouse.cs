using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class TproductWarehouse
    {
        public int ProductId { get; set; }
        public int WarehouseId { get; set; }
        public int PoUserId { get; set; }
        public int PurchaseUserId { get; set; }
        public string IsCloseOut { get; set; }
        public string IsDiscountinue { get; set; }
        public string CanReturn { get; set; }
        public string CanPurchase { get; set; }
        public string CanPurchaseReturn { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string InventoryTurnover { get; set; }
    }
}
