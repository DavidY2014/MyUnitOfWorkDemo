using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class CustomerExpand
    {
        public int SysNo { get; set; }
        public int CustomerSysNo { get; set; }
        public DateTime? FirstSoorderTime { get; set; }
        public DateTime? BdbonusStartTime { get; set; }
        public DateTime? BdbonusDeadline { get; set; }
        public int IsBdbonusStartTimeChanged { get; set; }
        public int IsBdbonusDeadlineChanged { get; set; }
        public DateTime? CustomerInvalidTime { get; set; }
        public int IsBdactivatedCustomer { get; set; }
        public int IsGroupCustomer { get; set; }
        public string GroupCustomerName { get; set; }
        public int CreateUserSysno { get; set; }
        public DateTime CreateTime { get; set; }
        public int? UpdateUserSysno { get; set; }
        public DateTime? UpdateTime { get; set; }
        public int? GroupNameSysNo { get; set; }
    }
}
