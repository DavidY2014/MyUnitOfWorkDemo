using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class WxDiancaiMember
    {
        public int Id { get; set; }
        public int? Shopid { get; set; }
        public string Name { get; set; }
        public string Openid { get; set; }
        public DateTime? CreateDate { get; set; }
        public string WeixinName { get; set; }
        public string MemberName { get; set; }
        public string MenberTel { get; set; }
        public string MemberAddress { get; set; }
        public int? SuccessDingdan { get; set; }
        public int? FailDingdan { get; set; }
        public int? CancelDingdan { get; set; }
        public int? Status { get; set; }
        public int? Zongjifen { get; set; }
        public double? Zongcje { get; set; }
    }
}
