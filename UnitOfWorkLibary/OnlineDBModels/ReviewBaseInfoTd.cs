using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class ReviewBaseInfoTd
    {
        public int ReviewId { get; set; }
        public int ItemId { get; set; }
        public string Content { get; set; }
        public int Score { get; set; }
        public DateTime? CreateTime { get; set; }
        public string CustomerName { get; set; }
        public string RankName { get; set; }
        public int? IsTop { get; set; }
        public int? IsGood { get; set; }
    }
}
