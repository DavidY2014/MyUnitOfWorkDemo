using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class WxDiancaiBlacklist
    {
        public int Id { get; set; }
        public string Openid { get; set; }
        public string BlackName { get; set; }
        public DateTime? BlackDate { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? Shopid { get; set; }
    }
}
