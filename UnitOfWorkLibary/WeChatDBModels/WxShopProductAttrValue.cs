using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class WxShopProductAttrValue
    {
        public int Id { get; set; }
        public int? AttributeId { get; set; }
        public int? ProductId { get; set; }
        public string PaValue { get; set; }
    }
}
