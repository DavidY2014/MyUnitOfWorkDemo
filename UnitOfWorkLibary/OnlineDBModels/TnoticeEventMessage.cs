using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class TnoticeEventMessage
    {
        public int MessageId { get; set; }
        public string EventId { get; set; }
        public string MessageType { get; set; }
        public string MessageFormatId { get; set; }
        public string IsUse { get; set; }
        public short SendPririty { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Status { get; set; }
    }
}
