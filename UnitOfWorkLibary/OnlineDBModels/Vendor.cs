﻿using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class Vendor
    {
        public int SysNo { get; set; }
        public string VendorId { get; set; }
        public string VendorName { get; set; }
        public string EnglishName { get; set; }
        public string BriefName { get; set; }
        public int? VendorType { get; set; }
        public string District { get; set; }
        public string Address { get; set; }
        public string Zip { get; set; }
        public string Contact { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Site { get; set; }
        public string Bank { get; set; }
        public string Account { get; set; }
        public string TaxNo { get; set; }
        public string Comment { get; set; }
        public string Note { get; set; }
        public int? WarrantyAreaSysNo { get; set; }
        public string WarrantyAddress { get; set; }
        public string WarrantyZip { get; set; }
        public string WarrantyContact { get; set; }
        public string WarrantyPhone { get; set; }
        public string WarrantyFax { get; set; }
        public string WarrantyEmail { get; set; }
        public string WarrantySite { get; set; }
        public int? WarrantySelfSend { get; set; }
        public int Status { get; set; }
        public string Rmaposition { get; set; }
        public int? Aptype { get; set; }
        public string PoMobileTel { get; set; }
        public string PoMsn { get; set; }
        public string PoQq { get; set; }
        public string WarrantyMsn { get; set; }
        public string WarrantyQq { get; set; }
        public string RcproductPolicy { get; set; }
        public string FinanceContact { get; set; }
        public string FinanceFax { get; set; }
        public string FinanceTel { get; set; }
        public string FinanceMsn { get; set; }
        public string FinanceQq { get; set; }
        public string FinanceEmail { get; set; }
        public string FinanceAddress { get; set; }
        public string OtherAccount { get; set; }
        public DateTime? ContractDateStart { get; set; }
        public DateTime? ContractDateEnd { get; set; }
        public int? CooperateType { get; set; }
        public int SyncStatus { get; set; }
        public int? ReceiveStatus { get; set; }
        public decimal VendorAdvanceAmt { get; set; }
        public string OrgCode { get; set; }
        public int? Arday { get; set; }
        public int? Artype { get; set; }
        public int DeliveryCycle { get; set; }
        public decimal PurchaseAmt { get; set; }
        public int? Poman { get; set; }
        public int? Orman { get; set; }
        public string EnterpriseLegal { get; set; }
        public decimal EstimatedAnnualPurchasesAmt { get; set; }
        public decimal ExpectedRebateRatio { get; set; }
        public DateTime? LastPurchaseDate { get; set; }
        public int AreaSysNo { get; set; }
        public string VarietiesPrice { get; set; }
        public int IsPromotionalSupport { get; set; }
        public int FinanceContactAreaSysNo { get; set; }
        public string FinanceContactZip { get; set; }
        public string FinanceContactMobile { get; set; }
        public string OrderContacts { get; set; }
        public string OrderContactsPhone { get; set; }
        public string OrderContactsMobile { get; set; }
        public string OrderContactsFax { get; set; }
        public string OrderContactsEmail { get; set; }
        public int OrderContactsAreaSysNo { get; set; }
        public string OrderContactsAddress { get; set; }
        public string OrderContactsZip { get; set; }
        public string NegotiationsContacts { get; set; }
        public string NegotiationsContactsPhone { get; set; }
        public string NegotiationsContactsMobile { get; set; }
        public string NegotiationsContactsFax { get; set; }
        public string NegotiationsContactsEmail { get; set; }
        public int NegotiationsContactsAreaSysNo { get; set; }
        public string NegotiationsContactsAddress { get; set; }
        public string NegotiationsContactsZip { get; set; }
        public string ReconciliationRequirements { get; set; }
        public string BillingRequirements { get; set; }
        public string TicketDeliveryRequirements { get; set; }
        public string PaymentRequirements { get; set; }
        public string OrderRequirements { get; set; }
        public string ReturnRequirements { get; set; }
        public string DeliveryRequirements { get; set; }
        public string FreightRequirements { get; set; }
        public string InvoiceTitle { get; set; }
        public string InvoiceAddress { get; set; }
        public string InvoicePhone { get; set; }
        public DateTime CreateTime { get; set; }
        public int VendorRank { get; set; }
        public string PromotionalSupport { get; set; }
        public int InvoiceType { get; set; }
        public string PublicityCosts { get; set; }
        public string RebateCosts { get; set; }
        public string SupplyCategory { get; set; }
        public string SupplyProduct { get; set; }
        public string PaymentAgreement { get; set; }
        public string EstimatedAnnualSales { get; set; }
        public string ExpectedGrossMargin { get; set; }
        public string ExpectedGrossMarginRate { get; set; }
        public string BackgroundExpectedAmount { get; set; }
        public string LogisticsCostsDescribed { get; set; }
        public decimal? MinOrderMoney { get; set; }
        public string AllowRreceipt { get; set; }
        public int? RebateType { get; set; }
        public int? RebateInvoiceType { get; set; }
        public int? ContractType { get; set; }
        public int? ContractVersions { get; set; }
        public short CommPoint { get; set; }
    }
}
