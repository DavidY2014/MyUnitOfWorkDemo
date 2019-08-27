using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class SounDomasterMark
    {
        public int SoSysNo { get; set; }
        public int CreateUserSysNo { get; set; }
        public DateTime CreateTime { get; set; }
        public string MarkSoid { get; set; }
        public DateTime? MarkTime { get; set; }
        public int? MarkUserSysNo { get; set; }
    }
}
