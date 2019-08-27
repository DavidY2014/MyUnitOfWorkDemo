using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.NewTMSDBModels
{
    public partial class Tprocess
    {
        public int ProcessId { get; set; }
        public int CurrentVersionId { get; set; }
        public string Class1 { get; set; }
        public string Class2 { get; set; }
        public string ProcessDescription { get; set; }
        public string ProcessName { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Status { get; set; }
    }
}
