using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class ProductCompetitorsPrice
    {
        public int SysNo { get; set; }
        public int ProductSysNo { get; set; }
        public string Competitors { get; set; }
        public decimal? CompetitorsPrice { get; set; }
        public int OrderNumber { get; set; }
        public DateTime CreatedTime { get; set; }
        public int CreateUserSysNo { get; set; }
        public DateTime? UpdateTime { get; set; }
        public int? UpdateUserSysNo { get; set; }
    }
}
