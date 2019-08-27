using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class TapplicationVersion
    {
        public string ApplicationId { get; set; }
        public string ApplicationName { get; set; }
        public string CurrentVersion { get; set; }
        public string CustomerCode { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Status { get; set; }
    }
}
