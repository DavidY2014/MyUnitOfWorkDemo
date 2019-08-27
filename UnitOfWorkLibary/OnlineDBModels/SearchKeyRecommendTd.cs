using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class SearchKeyRecommendTd
    {
        public int SysNo { get; set; }
        public string Keyword { get; set; }
        public int KeyType { get; set; }
        public int UserId { get; set; }
        public int ProductSaleType { get; set; }
    }
}
