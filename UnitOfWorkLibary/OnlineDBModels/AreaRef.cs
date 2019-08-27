using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class AreaRef
    {
        public int SysNo { get; set; }
        public int? ProvinceSysNo { get; set; }
        public int? CitySysNo { get; set; }
        public string ProvinceName { get; set; }
        public string CityName { get; set; }
        public string DistrictName { get; set; }
        public string OrderNumber { get; set; }
        public int IsLocal { get; set; }
        public int Status { get; set; }
        public int? Localcode { get; set; }
        public string DistrictShortName { get; set; }
        public string Sign { get; set; }
    }
}
