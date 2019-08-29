using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.TestDBModels
{
    public partial class Students
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ClassName { get; set; }
        public DateTime? CreateTime { get; set; }
    }
}
