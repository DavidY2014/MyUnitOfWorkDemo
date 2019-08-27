using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class TbusinessLogCompensatory
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public int Status { get; set; }
        public int RetryNum { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
