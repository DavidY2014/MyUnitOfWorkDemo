using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class EmailNoticeParametersTd
    {
        public int SysNo { get; set; }
        public string Id { get; set; }
        public string MailFrom { get; set; }
        public string MailFromName { get; set; }
        public string MailCharset { get; set; }
        public string MailServer { get; set; }
        public string MailUserName { get; set; }
        public string MailUserPassword { get; set; }
        public string MailTitle { get; set; }
        public string MailTemplates { get; set; }
        public string MailTo { get; set; }
        public string MailSubject { get; set; }
    }
}
