using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class WxUcardSys
    {
        public int Id { get; set; }
        public int? Wid { get; set; }
        public string TradeTel { get; set; }
        public string TradeContent { get; set; }
        public int? CardType { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
