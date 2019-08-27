using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class InvoiceChenGuangTd
    {
        public int SysNo { get; set; }
        public string Doid { get; set; }
        public string InvoiceNo { get; set; }
        public DateTime InvoiceDate { get; set; }
        public decimal InvoiceAmount { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? CreateUserSysNo { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? UpdateUserSysNo { get; set; }
        public int InvoiceType { get; set; }
    }
}
