using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class WxPanoJd
    {
        public int Id { get; set; }
        public int? SysId { get; set; }
        public int? Wid { get; set; }
        public string JdName { get; set; }
        public string Music { get; set; }
        public string PicFront { get; set; }
        public string PicRight { get; set; }
        public string PicBehind { get; set; }
        public string PicLeft { get; set; }
        public string PicTop { get; set; }
        public string PicBottom { get; set; }
        public string PicYulan { get; set; }
        public string Remark { get; set; }
        public int? Seq { get; set; }
        public DateTime? CreateDate { get; set; }
        public string ExtStr { get; set; }
        public string ExtStr2 { get; set; }
    }
}
