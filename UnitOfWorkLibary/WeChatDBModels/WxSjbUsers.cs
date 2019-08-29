using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class WxSjbUsers
    {
        public int Id { get; set; }
        public int? Wid { get; set; }
        public string Openid { get; set; }
        public string UName { get; set; }
        public string Tel { get; set; }
        public int? SuccTimes { get; set; }
        public int? FailTimes { get; set; }
    }
}
