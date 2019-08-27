using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class DoItem
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
        public string TaxCodeCategory { get; set; }
        public decimal TaxRate { get; set; }
        public int InvoiceQty { get; set; }
        public int VerificationQty { get; set; }
        public string Modal { get; set; }
        public string Specification { get; set; }
        public string ProductCode { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public decimal NetCost { get; set; }
        public decimal NetPrice { get; set; }
    }
}
