using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.NewTMSDBModels
{
    public partial class TnoticeEvent
    {
        public string EventId { get; set; }
        public string EventName { get; set; }
        public string EventDescription { get; set; }
        public string SubscriptionType { get; set; }
        public string SendType { get; set; }
        public string IsUse { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Status { get; set; }
    }
}
