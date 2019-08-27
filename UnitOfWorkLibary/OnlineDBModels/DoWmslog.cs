using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class DoWmslog
    {
        public int SysNo { get; set; }
        public int SoSysNo { get; set; }
        public string SoId { get; set; }
        public int? DoSysNo { get; set; }
        public string DoId { get; set; }
        public int Step { get; set; }
        public string Messages { get; set; }
        public string OperatorUser { get; set; }
        public DateTime? OperatorTime { get; set; }
        public int CreateUserSysNo { get; set; }
        public DateTime CreateTime { get; set; }
        public int? UpdateUserSysNo { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
