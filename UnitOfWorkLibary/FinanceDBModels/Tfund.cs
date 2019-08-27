using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.FinanceDBModels
{
    public partial class Tfund
    {
        public int FundId { get; set; }
        public int BranchId { get; set; }
        public int CustomerId { get; set; }
        public int PayTypeId { get; set; }
        public int? CustomerGroupId { get; set; }
        public string CustomerGroupName { get; set; }
        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }
        public string RemitCompany { get; set; }
        public string FundType { get; set; }
        public string ClaimType { get; set; }
        public DateTime InputFundTime { get; set; }
        public string IncomingBank { get; set; }
        public string IncomingSerialNo { get; set; }
        public decimal? IncomingUnassigned { get; set; }
        public decimal? IncomingAssigned { get; set; }
        public string VerificationStatus { get; set; }
        public decimal Amount { get; set; }
        public decimal UnVerificationAmount { get; set; }
        public DateTime? FirstVerificationTime { get; set; }
        public string FundRemark { get; set; }
        public string RejectReason { get; set; }
        public int? RejectUserId { get; set; }
        public DateTime? RejectTime { get; set; }
        public string Remark { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Status { get; set; }
        public string BindingStatus { get; set; }
        public decimal BoundAmount { get; set; }
        public int ShiftFundId { get; set; }
    }
}
