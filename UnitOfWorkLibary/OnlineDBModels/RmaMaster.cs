using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class RmaMaster
    {
        public RmaMaster()
        {
            RmaItem = new HashSet<RmaItem>();
        }

        public int SysNo { get; set; }
        public string Rmaid { get; set; }
        public int? SosysNo { get; set; }
        public int CustomerSysNo { get; set; }
        public int Status { get; set; }
        public int? AuditUserSysNo { get; set; }
        public DateTime? AuditTime { get; set; }
        public int? ReceiveUserSysNo { get; set; }
        public DateTime? ReceiveTime { get; set; }
        public int? RmauserSysNo { get; set; }
        public DateTime? Rmatime { get; set; }
        public int? CloseUserSysNo { get; set; }
        public DateTime? CloseTime { get; set; }
        public int? LastUserSysNo { get; set; }
        public DateTime? UserChangedTime { get; set; }
        public string Rmanote { get; set; }
        public string Ccnote { get; set; }
        public string SubmitInfo { get; set; }
        public string ReceiveInfo { get; set; }
        public int UserStatus { get; set; }
        public DateTime CreateTime { get; set; }
        public string RefundBank { get; set; }
        public string RefundAccount { get; set; }
        public string RefundAccountName { get; set; }
        public int DosysNo { get; set; }
        public string ReceiveName { get; set; }
        public string ReceiveAddress { get; set; }
        public string ReceivePhone { get; set; }
        public string ReceiveCellPhone { get; set; }
        public int? ReceiveAreaSysNo { get; set; }
        public string ReceiveZip { get; set; }
        public int? ShipTypeSysNo { get; set; }
        public string PickUpContact { get; set; }
        public string PickUpAddress { get; set; }
        public string PickUpMobile { get; set; }
        public string PickUpPhone { get; set; }
        public int? PickUpAreaSysNo { get; set; }
        public string PickUpZip { get; set; }
        public int PickUpInvoice { get; set; }
        public DateTime? PickUpTime { get; set; }
        public int ProductSaleType { get; set; }
        public int PickUpShipType { get; set; }
        public int IsPreSales { get; set; }
        public int? RefundType { get; set; }
        public int IsReturnInvoice { get; set; }
        public int CustomerDepartmentSysNo { get; set; }
        public string DepartmentCompanyName { get; set; }
        public int IsSdsysNo { get; set; }
        public int? StockSysNo { get; set; }
        public decimal? TotalPoints { get; set; }
        public decimal? TotalUsePoints { get; set; }
        public decimal? PointShipPrice { get; set; }
        public string DutyDepartment { get; set; }
        public int BranchSysNo { get; set; }
        public string ExpenseDepartment { get; set; }
        public int FollowupDepartment { get; set; }
        public int PickUpProvinceId { get; set; }
        public int PickUpCityId { get; set; }
        public int ReceiveProvinceId { get; set; }
        public int ReceiveCityId { get; set; }
        public int CreateUserId { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime? UpdateTime { get; set; }
        public int WarehouseId { get; set; }

        public virtual ICollection<RmaItem> RmaItem { get; set; }
    }
}
