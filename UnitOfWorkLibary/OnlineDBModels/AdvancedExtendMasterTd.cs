using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class AdvancedExtendMasterTd
    {
        public int SysNo { get; set; }
        public int? MasterNo { get; set; }
        public short? Verification { get; set; }
        public decimal? RestAmount { get; set; }
    }
}
