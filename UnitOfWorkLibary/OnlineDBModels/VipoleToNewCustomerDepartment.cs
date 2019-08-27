using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class VipoleToNewCustomerDepartment
    {
        public int SysNo { get; set; }
        public string DepartmentName { get; set; }
        public string Description { get; set; }
        public int? Status { get; set; }
        public int? CustomerSysNo { get; set; }
        public string ContactPhone { get; set; }
        public string ContactPerson { get; set; }
        public string FinanceContacts { get; set; }
        public string FinancialContactMobilePhone { get; set; }
        public string FinancialContactPhone { get; set; }
        public string FinancialContactFax { get; set; }
        public string FinancialMailContact { get; set; }
        public int? FinancialContactAddressSysNo { get; set; }
        public string FinancialContactAddress { get; set; }
        public string FinancialZip { get; set; }
        public string ReconciliationRequirements { get; set; }
        public string BillingRequirements { get; set; }
        public string DeliveryRequirements { get; set; }
        public string PaymentRequest { get; set; }
        public DateTime? UpdateTime { get; set; }
        public int? UpdateUserSysNo { get; set; }
        public DateTime? CreateTime { get; set; }
        public int? CreateUserSysNo { get; set; }
        public int IsAccountContact { get; set; }
        public int? InvoiceAddressSysNo { get; set; }
        public string InvoiceAddress { get; set; }
        public string DepartmentCompanyName { get; set; }
        public string CustomerCode { get; set; }
        public int IsSendAccountEmail { get; set; }
        public int DepartmentLevel { get; set; }
        public int ParentDepartmentSysNo { get; set; }
        public int IsAudit { get; set; }
        public int AccountId { get; set; }
        public int? IsOrderBudget { get; set; }
        public decimal? OrderBudget { get; set; }
        public int? IsMonBudget { get; set; }
        public int? IsMonAccumulate { get; set; }
        public decimal? MonBudget { get; set; }
        public int? IsYearBudget { get; set; }
        public int? IsYearAccumulate { get; set; }
        public decimal? YearBudget { get; set; }
        public decimal? MonRemainder { get; set; }
        public DateTime? MonRemainderUpdateDatetime { get; set; }
        public decimal? YearRemainder { get; set; }
        public DateTime? YearRemainderUpdateDatetime { get; set; }
        public int? NextIsMonAccumulate { get; set; }
        public decimal? NextMonBudget { get; set; }
        public DateTime? NextMonTime { get; set; }
        public int? NextIsYearAccumulate { get; set; }
        public decimal? NextYearBudget { get; set; }
        public DateTime? NextYearTime { get; set; }
        public int? NextIsMonBudget { get; set; }
        public int? NextIsYearBudget { get; set; }
        public decimal? ApprovalAmount { get; set; }
        public DateTime? ChangeDate { get; set; }
        public int? ChangeUserSysNo { get; set; }
    }
}
