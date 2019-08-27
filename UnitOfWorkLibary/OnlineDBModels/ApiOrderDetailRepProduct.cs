using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class ApiOrderDetailRepProduct
    {
        public int SysNo { get; set; }
        public int? ProductSysNo { get; set; }
        public string ProductId { get; set; }
        public int RepProductSysNo { get; set; }
        public string RepProductId { get; set; }
        public int CreateUserSysNo { get; set; }
        public DateTime CreateTime { get; set; }
        public int? UpdateUserSysNo { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
