using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class TuserLogin
    {
        public int UserLoginId { get; set; }
        public int UserId { get; set; }
        public string UserIpAddress { get; set; }
        public string ServerIpAddress { get; set; }
        public DateTime LoginTime { get; set; }
        public DateTime? LogoutTime { get; set; }
    }
}
