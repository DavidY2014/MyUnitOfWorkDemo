using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class VipoleToNewCustomerAddress
    {
        public int SysNo { get; set; }
        public int? CustomerSysNo { get; set; }
        public string Brief { get; set; }
        public string Name { get; set; }
        public string Contact { get; set; }
        public string Phone { get; set; }
        public string CellPhone { get; set; }
        public string Fax { get; set; }
        public string Address { get; set; }
        public string Zip { get; set; }
        public int? AreaSysNo { get; set; }
        public int? IsDefault { get; set; }
        public DateTime? UpdateTime { get; set; }
        public string ReceivePasphone { get; set; }
        public string Email { get; set; }
        public int? Sex { get; set; }
        public string DistributionCode { get; set; }
        public int? OperatorId { get; set; }
        public int? Status { get; set; }
        public int CompanySysNo { get; set; }
        public DateTime? ChangeDate { get; set; }
        public int? ChangeUserSysNo { get; set; }
    }
}
