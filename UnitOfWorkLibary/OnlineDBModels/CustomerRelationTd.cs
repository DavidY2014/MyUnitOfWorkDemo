using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class CustomerRelationTd
    {
        public int SysNo { get; set; }
        public int ParentSysNo { get; set; }
        public string Name { get; set; }
        public DateTime? CreateTime { get; set; }
        public string Code { get; set; }
        public int? TypeId { get; set; }
        public int? Status { get; set; }
        public string OrgId { get; set; }
    }
}
