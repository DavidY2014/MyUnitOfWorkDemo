using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class ManufacturerOri
    {
        public int SysNo { get; set; }
        public string ManufacturerId { get; set; }
        public string ManufacturerName { get; set; }
        public string BriefName { get; set; }
        public string Note { get; set; }
        public int Status { get; set; }
        public string OrderNum { get; set; }
        public int? ManufactureShowType { get; set; }
        public string ManufacturerNameEn { get; set; }
        public string Vendor { get; set; }
        public string VendorSummary { get; set; }
        public string Url { get; set; }
        public int IsbrandImage { get; set; }
        public string NameEn { get; set; }
        public string Logo { get; set; }
        public int? IsRecommend { get; set; }
        public int? RecommendOrderNum { get; set; }
    }
}
