using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class EmailMailNotificationTd
    {
        public int SysNo { get; set; }
        public string MailFrom { get; set; }
        public string MailFromName { get; set; }
        public string MailCharset { get; set; }
        public string MailServer { get; set; }
        public string MailUserName { get; set; }
        public string MailUserPassword { get; set; }
        public int Type { get; set; }
    }
}
