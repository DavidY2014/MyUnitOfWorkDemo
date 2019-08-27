using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.FinanceDBModels
{
    public partial class TinvoiceGroup
    {
        public int InvoiceGroupId { get; set; }
        public string InvoiceType { get; set; }
        public string InvoiceTitle { get; set; }
        public string InvoiceTaxNo { get; set; }
        public string BankName { get; set; }
        public string BankAccountNo { get; set; }
        public string InvoiceAddress { get; set; }
        public string InvoicePhone { get; set; }
        public string InvoiceNo { get; set; }
        public decimal TotalAmount { get; set; }
        public string InvoiceReceiver { get; set; }
        public string InvoiceGroupSource { get; set; }
        public string CustomerInvoiceRemark { get; set; }
        public int BranchId { get; set; }
        public string BranchName { get; set; }
        public string CustomerFullName { get; set; }
        public string VerificationStatus { get; set; }
        public DateTime? VerificationTime { get; set; }
        public string ErrorReason { get; set; }
        public string Status { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int? UpdateUserId { get; set; }
        public DateTime? UpdateTime { get; set; }
        public int? ImportUserId { get; set; }
        public DateTime? ImportTime { get; set; }
        public int? AbandonUserId { get; set; }
        public DateTime? AbandonTime { get; set; }
        public int? CancelUserId { get; set; }
        public DateTime? CancelTime { get; set; }
        public int? RedInvoiceUserId { get; set; }
        public DateTime? RedInvoiceTime { get; set; }
        public string SellerBankCode { get; set; }
        public string InvoiceRequest { get; set; }
        public string BindingStatus { get; set; }
        public string ExpressCompany { get; set; }
        public int AckUserId { get; set; }
        public DateTime? AckTime { get; set; }
        public string AckStatus { get; set; }
        public int ExportUserId { get; set; }
        public DateTime? ExportTime { get; set; }
        public string IsSplitMergeToInvoice { get; set; }
        public int InvoiceBusinessTypeId { get; set; }
        public decimal RealInvoiceAmount { get; set; }
        public decimal AllowedDiffAmount { get; set; }
        public string InvoiceFlowNumber { get; set; }
    }
}
