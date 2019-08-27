using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.FinanceDBModels
{
    public partial class TautoTaskServer
    {
        public string ServerId { get; set; }
        public string ServerName { get; set; }
        public string ComputerName { get; set; }
        public string IpAddress { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Status { get; set; }
    }
}
