using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class WxDzpAwardItem
    {
        public int Id { get; set; }
        public int? ActId { get; set; }
        public string JxName { get; set; }
        public string JpName { get; set; }
        public int? JpNum { get; set; }
        public int? JpRealNum { get; set; }
        public int? SortId { get; set; }
        public DateTime? CreateDate { get; set; }
        public decimal? JiaoduMin { get; set; }
        public decimal? JiaoduMax { get; set; }
    }
}
