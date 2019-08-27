using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.CSSDBModels
{
    public partial class TworkOrderProductSku
    {
        public int WorkOrderId { get; set; }
        public int LineId { get; set; }
        public string ProductSkuName { get; set; }
        public int Qty { get; set; }
        public string Remark { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Status { get; set; }
        public string ProductSkuCode { get; set; }
        public int ProductSkuId { get; set; }
    }
}
