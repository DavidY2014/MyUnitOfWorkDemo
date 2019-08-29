using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class WxUcardAdver
    {
        public int Id { get; set; }
        public int? Wid { get; set; }
        public string AdverName { get; set; }
        public string PicUrl { get; set; }
        public string LinkUrl { get; set; }
        public bool? IsShow { get; set; }
        public int? SortId { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
