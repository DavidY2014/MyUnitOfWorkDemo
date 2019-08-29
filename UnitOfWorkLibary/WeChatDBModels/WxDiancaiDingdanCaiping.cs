using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class WxDiancaiDingdanCaiping
    {
        public int Id { get; set; }
        public int? DingId { get; set; }
        public int? CaiId { get; set; }
        public int? Num { get; set; }
        public double? Price { get; set; }
        public double? Totpric { get; set; }
    }
}
