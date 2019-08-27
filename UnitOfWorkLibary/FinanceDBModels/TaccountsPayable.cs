using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.FinanceDBModels
{
    public partial class TaccountsPayable
    {
        public int AccountsPayableId { get; set; }
        public int PoId { get; set; }
        public string PoCode { get; set; }
        public int VendorId { get; set; }
        public string VendorCode { get; set; }
        public string VendorName { get; set; }
        public DateTime DueDate { get; set; }
        public decimal Amount { get; set; }
        public decimal AlreadyPayAmt { get; set; }
        public string ReferType { get; set; }
        public int ReferId { get; set; }
        public string ReferCode { get; set; }
        public DateTime PoCreateTime { get; set; }
        public DateTime AsnDoCreateTime { get; set; }
        public DateTime InTimeOrOutTime { get; set; }
        public string Note { get; set; }
        public DateTime? PayTime { get; set; }
        public string PayStatus { get; set; }
        public DateTime CreateTime { get; set; }
        public int CreateUserId { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
