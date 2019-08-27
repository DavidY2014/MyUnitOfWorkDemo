using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class LogicalWarehouseCompare
    {
        public int LogicalWarehouseId { get; set; }
        public string LogicalWarehouseCode { get; set; }
        public string LogicalWarehouseName { get; set; }
        public string LogicalWarehouseType { get; set; }
        public int WarehouseId { get; set; }
        public string IsSyncWms { get; set; }
        public string WmsWarehouseId { get; set; }
        public string Contact { get; set; }
        public string Phone { get; set; }
        public string Region { get; set; }
        public string Address { get; set; }
        public string Postalcode { get; set; }
        public string IsAutomaticAudit { get; set; }
        public string IsDefault { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Status { get; set; }
    }
}
