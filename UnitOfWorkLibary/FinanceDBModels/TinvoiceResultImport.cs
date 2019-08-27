using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.FinanceDBModels
{
    public partial class TinvoiceResultImport
    {
        public int ImportId { get; set; }
        public int InvoiceGroupId { get; set; }
        public string IsAbandon { get; set; }
        public string InvoiceType { get; set; }
        public string InvoiceCode { get; set; }
        public string InvoiceNo { get; set; }
        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }
        public string CustomerTaxNo { get; set; }
        public string CustomerAddress { get; set; }
        public string BankName { get; set; }
        public string InvoiceTime { get; set; }
        public string Drawer { get; set; }
        public string Payee { get; set; }
        public string Reviewer { get; set; }
        public string SalesBankName { get; set; }
        public string SalesAddress { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public string ItemSpecification { get; set; }
        public string ItemUnit { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public decimal TaxRate { get; set; }
        public decimal TaxAmount { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
