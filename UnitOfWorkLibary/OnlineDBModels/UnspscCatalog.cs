using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class UnspscCatalog
    {
        public int Sysno { get; set; }
        public string ProductId { get; set; }
        public string Unspsc { get; set; }
        public string InterfaceCode { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
