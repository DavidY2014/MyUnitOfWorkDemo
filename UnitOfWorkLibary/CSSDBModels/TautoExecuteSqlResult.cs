using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.CSSDBModels
{
    public partial class TautoExecuteSqlResult
    {
        public int ExecuteId { get; set; }
        public string SqlId { get; set; }
        public int ExecuteSeconds { get; set; }
        public string IsSuccess { get; set; }
        public string Result { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
