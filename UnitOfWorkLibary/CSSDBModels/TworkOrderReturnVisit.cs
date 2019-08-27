using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.CSSDBModels
{
    public partial class TworkOrderReturnVisit
    {
        public int WorkOrderId { get; set; }
        public int ResultId { get; set; }
        public string ResultReason { get; set; }
        public string CustomerSuggest { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
