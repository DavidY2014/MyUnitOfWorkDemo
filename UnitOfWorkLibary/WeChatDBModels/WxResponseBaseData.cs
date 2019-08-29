using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class WxResponseBaseData
    {
        public int Id { get; set; }
        public int? Wid { get; set; }
        public string WxOpenid { get; set; }
        public string RequestType { get; set; }
        public string RequestContent { get; set; }
        public string ResponseType { get; set; }
        public string ReponseContent { get; set; }
        public string CreateTime { get; set; }
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
