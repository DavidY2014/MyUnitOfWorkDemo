using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.NewTMSDBModels
{
    public partial class TlogisticInterface
    {
        public int InterfaceId { get; set; }
        public string InterfaceName { get; set; }
        public string InterfaceType { get; set; }
        public string ApplicationId { get; set; }
        public string PrepareClassName { get; set; }
        public string ReceiverRegex { get; set; }
        public string CourierRegex { get; set; }
        public string Remark { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Status { get; set; }
        public int InterfaceIntervalHour { get; set; }
    }
}
