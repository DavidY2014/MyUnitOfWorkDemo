using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.CSSDBModels
{
    public partial class TstockProductHandle
    {
        public int ProductHandleId { get; set; }
        public int? HandleId { get; set; }
        public int ReasonId { get; set; }
        public string Soid { get; set; }
        public string ProductCode { get; set; }
        public string AdditionalDescription { get; set; }
        public DateTime CreateTime { get; set; }
        public int CreateUserId { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Status { get; set; }
    }
}
