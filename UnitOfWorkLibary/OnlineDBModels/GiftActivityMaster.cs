using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class GiftActivityMaster
    {
        public int SysNo { get; set; }
        public string ActivityName { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int Status { get; set; }
        public int Type { get; set; }
        public string Url { get; set; }
        public string ChannelType { get; set; }
        public DateTime CreateTime { get; set; }
        public int CreateUserSysNo { get; set; }
        public DateTime? UpdateTime { get; set; }
        public int? UpdateUserSysNo { get; set; }
        public int IsAddUp { get; set; }
        public string PromotionWrods { get; set; }
        public string PromotionLink { get; set; }
        public int? IsPromotionInfoShow { get; set; }
        public string WebPromotionTitle { get; set; }
    }
}
