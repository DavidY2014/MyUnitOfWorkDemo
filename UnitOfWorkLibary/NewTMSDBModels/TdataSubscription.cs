using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.NewTMSDBModels
{
    public partial class TdataSubscription
    {
        public int SubscriptionId { get; set; }
        public string DataPublisherId { get; set; }
        public string SubscriptionType { get; set; }
        public string Url { get; set; }
        public string ClassName { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Status { get; set; }
    }
}
