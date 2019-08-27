using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class CustomerRecommendProduct
    {
        public int SysNo { get; set; }
        public int ProductSysNo { get; set; }
        public int CustomerSysNo { get; set; }
        public DateTime? CreateTime { get; set; }
        public int? CreateUserSysNo { get; set; }
        public DateTime? UpdateTime { get; set; }
        public int? UpdateUserSysNo { get; set; }
    }
}
