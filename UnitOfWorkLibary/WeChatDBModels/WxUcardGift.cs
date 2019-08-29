using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class WxUcardGift
    {
        public int Id { get; set; }
        public int? Wid { get; set; }
        public string GName { get; set; }
        public int? Score { get; set; }
        public DateTime? BeginDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string UseContent { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? SId { get; set; }
        public int? SortId { get; set; }
    }
}
