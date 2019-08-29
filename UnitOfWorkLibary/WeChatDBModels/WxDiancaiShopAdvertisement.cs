using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class WxDiancaiShopAdvertisement
    {
        public int Id { get; set; }
        public int? Setupid { get; set; }
        public string AdvertisementName { get; set; }
        public int? Sortid { get; set; }
        public string PicUrl { get; set; }
        public string WebsetUrl { get; set; }
        public bool? Isdisplay { get; set; }
        public string CreateDate { get; set; }
    }
}
