using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class MailNotificationAuditTd
    {
        public int SysNo { get; set; }
        public int MailNotificationSysNo { get; set; }
        public int SosysNo { get; set; }
        public int AuditOperatorSysNo { get; set; }
        public DateTime? CreateTime { get; set; }
        public int Status { get; set; }
        public int? AttemptCount { get; set; }
    }
}
