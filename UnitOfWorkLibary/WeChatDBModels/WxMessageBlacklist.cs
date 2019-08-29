using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class WxMessageBlacklist
    {
        public int Id { get; set; }
        public int? Wid { get; set; }
        public string Openid { get; set; }
        public DateTime? Blacktime { get; set; }
    }
}
