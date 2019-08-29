using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class WxVoteItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int? SortId { get; set; }
        public string PicUrl { get; set; }
        public string PicJump { get; set; }
        public int? Sid { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? Baseid { get; set; }
        public int? TpTimes { get; set; }
    }
}
