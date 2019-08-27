using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class CustomerRank
    {
        public int SysNo { get; set; }
        public string RankName { get; set; }
        public int RankType { get; set; }
        public decimal FloorAmount { get; set; }
        public decimal TopAmount { get; set; }
        public int DiscountPercent { get; set; }
        public int CanGetPoint { get; set; }
        public DateTime CreateTime { get; set; }
        public int Status { get; set; }
    }
}
