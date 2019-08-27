using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class InvoiceEtl
    {
        public int SysNo { get; set; }
        public string InvoiceNum { get; set; }
        public string SignNum { get; set; }
        public decimal Cash { get; set; }
        public int? Inserter { get; set; }
        public DateTime? InsertTime { get; set; }
        public int? Updater { get; set; }
        public DateTime? UpdateTime { get; set; }
        public string Type { get; set; }
        public string Note { get; set; }
        public int IsRelated { get; set; }
        public string Status { get; set; }
    }
}
