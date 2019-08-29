using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class WxLbsSetting
    {
        public int Id { get; set; }
        public int? Wid { get; set; }
        public double? SearchRadius { get; set; }
        public string BannerPicUrl { get; set; }
    }
}
