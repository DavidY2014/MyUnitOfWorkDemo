using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class AsyncEmail
    {
        public string MailAddress { get; set; }
        public string MailSubject { get; set; }
        public string MailBody { get; set; }
        public int Status { get; set; }
        public int SysNo { get; set; }
    }
}
