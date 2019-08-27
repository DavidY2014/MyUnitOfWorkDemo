using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class SoValueAddedInvoice
    {
        public int SysNo { get; set; }
        public int SosysNo { get; set; }
        public int CustomerSysNo { get; set; }
        public string CompanyName { get; set; }
        public string TaxNum { get; set; }
        public string CompanyAddress { get; set; }
        public string CompanyPhone { get; set; }
        public string BankAccount { get; set; }
        public string Memo { get; set; }
        public DateTime CreateTime { get; set; }
        public decimal? Vatemsfee { get; set; }
        public string BankInfo { get; set; }
        public int? AreaSysNo { get; set; }
        public string EleVatdefaultEmail { get; set; }
    }
}
