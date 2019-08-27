using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class DoprintSequenceTd
    {
        public int SysNo { get; set; }
        public string Doid { get; set; }
        public string Ip { get; set; }
        public int Status { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
