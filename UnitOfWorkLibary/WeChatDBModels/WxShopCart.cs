using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class WxShopCart
    {
        public int Id { get; set; }
        public string Openid { get; set; }
        public int Wid { get; set; }
        public int ProductId { get; set; }
        public int SkuId { get; set; }
        public string SkuInfo { get; set; }
        public double TotPrice { get; set; }
        public int ProductNum { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
