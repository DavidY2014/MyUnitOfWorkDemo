using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class WxUcardStore
    {
        public int Id { get; set; }
        public int? Wid { get; set; }
        public string StoreName { get; set; }
        public string Logo { get; set; }
        public string StoreCatagory { get; set; }
        public string CardBrief { get; set; }
        public string ConsumePwd { get; set; }
        public string Tel { get; set; }
        public string Addr { get; set; }
        public double? XPoint { get; set; }
        public double? YPoint { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? SortId { get; set; }
        public bool? IsRecommend { get; set; }
        public string HfPic { get; set; }
    }
}
