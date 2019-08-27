using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class SalesInvoiceOffice
    {
        public int SysNo { get; set; }
        public int DosysNo { get; set; }
        public int Status { get; set; }
        public int CreateUserSysNo { get; set; }
        public DateTime CreateTime { get; set; }
        public int? AuditUserSysNo { get; set; }
        public DateTime? AuditTime { get; set; }
        public int? AbandonUserSysNo { get; set; }
        public DateTime? AbandonTime { get; set; }
    }
}
