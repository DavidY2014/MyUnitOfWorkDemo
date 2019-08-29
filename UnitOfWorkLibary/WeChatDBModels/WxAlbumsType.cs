using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class WxAlbumsType
    {
        public int Id { get; set; }
        public int? Wid { get; set; }
        public string TypeName { get; set; }
        public string BannerPic { get; set; }
        public string TypeIco { get; set; }
        public string TypePic { get; set; }
        public string TContent { get; set; }
        public string Remark { get; set; }
        public string Music { get; set; }
        public int? ShowType { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? SortId { get; set; }
    }
}
