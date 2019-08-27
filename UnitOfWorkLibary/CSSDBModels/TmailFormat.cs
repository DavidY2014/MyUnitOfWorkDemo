using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.CSSDBModels
{
    public partial class TmailFormat
    {
        public short MailFormatId { get; set; }
        public string MailFormatName { get; set; }
        public string MailFormatCode { get; set; }
        public string MailFrom { get; set; }
        public string ContentUrl { get; set; }
        public string MailBcc { get; set; }
        public string MailCc { get; set; }
        public string Subject { get; set; }
        public short Priority { get; set; }
        public string VerifyWord { get; set; }
        public string IsAllowEdit { get; set; }
        public string IsEnablEdit { get; set; }
        public string MailContent { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Status { get; set; }
    }
}
