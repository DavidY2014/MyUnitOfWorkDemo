using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class TitemStatistic
    {
        public int ItemId { get; set; }
        public int? SaleQty { get; set; }
        public int? ReviewCount { get; set; }
        public DateTime? CreateTime { get; set; }
    }
}
