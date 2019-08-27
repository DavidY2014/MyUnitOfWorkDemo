using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.FinanceDBModels
{
    public partial class TelecInvoiceExtend
    {
        public int Id { get; set; }
        public int InvoiceGroupId { get; set; }
        public DateTime? AckTime { get; set; }
        public int? AckUserId { get; set; }
        public string AckStatus { get; set; }
        public string Link { get; set; }
        public string Email { get; set; }
        public DateTime CreateTime { get; set; }
        public int? UpdateUserId { get; set; }
        public DateTime? UpdateTime { get; set; }
        public int CreateUserId { get; set; }
    }
}
