using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class AsyncEmailAdditionalTd
    {
        public int SysNo { get; set; }
        public int? AsyncEmailSysNo { get; set; }
        public int? AsyncEmailServerSysNo { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? SendTime { get; set; }
        public int? SendCount { get; set; }
    }
}
