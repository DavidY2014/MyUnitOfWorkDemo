using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class WxWsiteSetting
    {
        public int Id { get; set; }
        public int? WId { get; set; }
        public string WName { get; set; }
        public string CompanyName { get; set; }
        public string BgMusic { get; set; }
        public string BgPic { get; set; }
        public int? BgDongHuaId { get; set; }
        public string WCopyright { get; set; }
        public string WBrief { get; set; }
        public string Remark { get; set; }
        public string Phone { get; set; }
        public string Addr { get; set; }
        public string AddrUrl { get; set; }
        public string Email { get; set; }
        public string SeoTitle { get; set; }
        public string SeoKeywords { get; set; }
        public string SeoDesc { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? ExtInt { get; set; }
        public string ExtStr { get; set; }
        public string ExtStr2 { get; set; }
    }
}
