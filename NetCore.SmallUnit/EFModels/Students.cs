﻿using System;
using System.Collections.Generic;

namespace NetCore.SmallUnit.EFModels
{
    public partial class Students
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ClassName { get; set; }
        public DateTime? CreateTime { get; set; }
    }
}
