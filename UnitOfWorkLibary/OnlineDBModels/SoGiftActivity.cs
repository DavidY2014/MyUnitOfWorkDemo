using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class SoGiftActivity
    {
        public int SysNo { get; set; }
        public int SosysNo { get; set; }
        public int GiftActivitySysNo { get; set; }
        public int ProductSysNo { get; set; }
        public int ProductQty { get; set; }
        public int IsGiftFlag { get; set; }
        public decimal OrginalPrice { get; set; }
        public decimal FinalPrice { get; set; }
        public int SendQty { get; set; }
        public int ReturnQty { get; set; }
        public int IsChanged { get; set; }
        public string Remark { get; set; }
        public int CreatorSysNo { get; set; }
        public DateTime CreatTime { get; set; }
        public int? UpdateSysNo { get; set; }
        public DateTime? UpdateTime { get; set; }
        public decimal? UnitPoints { get; set; }
        public decimal? TotalPoints { get; set; }
        public decimal? UnitUsePoints { get; set; }
        public decimal? TotalUsePoints { get; set; }
        public int Type { get; set; }
        public decimal OrderPrice { get; set; }
        public int IsChangePrice { get; set; }
        public string TaxCodeCategory { get; set; }
        public decimal TaxRate { get; set; }
    }
}
