using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class DoPackageTd
    {
        public int SysNo { get; set; }
        public int DosysNo { get; set; }
        public string PackageSize { get; set; }
        public int PackageQty { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
