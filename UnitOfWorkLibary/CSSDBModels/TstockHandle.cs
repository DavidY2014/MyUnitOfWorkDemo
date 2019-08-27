using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.CSSDBModels
{
    public partial class TstockHandle
    {
        public int HandleId { get; set; }
        public string Soid { get; set; }
        public string Source { get; set; }
        public string Status { get; set; }
        public DateTime CreateTime { get; set; }
        public int CreateUserId { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string CustomerDescription { get; set; }
    }
}
