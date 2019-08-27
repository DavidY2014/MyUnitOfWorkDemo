using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class SaleRuleMaster
    {
        public string SaleRuleName { get; set; }
        public int Status { get; set; }
        public int CreateUserSysNo { get; set; }
        public DateTime CreateTime { get; set; }
        public int ProductSaleType { get; set; }
        public int SysNo { get; set; }
        public int? ChannelType { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string PromotionWrods { get; set; }
        public string PromotionLink { get; set; }
        public int? IsPromotionInfoShow { get; set; }
        public string WebPromotionTitle { get; set; }
    }
}
