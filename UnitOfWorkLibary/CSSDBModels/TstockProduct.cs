using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.CSSDBModels
{
    public partial class TstockProduct
    {
        public string Soid { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string SaleUnit { get; set; }
        public int? OrderQuan { get; set; }
        public string UserName { get; set; }
        public DateTime? ExpectTime { get; set; }
        public string LastStockReason { get; set; }
        public string PurchasRemark { get; set; }
        public string SaleType { get; set; }
        public int? ProductId { get; set; }
    }
}
