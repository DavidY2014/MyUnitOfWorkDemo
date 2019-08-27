using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class ProductVendor
    {
        public int SysNo { get; set; }
        public int ProductSysNo { get; set; }
        public int VendorSysNo { get; set; }
        public decimal PurchasePrice { get; set; }
        public int IsDefaultVendor { get; set; }
        public int Status { get; set; }
        public DateTime CreateTime { get; set; }
        public int CreateUserSysNo { get; set; }
        public DateTime? UpdateTime { get; set; }
        public int? UpdateUserSysNo { get; set; }
        public int MinOrderQty { get; set; }
        public int StockSysNo { get; set; }
        public string Pounit { get; set; }
        public int? VendorArrivalInternal { get; set; }
        public int? PackageUnit { get; set; }
        public DateTime? LastUpdatetime { get; set; }
    }
}
