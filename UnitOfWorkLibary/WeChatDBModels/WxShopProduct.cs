using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class WxShopProduct
    {
        public int Id { get; set; }
        public int? Wid { get; set; }
        public int? CategoryId { get; set; }
        public int? CatalogId { get; set; }
        public int? BrandId { get; set; }
        public string Sku { get; set; }
        public string ProductName { get; set; }
        public string ShortDesc { get; set; }
        public string Unit { get; set; }
        public double? Weight { get; set; }
        public string Description { get; set; }
        public string SeoTitle { get; set; }
        public string SeoKeywords { get; set; }
        public string SeoDescription { get; set; }
        public string FocusImgUrl { get; set; }
        public string ThumbnailsUrll { get; set; }
        public bool? Recommended { get; set; }
        public bool? Latest { get; set; }
        public bool? Hotsale { get; set; }
        public bool? SpecialOffer { get; set; }
        public double? CostPrice { get; set; }
        public double? MarketPrice { get; set; }
        public double? SalePrice { get; set; }
        public bool? Upselling { get; set; }
        public int? Stock { get; set; }
        public DateTime? AddDate { get; set; }
        public int? VistiCounts { get; set; }
        public int? SortId { get; set; }
        public DateTime? ProductionDate { get; set; }
        public DateTime? ExpiryEndDate { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
