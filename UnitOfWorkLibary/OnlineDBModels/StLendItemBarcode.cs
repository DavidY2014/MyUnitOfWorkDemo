using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class StLendItemBarcode
    {
        public int SysNo { get; set; }
        public int LendSysNo { get; set; }
        public int ProductSysNo { get; set; }
        public string Barcode { get; set; }
        public int IsReturned { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
