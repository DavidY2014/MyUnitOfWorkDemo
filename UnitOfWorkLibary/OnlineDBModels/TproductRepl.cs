using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class TproductRepl
    {
        public int ProductId { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string ProductFullName { get; set; }
        public int CategoryId1 { get; set; }
        public int CategoryId2 { get; set; }
        public int CategoryId3 { get; set; }
        public int CategoryId4 { get; set; }
        public int CategoryId5 { get; set; }
        public int BrandId { get; set; }
        public int MinUnitId { get; set; }
        public string HasDimension { get; set; }
        public int DimensionId1 { get; set; }
        public int DimensionId2 { get; set; }
        public int DimensionId3 { get; set; }
        public int DimensionId4 { get; set; }
        public int DimensionId5 { get; set; }
        public int DimensionId6 { get; set; }
        public int DimensionId7 { get; set; }
        public int DimensionId8 { get; set; }
        public string IsCloseOut { get; set; }
        public string IsDiscontinue { get; set; }
        public string CanReturn { get; set; }
        public string CanPurchase { get; set; }
        public string CanPurchaseReturn { get; set; }
        public string AdditionalDescription { get; set; }
        public string InnerPackageDescription { get; set; }
        public int ShelfLifeDay { get; set; }
        public string Modal { get; set; }
        public string Specification { get; set; }
        public string Barcode { get; set; }
        public string IsNewGoods { get; set; }
        public string Color { get; set; }
        public string ProducingArea { get; set; }
        public string IsEmbargo { get; set; }
        public string IsBulkyCargo { get; set; }
        public string IsBig { get; set; }
        public decimal Length { get; set; }
        public decimal Width { get; set; }
        public decimal Height { get; set; }
        public decimal Cube { get; set; }
        public decimal Weight { get; set; }
        public string Has3C { get; set; }
        public string HasQuanlityStandard { get; set; }
        public string IsFsc { get; set; }
        public string IsEnergyConservation { get; set; }
        public string IsGreenProtectionde { get; set; }
        public string Remark { get; set; }
        public int ListField1 { get; set; }
        public int ListField2 { get; set; }
        public int ListField3 { get; set; }
        public int ListField4 { get; set; }
        public int ListField5 { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Status { get; set; }
        public string ModalBrief { get; set; }
        public string FullContainerBarcode { get; set; }
        public string IsRestrictSaleArea { get; set; }
        public string TaxCodeCategory { get; set; }
        public decimal TaxRate { get; set; }
    }
}
