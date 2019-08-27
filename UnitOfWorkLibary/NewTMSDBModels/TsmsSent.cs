using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.NewTMSDBModels
{
    public partial class TsmsSent
    {
        public int SmsId { get; set; }
        public string MobileNo { get; set; }
        public string Content { get; set; }
        public string Receiver { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime DateSent { get; set; }
    }
}
