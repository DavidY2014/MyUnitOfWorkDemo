using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class WxUserinfo
    {
        public int Id { get; set; }
        public int Wid { get; set; }
        public string Gid { get; set; }
        public string Openid { get; set; }
        public int Subscribe { get; set; }
        public string Nickname { get; set; }
        public int? Sex { get; set; }
        public string Language { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string Country { get; set; }
        public string Headimgul { get; set; }
        public DateTime? SubscribeTime { get; set; }
        public DateTime? UnsubscribeTime { get; set; }
        public string Remark { get; set; }
        public int? Userid { get; set; }
        public int? Groupid { get; set; }
        public string Groupname { get; set; }
        public int? ExtInt { get; set; }
        public string ExtStr1 { get; set; }
        public string ExtStr2 { get; set; }
        public string ExtStr3 { get; set; }
    }
}
