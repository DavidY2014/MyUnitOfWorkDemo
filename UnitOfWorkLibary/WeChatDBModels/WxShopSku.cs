using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class WxShopSku
    {
        public int Id { get; set; }
        public int? ProductId { get; set; }
        public string Sku { get; set; }
        public int? Stock { get; set; }
        public double? Price { get; set; }
        public string AttributeValue { get; set; }
        public int? AttributeId { get; set; }
    }
}
