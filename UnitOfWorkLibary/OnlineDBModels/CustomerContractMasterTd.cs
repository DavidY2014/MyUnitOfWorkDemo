using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class CustomerContractMasterTd
    {
        public int SysNo { get; set; }
        public int CustomerSysNo { get; set; }
        public string Description { get; set; }
        public int Priority { get; set; }
        public int Status { get; set; }
        public DateTime CreatedTime { get; set; }
        public int CreateUserSysNo { get; set; }
        public DateTime? UpdateTime { get; set; }
        public int? UpdateUserSysNo { get; set; }
        public DateTime AgreementStartTime { get; set; }
        public DateTime AgreementEndTime { get; set; }
        public int IsExpireStop { get; set; }
        public string NoticeEmail { get; set; }
        public int HasContractManage { get; set; }
        public string DeadLineNoticeDays { get; set; }
        public DateTime? ContractStartTime { get; set; }
        public DateTime? ContractEndTime { get; set; }
        public string ShareGroupId { get; set; }
    }
}
