using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class WxRequestRule
    {
        public int Id { get; set; }
        public int? WId { get; set; }
        public int? UId { get; set; }
        public string RuleName { get; set; }
        public string ReqKeywords { get; set; }
        public int? ReqestType { get; set; }
        public int? ResponseType { get; set; }
        public bool? IsDefault { get; set; }
        public string ModelFunctionName { get; set; }
        public int? ModelFunctionId { get; set; }
        public int? Seq { get; set; }
        public DateTime? CreateDate { get; set; }
        public string AgentUrl { get; set; }
        public string AgentToken { get; set; }
        public bool? IsLikeSearch { get; set; }
        public int? ExtInt { get; set; }
        public int? ExtInt2 { get; set; }
        public string ExtStr { get; set; }
        public string ExtStr2 { get; set; }
        public string ExtStr3 { get; set; }
        public string ExtStr4 { get; set; }
    }
}
