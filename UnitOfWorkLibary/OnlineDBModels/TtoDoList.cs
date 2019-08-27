using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class TtoDoList
    {
        public int ToDoListId { get; set; }
        public string RelativeId { get; set; }
        public string ToDoType { get; set; }
        public string AdditiveId { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public string IsStoped { get; set; }
        public DateTime? LastRetryTime { get; set; }
        public DateTime NextRetryTime { get; set; }
        public string ErrorInfo { get; set; }
        public int ErrorCount { get; set; }
    }
}
