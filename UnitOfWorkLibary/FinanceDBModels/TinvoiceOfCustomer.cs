using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.FinanceDBModels
{
    public partial class TinvoiceOfCustomer
    {
        public int InvoiceOcrid { get; set; }
        public string InvoiceCode { get; set; }
        public string InvoiceNo { get; set; }
        public DateTime InvoiceDate { get; set; }
        public string InvoiceCrc { get; set; }
        public decimal InvoiceAmount { get; set; }
        public string ChineseAmount { get; set; }
        public decimal InvoiceTax { get; set; }
        public decimal InvoiceVatAmount { get; set; }
        public string InvoiceTitle { get; set; }
        public string InvoiceTaxNo { get; set; }
        public string InvoiceAddress { get; set; }
        public string InvoiceAccount { get; set; }
        public string InvoiceSaler { get; set; }
        public string InvoiceSalerTaxNo { get; set; }
        public string InvoiceSalerAddress { get; set; }
        public string InvoiceSalerAccount { get; set; }
        public string InvoiceSeq { get; set; }
        public string InvoiceType { get; set; }
        public string InvoiceFileName { get; set; }
        public DateTime CreateTime { get; set; }
        public int CreateUserId { get; set; }
        public string Status { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public int Number { get; set; }
    }
}
