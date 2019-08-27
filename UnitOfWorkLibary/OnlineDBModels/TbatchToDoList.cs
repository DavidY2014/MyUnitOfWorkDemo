using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class TbatchToDoList
    {
        public int ToDoListId { get; set; }
        public string RelativeId { get; set; }
        public string ToDoType { get; set; }
        public string AdditiveId { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
