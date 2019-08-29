using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class WxShopCatalogAttribute
    {
        public int Id { get; set; }
        public int? Wid { get; set; }
        public int? CatalogId { get; set; }
        public string AName { get; set; }
        public int? AType { get; set; }
        public string AValue { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? SortId { get; set; }
    }
}
