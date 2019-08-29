using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class WxShopCatalog
    {
        public int Id { get; set; }
        public int? Wid { get; set; }
        public string CTitle { get; set; }
        public string Remark { get; set; }
        public int? SortId { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
