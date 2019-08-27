using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.FinanceDBModels
{
    public partial class TtoDoListErrorLog
    {
        public int ErrorId { get; set; }
        public int ToDoListId { get; set; }
        public string ErrorInfo { get; set; }
        public string IsBatchToDoList { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
