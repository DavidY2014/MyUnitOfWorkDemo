using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class DoInvoiceTd
    {
        public int SysNo { get; set; }
        public int? DoSysNo { get; set; }
        public string InvoiceCode { get; set; }
        public string InvoiceNum { get; set; }
        public decimal? Amount { get; set; }
        public DateTime? CreateTime { get; set; }
    }
}
