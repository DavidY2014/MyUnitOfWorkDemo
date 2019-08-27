using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class OperatorCart
    {
        public Guid SysNo { get; set; }
        public int OperatorSysNo { get; set; }
        public int ProductSysNo { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Point { get; set; }
        public int ProductNumber { get; set; }
        public int SaleType { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public DateTime? DeleteTime { get; set; }
        public string SoId { get; set; }
        public int Status { get; set; }
        public string SessionId { get; set; }
        public int PayType { get; set; }
    }
}
