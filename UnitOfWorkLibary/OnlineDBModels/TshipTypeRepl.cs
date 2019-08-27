﻿using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class TshipTypeRepl
    {
        public int ShipTypeId { get; set; }
        public string ShipTypeCode { get; set; }
        public string ShipTypeName { get; set; }
        public decimal FreeShipBase { get; set; }
        public int ShowOrder { get; set; }
        public string IsShipLarge { get; set; }
        public string IsSendInvoice { get; set; }
        public string IsSynTms { get; set; }
        public string ServiceLevel { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Status { get; set; }
        public string Address { get; set; }
    }
}
