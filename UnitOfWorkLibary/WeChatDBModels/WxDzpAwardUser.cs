using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class WxDzpAwardUser
    {
        public int Id { get; set; }
        public int? ActId { get; set; }
        public string UName { get; set; }
        public string UTel { get; set; }
        public string Openid { get; set; }
        public string JxName { get; set; }
        public string JxIndex { get; set; }
        public string JpName { get; set; }
        public DateTime? CreateDate { get; set; }
        public bool? HasLingQu { get; set; }
        public string Sn { get; set; }
    }
}
