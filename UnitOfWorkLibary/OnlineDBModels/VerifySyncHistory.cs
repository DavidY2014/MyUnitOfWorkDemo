using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class VerifySyncHistory
    {
        public int HistoryId { get; set; }
        public int? VerificationGroupId { get; set; }
        public int? ReferSysNo { get; set; }
        public string ReferType { get; set; }
        public string OperateType { get; set; }
        public string VerificationType { get; set; }
        public decimal? EndAmt { get; set; }
        public decimal? ReferEndAmt { get; set; }
        public int? IsReconciliation { get; set; }
        public DateTime? VerificationTime { get; set; }
        public int? UserSysno { get; set; }
        public DateTime? CreatTime { get; set; }
    }
}
