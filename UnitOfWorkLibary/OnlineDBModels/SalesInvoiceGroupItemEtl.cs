using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class SalesInvoiceGroupItemEtl
    {
        public int SysNo { get; set; }
        public int GroupSysNo { get; set; }
        public int ReferSysNo { get; set; }
        public int Type { get; set; }
        public int Status { get; set; }
    }
}
