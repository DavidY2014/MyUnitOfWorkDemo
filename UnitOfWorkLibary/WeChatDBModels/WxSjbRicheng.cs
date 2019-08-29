using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class WxSjbRicheng
    {
        public int Id { get; set; }
        public int? Wid { get; set; }
        public string RcName { get; set; }
        public DateTime? BeginDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string RcPic { get; set; }
        public string Remark { get; set; }
        public int? SortId { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
