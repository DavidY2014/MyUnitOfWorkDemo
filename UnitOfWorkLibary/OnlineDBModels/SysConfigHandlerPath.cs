using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class SysConfigHandlerPath
    {
        public int Id { get; set; }
        public int Pid { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public string Method { get; set; }
        public string Notes { get; set; }

        public virtual SysConfigHandlerMaster P { get; set; }
    }
}
