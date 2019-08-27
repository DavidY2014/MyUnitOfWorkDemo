using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.FinanceDBModels
{
    public partial class TmailToSend
    {
        public int MailId { get; set; }
        public short MailFormatId { get; set; }
        public string MailTo { get; set; }
        public string RelativeId { get; set; }
        public string MailCc { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
