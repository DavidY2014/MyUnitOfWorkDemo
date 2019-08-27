using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class InvoiceRef
    {
        public int Sysno { get; set; }
        public string InvoiceNum { get; set; }
        public string SignNum { get; set; }
        public decimal? Cash { get; set; }
        public int? Inserter { get; set; }
        public DateTime? InsertTime { get; set; }
        public int? Updater { get; set; }
        public DateTime? UpdateTime { get; set; }
        public string Type { get; set; }
        public string Note { get; set; }
        public bool? IsRelated { get; set; }
    }
}
