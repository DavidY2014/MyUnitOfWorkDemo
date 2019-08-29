using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class WxSqAct
    {
        public int Id { get; set; }
        public int? Wid { get; set; }
        public bool? IsOpen { get; set; }
        public string ActName { get; set; }
        public string Brief { get; set; }
        public bool? Shenghe { get; set; }
        public string NoshengheTip { get; set; }
        public string ShengheTip { get; set; }
        public string BannerPic { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? BeginDate { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? SortId { get; set; }
    }
}
