using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class FinancePopay
    {
        public int SysNo { get; set; }
        public int PosysNo { get; set; }
        public int CurrencySysNo { get; set; }
        public decimal Poamt { get; set; }
        public decimal AlreadyPayAmt { get; set; }
        public int PayStatus { get; set; }
        public int InvoiceStatus { get; set; }
        public string Note { get; set; }
        public DateTime? InvoiceTime { get; set; }
        public int OrderSysNo { get; set; }
        public int OrderType { get; set; }
        public DateTime? StockInTime { get; set; }
        public DateTime? PayTime { get; set; }
    }
}
