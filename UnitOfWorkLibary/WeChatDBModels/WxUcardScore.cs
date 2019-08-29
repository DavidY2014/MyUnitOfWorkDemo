using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class WxUcardScore
    {
        public int Id { get; set; }
        public int? Wid { get; set; }
        public string UserdContent { get; set; }
        public string ScoreRegular { get; set; }
        public int? QiandaoScore { get; set; }
        public int? Qiandao6Score { get; set; }
        public int? ConsumeMoney { get; set; }
        public int? ConsumeMoneyScore { get; set; }
        public int? SId { get; set; }
    }
}
