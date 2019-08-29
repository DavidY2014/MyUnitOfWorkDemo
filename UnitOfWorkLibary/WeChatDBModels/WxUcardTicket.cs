using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class WxUcardTicket
    {
        public int Id { get; set; }
        public int? SId { get; set; }
        public int? Wid { get; set; }
        public string TName { get; set; }
        public DateTime? BeginDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? TypeId { get; set; }
        public string UsedContent { get; set; }
        public int? UsedTimes { get; set; }
        public string UserDegree { get; set; }
        public int? UserType { get; set; }
        public int? ConsumeMoney { get; set; }
        public int? DyMoney { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? SortId { get; set; }
    }
}
