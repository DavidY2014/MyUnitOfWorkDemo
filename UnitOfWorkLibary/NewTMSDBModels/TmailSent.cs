using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.NewTMSDBModels
{
    public partial class TmailSent
    {
        public int MailId { get; set; }
        public short MailFormatId { get; set; }
        public string MailTo { get; set; }
        public string Subject { get; set; }
        public string MailCc { get; set; }
        public string RelativeId { get; set; }
        public string MailFrom { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime SendTime { get; set; }
    }
}
