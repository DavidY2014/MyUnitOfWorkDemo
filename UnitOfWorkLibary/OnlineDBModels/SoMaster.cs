﻿using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class SoMaster
    {
        public SoMaster()
        {
            SoItem = new HashSet<SoItem>();
            SoSaleRule = new HashSet<SoSaleRule>();
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
        public string ReceiveEmail { get; set; }
        public decimal? GiftCardPay { get; set; }
        public decimal? BalancePayAmt { get; set; }
        public int IsHold { get; set; }
        public int? CouponReturnRosysNo { get; set; }
        public int? CustomerOnLock { get; set; }
        public DateTime? CustomerOnLockTime { get; set; }
        public string Omssoid { get; set; }
        public int? OperatorSysNo { get; set; }
        public int? CustomerVatInfoId { get; set; }
        public int? OperatorAddressId { get; set; }
        public int? IsNoAccount { get; set; }
        public int IsSendInvoice { get; set; }
        public string CloseMsg { get; set; }
        public int AccountDay { get; set; }
        public int ZhangPeriod { get; set; }
        public int CustomerDepartmentSysNo { get; set; }
        public string DepartmentCompanyName { get; set; }
        public string ChannelSoid { get; set; }
        public decimal RealSoamt { get; set; }
        public int? CustomerManSysNo { get; set; }
        public int? SaleManSysNo { get; set; }
        public int? ReasonNotAudit { get; set; }
        public int? DefaultStockSysNo { get; set; }
        public string DistributionCode { get; set; }
        public int? IsHolidaysFlag { get; set; }
        public decimal? PointShipPrice { get; set; }
        public int? TotalPoints { get; set; }
        public int? TotalUsePoints { get; set; }
        public int? WaitAduitDepartmentSysNo { get; set; }
        public int? WaitAduitOperatorSysNo { get; set; }
        public string UseCoupons { get; set; }
        public string ReturnCoupons { get; set; }
        public int? HoldCustomerSysNo { get; set; }
        public DateTime? HoldTime { get; set; }
        public string ProductInvoiceType { get; set; }
        public int? SoCancelReasonType { get; set; }
        public string SoCancelReasonDesc { get; set; }
        public DateTime ExpectAuditDate { get; set; }
        public int IsAutoCalcShipPrice { get; set; }
        public int IsOfflineShow { get; set; }
        public decimal Longitude { get; set; }
        public decimal Latitude { get; set; }
        public int BranchSysNo { get; set; }
        public int? BdenterpriseTypeSysNo { get; set; }
        public int? BdsaleManSysNo { get; set; }
        public int? ReconciliationManSysNo { get; set; }
        public int ProvinceId { get; set; }
        public int CityId { get; set; }
        public int WarehouseId { get; set; }
        public int ChannelId { get; set; }
        public int SaleManId { get; set; }
        public DateTime CreateTime { get; set; }
        public int CreateUserId { get; set; }
        public int UpdateUserId { get; set; }
        public int BdcustomerClassId1 { get; set; }
        public int BdcustomerClassId2 { get; set; }
        public int BdcustomerClassId3 { get; set; }
        public int IsAutoCalcDeliveryDate { get; set; }
        public int? HoldSource { get; set; }
        public int IsShipAfterNotice { get; set; }
        public int OrderSplitRule { get; set; }
        public decimal TotalCost { get; set; }
        public decimal TotalNetCost { get; set; }
        public int IsAttachDeliveryBill { get; set; }
        public int IsUploadDeliveryBill { get; set; }
        public string DeliveryBillFileName { get; set; }

        public virtual ICollection<SoItem> SoItem { get; set; }
        public virtual ICollection<SoSaleRule> SoSaleRule { get; set; }
    }
}
