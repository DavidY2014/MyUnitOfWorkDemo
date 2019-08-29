using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class WxDiancaiShoppic
    {
        public int Id { get; set; }
        public int? Shopid { get; set; }
        public string Description { get; set; }
        public int? Sortid { get; set; }
        public string PicUrl { get; set; }
        public string PictzUrl { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
