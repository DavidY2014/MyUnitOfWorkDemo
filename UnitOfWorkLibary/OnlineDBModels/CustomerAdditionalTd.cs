using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class CustomerAdditionalTd
    {
        public int CustomerSysNo { get; set; }
        public string CompanyName { get; set; }
        public int? AreaSysNo { get; set; }
        public int? CustomerRelationSysNo { get; set; }
        public int? IsCfca { get; set; }
        public string GroupName { get; set; }
        public int? EconomicType { get; set; }
        public int? SectorType { get; set; }
        public int? FirmSize { get; set; }
        public string ManProductType { get; set; }
        public string RegisteredCapital { get; set; }
        public int IsAudit { get; set; }
        public int? ParentCustomerRelation { get; set; }
        public string BusinessLicense { get; set; }
    }
}
