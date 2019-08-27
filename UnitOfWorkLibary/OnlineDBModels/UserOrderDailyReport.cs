using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class UserOrderDailyReport
    {
        public int SysNo { get; set; }
        public DateTime OrderDate { get; set; }
        public int SumUserCount { get; set; }
        public int NewUserCount { get; set; }
        public int DayLoginCount { get; set; }
        public int Socount { get; set; }
        public int SopayCount { get; set; }
        public decimal Avgamt { get; set; }
        public decimal DayAmt { get; set; }
        public decimal Roamt { get; set; }
    }
}
