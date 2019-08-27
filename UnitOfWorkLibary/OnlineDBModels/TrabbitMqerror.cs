using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class TrabbitMqerror
    {
        public int RabbitMqerrorId { get; set; }
        public string ExchangeName { get; set; }
        public string QueueName { get; set; }
        public string Message { get; set; }
        public string ErrorInfo { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
