using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.CSSDBModels
{
    public partial class TworkOrderResponseDeparment
    {
        public int ResponseId { get; set; }
        public int WorkOrderId { get; set; }
        public int? HandleId { get; set; }
        public int DeparmentId { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Status { get; set; }
        public string DepartmentType { get; set; }
        public string DeparmentName { get; set; }
    }
}
