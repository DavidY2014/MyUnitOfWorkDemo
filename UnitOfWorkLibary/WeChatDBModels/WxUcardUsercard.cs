using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class WxUcardUsercard
    {
        public int Id { get; set; }
        public int? Uid { get; set; }
        public int? Sid { get; set; }
        public DateTime? AddDate { get; set; }
    }
}
