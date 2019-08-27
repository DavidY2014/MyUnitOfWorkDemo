﻿using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class ChannelCustomerMapping
    {
        public int SysNo { get; set; }
        public int ChannelTypeSysNo { get; set; }
        public int CustomerSysNo { get; set; }
        public int Status { get; set; }
        public int CreateUserSysNo { get; set; }
        public DateTime CreateTime { get; set; }
        public int? UpdateUserSysNo { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
