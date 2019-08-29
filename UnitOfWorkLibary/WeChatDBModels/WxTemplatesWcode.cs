using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class WxTemplatesWcode
    {
        public int Id { get; set; }
        public int? Wid { get; set; }
        public int? Tid { get; set; }
        public string Remark { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? ExtInt { get; set; }
        public string ExtStr { get; set; }
        public string ExtStr2 { get; set; }
        public int? ListTid { get; set; }
        public int? DetailTid { get; set; }
        public int? ChannelTid { get; set; }
        public int? BmenuTid { get; set; }
        public int? TopcolorTypeId { get; set; }
        public string TopcolorTypeName { get; set; }
        public string TopcolorHtml { get; set; }
    }
}
