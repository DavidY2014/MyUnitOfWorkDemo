using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class TmailAudit
    {
        public int MailAuditId { get; set; }
        public string NotificationCode { get; set; }
        public int SoSysNo { get; set; }
        public int AuditAccountId { get; set; }
        public int AuditCostcenterId { get; set; }
        public int AttemptCount { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public int Status { get; set; }
    }
}
