using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.FinanceDBModels
{
    public partial class TinvoiceGroupVersion
    {
        public int InvoiceGroupVersionId { get; set; }
        public int InvoiceGroupId { get; set; }
        public int VersionId { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public string SpecialDiffAmountReason { get; set; }
    }
}
