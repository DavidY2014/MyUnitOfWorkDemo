using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class ProductMatch
    {
        public int SysNo { get; set; }
        public int? MainProductSysNo { get; set; }
        public int? RecommendProductSysNo { get; set; }
        public int? OrderNo { get; set; }
        public int? Status { get; set; }
    }
}
