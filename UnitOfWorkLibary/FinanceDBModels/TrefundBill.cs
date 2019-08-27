using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.FinanceDBModels
{
    public partial class TrefundBill
    {
        public int RefundBillId { get; set; }
        public int PayTypeId { get; set; }
        public int SoId { get; set; }
        public string SoCode { get; set; }
        public int DoId { get; set; }
        public string DoCode { get; set; }
        public int RoId { get; set; }
        public string RoCode { get; set; }
        public string TradeNo { get; set; }
        public decimal ItemRefundAmount { get; set; }
        public decimal Freight { get; set; }
        public string RefundReason { get; set; }
        public string CustomerManNote { get; set; }
        public string FinanceNote { get; set; }
        public string RefundType { get; set; }
        public DateTime TradeTime { get; set; }
        public string ReceiverBankName { get; set; }
        public string ReceiverAccountNo { get; set; }
        public string Receiver { get; set; }
        public string CancelAuditReason { get; set; }
        public DateTime? ActualRefundTime { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Status { get; set; }
        public string RefundSource { get; set; }
    }
}
