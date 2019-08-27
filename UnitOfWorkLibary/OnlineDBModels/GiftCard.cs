using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class GiftCard
    {
        public int SysNo { get; set; }
        public string CardId { get; set; }
        public string CardName { get; set; }
        public string CardPwd { get; set; }
        public int LotSysNo { get; set; }
        public int LotType { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal LeftAmount { get; set; }
        public DateTime ValidFromDate { get; set; }
        public DateTime ValidToDate { get; set; }
        public int PrintStatus { get; set; }
        public int Status { get; set; }
        public int CreateUserSysNo { get; set; }
        public DateTime CreateTime { get; set; }
        public int? AbandonUserSysNo { get; set; }
        public DateTime? AbandonTime { get; set; }
        public int? BindCustomerSysNo { get; set; }
        public DateTime? BindTime { get; set; }
        public int? AuditUserSysNo { get; set; }
        public DateTime? AuditTime { get; set; }
    }
}
