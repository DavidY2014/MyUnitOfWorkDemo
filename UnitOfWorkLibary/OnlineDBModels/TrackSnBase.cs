using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class TrackSnBase
    {
        public int SysNo { get; set; }
        public int? C3sysNo { get; set; }
        public int? ManufacturerSysNo { get; set; }
        public int? Status { get; set; }
    }
}
