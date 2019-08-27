using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class RmaItem
    {
        public int SysNo { get; set; }
        public int RmasysNo { get; set; }
        public int ProductSysNo { get; set; }
        public int Rmatype { get; set; }
        public int Rmaqty { get; set; }
        public string Rmadesc { get; set; }
        public int? Rmareason { get; set; }
        public int DoitemSysNo { get; set; }
        public string RmareportFileName { get; set; }
        public decimal? Price { get; set; }
        public decimal? UnitPoints { get; set; }
        public decimal? TotalPoints { get; set; }
        public decimal? UnitUsePoints { get; set; }
        public decimal? TotalUsePoints { get; set; }
        public int IsPkgFull { get; set; }
        public string TaxCodeCategory { get; set; }
        public decimal TaxRate { get; set; }
        public int CreateUserId { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public string Modal { get; set; }
        public string Specification { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }

        public virtual RmaMaster RmasysNoNavigation { get; set; }
    }
}
