using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class VipoleToNewOperator
    {
        public int SysNo { get; set; }
        public string OperatorName { get; set; }
        public string OperatorPwd { get; set; }
        public int? Status { get; set; }
        public int? DepartmentSysNo { get; set; }
        public string Email { get; set; }
        public string ContactPerson { get; set; }
        public string ContactMobilePhone { get; set; }
        public string ContactZip { get; set; }
        public int? IsSubscribe { get; set; }
        public int? ContactAddressSysNo { get; set; }
        public string ContactAddress { get; set; }
        public DateTime? UpdateTime { get; set; }
        public int? UpdateUserSysNo { get; set; }
        public DateTime? CreateTime { get; set; }
        public int? CreateUserSysNo { get; set; }
        public string LoginName { get; set; }
        public string Fax { get; set; }
        public string CellPhone { get; set; }
        public string LoginId { get; set; }
        public string NickName { get; set; }
        public int IsShowOffline { get; set; }
        public int IsAdmin { get; set; }
        public int IsAccount { get; set; }
        public int IsMeger { get; set; }
        public int AuditType { get; set; }
        public int? AuditOperatorSysNo { get; set; }
        public int? CompanySysNo { get; set; }
        public int? CustomerSysNo { get; set; }
        public decimal? ApprovalAmount { get; set; }
        public string ShowType { get; set; }
        public int? IsShowBalance { get; set; }
        public string Cart { get; set; }
        public string OperatorShowModel { get; set; }
        public int? DefaultDepartment { get; set; }
        public int? SentInvoiceAddressSysNo { get; set; }
        public string SentInvoiceAddress { get; set; }
        public DateTime? ChangeDate { get; set; }
        public int? ChangeUserSysNo { get; set; }
    }
}
