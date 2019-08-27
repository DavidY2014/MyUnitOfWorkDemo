using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class VendorAdvanceAmtItem
    {
        public int SysNo { get; set; }
        public int VasysNo { get; set; }
        public int ProductSysNo { get; set; }
        public string ProductName { get; set; }
        public decimal PurchasePrice { get; set; }
        public int Pcount { get; set; }
        public DateTime CreateTime { get; set; }
        public int CreateUserSysNo { get; set; }
        public DateTime? UpdateTime { get; set; }
        public int? UpdateUserSysNo { get; set; }
    }
}
