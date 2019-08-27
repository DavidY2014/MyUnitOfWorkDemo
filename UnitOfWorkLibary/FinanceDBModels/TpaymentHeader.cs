using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.FinanceDBModels
{
    public partial class TpaymentHeader
    {
        public int PaymentId { get; set; }
        public string PaymentCode { get; set; }
        public string SourceSystem { get; set; }
        public string SourceCode { get; set; }
        public int PayAccountId { get; set; }
        public string PayBankAccount { get; set; }
        public string ReceiverAccountCode { get; set; }
        public string ReceiverAccountName { get; set; }
        public string ReceiveOpanBank { get; set; }
        public string ReceiveBankAccount { get; set; }
        public string ReceiveBankProvince { get; set; }
        public string ReceiveBankCity { get; set; }
        public string ReceiveBankAddress { get; set; }
        public string ReceiveEmail { get; set; }
        public string PayUseCn { get; set; }
        public string DealWithWay { get; set; }
        public string PayAmount { get; set; }
        public string ActualAmount { get; set; }
        public string DefrayAmount { get; set; }
        public string PayStatus { get; set; }
        public string Status { get; set; }
        public string PayType { get; set; }
        public string PayDeptName { get; set; }
        public string PayMethod { get; set; }
        public string PayRemark { get; set; }
        public string InternalRemark { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public DateTime? SourceCreateTime { get; set; }
        public DateTime? AuditTime { get; set; }
        public DateTime? PayTime { get; set; }
        public string ReceiptFlag { get; set; }
        public int? ReceiptId { get; set; }
    }
}
