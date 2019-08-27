using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.CSSDBModels
{
    public partial class TworkOrderHandle
    {
        public int HandleId { get; set; }
        public int WorkOrderId { get; set; }
        public int HandleTypeId { get; set; }
        public int KeyNodeId { get; set; }
        public string HandleContent { get; set; }
        public string AllocateContent { get; set; }
        public string IsCurrentHandleComplete { get; set; }
        public string IsLastHandle { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public string IsAccept { get; set; }
    }
}
