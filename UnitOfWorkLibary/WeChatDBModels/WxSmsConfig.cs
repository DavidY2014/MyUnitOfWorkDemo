using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class WxSmsConfig
    {
        public int Id { get; set; }
        public int Wid { get; set; }
        public string UName { get; set; }
        public string Ucode { get; set; }
        public string Pwd { get; set; }
        public string Qianming { get; set; }
        public DateTime CreateDate { get; set; }
        public string Remark { get; set; }
        public int? SortId { get; set; }
    }
}
