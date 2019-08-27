using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.CSSDBModels
{
    public partial class TworkOrderUser
    {
        public int WorkOrderId { get; set; }
        public int UserId { get; set; }
        public string ReferType { get; set; }
        public int? CreateUserId { get; set; }
        public DateTime? CreateTime { get; set; }
    }
}
