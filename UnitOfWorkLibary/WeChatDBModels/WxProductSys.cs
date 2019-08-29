using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class WxProductSys
    {
        public int Id { get; set; }
        public int? Wid { get; set; }
        public string Title { get; set; }
        public string Banner { get; set; }
        public string ExtStr { get; set; }
        public string ExtStr2 { get; set; }
        public string ExtStr3 { get; set; }
        public string Remark { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? SortId { get; set; }
        public string LinkUrl { get; set; }
    }
}
