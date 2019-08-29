using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class WxShopCategoryCatalog
    {
        public int Id { get; set; }
        public int? CategoryId { get; set; }
        public int? CatalogId { get; set; }
    }
}
