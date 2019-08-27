using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class ProductPrice
    {
        public int SysNo { get; set; }
        public int ProductSysNo { get; set; }
        public decimal BasicPrice { get; set; }
        public decimal CurrentPrice { get; set; }
        public decimal? UnitCost { get; set; }
        public decimal Discount { get; set; }
        public int PointType { get; set; }
        public int IsWholeSale { get; set; }
        public int? Q1 { get; set; }
        public decimal? P1 { get; set; }
        public int? Q2 { get; set; }
        public decimal? P2 { get; set; }
        public int? Q3 { get; set; }
        public decimal? P3 { get; set; }
        public decimal CashRebate { get; set; }
        public int Point { get; set; }
        public int? ClearanceSale { get; set; }
        public DateTime CreateTime { get; set; }
        public decimal LastOrderPrice { get; set; }
        public decimal? LastMarketLowestPrice { get; set; }
        public int? LimitedQty { get; set; }
        public int CustomerType { get; set; }
        public int SaleType { get; set; }
        public int ChannelType { get; set; }
        public int? SalesMultiple { get; set; }
        public decimal? CostWithTax { get; set; }
        public decimal? SpecialPrice { get; set; }
        public int IsSpecialPrice { get; set; }
        public int IsGiftActivity { get; set; }
        public decimal? PointPrice { get; set; }
        public DateTime? UpdateTime { get; set; }
        public int? UpdateUserSysNo { get; set; }

        public virtual Product ProductSysNoNavigation { get; set; }
    }
}
