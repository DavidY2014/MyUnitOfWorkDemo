using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class RoMaster
    {
        public RoMaster()
        {
            RoItem = new HashSet<RoItem>();
        }

        public int SysNo { get; set; }
        public string Roid { get; set; }
        public int? RmasysNo { get; set; }
        public int Status { get; set; }
        public int StockSysNo { get; set; }
        public decimal OriginCashAmt { get; set; }
        public int OriginPointAmt { get; set; }
        public decimal RedeemAmt { get; set; }
        public decimal CashAmt { get; set; }
        public int PointAmt { get; set; }
        public int CreateUserSysNo { get; set; }
        public DateTime CreateTime { get; set; }
        public int? AuditUserSysNo { get; set; }
        public DateTime? AuditTime { get; set; }
        public int? ReturnUserSysNo { get; set; }
        public DateTime? ReturnTime { get; set; }
        public string ReceiveName { get; set; }
        public string ReceiveAddress { get; set; }
        public string ReceivePhone { get; set; }
        public string Note { get; set; }
        public int? ExchangeSo { get; set; }
        public int? Isexchange { get; set; }
        public string ReceiveCellPhone { get; set; }
        public int? ReceiveAreaSysNo { get; set; }
        public string ReceiveZip { get; set; }
        public int? ShipTypeSysNo { get; set; }
        public int? PayTypeSysNo { get; set; }
        public int? PickUpAreaSysNo { get; set; }
        public string PickUpAddress { get; set; }
        public string PickUpContact { get; set; }
        public string PickUpZip { get; set; }
        public string PickUpMobile { get; set; }
        public string PickUpPhone { get; set; }
        public DateTime? PickUpTime { get; set; }
        public int PickUpInvoice { get; set; }
        public int DosysNo { get; set; }
        public int ProductSaleType { get; set; }
        public int PickUpShipType { get; set; }
        public int CashRefundType { get; set; }
        public int RefundStatus { get; set; }
        public DateTime? RequestRefundTime { get; set; }
        public string Memo { get; set; }
        public DateTime? RefundApproveTime { get; set; }
        public int? RefundApproveUserSysNo { get; set; }
        public DateTime? RefundTime { get; set; }
        public int? RefundUserSysNo { get; set; }
        public decimal RefundBalance { get; set; }
        public decimal RefundGiftCard { get; set; }
        public string Omsroid { get; set; }
        public int IsReconciliation { get; set; }
        public DateTime? VerificationTime { get; set; }
        public int CustomerSysNo { get; set; }
        public int CustomerDepartmentSysNo { get; set; }
        public string DepartmentCompanyName { get; set; }
        public int IsSdsysNo { get; set; }
        public bool? IsRelated { get; set; }
        public bool? IsHaveInvoice { get; set; }
        public decimal? TotalPoints { get; set; }
        public decimal? TotalUsePoints { get; set; }
        public decimal? PointShipPrice { get; set; }
        public decimal? EndAmt { get; set; }
        public DateTime? LatestCollectionTime { get; set; }
        public int? AccountDay { get; set; }
        public int? ZhangPeriod { get; set; }
        public int BranchSysNo { get; set; }
        public int? InvoiceStatus { get; set; }
        public int PickUpProvinceId { get; set; }
        public int PickUpCityId { get; set; }
        public int ReceiveProvinceId { get; set; }
        public int ReceiveCityId { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime? UpdateTime { get; set; }
        public int WarehouseId { get; set; }
        public decimal TotalCost { get; set; }
        public decimal TotalNetCost { get; set; }

        public virtual ICollection<RoItem> RoItem { get; set; }
    }
}
