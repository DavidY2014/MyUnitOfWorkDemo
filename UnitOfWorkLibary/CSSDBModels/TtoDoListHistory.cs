using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.CSSDBModels
{
    public partial class TtoDoListHistory
    {
        public int ToDoListId { get; set; }
        public string RelativeId { get; set; }
        public string ToDoType { get; set; }
        public DateTime DateProcessed { get; set; }
        public string AdditiveId { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
