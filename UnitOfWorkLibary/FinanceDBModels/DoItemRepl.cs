using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.FinanceDBModels
{
    public partial class DoItemRepl
    {
        public int DosysNo { get; set; }
        public int ReferSysNo { get; set; }
        public int ProductSysNo { get; set; }
        public int Quantity { get; set; }
        public decimal Weight { get; set; }
        public decimal? Price { get; set; }
        public int? Point { get; set; }
        public int? PointType { get; set; }
        public decimal? PointPay { get; set; }
        public string Warranty { get; set; }
        public int? ProductType { get; set; }
        public int? GiftSysNo { get; set; }
        public string ProductName { get; set; }
        public int? IsInStock { get; set; }
        public decimal? Volume { get; set; }
        public decimal? Cost { get; set; }
        public int? ReturnQty { get; set; }
        public int SysNo { get; set; }
        public string ProductNote { get; set; }
        public decimal BalancePay { get; set; }
        public decimal GiftCardPay { get; set; }
        public decimal? UnitPoints { get; set; }
        public decimal? TotalPoints { get; set; }
        public decimal? UnitUsePoints { get; set; }
        public decimal? TotalUsePoints { get; set; }
        public string BriefName { get; set; }
        public string SaleUnit { get; set; }
        public int ReferItemSysNo { get; set; }
        public int OriProductSysNo { get; set; }
        public int ReferType { get; set; }
    }
}
