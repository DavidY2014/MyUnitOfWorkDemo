using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class Product
    {
        public Product()
        {
            ProductAttribute2Td = new HashSet<ProductAttribute2Td>();
            ProductChannel = new HashSet<ProductChannel>();
            ProductPrice = new HashSet<ProductPrice>();
            ProductStatus = new HashSet<ProductStatus>();
        }

        public int SysNo { get; set; }
        public string ProductId { get; set; }
        public string ProductMode { get; set; }
        public int ProductType { get; set; }
        public string ProductName { get; set; }
        public string PromotionWord { get; set; }
        public string BriefName { get; set; }
        public string ProductDesc { get; set; }
        public string ProductDescLong { get; set; }
        public string Performance { get; set; }
        public string Warranty { get; set; }
        public string PackageList { get; set; }
        public decimal Weight { get; set; }
        public int C3sysNo { get; set; }
        public int? ManufacturerSysNo { get; set; }
        public string ProductLink { get; set; }
        public int MultiPicNum { get; set; }
        public int? PmuserSysNo { get; set; }
        public int? PpmuserSysNo { get; set; }
        public int? ApmuserSysNo { get; set; }
        public int CreateUserSysNo { get; set; }
        public DateTime CreateTime { get; set; }
        public string Attention { get; set; }
        public string Note { get; set; }
        public string BarCode { get; set; }
        public int Status { get; set; }
        public int IsLarge { get; set; }
        public int? LastVendorSysNo { get; set; }
        public int? AvgDailyClick { get; set; }
        public string AssessmentTitle { get; set; }
        public string AssessmentLink { get; set; }
        public int? VirtualArriveTime { get; set; }
        public int? InventoryCycleTime { get; set; }
        public decimal? Dmsweight { get; set; }
        public decimal? Dms { get; set; }
        public int? Opl { get; set; }
        public int? OrderNum { get; set; }
        public int? ProductColor { get; set; }
        public int? ProductSize { get; set; }
        public int? DefaultVendorSysNo { get; set; }
        public decimal? DefaultPurchasePrice { get; set; }
        public int? Product2ndType { get; set; }
        public int? MasterProductSysNo { get; set; }
        public int? IsCanPurchase { get; set; }
        public DateTime? PromotionTimeFrom { get; set; }
        public DateTime? PromotionTimeTo { get; set; }
        public int? IsCanDoVat { get; set; }
        public string ProducingArea { get; set; }
        public int? PackQuantity { get; set; }
        public int? MinOrderQuantity { get; set; }
        public int? IsStoreFrontSale { get; set; }
        public string SaleUnit { get; set; }
        public int? StorageDay { get; set; }
        public byte[] Version { get; set; }
        public int IsInStock { get; set; }
        public string Keywords { get; set; }
        public int? ProductAssociateSysNo { get; set; }
        public int SaleType { get; set; }
        public decimal Volume { get; set; }
        public int OnlineShowType { get; set; }
        public int Isinstall { get; set; }
        public string WarrantyDescription { get; set; }
        public int Avgscore { get; set; }
        public int HasFlash { get; set; }
        public int BaseNumber { get; set; }
        public string Seotitle { get; set; }
        public string Seokeyword { get; set; }
        public string Seodescription { get; set; }
        public int? LimitArea { get; set; }
        public int IslistShow { get; set; }
        public int IsInvoice { get; set; }
        public int? IsVirtual { get; set; }
        public string MsgTemplate { get; set; }
        public decimal Long { get; set; }
        public decimal Width { get; set; }
        public decimal High { get; set; }
        public int IsDirectSend { get; set; }
        public string OldProductId { get; set; }
        public int SynStatus { get; set; }
        public int ReceiveStatus { get; set; }
        public int? IsBulkStock { get; set; }
        public int? IsThePlan { get; set; }
        public string BiddingDesc { get; set; }
        public int IsGonlineShow { get; set; }
        public int IscreateSn { get; set; }
        public string WarrantyB2g { get; set; }
        public string WarrantyDescriptionB2g { get; set; }
        public string WarrantyB2b { get; set; }
        public string WarrantyDescriptionB2b { get; set; }
        public int FinanceType { get; set; }
        public int? IsGiftCard { get; set; }
        public int? IsNewProduct { get; set; }
        public int? SaleQty { get; set; }
        public DateTime? UpdateNewProductTime { get; set; }
        public int? Saleweekqty { get; set; }
        public int? GiftCardLotSysNo { get; set; }
        public DateTime OnlineDateTime { get; set; }
        public int IsInBuy { get; set; }
        public int? AttentionPercent { get; set; }
        public string ProductChannelShowType { get; set; }
        public decimal DayAvgSaleQty1 { get; set; }
        public decimal DayAvgSaleQty2 { get; set; }
        public int IsShowTypeAll { get; set; }
        public int IsReturnGoods { get; set; }
        public int IsPurchase { get; set; }
        public int IsPurchaseReturn { get; set; }
        public int MediaMerchId { get; set; }
        public string MerchandiseCode { get; set; }
        public string MediaMerchCode { get; set; }
        public int MediaMerchSysNo { get; set; }
        public int DeliveryDay { get; set; }
        public int IsGreen { get; set; }
        public int IsBoxFul { get; set; }
        public int DayAvgOutStockQty1 { get; set; }
        public int DayAvgOutStockQty2 { get; set; }
        public decimal ProductInventoryCycleTime { get; set; }
        public string PackingList { get; set; }
        public int DescStatus { get; set; }
        public int PictureStatus { get; set; }
        public int PriceStatus { get; set; }
        public int ProductNameStatus { get; set; }
        public string InventoryTurnover { get; set; }
        public int IsQualityStandards { get; set; }
        public int IsCertification { get; set; }
        public string SaleStopProduct { get; set; }
        public string SaleOverProduct { get; set; }
        public int IsSaleStop { get; set; }
        public int IsSaleOver { get; set; }
        public int IsAdproduct { get; set; }
        public string TextDescription { get; set; }
        public int? DayAvgOutStockQty3 { get; set; }
        public int IsLargeCustomer { get; set; }
        public decimal? OutStockFrequency { get; set; }
        public int? OutStockQuantity { get; set; }
        public int? MaxOrderQuantity1 { get; set; }
        public int? MaxOrderQuantity2 { get; set; }
        public int? MaxOrderQuantity3 { get; set; }
        public int? SoorderQuantity1 { get; set; }
        public int? SoorderQuantity2 { get; set; }
        public int? SoorderQuantity3 { get; set; }
        public int? IsUnSaleable { get; set; }
        public string UnSaleableDesc { get; set; }
        public string ConvertUnit { get; set; }
        public int? ConvertNum { get; set; }
        public int? PointSaleQty { get; set; }
        public decimal? IntegralCoefficient { get; set; }
        public string IntegralName { get; set; }
        public string BuyingGuideIcon { get; set; }
        public string PreProductChannelShowType { get; set; }
        public int IsChange { get; set; }
        public int IsSync { get; set; }
        public int? MaxOrderQuantity4 { get; set; }
        public int? SoorderQuantity4 { get; set; }
        public DateTime? UpdateTime { get; set; }
        public int? UpdateUserSysNo { get; set; }
        public int IsDistribution { get; set; }
        public string TaxCodeCategory { get; set; }
        public decimal TaxRate { get; set; }

        public virtual ProductAttribute2Summary ProductAttribute2Summary { get; set; }
        public virtual ICollection<ProductAttribute2Td> ProductAttribute2Td { get; set; }
        public virtual ICollection<ProductChannel> ProductChannel { get; set; }
        public virtual ICollection<ProductPrice> ProductPrice { get; set; }
        public virtual ICollection<ProductStatus> ProductStatus { get; set; }
    }
}
