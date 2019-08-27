using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class TgpPromotionDetailRepl
    {
        public int GpPromotionDetailId { get; set; }
        public int? GpPromotionId { get; set; }
        public int CategoryId { get; set; }
        public decimal? IntegralMultiples { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Status { get; set; }
    }
}
