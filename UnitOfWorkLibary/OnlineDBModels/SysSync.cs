using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class SysSync
    {
        public int SysNo { get; set; }
        public int SyncType { get; set; }
        public DateTime LastVersionTime { get; set; }
    }
}
