using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class InvoiceTaxCategoryCode
    {
        public int SysNo { get; set; }
        public int? CategorySysNo { get; set; }
        public string TaxCategoryCode { get; set; }
        public int CreateUserSysNo { get; set; }
        public DateTime CreateTime { get; set; }
        public int? UpdateUserSysNo { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
