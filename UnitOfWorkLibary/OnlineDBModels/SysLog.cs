using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class SysLog
    {
        public int SysNo { get; set; }
        public DateTime OptTime { get; set; }
        public int OptUserSysNo { get; set; }
        public string OptIp { get; set; }
        public int TicketType { get; set; }
        public int TicketSysNo { get; set; }
        public string Note { get; set; }
    }
}
