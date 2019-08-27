using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class Subscription
    {
        public int SysNo { get; set; }
        public string EmailSubscription { get; set; }
        public string Smssubscription { get; set; }
    }
}
