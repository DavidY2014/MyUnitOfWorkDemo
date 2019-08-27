using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class InterfaceProtocolTd
    {
        public int SysNo { get; set; }
        public string FileName { get; set; }
        public string Content { get; set; }
        public int SendType { get; set; }
        public int Type { get; set; }
        public int SyncStatus { get; set; }
        public int HandleStatus { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public string Message { get; set; }
        public string Id { get; set; }
    }
}
