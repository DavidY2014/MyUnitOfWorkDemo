using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class CurrencyTd
    {
        public int SysNo { get; set; }
        public string CurrencyId { get; set; }
        public string CurrencyName { get; set; }
        public string CurrencySymbol { get; set; }
        public int IsLocal { get; set; }
        public decimal ExchangeRate { get; set; }
        public string ListOrder { get; set; }
        public int Status { get; set; }
    }
}
