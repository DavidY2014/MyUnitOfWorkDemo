using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class WxSqPiclist
    {
        public int Id { get; set; }
        public int? Aid { get; set; }
        public string Openid { get; set; }
        public string PicUrl { get; set; }
        public DateTime? CreateDate { get; set; }
        public bool? HasShenghe { get; set; }
    }
}
