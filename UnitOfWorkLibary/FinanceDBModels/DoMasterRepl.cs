using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.FinanceDBModels
{
    public partial class DoMasterRepl
    {
        public int SysNo { get; set; }
        public string Doid { get; set; }
        public int ReferType { get; set; }
        public int StockSysNo { get; set; }
        public int? ShipTypeSysNo { get; set; }
        public decimal ShipPrice { get; set; }
        public decimal Codamt { get; set; }
        public int? ReceiveAreaSysNo { get; set; }
        public string ReceiveContact { get; set; }
        public string ReceiveName { get; set; }
        public string ReceivePhone { get; set; }
        public string ReceiveCellPhone { get; set; }
        public string ReceiveAddress { get; set; }
        public string ReceiveZip { get; set; }
        public int? InvoiceStatus { get; set; }
        public DateTime? InvoiceTime { get; set; }
        public int? InvoiceUpdateUserSysNo { get; set; }
        public DateTime? AbandonInvoiceTime { get; set; }
        public int? RequestInvoiceType { get; set; }
        public int? InvoiceType { get; set; }
        public string ReceivePasphone { get; set; }
        public int Status { get; set; }
        public int SyncStatus { get; set; }
        public int CreateUserSysNo { get; set; }
        public DateTime CreateTime { get; set; }
        public int? UpdateUserSysNo { get; set; }
        public DateTime? UpdateTime { get; set; }
        public int? AuditUserSysNo { get; set; }
        public DateTime? AuditTime { get; set; }
        public DateTime? OutTime { get; set; }
        public decimal? Wmsweight { get; set; }
        public decimal? ExpressWeight { get; set; }
        public string Express { get; set; }
        public string ExpressNo { get; set; }
        public int? IsSign { get; set; }
        public DateTime? SignTime { get; set; }
        public int? ReceiveStatus { get; set; }
        public int? SendType { get; set; }
        public int IscancelOutStock { get; set; }
        public DateTime? SyncTime { get; set; }
        public DateTime? ReceiveTime { get; set; }
        public int? HandlerSysNo { get; set; }
        public string MergerDoid { get; set; }
        public int? CustomerSysNo { get; set; }
        public int ProductSaleType { get; set; }
        public string Exportlist { get; set; }
        public int IsVisualStock { get; set; }
        public int IsprintPrice { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public int DistributionRequireType { get; set; }
        public string InvoiceNo { get; set; }
        public int? CheckQtyUserSysNo { get; set; }
        public DateTime? CheckQtyTime { get; set; }
        public int? FreightUserSysNo { get; set; }
        public int? DlsysNo { get; set; }
        public DateTime? SetDeliveryManTime { get; set; }
        public int IsPrintPackageCover { get; set; }
        public int IsPrintPickupCover { get; set; }
        public string PickupPrintIp { get; set; }
        public DateTime? PickupPrintTime { get; set; }
        public int IsReconciliation { get; set; }
        public int? OutUserSysNo { get; set; }
        public DateTime? VerificationTime { get; set; }
        public int AccountDay { get; set; }
        public int ZhangPeriod { get; set; }
        public string Remark { get; set; }
        public decimal AggregateAmount { get; set; }
        public int CustomerDepartmentSysNo { get; set; }
        public string DepartmentCompanyName { get; set; }
        public string DistributionCode { get; set; }
        public string SignOperator { get; set; }
        public int? IsSyncToG7 { get; set; }
        public bool? IsRelated { get; set; }
        public bool? IsHaveInvoice { get; set; }
        public decimal? TotalPoints { get; set; }
        public decimal? TotalUsePoints { get; set; }
        public decimal? PointShipPrice { get; set; }
        public decimal? PointsAmt { get; set; }
        public int? CustomerType { get; set; }
        public decimal? EndAmt { get; set; }
        public string ProductInvoiceType { get; set; }
        public int? IsInStock { get; set; }
        public int ReferSysNo { get; set; }
        public DateTime? LatestCollectionTime { get; set; }
        public int BranchSysNo { get; set; }
    }
}
