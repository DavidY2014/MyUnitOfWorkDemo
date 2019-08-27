﻿using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class Customer
    {
        public Customer()
        {
            CustomerContractMasterPreTd = new HashSet<CustomerContractMasterPreTd>();
        }

        public int SysNo { get; set; }
        public string CustomerId { get; set; }
        public string Pwd { get; set; }
        public int Status { get; set; }
        public string CustomerName { get; set; }
        public int? Gender { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string CellPhone { get; set; }
        public string Fax { get; set; }
        public int? DwellAreaSysNo { get; set; }
        public string DwellAddress { get; set; }
        public string DwellZip { get; set; }
        public string ReceiveName { get; set; }
        public string ReceiveContact { get; set; }
        public string ReceivePhone { get; set; }
        public string ReceiveCellPhone { get; set; }
        public string ReceiveFax { get; set; }
        public int? ReceiveAreaSysNo { get; set; }
        public string ReceiveAddress { get; set; }
        public string ReceiveZip { get; set; }
        public int TotalScore { get; set; }
        public int ValidScore { get; set; }
        public string CardNo { get; set; }
        public string Note { get; set; }
        public int EmailStatus { get; set; }
        public DateTime RegisterTime { get; set; }
        public string LastLoginIp { get; set; }
        public DateTime? LastLoginTime { get; set; }
        public int? CustomerRank { get; set; }
        public int? IsManualRank { get; set; }
        public int? CustomerType { get; set; }
        public decimal? TotalFreeShipFee { get; set; }
        public decimal? ValidFreeShipFee { get; set; }
        public int? RefCustomerSysNo { get; set; }
        public int? Viprank { get; set; }
        public int? DiscountPercent { get; set; }
        public DateTime? Birthday { get; set; }
        public string Nickname { get; set; }
        public string Msn { get; set; }
        public string Qq { get; set; }
        public string ReceivePasphone { get; set; }
        public string Contact { get; set; }
        public string Bank { get; set; }
        public string Account { get; set; }
        public string TaxNo { get; set; }
        public int? Aptype { get; set; }
        public decimal? CreditLine { get; set; }
        public decimal? SumCreditLine { get; set; }
        public int? AccountPeriod { get; set; }
        public int? CmuserSysNo { get; set; }
        public int IsprintPrice { get; set; }
        public decimal TotalBalance { get; set; }
        public int? IsCompany { get; set; }
        public int CellPhoneStatus { get; set; }
        public int? IsStaff { get; set; }
        public string EmpNumber { get; set; }
        public int? HmAccount { get; set; }
        public decimal? AccountQuota { get; set; }
        public int? BufferAccount { get; set; }
        public decimal? BufferAccountQuota { get; set; }
        public int? Organization { get; set; }
        public decimal? CurrentAccountQuota { get; set; }
        public int? AccountType { get; set; }
        public string Industry { get; set; }
        public string CompanyScale { get; set; }
        public string AddtaxNo { get; set; }
        public string InvoiceAddress { get; set; }
        public string AddTaxTel { get; set; }
        public string AccountNo { get; set; }
        public string AccountName { get; set; }
        public string BankName { get; set; }
        public string CorpContactContractName { get; set; }
        public string CorpContactMobliePhone { get; set; }
        public string CorpContactTelePhone { get; set; }
        public string CorpContactEmial { get; set; }
        public int? SaleMan { get; set; }
        public int? CustomerMan { get; set; }
        public string CompanyName { get; set; }
        public string LegalRepresentative { get; set; }
        public DateTime? BuyTime { get; set; }
        public DateTime? ContractStart { get; set; }
        public DateTime? ContractEnd { get; set; }
        public string MinimumRequirements { get; set; }
        public string ReturnRequest { get; set; }
        public string DeliveryRequirements { get; set; }
        public string FreightDemand { get; set; }
        public string InvalidReason { get; set; }
        public int HmCustomerType { get; set; }
        public DateTime? LastTypeChangeDate { get; set; }
        public string CustomerGroup { get; set; }
        public int ReconciliationDay { get; set; }
        public int IsPrintAmt { get; set; }
        public string UnitCode { get; set; }
        public int? IsAutomaticAudit { get; set; }
        public int? EnterpriseTypeSysNo { get; set; }
        public int? SourceFlag { get; set; }
        public int IsShareGiftActivity { get; set; }
        public string CompanyCode { get; set; }
        public string CustomerLabel { get; set; }
        public int? CustomerActivity { get; set; }
        public int? DevelopMan { get; set; }
        public string SourceDesc { get; set; }
        public int CompanyLevel { get; set; }
        public int? ParentCustomerSysNo { get; set; }
        public string CompanyLogo { get; set; }
        public int IsVirtualStatic { get; set; }
        public int IsVipNewSite { get; set; }
        public DateTime? TransitionDatetime { get; set; }
        public int? IsFreeShipPay { get; set; }
        public int CompanyCategory { get; set; }
        public int IsSendInvoiceWithOrder { get; set; }
        public int? CustomerStockSysNo { get; set; }
        public int IsShowDiscount { get; set; }
        public int? DefaultOrderShipAreaSysNo { get; set; }
        public string District { get; set; }
        public int SignOrderBack { get; set; }
        public int? DuiZhangSysUserOut { get; set; }
        public int AccountCheckerType { get; set; }
        public int BillingType { get; set; }
        public int IsFanLi { get; set; }
        public string InvoiceAndBillingRequirement { get; set; }
        public string InvoiceArrivedTime { get; set; }
        public int BranchSysNo { get; set; }
        public int IsStopGoods { get; set; }

        public virtual ICollection<CustomerContractMasterPreTd> CustomerContractMasterPreTd { get; set; }
    }
}
