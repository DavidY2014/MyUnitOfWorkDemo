using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class SalePointDelayTd
    {
        public int SysNo { get; set; }
        public int? SosysNo { get; set; }
        public DateTime CreateTime { get; set; }
        public int Status { get; set; }
        public int DosysNo { get; set; }
    }
}
