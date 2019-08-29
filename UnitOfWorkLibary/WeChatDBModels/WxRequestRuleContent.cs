using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class WxRequestRuleContent
    {
        public int Id { get; set; }
        public int? UId { get; set; }
        public int? RId { get; set; }
        public string RContent { get; set; }
        public string RContent2 { get; set; }
        public string DetailUrl { get; set; }
        public string PicUrl { get; set; }
        public string MediaUrl { get; set; }
        public string MeidaHdurl { get; set; }
        public string Remark { get; set; }
        public int? Seq { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? ExtInt { get; set; }
        public int? ExtInt2 { get; set; }
        public string ExtStr { get; set; }
        public string ExtStr2 { get; set; }
        public string Extstr3 { get; set; }
    }
}
