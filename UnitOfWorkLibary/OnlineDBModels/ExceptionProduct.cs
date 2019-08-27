using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class ExceptionProduct
    {
        public int SysNo { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public int? CustomerSysNo { get; set; }
        public int Status { get; set; }
        public int Type { get; set; }
        public int SyncStatus { get; set; }
        public DateTime CreateTime { get; set; }
        public int CreateUserSysNo { get; set; }
        public DateTime? UpdateTime { get; set; }
        public int? UpdateUserSysNo { get; set; }
    }
}
