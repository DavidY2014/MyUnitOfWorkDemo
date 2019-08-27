using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.FinanceDBModels
{
    public partial class TpublishedMessage
    {
        public int PublishedMessageId { get; set; }
        public string UsageType { get; set; }
        public string UsageDescription { get; set; }
        public string Content { get; set; }
        public int Retries { get; set; }
        public string Status { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
