﻿using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.CSSDBModels
{
    public partial class TagencyNode
    {
        public int AgencyId { get; set; }
        public int NodeId { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
