using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class WxDiancaiCaipinManage
    {
        public int Id { get; set; }
        public int? Categoryid { get; set; }
        public string CpName { get; set; }
        public string CategoryName { get; set; }
        public double? CpPrice { get; set; }
        public double? ZkPrice { get; set; }
        public string PriceUnite { get; set; }
        public string CpPic { get; set; }
        public string PicUrl { get; set; }
        public string DetailContent { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? Shopid { get; set; }
        public int? Sortid { get; set; }
        public int? Scan { get; set; }
    }
}
