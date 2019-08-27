using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class FinanceSoincome
    {
        public int OrderType { get; set; }
        public int OrderSysNo { get; set; }
        public decimal OrderAmt { get; set; }
        public int IncomeStyle { get; set; }
        public decimal IncomeAmt { get; set; }
        public DateTime IncomeTime { get; set; }
        public int IncomeUserSysNo { get; set; }
        public DateTime? ConfirmTime { get; set; }
        public int? ConfirmUserSysNo { get; set; }
        public string Note { get; set; }
        public int Status { get; set; }
        public decimal Aramt { get; set; }
        public int ReferSysNo { get; set; }
        public decimal ReceivedAmt { get; set; }
        public int SysNo { get; set; }
        public decimal? SaleAmt { get; set; }
        public decimal? GiftCardAmt { get; set; }
        public DateTime? Artime { get; set; }
        public DateTime? LatestCollectionTime { get; set; }
        public DateTime? VerificationTime { get; set; }
    }
}
