using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.FinanceDBModels
{
    public partial class SoItemRepl
    {
        public int SosysNo { get; set; }
        public int ProductSysNo { get; set; }
        public int Quantity { get; set; }
        public decimal Weight { get; set; }
        public decimal? OrderPrice { get; set; }
        public decimal Price { get; set; }
        public decimal? Cost { get; set; }
        public int Point { get; set; }
        public int PointType { get; set; }
        public decimal DiscountAmt { get; set; }
        public string Warranty { get; set; }
        public int ProductType { get; set; }
        public int? GiftSysNo { get; set; }
        public int? BaseProductType { get; set; }
        public int? ExpectQty { get; set; }
        public int ReturnQty { get; set; }
        public int? IsCanVat { get; set; }
        public string ProductName { get; set; }
        public int IsInStock { get; set; }
        public int? IsDefaultInvoice { get; set; }
        public int? TaxOrder { get; set; }
        public decimal CouponAmtApportion { get; set; }
        public decimal CouponAmtApportionForPm { get; set; }
        public int? ItemPointPay { get; set; }
        public decimal Volume { get; set; }
        public int Isinstall { get; set; }
        public int? CdsysNo { get; set; }
        public int WaitOutQty { get; set; }
        public int OutStockQty { get; set; }
        public int SysNo { get; set; }
        public string ProductNote { get; set; }
        public int IsvirtualStock { get; set; }
        public int IsBulkStock { get; set; }
        public decimal RealPrice { get; set; }
        public decimal? CouponAmt { get; set; }
        public int? OriginalIsInStock { get; set; }
        public int IsSaleOver { get; set; }
        public int IsSaleStop { get; set; }
        public decimal? UnitPoints { get; set; }
        public decimal? TotalPoints { get; set; }
        public decimal? UnitUsePoints { get; set; }
        public decimal? TotalUsePoints { get; set; }
        public int? IsAgreementProduct { get; set; }
        public int? IsContractProduct { get; set; }
        public string ContractDescription { get; set; }
        public string SaleUnit { get; set; }
        public string BriefName { get; set; }
    }
}
