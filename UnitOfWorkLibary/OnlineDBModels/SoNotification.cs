using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class SoNotification
    {
        public int SysNo { get; set; }
        public string Soid { get; set; }
        public string NotificationType { get; set; }
        public DateTime NotificationTime { get; set; }
        public int CreateUserSysNo { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserSysNo { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
