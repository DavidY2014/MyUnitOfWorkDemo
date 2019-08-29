using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class WxShopSetting
    {
        public int Id { get; set; }
        public int? Wid { get; set; }
        public string ShopName { get; set; }
        public string Copyright { get; set; }
        public string Logo { get; set; }
        public string BgPic { get; set; }
        public string Tel { get; set; }
        public string Addr { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? ExtInt { get; set; }
        public string ExtStr { get; set; }
    }
}
