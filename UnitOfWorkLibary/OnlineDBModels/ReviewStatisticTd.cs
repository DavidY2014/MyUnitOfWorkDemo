using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class ReviewStatisticTd
    {
        public int ItemId { get; set; }
        public int? Counts { get; set; }
        public int? VeryGoodCount { get; set; }
        public int? GoodCount { get; set; }
        public int? NoGoodCount { get; set; }
    }
}
