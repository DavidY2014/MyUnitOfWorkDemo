using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class SrMaster
    {
        public int SysNo { get; set; }
        public string Srid { get; set; }
        public int? SosysNo { get; set; }
        public int? Status { get; set; }
        public int? ReturnType { get; set; }
        public int? StockSysNo { get; set; }
        public int? CreateUserSysNo { get; set; }
        public DateTime? CreateTime { get; set; }
        public int? ReceiveUserSysNo { get; set; }
        public DateTime? ReceiveTime { get; set; }
        public DateTime? InstockTime { get; set; }
        public int? InstockUserSysNo { get; set; }
        public DateTime? ShelveTime { get; set; }
        public int? ShelveUserSysNo { get; set; }
        public int? UpdateUserSysNo { get; set; }
        public DateTime? UpdateTime { get; set; }
        public string Note { get; set; }
    }
}
