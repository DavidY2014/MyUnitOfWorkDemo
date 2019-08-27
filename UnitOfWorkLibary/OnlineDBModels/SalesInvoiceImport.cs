using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class SalesInvoiceImport
    {
        public int SysNo { get; set; }
        public int GroupSysNo { get; set; }
        public string Sign { get; set; }
        public string InvoiceType { get; set; }
        public string DocumentNo { get; set; }
        public string InvoiceCode { get; set; }
        public string InvoiceNo { get; set; }
        public string CustomerNo { get; set; }
        public string CustomerName { get; set; }
        public string CustomerTax { get; set; }
        public string CustomerAddress { get; set; }
        public string BankName { get; set; }
        public string IssueDate { get; set; }
        public string Remark { get; set; }
        public string Drawer { get; set; }
        public string Payee { get; set; }
        public string Reviewer { get; set; }
        public string SalesBankAccountNumber { get; set; }
        public string SalesAddress { get; set; }
        public string ProdcutId { get; set; }
        public string ProductName { get; set; }
        public string ProductMode { get; set; }
        public string Unit { get; set; }
        public int Qty { get; set; }
        public decimal Price { get; set; }
        public decimal Tax { get; set; }
        public decimal? AmountOfTax { get; set; }
        public decimal? DiscountAmount { get; set; }
        public decimal? DiscountTaxAmount { get; set; }
    }
}
