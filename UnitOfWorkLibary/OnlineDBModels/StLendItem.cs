﻿using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class StLendItem
    {
        public int SysNo { get; set; }
        public int LendSysNo { get; set; }
        public int ProductSysNo { get; set; }
        public int LendQty { get; set; }
        public DateTime? ExpectReturnTime { get; set; }
        public decimal? Cost { get; set; }
        public decimal? SalesPrice { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public decimal VatRate { get; set; }
        public decimal NetCost { get; set; }

        public virtual StLend LendSysNoNavigation { get; set; }
    }
}