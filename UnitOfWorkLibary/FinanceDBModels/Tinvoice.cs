using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.FinanceDBModels
{
    public partial class Tinvoice
    {
        public int InvoiceId { get; set; }
        public string InvoiceCode { get; set; }
        public string InvoiceBusinessType { get; set; }
        public int InvoiceManUserId { get; set; }
        public int CustomerId { get; set; }
        public string InvocieContactName { get; set; }
        public string InvoicerContactPhone { get; set; }
        public string InvoiceType { get; set; }
        public string InvoiceTitle { get; set; }
        public string InvoiceBankName { get; set; }
        public string InvoiceTaxNo { get; set; }
        public string InvoiceAddress { get; set; }
        public string InvoicePhone { get; set; }
        public string InvoiceBankAccount { get; set; }
        public string InvoiceShipAddress { get; set; }
        public string InvoiceShipType { get; set; }
        public string InvoiceNo { get; set; }
        public decimal ApplyAmount { get; set; }
        public decimal TaxRate { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal AmountExcludeTax { get; set; }
        public decimal ShipFee { get; set; }
        public string AuditStatus { get; set; }
        public string InvoiceStatus { get; set; }
        public string VerifyStatus { get; set; }
        public decimal VerifyAmount { get; set; }
        public decimal UnVerifyAmount { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public DateTime? ApplyTime { get; set; }
        public string Remark { get; set; }
        public DateTime? IssueDate { get; set; }
    }
}
