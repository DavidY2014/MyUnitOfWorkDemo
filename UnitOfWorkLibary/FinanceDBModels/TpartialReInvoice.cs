using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.FinanceDBModels
{
    public partial class TpartialReInvoice
    {
        public int PartialReInvoiceId { get; set; }
        public int InvoiceGroupVersionId { get; set; }
        public int ToRelatedInvoiceGroupId { get; set; }
        public string ToRelatedInvoiceNo { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
