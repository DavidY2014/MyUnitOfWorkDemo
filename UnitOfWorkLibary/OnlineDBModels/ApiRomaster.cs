using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class ApiRomaster
    {
        public int SysNo { get; set; }
        public string Poid { get; set; }
        public string FromId { get; set; }
        public string CompanyCode { get; set; }
        public string DepartmentCode { get; set; }
        public string Desc { get; set; }
        public string EmailList { get; set; }
        public int Type { get; set; }
        public string PickUpContact { get; set; }
        public string PickUpAddress { get; set; }
        public string PickUpMobile { get; set; }
        public string PickUpPhone { get; set; }
        public int? PickUpAreaSysNo { get; set; }
        public string PickUpZip { get; set; }
        public int PickUpInvoice { get; set; }
        public DateTime? PickUpTime { get; set; }
        public int PickUpShipType { get; set; }
        public string RefundBank { get; set; }
        public string RefundAccount { get; set; }
        public string RefundAccountName { get; set; }
        public int Status { get; set; }
        public string Message { get; set; }
        public DateTime CreateTime { get; set; }
        public int CreateUserSysNo { get; set; }
        public DateTime? UpdateTime { get; set; }
        public int? UpdateUserSysNo { get; set; }
    }
}
