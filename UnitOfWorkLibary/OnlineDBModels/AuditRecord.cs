using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class AuditRecord
    {
        public int SysNo { get; set; }
        public int AuditorSysNo { get; set; }
        public int DepartmentSysNo { get; set; }
        public string Memo { get; set; }
        public string ActionCode { get; set; }
        public string SoId { get; set; }
        public int? ErpSysNo { get; set; }
        public int? Validity { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? CreateType { get; set; }
        public int? CreateSysNo { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? UpdateType { get; set; }
        public int? UpdateSysNo { get; set; }
        public DateTime? CancelDate { get; set; }
        public int? CancelType { get; set; }
        public int? CancelSysNo { get; set; }
        public int SoVersionSysNo { get; set; }
    }
}
