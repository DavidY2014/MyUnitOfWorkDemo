using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class TreplicationApplication
    {
        public string ApplicationId { get; set; }
        public string ApplicationName { get; set; }
        public string ApplicationType { get; set; }
        public string InterfaceBaseUrl { get; set; }
        public string IsVerifyKey { get; set; }
        public string CommunicationUserId { get; set; }
        public string CommunicationKey { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Status { get; set; }
    }
}
