using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class WxSjbQiudui
    {
        public int Id { get; set; }
        public int? Wid { get; set; }
        public string QdName { get; set; }
        public string QdPic { get; set; }
        public string Remark { get; set; }
        public int? SuccTimes { get; set; }
        public int? FailTimes { get; set; }
        public int? SortId { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
