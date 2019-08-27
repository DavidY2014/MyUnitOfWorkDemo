using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.CSSDBModels
{
    public partial class TstockProductChange
    {
        public int ChangeId { get; set; }
        public int ProductHandleId { get; set; }
        public int ReasonId { get; set; }
        public string AdditionalDescription { get; set; }
        public DateTime CreateTime { get; set; }
        public int CreateUserId { get; set; }
    }
}
