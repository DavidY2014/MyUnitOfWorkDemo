using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class DepartmentsTemp
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public int ParentId { get; set; }
        public decimal? OrderNumber { get; set; }
    }
}
