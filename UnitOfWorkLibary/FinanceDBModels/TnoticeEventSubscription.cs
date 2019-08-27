using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.FinanceDBModels
{
    public partial class TnoticeEventSubscription
    {
        public int SubscriptionId { get; set; }
        public string EventId { get; set; }
        public int MessageId { get; set; }
        public string Subscriber { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
