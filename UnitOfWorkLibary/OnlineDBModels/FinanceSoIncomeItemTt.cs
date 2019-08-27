using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class FinanceSoIncomeItemTt
    {
        public int FsisysNo { get; set; }
        public int TypeId { get; set; }
        public decimal Amount { get; set; }
        public string OrderId { get; set; }
        public DateTime IncomeTime { get; set; }
        public DateTime CreateTime { get; set; }
        public int SysNo { get; set; }
    }
}
