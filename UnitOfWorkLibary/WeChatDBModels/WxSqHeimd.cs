using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class WxSqHeimd
    {
        public int Id { get; set; }
        public int? Aid { get; set; }
        public string Openid { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Remark { get; set; }
    }
}
