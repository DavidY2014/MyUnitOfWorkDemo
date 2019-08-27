using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class MailNotificationTd
    {
        public int SysNo { get; set; }
        public string MailAddress { get; set; }
        public string MailSubject { get; set; }
        public string MailBody { get; set; }
        public int? Status { get; set; }
        public int? SendCount { get; set; }
        public string Attachment { get; set; }
        public DateTime CreateDate { get; set; }
        public int CreateUserSysNo { get; set; }
        public DateTime? LastSendDate { get; set; }
        public int Type { get; set; }
    }
}
