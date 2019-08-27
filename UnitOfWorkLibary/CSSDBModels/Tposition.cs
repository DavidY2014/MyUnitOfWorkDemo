using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.CSSDBModels
{
    public partial class Tposition
    {
        public int PositionId { get; set; }
        public string PositionName { get; set; }
        public int PositionLevelId { get; set; }
        public int DepartmentId { get; set; }
        public int OccupationId { get; set; }
        public int ParentPositionId { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Status { get; set; }
        public int BizSupervisorPositionId { get; set; }
    }
}
