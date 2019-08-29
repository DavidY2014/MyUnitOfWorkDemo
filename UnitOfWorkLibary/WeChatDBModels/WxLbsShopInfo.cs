using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class WxLbsShopInfo
    {
        public int Id { get; set; }
        public int? Wid { get; set; }
        public string ShopName { get; set; }
        public string Telphone { get; set; }
        public string Brief { get; set; }
        public string ShopContent { get; set; }
        public string ShopLogo { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string DetailAddr { get; set; }
        public double? XPoint { get; set; }
        public double? YPoint { get; set; }
        public string WUrl { get; set; }
        public int? Seq { get; set; }
        public string Remark { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
