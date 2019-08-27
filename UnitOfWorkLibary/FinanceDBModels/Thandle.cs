using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.FinanceDBModels
{
    public partial class Thandle
    {
        public int HandleId { get; set; }
        public byte HandleTypeId { get; set; }
        public string RelativeId { get; set; }
        public string Remark { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
