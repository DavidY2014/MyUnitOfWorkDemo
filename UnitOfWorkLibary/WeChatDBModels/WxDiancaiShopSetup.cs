using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class WxDiancaiShopSetup
    {
        public int Id { get; set; }
        public int? Wid { get; set; }
        public string UnionManage { get; set; }
        public string UnionTel { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
