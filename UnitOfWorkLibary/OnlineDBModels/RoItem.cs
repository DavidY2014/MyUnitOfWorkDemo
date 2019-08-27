using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class RoItem
    {
        public int RosysNo { get; set; }
        public int ProductSysNo { get; set; }
        public int? ReturnPriceType { get; set; }
        public int ReturnType { get; set; }
        public int? ReturnSysNo { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal? Cost { get; set; }
        public decimal Weight { get; set; }
        public int Point { get; set; }
        public decimal? RefundCash { get; set; }
        public int? RefundPoint { get; set; }
        public decimal RedeemAmt { get; set; }
        public int DoitemSysNo { get; set; }
        public int SysNo { get; set; }
        public decimal RefundBalance { get; set; }
        public decimal GiftCardPay { get; set; }
        public decimal? UnitPoints { get; set; }
        public decimal? TotalPoints { get; set; }
        public decimal? UnitUsePoints { get; set; }
        public decimal? TotalUsePoints { get; set; }
        public string ProductName { get; set; }
        public string BriefName { get; set; }
        public string SaleUnit { get; set; }
        public string TaxCodeCategory { get; set; }
        public decimal TaxRate { get; set; }
        public int CreateUserId { get; set; }
        public DateTime? CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime? UpdateTime { get; set; }
        public string Modal { get; set; }
        public string Specification { get; set; }
        public string ProductCode { get; set; }
        public decimal NetCost { get; set; }

        public virtual RoMaster RosysNoNavigation { get; set; }
    }
}
