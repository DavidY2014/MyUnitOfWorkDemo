using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class WxXtPhoto
    {
        public int Id { get; set; }
        public int? BId { get; set; }
        public string PName { get; set; }
        public string PUrl { get; set; }
        public string Remark { get; set; }
        public int? Seq { get; set; }
    }
}
