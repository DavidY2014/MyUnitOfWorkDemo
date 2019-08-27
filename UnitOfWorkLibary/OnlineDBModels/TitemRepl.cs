using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class TitemRepl
    {
        public int ItemId { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public string ItemFullName { get; set; }
        public int ProductId { get; set; }
        public int CategoryId1 { get; set; }
        public int CategoryId2 { get; set; }
        public int CategoryId3 { get; set; }
        public int SaleUnitId { get; set; }
        public decimal SkuMaxSalePrice { get; set; }
        public decimal SkuMinSalePrice { get; set; }
        public string IsSale { get; set; }
        public string IsSaleOnWeb { get; set; }
        public string SearchKeyword { get; set; }
        public string AdDescription { get; set; }
        public int ListField1 { get; set; }
        public int ListField2 { get; set; }
        public int ListField3 { get; set; }
        public int ListField4 { get; set; }
        public int ListField5 { get; set; }
        public decimal? GpRate { get; set; }
        public int MaxSaleQty { get; set; }
        public int MinSaleQty { get; set; }
        public string IsBuyBySets { get; set; }
        public int QtyPerSets { get; set; }
        public string IsGift { get; set; }
        public int DefaultPictureId { get; set; }
        public short PictureDimentionFieldId { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Status { get; set; }
        public int? ErpInnerPackageUnitId { get; set; }
        public int? ErpInnerPackageQty { get; set; }
    }
}
