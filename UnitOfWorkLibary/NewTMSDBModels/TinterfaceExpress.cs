using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.NewTMSDBModels
{
    public partial class TinterfaceExpress
    {
        public int InterfaceId { get; set; }
        public int ExpressId { get; set; }
        public string InterfaceExpressCode { get; set; }
        public string ReceiverRegex { get; set; }
        public string CourierRegex { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Status { get; set; }
    }
}
