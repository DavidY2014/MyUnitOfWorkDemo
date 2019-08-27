using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.CSSDBModels
{
    public partial class TworkOrderType
    {
        public string WorkOrderTypeId { get; set; }
        public string WorkOrderTypeName { get; set; }
        public int ProcessVersionId { get; set; }
        public string OrderRequireType { get; set; }
        public string PackiingSlipRequireType { get; set; }
        public string AddressRequireType { get; set; }
        public string ProductRequireType { get; set; }
        public string ExpressRequireType { get; set; }
        public string Remark { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Status { get; set; }
    }
}
