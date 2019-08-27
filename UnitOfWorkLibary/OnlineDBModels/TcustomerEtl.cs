using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class TcustomerEtl
    {
        public int CustomerId { get; set; }
        public string CustomerCode { get; set; }
        public int ChannelId { get; set; }
        public string CustomerType { get; set; }
        public int BranchId { get; set; }
        public string FullName { get; set; }
        public string BriefName { get; set; }
        public int TeamId1 { get; set; }
        public int TeamId2 { get; set; }
        public int CustomerGroupId { get; set; }
        public int SalesManUserId { get; set; }
        public int DevelopeManUserId { get; set; }
        public int CustomerManUserId { get; set; }
        public int ReconciliationManUserId { get; set; }
        public string IsVipNewSite { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Status { get; set; }
        public string OuterCompanyCode { get; set; }
        public string IsOrderAutoAudit { get; set; }
    }
}
