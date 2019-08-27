using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.NewTMSDBModels
{
    public partial class TsmsFailed
    {
        public int SmsId { get; set; }
        public string MobileNo { get; set; }
        public string Content { get; set; }
        public string Receiver { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public short RetryNumber { get; set; }
        public DateTime LastRetryTime { get; set; }
        public string FailDescription { get; set; }
    }
}
