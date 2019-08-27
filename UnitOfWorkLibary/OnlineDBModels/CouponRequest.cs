using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class CouponRequest
    {
        public int SysNo { get; set; }
        public int CustomerSysNo { get; set; }
        public string CouponCode { get; set; }
        public int? RequestUserSysNo { get; set; }
        public DateTime? RequestTime { get; set; }
        public int? AuditUserSysNo { get; set; }
        public DateTime? AuditTime { get; set; }
        public int? SosysNo { get; set; }
        public int? BatchNo { get; set; }
        public string Note { get; set; }
        public int Status { get; set; }
        public string Execsql { get; set; }
    }
}
