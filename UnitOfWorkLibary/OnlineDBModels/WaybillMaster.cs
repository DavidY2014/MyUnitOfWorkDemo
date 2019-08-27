using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class WaybillMaster
    {
        public int SysNo { get; set; }
        public int DosysNo { get; set; }
        public string WaybillNo { get; set; }
        public DateTime CreateTime { get; set; }
        public int Status { get; set; }
        public int DataType { get; set; }
        public DateTime? UpdateTime { get; set; }
        public int SequenceNumber { get; set; }
        public int PrintCount { get; set; }
        public int AsyncState { get; set; }
        public string ErrorMessage { get; set; }
        public int ShipTypeSysno { get; set; }
        public int CreateUserSysNo { get; set; }
        public string OrderType { get; set; }
        public string Doid { get; set; }
    }
}
