using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class WxUcardStoreFendian
    {
        public int Id { get; set; }
        public int? SId { get; set; }
        public string Area { get; set; }
        public string Addr { get; set; }
        public double? XPoint { get; set; }
        public double? YPoint { get; set; }
        public string Tel { get; set; }
        public int? SortId { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
