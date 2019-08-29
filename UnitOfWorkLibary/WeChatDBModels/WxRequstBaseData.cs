using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class WxRequstBaseData
    {
        public int Id { get; set; }
        public int? Wid { get; set; }
        public string WxOpenid { get; set; }
        public string WxMsgType { get; set; }
        public string WxDataContent { get; set; }
        public string WxEventKey { get; set; }
        public string WxCreateTime { get; set; }
        public string WxUrl { get; set; }
        public string WxUrl2 { get; set; }
        public string WxXmlContent { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? Flag { get; set; }
        public string RType { get; set; }
        public string Remark { get; set; }
        public int? ExtInt { get; set; }
        public string ExtStr { get; set; }
        public string ExtStr2 { get; set; }
        public string ExtStr3 { get; set; }
    }
}
