using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class GiftCardSoMasterTt
    {
        public GiftCardSoMasterTt()
        {
            GiftCardSoItemTt = new HashSet<GiftCardSoItemTt>();
        }

        public int SysNo { get; set; }
        public string Soid { get; set; }
        public int Status { get; set; }
        public int CustomerSysNo { get; set; }
        public int? StockSysNo { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public int SalesManSysNo { get; set; }
        public int IsWholeSale { get; set; }
        public int IsPremium { get; set; }
        public decimal PremiumAmt { get; set; }
        public int ShipTypeSysNo { get; set; }
        public decimal ShipPrice { get; set; }
        public decimal? FreeShipFeePay { get; set; }
        public int PayTypeSysNo { get; set; }
        public decimal PayPrice { get; set; }
        public decimal Soamt { get; set; }
        public decimal DiscountAmt { get; set; }
        public int? CouponType { get; set; }
        public string CouponCode { get; set; }
        public decimal? CouponAmt { get; set; }
        public int PointAmt { get; set; }
        public decimal CashPay { get; set; }
        public int PointPay { get; set; }
        public int ReceiveAreaSysNo { get; set; }
        public string ReceiveContact { get; set; }
        public string ReceiveName { get; set; }
        public string ReceivePhone { get; set; }
        public string ReceiveCellPhone { get; set; }
        public string ReceiveAddress { get; set; }
        public string ReceiveZip { get; set; }
        public int? AllocatedManSysNo { get; set; }
        public int? FreightUserSysNo { get; set; }
        public int? UpdateUserSysNo { get; set; }
        public DateTime? UpdateTime { get; set; }
        public int? AuditUserSysNo { get; set; }
        public DateTime? AuditTime { get; set; }
        public int? ManagerAuditUserSysNo { get; set; }
        public DateTime? ManagerAuditTime { get; set; }
        public int? OutUserSysNo { get; set; }
        public DateTime? OutTime { get; set; }
        public int? CheckQtyUserSysNo { get; set; }
        public DateTime? CheckQtyTime { get; set; }
        public string Memo { get; set; }
        public string Note { get; set; }
        public string InvoiceNote { get; set; }
        public int IsVat { get; set; }
        public int IsPrintPackageCover { get; set; }
        public string DeliveryMemo { get; set; }
        public decimal? Vatemsfee { get; set; }
        public DateTime? SetDeliveryManTime { get; set; }
        public DateTime? ExpectDeliveryDate { get; set; }
        public int? ExpectDeliveryTimeSpan { get; set; }
        public DateTime? AuditDeliveryDate { get; set; }
        public int? AuditDeliveryTimeSpan { get; set; }
        public DateTime? SentDate { get; set; }
        public int? SentTimeSpan { get; set; }
        public int? SignByOther { get; set; }
        public int? HasServiceProduct { get; set; }
        public int? CsuserSysNo { get; set; }
        public int? HasExpectQty { get; set; }
        public int? IsMergeSo { get; set; }
        public int? InvoiceStatus { get; set; }
        public DateTime? InvoiceTime { get; set; }
        public int? InvoiceUpdateUserSysNo { get; set; }
        public DateTime? AbandonInvoiceTime { get; set; }
        public int? RequestInvoiceType { get; set; }
        public int? InvoiceType { get; set; }
        public DateTime? RequestInvoiceTime { get; set; }
        public decimal? PosFee { get; set; }
        public int? IsLarge { get; set; }
        public int? DlsysNo { get; set; }
        public int? PayPlusSysNo { get; set; }
        public int IsreceiveSms { get; set; }
        public int IsOnlinePayLimited { get; set; }
        public string ReceivePasphone { get; set; }
        public int Sosource { get; set; }
        public string TaoBaoAliPayOrder { get; set; }
        public string TaoBaoOrderId { get; set; }
        public int DistributionRequireType { get; set; }
        public int OutStockStatus { get; set; }
        public int ProductSaleType { get; set; }
        public int IsThePlan { get; set; }
        public int? ShipPriceDosysNo { get; set; }
        public string Exportlist { get; set; }
        public int? CmuserSysNo { get; set; }
        public string SourceId { get; set; }
        public string UploadPwd { get; set; }
        public string GetPwdPhone { get; set; }
        public int? IsPay { get; set; }

        public virtual ICollection<GiftCardSoItemTt> GiftCardSoItemTt { get; set; }
    }
}
