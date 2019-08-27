using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.FinanceDBModels
{
    public partial class TinvoiceGroupVersionDetail
    {
        public int InvoiceGroupVersionDetailId { get; set; }
        public int InvoiceGroupVersionId { get; set; }
        public int InvoiceSerialNo { get; set; }
        public string CustomerCode { get; set; }
        public string InvoiceProductCode { get; set; }
        public string InvoiceProductName { get; set; }
        public string InvoiceProductUnit { get; set; }
        public string InvoiceProductMode { get; set; }
        public string TaxCodeCategory { get; set; }
        public int InvoiceQuantity { get; set; }
        public decimal InvoiceUntaxedAmount { get; set; }
        public decimal InvoiceAmount { get; set; }
        public decimal InvoiceTax { get; set; }
        public decimal TaxRate { get; set; }
        public string CustomerInvoiceRemark { get; set; }
        public string InvoiceRequest { get; set; }
        public int CustomerInvoiceId { get; set; }
        public string InvoiceNo { get; set; }
        public string UploadedFilePath { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public string CustomerInvoiceType { get; set; }
        public string OriginalProductCode { get; set; }
        public string IsNeedSecondaryConfirmation { get; set; }
        public string SecondaryConfirmationReason { get; set; }
    }
}
