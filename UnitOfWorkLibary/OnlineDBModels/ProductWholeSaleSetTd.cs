using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class ProductWholeSaleSetTd
    {
        public int Sysno { get; set; }
        public int ProductSysno { get; set; }
        public decimal MinPrice { get; set; }
        public decimal Maxprice { get; set; }
        public int MaxPeopleNumber { get; set; }
        public int MinPeopleNumber { get; set; }
        public int SectionNumber { get; set; }
        public int CreateUserSysno { get; set; }
        public DateTime CreateDatetime { get; set; }
        public int Status { get; set; }
        public DateTime WholeSaleBeginDate { get; set; }
        public DateTime WholeSaleEndDate { get; set; }
        public int? LastUpdateUserSysno { get; set; }
        public DateTime? LastupDatetime { get; set; }
        public int? CurrentPeopleNumber { get; set; }
        public int? CanRevertPoint { get; set; }
        public decimal? LastPrice { get; set; }
    }
}
