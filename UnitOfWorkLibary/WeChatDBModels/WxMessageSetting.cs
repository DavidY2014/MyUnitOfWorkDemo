using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class WxMessageSetting
    {
        public int Id { get; set; }
        public int? Wid { get; set; }
        public string Title { get; set; }
        public string AdminOpenid { get; set; }
        public string PicUrl { get; set; }
        public bool? NeedSh { get; set; }
    }
}
