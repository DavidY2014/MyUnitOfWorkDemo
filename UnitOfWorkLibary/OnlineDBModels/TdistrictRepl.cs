﻿using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class TdistrictRepl
    {
        public int DistrictId { get; set; }
        public int CityId { get; set; }
        public string DistrictName { get; set; }
        public int ShowOrder { get; set; }
        public string Status { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
