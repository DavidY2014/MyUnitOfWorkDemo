using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class AsyncEmailHistorical
    {
        public int Id { get; set; }
        public int? SysNo { get; set; }
        public string MailAddress { get; set; }
        public string MailSubject { get; set; }
        public string MailBody { get; set; }
        public int? Status { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? SendTime { get; set; }
        public int? SendCount { get; set; }
    }
}
