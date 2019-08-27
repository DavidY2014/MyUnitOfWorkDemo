using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.NewTMSDBModels
{
    public partial class TtaskType
    {
        public string TaskTypeId { get; set; }
        public string TaskTypeName { get; set; }
        public DateTime? DateHandled { get; set; }
        public string MaxId { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
