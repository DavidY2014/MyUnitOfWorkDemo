using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class SoInvoiceLog
    {
        public int SysNo { get; set; }
        public int SoSysNo { get; set; }
        public string Soid { get; set; }
        public string InvoiceNum { get; set; }
        public int? Type { get; set; }
        public int? Status { get; set; }
        public decimal Cash { get; set; }
        public decimal Soamt { get; set; }
        public decimal ShipAmt { get; set; }
        public decimal NeverShipAmt { get; set; }
        public int? UpdateStatus { get; set; }
        public DateTime CreateTime { get; set; }
        public int CreateUserSysNo { get; set; }
        public DateTime? UpdateTime { get; set; }
        public int? UpdateUserSysNo { get; set; }
    }
}
