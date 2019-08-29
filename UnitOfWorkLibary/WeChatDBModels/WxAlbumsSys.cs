using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class WxAlbumsSys
    {
        public int Id { get; set; }
        public int? Wid { get; set; }
        public string BannerPic { get; set; }
        public string Code { get; set; }
        public int? TypeId { get; set; }
        public string TypeName { get; set; }
    }
}
