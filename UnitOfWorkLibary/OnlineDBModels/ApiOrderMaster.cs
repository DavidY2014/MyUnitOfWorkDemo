using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class ApiOrderMaster
    {
        public int SysNo { get; set; }
        public string Poid { get; set; }
        public string CompanyCode { get; set; }
        public string DepartmentCode { get; set; }
        public DateTime DeliveryTime { get; set; }
        public int PayTypeSysNo { get; set; }
        public int ReciverAreaSysno { get; set; }
        public string Receiver { get; set; }
        public string ReceiverTelePhone { get; set; }
        public string ReceiverMobie { get; set; }
        public string ReceiverZip { get; set; }
        public string ReceiverAddress { get; set; }
        public string Desc { get; set; }
        public int WaybillCounterparts { get; set; }
        public int InvoiceType { get; set; }
        public string InvoiceCompanyName { get; set; }
        public string InvoiceTaxNum { get; set; }
        public string InvoiceBankInfo { get; set; }
        public string InvoiceBankAccount { get; set; }
        public string InvoiceAddress { get; set; }
        public string InvoicePhone { get; set; }
        public int Type { get; set; }
        public int Status { get; set; }
        public string FromId { get; set; }
        public string EmailList { get; set; }
        public string Message { get; set; }
        public DateTime CreateTime { get; set; }
        public int CreateUserSysNo { get; set; }
        public DateTime? UpdateTime { get; set; }
        public int? UpdateUserSysNo { get; set; }
        public int UseApiproductPrice { get; set; }
        public string ReceiverEmail { get; set; }
        public int SourceType { get; set; }
        public int OrderType { get; set; }
        public string OperatorUserEmail { get; set; }
        public string UserId { get; set; }
        public int? LockSysUserNo { get; set; }
        public DateTime? LockDateTime { get; set; }
        public string LockReason { get; set; }
        public DateTime ExpectHandleTime { get; set; }
        public string ElecEmail { get; set; }
        public int ProvinceId { get; set; }
        public int CityId { get; set; }
        public string OrderTag { get; set; }
        public decimal ShipPrice { get; set; }
    }
}
