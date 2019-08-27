using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.CSSDBModels
{
    public partial class TworkOrderHandleType
    {
        public int HandleTypeId { get; set; }
        public string HandleTypeCode { get; set; }
        public string HandleTypeName { get; set; }
        public string WorkOrderTypeId { get; set; }
        public string Remark { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Status { get; set; }
    }
}
