using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class TmailFailed
    {
        public int MailId { get; set; }
        public short MailFormatId { get; set; }
        public string MailTo { get; set; }
        public string MailCc { get; set; }
        public string RelativeId { get; set; }
        public short RetryNumber { get; set; }
        public DateTime? LastRetryTime { get; set; }
        public string FailDescription { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
