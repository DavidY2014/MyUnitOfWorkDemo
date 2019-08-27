using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class TbrandRepl
    {
        public int BrandId { get; set; }
        public string BrandCode { get; set; }
        public string BrandName { get; set; }
        public string BrandBriefName { get; set; }
        public string BrandEnglishName { get; set; }
        public string BrandEnglishBriefName { get; set; }
        public string FirstLetter { get; set; }
        public string Manufacturer { get; set; }
        public string ManufacturerWebSite { get; set; }
        public string ManufacturerDescription { get; set; }
        public string Remark { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Status { get; set; }
        public string SeoName { get; set; }
        public string PictureName { get; set; }
    }
}
