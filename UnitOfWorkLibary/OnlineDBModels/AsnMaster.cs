using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class AsnMaster
    {
        public int SysNo { get; set; }
        public string Asnid { get; set; }
        public int ReferType { get; set; }
        public int StockSysNo { get; set; }
        public int Status { get; set; }
        public DateTime CreateTime { get; set; }
        public int CreateUserSysNo { get; set; }
        public DateTime? InTime { get; set; }
        public DateTime? AbandonTime { get; set; }
        public int? AbandonUserSysNo { get; set; }
        public DateTime? AuditTime { get; set; }
        public int? AuditUserSysNo { get; set; }
        public int? PickUpAreaSysNo { get; set; }
        public string PickUpAddress { get; set; }
        public string PickUpContact { get; set; }
        public string PickUpZip { get; set; }
        public string PickUpMobile { get; set; }
        public string PickUpPhone { get; set; }
        public DateTime? PickUpTime { get; set; }
        public int? PickUpInvoice { get; set; }
        public int? IsAllReturn { get; set; }
        public string Note { get; set; }
        public int IsAllInStock { get; set; }
        public int? SendType { get; set; }
        public DateTime? ExpRecDate { get; set; }
        public DateTime? FirstInTime { get; set; }
        public int SyncStatus { get; set; }
        public DateTime? SyncTime { get; set; }
        public int? ReceiveStatus { get; set; }
        public int ProductSaleType { get; set; }
        public string ExportList { get; set; }
        public int IsVisualStock { get; set; }
        public int PickUpShipType { get; set; }
        public int? IsPrintPrice { get; set; }
        public decimal? TotalAmt { get; set; }
        public int? InStockUserSysNo { get; set; }
        public decimal? TotalPoints { get; set; }
        public decimal? TotalUsePoints { get; set; }
        public decimal? PointShipPrice { get; set; }
        public string Wmsid { get; set; }
        public int PaidStatus { get; set; }
        public int ReferId { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public int BranchId { get; set; }
        public decimal TotalNetCost { get; set; }
    }
}
