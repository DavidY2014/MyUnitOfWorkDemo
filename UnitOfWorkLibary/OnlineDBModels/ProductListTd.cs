using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class ProductListTd
    {
        public int SysNo { get; set; }
        public int? ProductSysNo { get; set; }
        public string ListName { get; set; }
        public string ListAttribute { get; set; }
        public DateTime? CreateTime { get; set; }
        public int? Status { get; set; }
        public int ListOrder { get; set; }
    }
}
