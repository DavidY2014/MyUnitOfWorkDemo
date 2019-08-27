using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class DirectPoCloseApply
    {
        public int SysNo { get; set; }
        public int PosysNo { get; set; }
        public DateTime CreateTime { get; set; }
        public int CreateUserSysNo { get; set; }
        public string AttachmentFile { get; set; }
        public string Remark { get; set; }
        public int Status { get; set; }
        public DateTime? CloseTime { get; set; }
        public int? CloseUserSysNo { get; set; }
        public string SignType { get; set; }
        public int ReferSysNo { get; set; }
        public string WayBillNo { get; set; }
    }
}
