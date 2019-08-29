using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class WxVoteResult
    {
        public int Id { get; set; }
        public int? Baseid { get; set; }
        public int? Itemid { get; set; }
        public string OpenId { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
