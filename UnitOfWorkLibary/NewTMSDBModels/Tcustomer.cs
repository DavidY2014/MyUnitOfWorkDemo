using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.NewTMSDBModels
{
    public partial class Tcustomer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string DistributeCenterId { get; set; }
        public string ApiUserId { get; set; }
        public string ApiPassword { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Status { get; set; }
    }
}
