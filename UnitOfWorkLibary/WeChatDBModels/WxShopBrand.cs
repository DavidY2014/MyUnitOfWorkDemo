using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class WxShopBrand
    {
        public int Id { get; set; }
        public int? Wid { get; set; }
        public string BName { get; set; }
        public string Logo { get; set; }
        public string CompanyUrl { get; set; }
        public string CompanyName { get; set; }
        public string Remark { get; set; }
        public int? SortId { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
